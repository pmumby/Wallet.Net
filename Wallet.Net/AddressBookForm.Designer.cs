namespace Wallet.Net
{
    partial class AddressBookForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ReceiverPage = new System.Windows.Forms.TabPage();
            this.MyAddressesGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.RecipientsPage = new System.Windows.Forms.TabPage();
            this.DestAddressesGrid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ReceiverPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyAddressesGrid)).BeginInit();
            this.RecipientsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DestAddressesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ReceiverPage);
            this.tabControl1.Controls.Add(this.RecipientsPage);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // ReceiverPage
            // 
            this.ReceiverPage.Controls.Add(this.MyAddressesGrid);
            this.ReceiverPage.Controls.Add(this.button1);
            this.ReceiverPage.Location = new System.Drawing.Point(4, 22);
            this.ReceiverPage.Name = "ReceiverPage";
            this.ReceiverPage.Padding = new System.Windows.Forms.Padding(3);
            this.ReceiverPage.Size = new System.Drawing.Size(476, 407);
            this.ReceiverPage.TabIndex = 1;
            this.ReceiverPage.Text = "Your Addresses";
            this.ReceiverPage.UseVisualStyleBackColor = true;
            // 
            // MyAddressesGrid
            // 
            this.MyAddressesGrid.AllowUserToAddRows = false;
            this.MyAddressesGrid.AllowUserToDeleteRows = false;
            this.MyAddressesGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MyAddressesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MyAddressesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MyAddressesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyAddressesGrid.Location = new System.Drawing.Point(9, 36);
            this.MyAddressesGrid.Name = "MyAddressesGrid";
            this.MyAddressesGrid.ReadOnly = true;
            this.MyAddressesGrid.RowHeadersVisible = false;
            this.MyAddressesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyAddressesGrid.Size = new System.Drawing.Size(459, 365);
            this.MyAddressesGrid.TabIndex = 1;
            this.MyAddressesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyAddressesGrid_CellClick);
            this.MyAddressesGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyAddressesGrid_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(459, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate A New Bitcoin Address";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RecipientsPage
            // 
            this.RecipientsPage.Controls.Add(this.DestAddressesGrid);
            this.RecipientsPage.Controls.Add(this.button2);
            this.RecipientsPage.Location = new System.Drawing.Point(4, 22);
            this.RecipientsPage.Name = "RecipientsPage";
            this.RecipientsPage.Padding = new System.Windows.Forms.Padding(3);
            this.RecipientsPage.Size = new System.Drawing.Size(476, 407);
            this.RecipientsPage.TabIndex = 0;
            this.RecipientsPage.Text = "Recipients";
            this.RecipientsPage.UseVisualStyleBackColor = true;
            // 
            // DestAddressesGrid
            // 
            this.DestAddressesGrid.AllowUserToAddRows = false;
            this.DestAddressesGrid.AllowUserToDeleteRows = false;
            this.DestAddressesGrid.AllowUserToOrderColumns = true;
            this.DestAddressesGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DestAddressesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DestAddressesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DestAddressesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DestAddressesGrid.Location = new System.Drawing.Point(9, 36);
            this.DestAddressesGrid.Name = "DestAddressesGrid";
            this.DestAddressesGrid.ReadOnly = true;
            this.DestAddressesGrid.RowHeadersVisible = false;
            this.DestAddressesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DestAddressesGrid.Size = new System.Drawing.Size(459, 365);
            this.DestAddressesGrid.TabIndex = 1;
            this.DestAddressesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DestAddressesGrid_CellClick);
            this.DestAddressesGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DestAddressesGrid_CellDoubleClick);
            this.DestAddressesGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DestAddressesGrid_KeyDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(459, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Add A New Recipient To Your Address Book";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Single Click to Copy Address To Clipboard Doubleclick to Edit";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(459, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddressBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddressBookForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address Book";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddressBookForm_FormClosed);
            this.Load += new System.EventHandler(this.AddressBookForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.ReceiverPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyAddressesGrid)).EndInit();
            this.RecipientsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DestAddressesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage RecipientsPage;
        private System.Windows.Forms.TabPage ReceiverPage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView MyAddressesGrid;
        private System.Windows.Forms.DataGridView DestAddressesGrid;
    }
}