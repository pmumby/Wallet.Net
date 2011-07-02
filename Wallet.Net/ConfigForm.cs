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
    public partial class ConfigForm : Form
    {
        public ConfigFile Config;
        public BitnetClient Bitcoin;
        public SSHCore SSHConnection;

        public ConfigForm(ConfigFile CF, BitnetClient RPC, SSHCore SSH)
        {
            InitializeComponent();
            this.Config = CF;
            this.Bitcoin = RPC;
            this.SSHConnection = SSH;
        }

        public bool TestSettings()
        {
            if (this.UseSSHCheckBox.Checked)
            {
                //try
                //{
                    this.SSHConnection.Connect(this.SSHUserBox.Text, this.SSHPassBox.Text, this.RPCHost.Text, 22);
                    this.SSHConnection.Tunnel("127.0.0.1", int.Parse(this.RPCPort.Text), 22123);
                //}
                //catch
                //{
                   // MessageBox.Show("Error: SSH Security Layer failed to establish a connection & secure tunnel.", "ERROR");
                   // return false;
                //}
                try
                {
                    Bitcoin.Url = new Uri("HTTP://localhost:22123");
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
                    Bitcoin.Url = new Uri("HTTP://" + RPCHost.Text + ":" + RPCPort.Text);
                }
                catch
                {
                    MessageBox.Show("Error: URL Malformed", "ERROR");
                    return false;
                }
            }
            try
            {
                Bitcoin.Credentials = new NetworkCredential(RPCUser.Text, RPCPass.Text);
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
            if (UseSSHCheckBox.Checked)
            {
                this.SSHConnection.Disconnect();
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

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            RPCHost.Text = Config.BitCoinHost;
            RPCPort.Text = Config.BitCoinPort;
            RPCUser.Text = Config.BitCoinUser;
            RPCPass.Text = Config.BitCoinPass;
            UseSSHCheckBox.Checked = Config.UseSSH;
            SSHUserBox.Text = Config.SSHUser;
            SSHPassBox.Text = Config.SSHPass;
            this.UpdateSSHState();
        }

        private void CencelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            if (this.TestSettings())
            {
                MessageBox.Show("Test Succeeded!", "Success!");
            }
            else
            {
                MessageBox.Show("Test Failed!", "Failure!");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
//            if (this.TestSettings())
//            {
                this.Config.BitCoinHost = this.RPCHost.Text;
                this.Config.BitCoinPort = this.RPCPort.Text;
                this.Config.BitCoinUser = this.RPCUser.Text;
                this.Config.BitCoinPass = this.RPCPass.Text;
                this.Config.UseSSH = this.UseSSHCheckBox.Checked;
                this.Config.SSHUser = this.SSHUserBox.Text;
                this.Config.SSHPass = this.SSHPassBox.Text;
                this.Config.Write();
                MessageBox.Show("Settings Saved!");
                this.Close();
//            }
//            else
//            {
//                MessageBox.Show("Error: Settings appear to be invalid! Please either cancel, or correct settings, before saving.", "ERROR");
//            }
        }

        private void UpdateSSHState()
        {
            SSHUserBox.Enabled = UseSSHCheckBox.Checked;
            SSHPassBox.Enabled = UseSSHCheckBox.Checked;
        }

        private void UseSSHCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSSHState();           
        }

    }
}
