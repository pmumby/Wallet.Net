namespace Wallet.Net
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.MasterBalance = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AccountDropDown = new System.Windows.Forms.ComboBox();
            this.TypeDropDown = new System.Windows.Forms.ComboBox();
            this.TransactionLimit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ConnectButton = new System.Windows.Forms.ToolStripButton();
            this.ConfigButton = new System.Windows.Forms.ToolStripButton();
            this.ConsoleButton = new System.Windows.Forms.ToolStripButton();
            this.InfoButton = new System.Windows.Forms.ToolStripButton();
            this.AddressBookButton = new System.Windows.Forms.ToolStripButton();
            this.SendMoneyButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.DonateButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectButton,
            this.ConfigButton,
            this.ConsoleButton,
            this.InfoButton,
            this.toolStripSeparator1,
            this.AddressBookButton,
            this.SendMoneyButton,
            this.toolStripSeparator2,
            this.RefreshButton,
            this.toolStripSeparator3,
            this.DonateButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "BitCoin Balance";
            // 
            // MasterBalance
            // 
            this.MasterBalance.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasterBalance.ForeColor = System.Drawing.Color.Blue;
            this.MasterBalance.Location = new System.Drawing.Point(160, 49);
            this.MasterBalance.Name = "MasterBalance";
            this.MasterBalance.ReadOnly = true;
            this.MasterBalance.Size = new System.Drawing.Size(255, 31);
            this.MasterBalance.TabIndex = 9999;
            this.MasterBalance.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 92);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(584, 445);
            this.dataGridView1.TabIndex = 10000;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // AccountDropDown
            // 
            this.AccountDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountDropDown.FormattingEnabled = true;
            this.AccountDropDown.Location = new System.Drawing.Point(422, 42);
            this.AccountDropDown.Name = "AccountDropDown";
            this.AccountDropDown.Size = new System.Drawing.Size(150, 21);
            this.AccountDropDown.TabIndex = 10001;
            this.AccountDropDown.SelectedIndexChanged += new System.EventHandler(this.AccountDropDown_SelectedIndexChanged);
            // 
            // TypeDropDown
            // 
            this.TypeDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeDropDown.FormattingEnabled = true;
            this.TypeDropDown.Items.AddRange(new object[] {
            "All Transactions",
            "Sent Transactions",
            "Received Transactions",
            "Internal Transactions",
            "Unknown Transactions"});
            this.TypeDropDown.Location = new System.Drawing.Point(422, 65);
            this.TypeDropDown.Name = "TypeDropDown";
            this.TypeDropDown.Size = new System.Drawing.Size(150, 21);
            this.TypeDropDown.TabIndex = 10002;
            this.TypeDropDown.SelectedIndexChanged += new System.EventHandler(this.TypeDropDown_SelectedIndexChanged);
            // 
            // TransactionLimit
            // 
            this.TransactionLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TransactionLimit.Location = new System.Drawing.Point(472, 13);
            this.TransactionLimit.Name = "TransactionLimit";
            this.TransactionLimit.Size = new System.Drawing.Size(100, 20);
            this.TransactionLimit.TabIndex = 10003;
            this.TransactionLimit.Text = "100";
            this.TransactionLimit.TextChanged += new System.EventHandler(this.TransactionLimit_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(379, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 10004;
            this.label2.Text = "Transaction Limit";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // ConnectButton
            // 
            this.ConnectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ConnectButton.Image = global::Wallet.Net.Properties.Resources.connect_green;
            this.ConnectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(36, 36);
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ConfigButton
            // 
            this.ConfigButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ConfigButton.Image = global::Wallet.Net.Properties.Resources.Config;
            this.ConfigButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(36, 36);
            this.ConfigButton.Text = "Configuration";
            this.ConfigButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // ConsoleButton
            // 
            this.ConsoleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ConsoleButton.Image = global::Wallet.Net.Properties.Resources.Console;
            this.ConsoleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConsoleButton.Name = "ConsoleButton";
            this.ConsoleButton.Size = new System.Drawing.Size(36, 36);
            this.ConsoleButton.Text = "BitCoin Console";
            this.ConsoleButton.Click += new System.EventHandler(this.ConsoleButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InfoButton.Image = global::Wallet.Net.Properties.Resources.Info;
            this.InfoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(36, 36);
            this.InfoButton.Text = "Query BitCoin RPC Server Info";
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // AddressBookButton
            // 
            this.AddressBookButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddressBookButton.Image = global::Wallet.Net.Properties.Resources.AddressBook;
            this.AddressBookButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddressBookButton.Name = "AddressBookButton";
            this.AddressBookButton.Size = new System.Drawing.Size(36, 36);
            this.AddressBookButton.Text = "Address Book";
            this.AddressBookButton.Click += new System.EventHandler(this.AddressBookButton_Click);
            // 
            // SendMoneyButton
            // 
            this.SendMoneyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SendMoneyButton.Image = global::Wallet.Net.Properties.Resources.Send;
            this.SendMoneyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SendMoneyButton.Name = "SendMoneyButton";
            this.SendMoneyButton.Size = new System.Drawing.Size(36, 36);
            this.SendMoneyButton.Text = "Send Money";
            this.SendMoneyButton.Click += new System.EventHandler(this.SendMoneyButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = global::Wallet.Net.Properties.Resources.Refresh;
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(36, 36);
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // DonateButton
            // 
            this.DonateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DonateButton.Image = global::Wallet.Net.Properties.Resources.icon_bitcoin_large1;
            this.DonateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DonateButton.Name = "DonateButton";
            this.DonateButton.Size = new System.Drawing.Size(36, 36);
            this.DonateButton.Text = "Donate";
            this.DonateButton.Click += new System.EventHandler(this.DonateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TransactionLimit);
            this.Controls.Add(this.TypeDropDown);
            this.Controls.Add(this.AccountDropDown);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MasterBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wallet.Net";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ConnectButton;
        private System.Windows.Forms.ToolStripButton ConfigButton;
        private System.Windows.Forms.ToolStripButton ConsoleButton;
        private System.Windows.Forms.ToolStripButton InfoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MasterBalance;
        private System.Windows.Forms.ToolStripButton AddressBookButton;
        private System.Windows.Forms.ToolStripButton SendMoneyButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox AccountDropDown;
        private System.Windows.Forms.ComboBox TypeDropDown;
        private System.Windows.Forms.TextBox TransactionLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton DonateButton;

    }
}