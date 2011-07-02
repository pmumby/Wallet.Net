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
    public partial class ConsoleForm : Form
    {
        public BitnetClient Bitcoin;

        public ConsoleForm(BitnetClient RPC)
        {
            InitializeComponent();
            this.Bitcoin = RPC;
        }

        private void ConsoleForm_Load(object sender, EventArgs e)
        {
            OutputBox.Text += "Welcome to the RPC Console. Here you can execute any of the commands in the JSON RPC API for BitCoin, but in a shell type interface. Allows you to experiment with the protocol (or for debugging purposes).\r\n\r\nNote, this was meant to be used mostly on TestNet. PLEASE don't use this unless you know what your doing.\r\nAnything you can do on the JSON protocol, you can do via this console, (that includes sending money into oblivion lol).\r\n\r\nTo get started, perhaps start out with the \"help\" command.\r\n\r\n";
            OutputBox.Text += ">";
            System.Threading.Thread.Sleep(100);
            InputBox.Focus();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            this.Send();
        }

        private void InputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.Send();
            }
        }

        public void Send()
        {
            string OutputString = "";
            OutputString += InputBox.Text+"\r\n";
            switch (this.GetCommand())
            {
                case "help":
                    if (this.GetParm(1) != null)
                    {
                        OutputString += this.Bitcoin.Help(this.GetParm(1).ToLower()).ToString();
                    }
                    else
                    {
                        OutputString += this.Bitcoin.Help().ToString();
                    }
                    break;
                case "listaccounts":
                    OutputString += this.Bitcoin.ListAccounts().ToString();
                    break;
                case "getbalance":
                    if (this.GetParm(1) != null)
                    {
                        OutputString += this.Bitcoin.GetBalance(this.GetParm(1)).ToString();
                    }
                    else
                    {
                        OutputString += this.Bitcoin.GetBalance().ToString();
                    }
                    break;
                case "getblockcount":
                    OutputString += this.Bitcoin.GetBlockCount();
                    break;
                case "getblocknumber":
                    OutputString += this.Bitcoin.GetBlockNumber();
                    break;
                case "getconnectioncount":
                    OutputString += this.Bitcoin.GetConnectionCount();
                    break;
                case "getdifficulty":
                    OutputString += this.Bitcoin.GetDifficulty();
                    break;
                case "getgenerate":
                    OutputString += this.Bitcoin.GetGenerate();
                    break;
                case "gethashespersec":
                    OutputString += this.Bitcoin.GetHashesPerSec();
                    break;
                case "getinfo":
                    OutputString += this.Bitcoin.GetInfo();
                    break;
                case "getaccount":
                    if (this.GetParm(1) != null)
                    {
                        OutputString += this.Bitcoin.GetAccount(this.GetParm(1)).ToString();
                    }
                    else
                    {
                        OutputString += "Error: You must specify a bitcoin address";
                    }
                    break;
                case "getaccountaddress":
                    if (this.GetParm(1) != null)
                    {
                        OutputString += this.Bitcoin.GetAccountAddress(this.GetParm(1)).ToString();
                    }
                    else
                    {
                        OutputString += "Error: You must specify an account";
                    }
                    break;
                case "getaddressesbyaccount":
                    if (this.GetParm(1) != null)
                    {
                        OutputString += this.Bitcoin.GetAddressesByAccount(this.GetParm(1)).ToString();
                    }
                    else
                    {
                        OutputString += "Error: You must specify an account";
                    }
                    break;
                case "getblockbycount":
                    if (this.GetParm(1) != null)
                    {
                        int count;
                        if (int.TryParse(this.GetParm(1), out count))
                        {
                            if (count > 0)
                            {
                                OutputString += this.Bitcoin.GetBlockByCount(count).ToString();
                            }
                            else
                            {
                                OutputString += "Error: The [height] parameter must be greater than zero if specified.";
                            }
                        }
                        else
                        {
                            OutputString += "Error: You did not provide a valid numerical value for the [height] parameter.";
                        }                        
                    }
                    else
                    {
                        OutputString += "Error: you must specify a block height";
                    }
                    break;
                case "getnewaddress":
                    if (this.GetParm(1) != null)
                    {
                        OutputString += this.Bitcoin.GetNewAddress(this.GetParm(1)).ToString();
                    }
                    else
                    {
                        OutputString += this.Bitcoin.GetNewAddress("").ToString();
                    }
                    break;
                case "getreceivedbyaccount":
                    if (this.GetParm(1) != null)
                    {
                        OutputString += this.Bitcoin.GetReceivedByAccount(this.GetParm(1)).ToString();
                    }
                    else
                    {
                        OutputString += "Error: You must specify an account";
                    }
                    break;
                case "getreceivedbyaddress":
                    if (this.GetParm(1) != null)
                    {
                        OutputString += this.Bitcoin.GetReceivedByAddress(this.GetParm(1)).ToString();
                    }
                    else
                    {
                        OutputString += "Error: You must Specify a bitcoin address";
                    }
                    break;
                case "gettransaction":
                    if (this.GetParm(1) != null)
                    {
                        OutputString += this.Bitcoin.GetTransaction(this.GetParm(1)).ToString();
                    }
                    else
                    {
                        OutputString += "Error: You must speficy a transaction id";
                    }
                    break;
                case "getwork":
                    if (this.GetParm(1) != null)
                    {
                        OutputString += this.Bitcoin.GetWork(this.GetParm(1)).ToString();
                    }
                    else
                    {
                        OutputString += this.Bitcoin.GetWork().ToString();
                    }
                    break;
                case "listreceivedbyaccount":
                    if (this.GetParm(1) != null)
                    {
                        bool Parm;
                        if (this.GetParm(1).ToLower() == "true")
                        {
                            Parm = true;
                            OutputString += this.Bitcoin.ListReceivedByAccount(1, Parm).ToString();
                        }
                        else if (this.GetParm(1).ToLower() == "false")
                        {
                            Parm = false;
                            OutputString += this.Bitcoin.ListReceivedByAccount(1, Parm).ToString();
                        }
                        else if (this.GetParm(1).ToLower() == "1")
                        {
                            Parm = true;
                            OutputString += this.Bitcoin.ListReceivedByAccount(1, Parm).ToString();
                        }
                        else if (this.GetParm(1).ToLower() == "0")
                        {
                            Parm = false;
                            OutputString += this.Bitcoin.ListReceivedByAccount(1, Parm).ToString();
                        }
                        else
                        {
                            OutputString += "Error: [includeempty] parameter must be a boolean value (valid values: true,false,1,0)";
                        }
                        
                    }
                    else
                    {
                        OutputString += this.Bitcoin.ListReceivedByAccount().ToString();
                    }
                    break;
                case "listreceivedbyaddress":
                    if (this.GetParm(1) != null)
                    {
                        bool Parm;
                        if (this.GetParm(1).ToLower() == "true")
                        {
                            Parm = true;
                            OutputString += this.Bitcoin.ListReceivedByAddress(1, Parm).ToString();
                        }
                        else if (this.GetParm(1).ToLower() == "false")
                        {
                            Parm = false;
                            OutputString += this.Bitcoin.ListReceivedByAddress(1, Parm).ToString();
                        }
                        else if (this.GetParm(1).ToLower() == "1")
                        {
                            Parm = true;
                            OutputString += this.Bitcoin.ListReceivedByAddress(1, Parm).ToString();
                        }
                        else if (this.GetParm(1).ToLower() == "0")
                        {
                            Parm = false;
                            OutputString += this.Bitcoin.ListReceivedByAddress(1, Parm).ToString();
                        }
                        else
                        {
                            OutputString += "Error: [includeempty] parameter must be a boolean value (valid values: true,false,1,0)";
                        }

                    }
                    else
                    {
                        OutputString += this.Bitcoin.ListReceivedByAddress().ToString();
                    }
                    break;
                case "listtransactions":
                    if (this.GetParm(1) != null && this.GetParm(2) != null)
                    {
                        int count;
                        if (int.TryParse(this.GetParm(2), out count))
                        {
                            if (count > 0)
                            {
                                OutputString += this.Bitcoin.ListTransactions(this.GetParm(1), count);
                            }
                            else
                            {
                                OutputString += "Error: The [count] parameter must be greater than zero if specified";
                            }
                        }
                        else
                        {
                            OutputString += "Error: You did not provide a valid number value for the [count] parameter";
                        }

                    }
                    else if (this.GetParm(1) != null)
                    {
                        int count;
                        if (int.TryParse(this.GetParm(1), out count))
                        {
                            OutputString += this.Bitcoin.ListTransactions("",count).ToString();
                        }
                        else
                        {
                            OutputString += this.Bitcoin.ListTransactions(this.GetParm(1)).ToString();
                        }                    
                    }
                    else
                    {
                        OutputString += this.Bitcoin.ListTransactions("").ToString();
                    }
                    break;
                case "move":
                    if (this.GetParmArray().Count() >= 4)
                    {
                        //Need to trap errors on the float.parse in the event of invalid float strings. right now it will crash.
                        if (this.GetParmArray().Count() > 4)
                        {
                            OutputString += this.Bitcoin.Move(this.GetParm(1), this.GetParm(2), float.Parse(this.GetParm(3)),1,this.GetParm(4));
                        }
                        else
                        {
                            OutputString += this.Bitcoin.Move(this.GetParm(1), this.GetParm(2), float.Parse(this.GetParm(3)));
                        }
                    }
                    else
                    {
                        OutputString += "Error, insufficient parameters. Use 'help move' for usage assistance";
                    }
                    break;
                case "sendfrom":
                    if (this.GetParmArray().Count() >= 4)
                    {
                        //Need to trap errors on the float.parse in the event of invalid float strings. right now it will crash.
                        if (this.GetParmArray().Count() > 5)
                        {
                            OutputString += this.Bitcoin.SendFrom(this.GetParm(1), this.GetParm(2), float.Parse(this.GetParm(3)), 1, this.GetParm(4), this.GetParm(5));
                        }
                        else if (this.GetParmArray().Count() > 4)
                        {
                            OutputString += this.Bitcoin.SendFrom(this.GetParm(1), this.GetParm(2), float.Parse(this.GetParm(3)), 1, this.GetParm(4));
                        }
                        else
                        {
                            OutputString += this.Bitcoin.SendFrom(this.GetParm(1), this.GetParm(2), float.Parse(this.GetParm(3)));
                        }
                    }
                    else
                    {
                        OutputString += "Error, insufficient parameters. Use 'help sendfrom' for usage assistance";
                    }
                    break;
                case "sendtoaddress":
                    if (this.GetParmArray().Count() >= 3)
                    {
                        //Need to trap errors on the float.parse in the event of invalid float strings. right now it will crash.
                        if (this.GetParmArray().Count() > 4)
                        {
                            OutputString += this.Bitcoin.SendToAddress(this.GetParm(1), float.Parse(this.GetParm(2)), this.GetParm(3), this.GetParm(4));
                        }
                        else if (this.GetParmArray().Count() > 3)
                        {
                            OutputString += this.Bitcoin.SendToAddress(this.GetParm(1), float.Parse(this.GetParm(2)), this.GetParm(3), "");
                        }
                        else
                        {
                            OutputString += this.Bitcoin.SendToAddress(this.GetParm(1), float.Parse(this.GetParm(2)), "", "");
                        }
                    }
                    else
                    {
                        OutputString += "Error, insufficient parameters. Use 'help sendtoaddress' for usage assistance";
                    }
                    break;
                case "setaccount":
                    if (this.GetParmArray().Count() >= 3)
                    {
                        this.Bitcoin.SetAccount(this.GetParm(1), this.GetParm(2));
                        OutputString += "SetAccount: OK";
                    }
                    else
                    {
                        OutputString += "Error, insufficient parameters. Use 'help setaccount' for usage assistance";
                    }
                    break;
                case "setgenerate":
                    if (this.GetParmArray().Count() >= 2)
                    {
                        if (this.GetParmArray().Count() >= 3)
                        {
                            this.Bitcoin.SetGenerate(bool.Parse(this.GetParm(1)), int.Parse(this.GetParm(2)));
                        }
                        else
                        {
                            this.Bitcoin.SetGenerate(bool.Parse(this.GetParm(1)));
                        }
                        OutputString += "SetAccount: OK";
                    }
                    else
                    {
                        OutputString += "Error, insufficient parameters. Use 'help setgenerate' for usage assistance";
                    }
                    break;
                case "stop":
                    OutputString += "Stopping Bitcoin Service! You will need to remotely restart it after this!";
                    this.Bitcoin.Stop();
                    break;
                case "validateaddress":
                    if (this.GetParmArray().Count() >= 2)
                    {
                        OutputString += this.Bitcoin.ValidateAddress(this.GetParm(1));
                    }
                    else
                    {
                        OutputString += "Error, insufficient parameters. Use 'help validateaddress' for usage assistance";
                    }
                    break;
                case "settxfee":
                    if (this.GetParm(1) != null)
                    {
                        float Fee;
                        if (float.TryParse(this.GetParm(1), out Fee))
                        {
                            this.Bitcoin.SetTXFee(Fee);
                            OutputString += "Success.";
                        }
                        else
                        {
                            OutputString += "Error: Invalid amount specified!";
                        }
                    }
                    else
                    {
                        OutputString += "Error: You must specify a fee amount";
                    }
                    break;
                case "exit":
                    this.Close();
                    break;
                case "quit":
                    this.Close();
                    break;
                default:
                    OutputString += "ERROR: Unknown Command " + this.GetCommand();
                    break;
            }
            this.WriteToConsole(OutputString);
            this.InputBox.Text = "";
        }

        public string GetParm(int index)
        {
            if (this.GetParmArray().Count() >= (index + 1))
            {
                return this.GetParmArray().ElementAt(index);
            }
            else
            {
                return null;
            }
        }

        public string[] GetParmArray()
        {
            List<string> ResultArrayTemp = new List<string>();
            List<string> ResultArray = new List<string>();
            ResultArrayTemp = InputBox.Text.Split(' ').ToList();
            bool instring = false;
            int trueindex = 0;
            int instringcount = 0;
            foreach (string result in ResultArrayTemp)
            {
                if (ResultArray.Count() < trueindex + 1)
                    ResultArray.Add("");
                if (result.StartsWith("\""))
                    instring = true;
                if (instring)
                {
                    if (instringcount > 0)
                        ResultArray[trueindex] += " ";
                    instringcount++;
                    ResultArray[trueindex] += result.Replace("\"","");
                }
                else
                {
                    instringcount = 0;
                    ResultArray[trueindex] = result;
                }
                if (result.EndsWith("\""))
                    instring = false;
                if (!instring)
                    trueindex++;
            }
            return ResultArray.ToArray();
        }

        public string GetCommand()
        {
            return InputBox.Text.Split(' ').FirstOrDefault().ToLower();
        }

        private void WriteToConsole(string Text)
        {
            Text = Text.Replace("\n", "\r\n");
            OutputBox.Text += Text + "\r\n\r\n>" ;
            OutputBox.SelectionStart = OutputBox.Text.Length;
            OutputBox.ScrollToCaret();
            OutputBox.Refresh();
        }
    }
}
