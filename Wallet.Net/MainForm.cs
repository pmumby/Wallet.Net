using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bitnet.Client;
using System.Net;

namespace Wallet.Net
{
    public partial class MainForm : Form
    {
        public ConfigFile Config;
        public BitnetClient Bitcoin;
        public SSHCore SSHConnection;
        public bool Connected;
        public List<Transaction> MasterTransactionList = new List<Transaction>();
        public List<Transaction> TransactionList = new List<Transaction>();

        public Timer RefreshTimer;

        public MainForm()
        {
            InitializeComponent();
            this.Config = new ConfigFile();
            this.Bitcoin = new BitnetClient();
            this.SSHConnection = new SSHCore();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Config.Read();
            if (this.Config.IsNew)
            {
                this.DoConfig();
            }
            this.Connect();           
        }

        public bool AttemptConnect()
        {
            if (this.Config.UseSSH)
            {
                if (!this.SSHConnection.IsConnected())
                {
                    this.SSHConnection.Connect(this.Config.SSHUser, this.Config.SSHPass, this.Config.BitCoinHost, 22);
                    this.SSHConnection.Tunnel("127.0.0.1", int.Parse(this.Config.BitCoinPort), 22123);
                }
                try
                {
                    Bitcoin.Url = new Uri("HTTP://" + this.Config.BitCoinHost + ":" + this.Config.BitCoinPort);
                }
                catch
                {
                    MessageBox.Show("Error: URL Malformed", "ERROR");
                    return false;
                }
            }
            else
            {
                try
                {
                    Bitcoin.Url = new Uri("HTTP://" + this.Config.BitCoinHost + ":" + this.Config.BitCoinPort);
                }
                catch
                {
                    MessageBox.Show("Error: URL Malformed", "ERROR");
                    return false;
                }
            }
            try
            {
                Bitcoin.Credentials = new NetworkCredential(this.Config.BitCoinUser, this.Config.BitCoinPass);
            }
            catch
            {
                MessageBox.Show("Error: Credentials Invalid", "ERROR");
                return false;
            }
            Newtonsoft.Json.Linq.JObject info;
            try
            {
                info = Bitcoin.GetInfo();
            }
            catch
            {
                MessageBox.Show("Error Getting Info From BitCoin RPC Host.", "ERROR");
                return false;
            }
            if (int.Parse(info["version"].ToString()) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Connect()
        {
            if (this.AttemptConnect())
            {
                var info = Bitcoin.GetInfo();
                if (int.Parse(info["version"].ToString()) > 0)
                {
                    this.Connected = true;
                    StatusLabel.Text = "Connected To Host:" + this.Config.BitCoinHost + " on Port:" + this.Config.BitCoinPort + " Server Version:" + info["version"].ToString();
                    this.ConnectButton.Image = Wallet.Net.Properties.Resources.connect_green;
                    this.DataRefresh();
                    this.SetupDropDowns();
                    this.StartRefreshTimer();
                }
                else
                {
                    this.Connected = false;
                    StatusLabel.Text = "Connection Failed! Check Config";
                    this.ConnectButton.Image = Wallet.Net.Properties.Resources.connect_red;
                }
            }
            else
            {
                this.Connected = false;
                StatusLabel.Text = "Connection Failed! Check Config";
                this.ConnectButton.Image = Wallet.Net.Properties.Resources.connect_red;
            }
        }

        public void StartRefreshTimer()
        {
            RefreshTimer = new Timer();
            RefreshTimer.Interval = 30000;            
            RefreshTimer.Tick += new EventHandler(RefreshTimer_Tick);
            RefreshTimer.Start();
        }

        void RefreshTimer_Tick(object sender, EventArgs e)
        {
            this.DataRefresh();
        }

        public void DataRefresh()
        {
            this.GetBalance();
            int TXLimit;
            int.TryParse(TransactionLimit.Text, out TXLimit);
            this.FetchTransactions(TXLimit);
            if (AccountDropDown.Text != "All Accounts")
            {
                this.TransactionList = this.MasterTransactionList.Where(E => E.Account == AccountDropDown.Text).ToList();
            }
            else
            {
                this.TransactionList = this.MasterTransactionList;
            }
            if (TypeDropDown.Text != "All Transactions")
            {
                switch (TypeDropDown.Text)
                {
                    case "Sent Transactions":
                        this.TransactionList = this.TransactionList.Where(E => !E.Status.StartsWith("Internal") && !E.Status.StartsWith("Unknown") && E.Debit != 0).ToList();
                        break;
                    case "Received Transactions":
                        this.TransactionList = this.TransactionList.Where(E => !E.Status.StartsWith("Internal") && !E.Status.StartsWith("Unknown") && E.Credit != 0).ToList();
                        break;
                    case "Internal Transactions":
                        this.TransactionList = this.TransactionList.Where(E => E.Status.StartsWith("Internal")).ToList();
                        break;
                    case "Unknown Transactions":
                        this.TransactionList = this.TransactionList.Where(E => E.Status.StartsWith("Unknown")).ToList();
                        break;
                }                
            }
            this.TransactionList = this.TransactionList.OrderBy(E => E.Time).Reverse().ToList();
            BindingSource TXSource = new BindingSource();
            TXSource.DataSource = this.TransactionList;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = TXSource;
            dataGridView1.Refresh();
            //this.SetupDropDowns();
        }

        public void SetupDropDowns()
        {
            Newtonsoft.Json.Linq.JObject AccountList = this.Bitcoin.ListAccounts();
            AccountDropDown.Items.Clear();
            AccountDropDown.Items.Add("All Accounts");
            foreach (System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> Item in AccountList)
            {
                if (Item.Key.Length > 0)
                {
                    AccountDropDown.Items.Add(Item.Key);
                }
            }
            if (TypeDropDown.SelectedIndex < 0) TypeDropDown.SelectedIndex = 0;
            if (AccountDropDown.SelectedIndex < 0) AccountDropDown.SelectedIndex = 0;
        }

        public void FetchTransactions(int count)
        {
            this.MasterTransactionList = new List<Transaction>();
            Newtonsoft.Json.Linq.JArray txlist = this.Bitcoin.ListTransactions("*", count);
            Newtonsoft.Json.Linq.JToken temp;
            Transaction TempTrans;
            foreach (Newtonsoft.Json.Linq.JObject tx in txlist)
            {
                if (tx.TryGetValue("txid", out temp))
                {
                    TempTrans = new Transaction(this.Bitcoin, temp.ToString());
                    this.MasterTransactionList.Add(TempTrans);
                }
                else
                {
                    //No TXID so generate a manual transaction based on data in list
                    TempTrans = new Transaction(tx);
                    this.MasterTransactionList.Add(TempTrans);
                }
            }
        }

        public void GetBalance()
        {
            double Balance = double.Parse(this.Bitcoin.GetBalance().ToString());
            if (AccountDropDown.Text != "All Accounts")
            {
                Balance = double.Parse(this.Bitcoin.GetBalance(AccountDropDown.Text).ToString());
            }
            else
            {
                Balance = double.Parse(this.Bitcoin.GetBalance().ToString());
            }
            MasterBalance.Text = Balance.ToString("##,0.##########' BTC'");
        }

        public void DoConfig()
        {
            ConfigForm CForm = new ConfigForm(this.Config, this.Bitcoin,this.SSHConnection);
            CForm.ShowDialog();
            this.Config.Read();
            this.Connect();
        }

        public void DoConsole()
        {
            if (MessageBox.Show("The RPC Console is an advanced function.\r\nYou could accidentally send your bitcoins into oblivion, or do something TERRIBLE to your wallet with this.\r\nYou have been warned!\r\n\r\nAre you SURE you want to continue?", "WARNING!!!!!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                ConsoleForm CForm = new ConsoleForm(this.Bitcoin);
                CForm.ShowDialog();
            }
        }

        public void DoAddressBook()
        {
            AddressBookForm ABForm = new AddressBookForm(this.Bitcoin);
            ABForm.ShowDialog();
        }

        public void SendMoney()
        {
            SendMoneyForm SMForm = new SendMoneyForm(this.Bitcoin);
            SMForm.ShowDialog();
        }
        
        public void Donate()
        {
            SendMoneyForm SMForm = new SendMoneyForm(this.Bitcoin);
            SMForm.SetupFields("1KsUFustgDpiuj6YUztMCi476TQzivZnLn", "Donation To Wallet.Net Author", 0.1);
            SMForm.ShowDialog();
        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {
            this.DoConfig();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            this.Connect();
        }

        private void ConsoleButton_Click(object sender, EventArgs e)
        {
            if (this.Connected)
            {
                this.DoConsole();
            }
            else
            {
                MessageBox.Show("Not Connected!");
            }
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            if (this.Connected)
            {
                InfoForm IForm = new InfoForm(this.Bitcoin);
                IForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Not Connected!");
            }
        }

        private void AddressBookButton_Click(object sender, EventArgs e)
        {
            if (this.Connected)
            {
                this.DoAddressBook();
            }
            else
            {
                MessageBox.Show("Not Connected!");
            }
        }

        private void SendMoneyButton_Click(object sender, EventArgs e)
        {
            if (this.Connected)
            {
                this.SendMoney();
            }
            else
            {
                MessageBox.Show("Not Connected!");
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            if (this.Connected)
            {
                this.DataRefresh();
                this.SetupDropDowns();
            }
            else
            {
                MessageBox.Show("Not Connected!");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Transaction TX = (Transaction)dataGridView1.CurrentRow.DataBoundItem;
            MessageBox.Show(TX.FetchDetailString(), "Transaction Details");
        }

        private void TransactionLimit_TextChanged(object sender, EventArgs e)
        {
            this.DataRefresh();
        }

        private void AccountDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DataRefresh();
        }

        private void TypeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DataRefresh();
        }

        private void DonateButton_Click(object sender, EventArgs e)
        {
            if (this.Connected)
            {
                this.Donate();
            }
            else
            {
                MessageBox.Show("Not Connected!");
            }
        }
    }
}
