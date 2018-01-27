namespace Assignment_3._1
{
    partial class EntryMenu
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
            this.lbxAccounts = new System.Windows.Forms.ListBox();
            this.btnOpenAccount = new System.Windows.Forms.Button();
            this.txtNewAccountName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxAccounts
            // 
            this.lbxAccounts.FormattingEnabled = true;
            this.lbxAccounts.Location = new System.Drawing.Point(189, 38);
            this.lbxAccounts.Name = "lbxAccounts";
            this.lbxAccounts.Size = new System.Drawing.Size(202, 277);
            this.lbxAccounts.TabIndex = 0;
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Location = new System.Drawing.Point(289, 318);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(102, 23);
            this.btnOpenAccount.TabIndex = 1;
            this.btnOpenAccount.Text = "Open Account";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            this.btnOpenAccount.Click += new System.EventHandler(this.btnOpenAccount_Click);
            // 
            // txtNewAccountName
            // 
            this.txtNewAccountName.Location = new System.Drawing.Point(12, 38);
            this.txtNewAccountName.Name = "txtNewAccountName";
            this.txtNewAccountName.Size = new System.Drawing.Size(171, 20);
            this.txtNewAccountName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Account Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Accounts:";
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Location = new System.Drawing.Point(13, 65);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(106, 23);
            this.btnNewAccount.TabIndex = 5;
            this.btnNewAccount.Text = "New Account";
            this.btnNewAccount.UseVisualStyleBackColor = true;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // EntryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 353);
            this.Controls.Add(this.btnNewAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewAccountName);
            this.Controls.Add(this.btnOpenAccount);
            this.Controls.Add(this.lbxAccounts);
            this.Name = "EntryMenu";
            this.Text = "Bank of Advancing Technology - Select Account";
            this.Load += new System.EventHandler(this.EntryMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAccounts;
        private System.Windows.Forms.Button btnOpenAccount;
        private System.Windows.Forms.TextBox txtNewAccountName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewAccount;
    }
}

