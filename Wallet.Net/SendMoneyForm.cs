using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bitnet.Client;

namespace Wallet.Net
{
    public partial class SendMoneyForm : Form
    {
        public BitnetClient Bitcoin;

        public SendMoneyForm(BitnetClient RPC)
        {
            InitializeComponent();
            this.Bitcoin = RPC;
        }

        private void SendMoneyForm_Load(object sender, EventArgs e)
        {
            Newtonsoft.Json.Linq.JObject Result = this.Bitcoin.GetInfo();
            FeeBox.Text = Result["paytxfee"].ToString();
        }

        public void SetupFields(string Address, string Comment, double Amount)
        {
            this.AddressBox.Text = Address;
            this.CommentBox.Text = Comment;
            this.AmountBox.Text = Amount.ToString();
            this.AddressBox.ReadOnly = true;
            this.CommentBox.ReadOnly = true;
            this.AmountBox.Focus();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string Address = AddressBox.Text;
            string Comment = CommentBox.Text;
            string CommentTo = CommentToBox.Text;
            float Amount;
            float Fee;
            if (float.TryParse(AmountBox.Text, out Amount))
            {
                if (float.TryParse(FeeBox.Text, out Fee))
                {
                    try
                    {
                        this.Bitcoin.SetTXFee(Fee);
                        string Result = this.Bitcoin.SendToAddress(Address, Amount, Comment, CommentTo);
                        MessageBox.Show("Transaction ID:\r\n"+Result, "Success");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("ERROR: Problem Initiating Transaction!\r\n(probably an invalid bitcoin address)\r\n\r\nPlease check your information, and try again!", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("Error, invalid value in Fee box", "Error");
                }
            }
            else
            {
                MessageBox.Show("Error, invalid value in Amount box", "Error");
            }
        }

        private void ABButton_Click(object sender, EventArgs e)
        {
            AddressBookForm ABForm = new AddressBookForm(this.Bitcoin);
            ABForm.SetTab(1);
            ABForm.ShowDialog();
            this.AddressBox.Paste();
            CommentBox.Focus();
        }
    }
}
