using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bitnet.Client;
using System.Xml.Serialization;
using System.Reflection;
using System.IO;

namespace Wallet.Net
{
    public partial class EditAddress : Form
    {
        public BitnetClient Bitcoin;
        bool ReceiveMode;
        public List<AddressBookEntry> DestAddressList;
        public int ItemIndex;

        public EditAddress(BitnetClient RPC, string Address, bool RecvMode, bool New)
        {
            InitializeComponent();
            this.Bitcoin = RPC;
            this.ReceiveMode = RecvMode;
            AddressBox.Text = Address;
            if (!this.ReceiveMode)
            {
                this.GetDestAddresses();
            }
            if (New)
                this.ItemIndex = -1;
        }

        public void SaveAccount()
        {
            if (this.ReceiveMode)
            {
                this.Bitcoin.SetAccount(this.AddressBox.Text, this.AccountBox.Text);
            }
            else
            {
                if (this.ItemIndex < 0 || this.ItemIndex > this.DestAddressList.Count() - 1)
                {
                    AddressBookEntry TempEntry = new AddressBookEntry();
                    TempEntry.Address = this.AddressBox.Text;
                    TempEntry.Description = this.AccountBox.Text;
                    this.DestAddressList.Add(TempEntry);
                    this.SaveDestAddresses();
                }
                else
                {
                    this.DestAddressList.ElementAt(this.ItemIndex).Address = this.AddressBox.Text;
                    this.DestAddressList.ElementAt(this.ItemIndex).Description = this.AccountBox.Text;
                    this.SaveDestAddresses();
                }
            }
        }

        public void ReadAccount()
        {
            if (this.ReceiveMode)
            {
                this.AccountBox.Text = this.Bitcoin.GetAccount(this.AddressBox.Text);
            }
            else
            {
                if (this.AddressBox.Text.Length > 0)
                {
                    this.ItemIndex = this.DestAddressList.IndexOf(this.DestAddressList.Where(E => E.Address == this.AddressBox.Text).FirstOrDefault());
                    AccountBox.Text = this.DestAddressList.ElementAt(ItemIndex).Description;
                }
            }
        }

        public void GetDestAddresses()
        {
            string filename = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName) + "\\addressbook.xml";
            XmlSerializer deserializer = new XmlSerializer(typeof(List<AddressBookEntry>));
            TextReader reader = new StreamReader(filename);
            this.DestAddressList = (List<AddressBookEntry>)deserializer.Deserialize(reader);
            reader.Close();
        }

        public void SaveDestAddresses()
        {
            string filename = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName) + "\\addressbook.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(List<AddressBookEntry>));
            TextWriter writer = new StreamWriter(filename);
            serializer.Serialize(writer, this.DestAddressList);
            writer.Close();
        }

        private void EditAddress_Load(object sender, EventArgs e)
        {
            this.ReadAccount();
            this.AddressBox.ReadOnly = this.ReceiveMode;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.SaveAccount();
            this.Close();
        }

        private void AccountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.SaveAccount();
                this.Close();
            }
        }
    }
}
