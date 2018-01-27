namespace Assignment_3._1
{
    partial class TransactionMenu
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
            this.lbxTransactions = new System.Windows.Forms.ListBox();
            this.nudTransactionValue = new System.Windows.Forms.NumericUpDown();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransactionValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxTransactions
            // 
            this.lbxTransactions.Enabled = false;
            this.lbxTransactions.FormattingEnabled = true;
            this.lbxTransactions.Location = new System.Drawing.Point(176, 11);
            this.lbxTransactions.Name = "lbxTransactions";
            this.lbxTransactions.ScrollAlwaysVisible = true;
            this.lbxTransactions.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxTransactions.Size = new System.Drawing.Size(272, 368);
            this.lbxTransactions.TabIndex = 0;
            // 
            // nudTransactionValue
            // 
            this.nudTransactionValue.DecimalPlaces = 2;
            this.nudTransactionValue.Location = new System.Drawing.Point(12, 70);
            this.nudTransactionValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudTransactionValue.Name = "nudTransactionValue";
            this.nudTransactionValue.Size = new System.Drawing.Size(158, 20);
            this.nudTransactionValue.TabIndex = 1;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(13, 97);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(95, 96);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Location = new System.Drawing.Point(13, 12);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentBalance.TabIndex = 4;
            this.lblCurrentBalance.Text = "label1";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(16, 356);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(113, 23);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return to Accounts";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // TransactionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 399);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblCurrentBalance);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.nudTransactionValue);
            this.Controls.Add(this.lbxTransactions);
            this.Name = "TransactionMenu";
            this.Text = "TransactionMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TransactionMenu_FormClosed);
            this.Load += new System.EventHandler(this.TransactionMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTransactionValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxTransactions;
        private System.Windows.Forms.NumericUpDown nudTransactionValue;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.Button btnReturn;
    }
}