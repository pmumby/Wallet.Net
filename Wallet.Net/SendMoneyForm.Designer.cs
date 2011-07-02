namespace Wallet.Net
{
    partial class SendMoneyForm
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
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ABButton = new System.Windows.Forms.Button();
            this.FeeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.CommentToBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(111, 12);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(250, 20);
            this.AddressBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recipient Address";
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(111, 92);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(100, 20);
            this.AmountBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount";
            // 
            // ABButton
            // 
            this.ABButton.Location = new System.Drawing.Point(367, 9);
            this.ABButton.Name = "ABButton";
            this.ABButton.Size = new System.Drawing.Size(95, 23);
            this.ABButton.TabIndex = 6;
            this.ABButton.Text = "<- Address Book";
            this.ABButton.UseVisualStyleBackColor = true;
            this.ABButton.Click += new System.EventHandler(this.ABButton_Click);
            // 
            // FeeBox
            // 
            this.FeeBox.Location = new System.Drawing.Point(111, 118);
            this.FeeBox.Name = "FeeBox";
            this.FeeBox.Size = new System.Drawing.Size(100, 20);
            this.FeeBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fee (optional)";
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(217, 92);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(245, 46);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "Send!";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // CommentBox
            // 
            this.CommentBox.Location = new System.Drawing.Point(111, 39);
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(351, 20);
            this.CommentBox.TabIndex = 1;
            // 
            // CommentToBox
            // 
            this.CommentToBox.Location = new System.Drawing.Point(111, 66);
            this.CommentToBox.Name = "CommentToBox";
            this.CommentToBox.Size = new System.Drawing.Size(351, 20);
            this.CommentToBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Comment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Recipient Comment";
            // 
            // SendMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 145);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CommentToBox);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FeeBox);
            this.Controls.Add(this.ABButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendMoneyForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Money";
            this.Load += new System.EventHandler(this.SendMoneyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ABButton;
        private System.Windows.Forms.TextBox FeeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox CommentBox;
        private System.Windows.Forms.TextBox CommentToBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}