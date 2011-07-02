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
    public partial class InfoForm : Form
    {
        public BitnetClient Bitcoin;

        public InfoForm(BitnetClient RPC)
        {
            InitializeComponent();
            this.Bitcoin = RPC;
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            var info = this.Bitcoin.GetInfo();
            TBversion.Text = info["version"].ToString();
            TBbalance.Text = info["balance"].ToString();
            TBblocks.Text = info["blocks"].ToString();
            TBconnections.Text = info["connections"].ToString();
            TBproxy.Text = info["proxy"].ToString();
            TBgenerate.Text = info["generate"].ToString();
            TBgenproclimit.Text = info["genproclimit"].ToString();
            TBdifficulty.Text = info["difficulty"].ToString();
            TBhashespersec.Text = info["hashespersec"].ToString();
            TBtestnet.Text = info["testnet"].ToString();
            TBkeypoololdest.Text = info["keypoololdest"].ToString();
            TBpaytxfee.Text = info["paytxfee"].ToString();
            TBerrors.Text = info["errors"].ToString();
        }
    }
}
