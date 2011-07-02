using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bitnet.Client;
using System.Globalization;
using System.Windows.Forms;

namespace Wallet.Net
{
    public class Transaction
    {
        private double _Amount;
        private double _Fee;
        private string _Account;
        private string _OtherAccount;
        private string _Address;
        private string _Category;
        private int _Confirmations;
        private string _TransactionID;
        private DateTime _Time;
        private string _Comment;
        private string _CommentTo;
        private string _SenderAddress;
        private string _ReceiverAddress;
        private double _SenderAmount;
        private double _ReceiverAmount;
        private double _SenderFee;
        private string _SenderAccount;
        private string _ReceiverAccount;

        public String Status
        {
            get
            {
                if (this._TransactionID != null)
                {
                    if (this._Confirmations == 0)
                    {
                        return "New (" + this._Confirmations.ToString() + ")";
                    }
                    else if (this._Confirmations >= 1 && this._Confirmations < 3)
                    {
                        return "Pending (" + this._Confirmations.ToString() + ")";
                    }
                    else if (this._Confirmations >= 3 && this._Confirmations < 6)
                    {
                        return "OK (" + this._Confirmations.ToString() + ")";
                    }
                    else if (this._Confirmations >= 6)
                    {
                        return "Confirmed (" + this._Confirmations.ToString() + ")";
                    }
                    else
                    {
                        return "Unknown?";
                    }
                }
                else
                {
                    if(this._Category!=null)
                    {
                        return "Internal (" + this._Category + ")";
                    }else{
                        return "Internal (Unknown)";
                    }
                }
            }
            set{}
        }

        public DateTime Time
        {
            get { return this._Time; }
            set {}
        }

        public string Account
        {
            get
            {
                if (this._Account != null)
                {
                    return this._Account;
                }
                else
                {
                    if (this._Amount >= 0 && this._ReceiverAccount != null)
                    {
                        return this._ReceiverAccount;
                    }
                    else if (this._Amount < 0 && this._SenderAccount != null)
                    {
                        return this._SenderAccount;
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            set{}
        }

        public double Debit
        {
            get
            {
                if (this._Amount < 0)
                {
                    return this._Amount;
                }
                else
                {
                    return 0;
                }
            }
            set { }
        }

        public double Credit
        {
            get
            {
                if (this._Amount > 0)
                {
                    return this._Amount;
                }
                else
                {
                    return 0;
                }
            }
            set { }
        }

        public string Comment
        {
            get
            {
                return this._Comment;
            }
            set { }
        }

        private BitnetClient Bitcoin;
        private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public Transaction(BitnetClient RPC, string txid)
        {
            this.Bitcoin = RPC;
            this.Fetch(txid);
        }

        public Transaction(Newtonsoft.Json.Linq.JObject source)
        {
            this.FetchData(source);
        }
 
        private void Fetch(string txid)
        {
            Newtonsoft.Json.Linq.JObject txtemp = Bitcoin.GetTransaction(txid);
            this.FetchData(txtemp);
        }

        private void FetchData(Newtonsoft.Json.Linq.JObject txtemp)
        {
            TXDetails TempDetails;
            foreach (System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> Item in txtemp)
            {
                switch(Item.Key)
                {
                    case "amount":
                        double.TryParse(Item.Value.ToString(),out this._Amount);
                        break;
                    case "account":
                        this._Account = Item.Value.ToString();
                        break;
                    case "address":
                        this._Address = Item.Value.ToString();
                        break;
                    case "category":
                        this._Category = Item.Value.ToString();
                        break;
                    case "fee":
                        double.TryParse(Item.Value.ToString(),out this._Fee);
                        break;
                    case "confirmations":
                        int.TryParse(Item.Value.ToString(),out this._Confirmations);
                        break;
                    case "txid":
                        this._TransactionID = Item.Value.ToString();
                        break;
                    case "time":
                        this._Time = this.ConvertFromTimeStamp(Item.Value.ToString());
                        break;
                    case "comment":
                        this._Comment = Item.Value.ToString();
                        break;
                    case "to":
                        this._CommentTo = Item.Value.ToString();
                        break;
                    case "otheraccount":
                        this._OtherAccount = Item.Value.ToString();
                        break;
                    case "details":
                        //What the fuck...
                        break;
                }
            }
        }

        public string FetchDetailString()
        {
            string Details = "";
            if (this._Amount != null) Details += "Amount: " + this._Amount.ToString() + "\r\n";
            if (this._Account != null) Details += "Account: " + this._Account.ToString() + "\r\n";
            if (this._Address != null) Details += "Address: " + this._Address.ToString() + "\r\n";
            if (this._Category != null) Details += "Category: " + this._Category.ToString() + "\r\n";
            if (this._Fee != null) Details += "Fee: " + this._Fee.ToString() + "\r\n";
            if (this._Confirmations != null) Details += "Confirmations: " + this._Confirmations.ToString() + "\r\n";
            if (this._TransactionID != null) Details += "Transaction ID: " + this._TransactionID.ToString() + "\r\n";
            if (this._Time != null) Details += "Timestamp: " + this._Time.ToString() + "\r\n";
            if (this._Comment != null) Details += "Comment: " + this._Comment.ToString() + "\r\n";
            if (this._CommentTo != null) Details += "Comment (To): " + this._CommentTo.ToString() + "\r\n";
            if (this._SenderAddress != null) Details += "Sender Address: " + this._SenderAddress.ToString() + "\r\n";
            if (this._SenderAccount != null) Details += "Sender Account: " + this._SenderAccount.ToString() + "\r\n";
            if (this._SenderAmount != null) Details += "Sender Amount: " + this._SenderAmount.ToString() + "\r\n";
            if (this._SenderFee != null) Details += "Sender Fee: " + this._SenderFee.ToString() + "\r\n";
            if (this._ReceiverAddress != null) Details += "Receiver Address: " + this._ReceiverAddress.ToString() + "\r\n";
            if (this._ReceiverAccount != null) Details += "Receiver Account: " + this._ReceiverAccount.ToString() + "\r\n";
            if (this._ReceiverAmount != null) Details += "Receiver Amount: " + this._ReceiverAmount.ToString() + "\r\n";
            return Details;
        }

        private DateTime ConvertFromTimeStamp(string timestamp)
        {
            double seconds = double.Parse(timestamp, CultureInfo.InvariantCulture);
            return Epoch.AddSeconds(seconds);
        }
    }

    public class TXDetails
    {
        public string Account;
        public string Address;
        public string Category;
        public double Amount;
        public double Fee;
    }
}


