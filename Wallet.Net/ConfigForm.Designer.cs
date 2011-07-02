namespace Wallet.Net
{
    partial class ConfigForm
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
            this.RPCHost = new System.Windows.Forms.TextBox();
            this.RPCPort = new System.Windows.Forms.TextBox();
            this.RPCUser = new System.Windows.Forms.TextBox();
            this.RPCPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CencelButton = new System.Windows.Forms.Button();
            this.TestButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SSHUserBox = new System.Windows.Forms.TextBox();
            this.SSHPassBox = new System.Windows.Forms.TextBox();
            this.UseSSHCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RPCHost
            // 
            this.RPCHost.Location = new System.Drawing.Point(136, 6);
            this.RPCHost.Name = "RPCHost";
            this.RPCHost.Size = new System.Drawing.Size(436, 20);
            this.RPCHost.TabIndex = 0;
            // 
            // RPCPort
            // 
            this.RPCPort.Location = new System.Drawing.Point(136, 32);
            this.RPCPort.Name = "RPCPort";
            this.RPCPort.Size = new System.Drawing.Size(436, 20);
            this.RPCPort.TabIndex = 1;
            // 
            // RPCUser
            // 
            this.RPCUser.Location = new System.Drawing.Point(136, 58);
            this.RPCUser.Name = "RPCUser";
            this.RPCUser.Size = new System.Drawing.Size(436, 20);
            this.RPCUser.TabIndex = 2;
            // 
            // RPCPass
            // 
            this.RPCPass.Location = new System.Drawing.Point(136, 84);
            this.RPCPass.Name = "RPCPass";
            this.RPCPass.PasswordChar = '#';
            this.RPCPass.Size = new System.Drawing.Size(436, 20);
            this.RPCPass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "BitCoin RPC Host";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "BitCoin RPC Port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "BitCoin RPC User Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bitcoin RPC Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CencelButton
            // 
            this.CencelButton.Location = new System.Drawing.Point(12, 182);
            this.CencelButton.Name = "CencelButton";
            this.CencelButton.Size = new System.Drawing.Size(182, 20);
            this.CencelButton.TabIndex = 8;
            this.CencelButton.Text = "Cancel";
            this.CencelButton.UseVisualStyleBackColor = true;
            this.CencelButton.Click += new System.EventHandler(this.CencelButton_Click);
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(200, 182);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(182, 20);
            this.TestButton.TabIndex = 9;
            this.TestButton.Text = "Test Settings";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(388, 182);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(182, 20);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save Settings";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SSHUserBox
            // 
            this.SSHUserBox.Location = new System.Drawing.Point(136, 130);
            this.SSHUserBox.Name = "SSHUserBox";
            this.SSHUserBox.Size = new System.Drawing.Size(436, 20);
            this.SSHUserBox.TabIndex = 11;
            // 
            // SSHPassBox
            // 
            this.SSHPassBox.Location = new System.Drawing.Point(136, 156);
            this.SSHPassBox.Name = "SSHPassBox";
            this.SSHPassBox.PasswordChar = '#';
            this.SSHPassBox.Size = new System.Drawing.Size(436, 20);
            this.SSHPassBox.TabIndex = 12;
            // 
            // UseSSHCheckBox
            // 
            this.UseSSHCheckBox.AutoSize = true;
            this.UseSSHCheckBox.Enabled = false;
            this.UseSSHCheckBox.Location = new System.Drawing.Point(136, 110);
            this.UseSSHCheckBox.Name = "UseSSHCheckBox";
            this.UseSSHCheckBox.Size = new System.Drawing.Size(15, 14);
            this.UseSSHCheckBox.TabIndex = 13;
            this.UseSSHCheckBox.UseVisualStyleBackColor = true;
            this.UseSSHCheckBox.CheckedChanged += new System.EventHandler(this.UseSSHCheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Use SSH Security";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "SSH Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "SSH Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "(feature not working yet. sorry)";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 210);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UseSSHCheckBox);
            this.Controls.Add(this.SSHPassBox);
            this.Controls.Add(this.SSHUserBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.CencelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RPCPass);
            this.Controls.Add(this.RPCUser);
            this.Controls.Add(this.RPCPort);
            this.Controls.Add(this.RPCHost);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RPCHost;
        private System.Windows.Forms.TextBox RPCPort;
        private System.Windows.Forms.TextBox RPCUser;
        private System.Windows.Forms.TextBox RPCPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CencelButton;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox SSHUserBox;
        private System.Windows.Forms.TextBox SSHPassBox;
        private System.Windows.Forms.CheckBox UseSSHCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}