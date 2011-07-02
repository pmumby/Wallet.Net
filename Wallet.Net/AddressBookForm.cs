using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bitnet.Client;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;

namespace Wallet.Net
{
    public partial class AddressBookForm : Form
    {
        public BitnetClient Bitcoin;
        public List<AddressBookEntry> MyAddressList;       
        public List<AddressBookEntry> DestAddressList;

        public AddressBookForm(BitnetClient RPC)
        {
            InitializeComponent();
            this.Bitcoin = RPC;
        }

        private void AddressBookForm_Load(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        public void SetTab(int tabindex)
        {
            this.tabControl1.SelectedIndex = tabindex;
        }

        public void RefreshData()
        {
            this.GetMyAddresses();
            this.GetDestAddresses();
            BindingSource MyAddressesSource = new BindingSource();
            MyAddressesSource.DataSource = this.MyAddressList;
            MyAddressesGrid.AutoGenerateColumns = true;
            MyAddressesGrid.DataSource = MyAddressesSource;
            BindingSource DestAddressesSource = new BindingSource();
            DestAddressesSource.DataSource = this.DestAddressList;
            DestAddressesGrid.AutoGenerateColumns = true;
            DestAddressesGrid.DataSource = DestAddressesSource;
        }

        public void GetMyAddresses()
        {
            Newtonsoft.Json.Linq.JArray AddrList = this.Bitcoin.ListReceivedByAddress(1, true);
            this.MyAddressList = new List<AddressBookEntry>();
            foreach (Newtonsoft.Json.Linq.JObject Item in AddrList)
            {
                AddressBookEntry TempItem = new AddressBookEntry();
                TempItem.Address = Item["address"].ToString();
                TempItem.Description = Item["account"].ToString();
                this.MyAddressList.Add(TempItem);
            }
            this.MyAddressList = this.MyAddressList.OrderBy(E => E.Description).Reverse().ToList();
        }

        public void GetDestAddresses()
        {
            string filename = System.Windows.Forms.Application.UserAppDataPath + "\\addressbook.xml";
            XmlSerializer deserializer = new XmlSerializer(typeof(List<AddressBookEntry>));
            TextReader reader = new StreamReader(filename);
            this.DestAddressList = (List<AddressBookEntry>)deserializer.Deserialize(reader);
            reader.Close();
            this.DestAddressList = this.DestAddressList.OrderBy(E => E.Description).Reverse().ToList();
        }

        public void SaveDestAddresses()
        {
            string filename = System.Windows.Forms.Application.UserAppDataPath + "\\addressbook.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(List<AddressBookEntry>));
            TextWriter writer = new StreamWriter(filename);
            serializer.Serialize(writer, this.DestAddressList);
            writer.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddressBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.SaveDestAddresses();
        }

        private void MyAddressesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddressBookEntry SelectedEntry = (AddressBookEntry)MyAddressesGrid.CurrentRow.DataBoundItem;
            Clipboard.SetText(SelectedEntry.Address);
        }

        private void MyAddressesGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddressBookEntry SelectedEntry = (AddressBookEntry)MyAddressesGrid.CurrentRow.DataBoundItem;
            EditAddress EditForm = new EditAddress(this.Bitcoin, SelectedEntry.Address, true, false);
            EditForm.ShowDialog();
            this.RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditAddress EditForm = new EditAddress(this.Bitcoin, this.Bitcoin.GetNewAddress(""), true, true);
            EditForm.ShowDialog();
            this.RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditAddress EditForm = new EditAddress(this.Bitcoin, "", false, true);
            EditForm.ShowDialog();
            this.RefreshData();
        }

        private void DestAddressesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddressBookEntry SelectedEntry = (AddressBookEntry)DestAddressesGrid.CurrentRow.DataBoundItem;
            Clipboard.SetText(SelectedEntry.Address);
        }

        private void DestAddressesGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddressBookEntry SelectedEntry = (AddressBookEntry)DestAddressesGrid.CurrentRow.DataBoundItem;
            EditAddress EditForm = new EditAddress(this.Bitcoin, SelectedEntry.Address, false, false);
            EditForm.ShowDialog();
            this.RefreshData();
        }

        private void DestAddressesGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (this.DestAddressesGrid.CurrentRow != null)
                {
                    this.DestAddressList.Remove((AddressBookEntry)this.DestAddressesGrid.CurrentRow.DataBoundItem);
                    this.SaveDestAddresses();
                    this.RefreshData();
                }
            }
        }

    }

    public class AddressBookEntry
    {
        private string _Address;
        private string _Description;

        public string Address
        {
            get
            {
                return this._Address;
            }
            set 
            {
                this._Address = value;
            }
        }

        public string Description
        {
            get
            {
                return this._Description;
            }
            set 
            {
                this._Description = value;
            }
        }
    }
}
