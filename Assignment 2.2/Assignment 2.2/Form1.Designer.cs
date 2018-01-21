namespace Assignment_2._2
{
    partial class Form1
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
            this.cbxFlavor = new System.Windows.Forms.ComboBox();
            this.cbxQuantity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtReceipt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudEspresso = new System.Windows.Forms.NumericUpDown();
            this.cbxIced = new System.Windows.Forms.CheckBox();
            this.cbxCream = new System.Windows.Forms.CheckBox();
            this.cbxMilk = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudEspresso)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxFlavor
            // 
            this.cbxFlavor.FormattingEnabled = true;
            this.cbxFlavor.Location = new System.Drawing.Point(66, 13);
            this.cbxFlavor.Name = "cbxFlavor";
            this.cbxFlavor.Size = new System.Drawing.Size(121, 21);
            this.cbxFlavor.TabIndex = 0;
            // 
            // cbxQuantity
            // 
            this.cbxQuantity.FormattingEnabled = true;
            this.cbxQuantity.Location = new System.Drawing.Point(66, 41);
            this.cbxQuantity.Name = "cbxQuantity";
            this.cbxQuantity.Size = new System.Drawing.Size(121, 21);
            this.cbxQuantity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flavor:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 168);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(121, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Add to Receipt";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtReceipt
            // 
            this.txtReceipt.Font = new System.Drawing.Font("Liberation Mono", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceipt.Location = new System.Drawing.Point(193, 6);
            this.txtReceipt.Multiline = true;
            this.txtReceipt.Name = "txtReceipt";
            this.txtReceipt.ReadOnly = true;
            this.txtReceipt.Size = new System.Drawing.Size(230, 354);
            this.txtReceipt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Espresso Shots:";
            // 
            // nudEspresso
            // 
            this.nudEspresso.Location = new System.Drawing.Point(102, 69);
            this.nudEspresso.Name = "nudEspresso";
            this.nudEspresso.Size = new System.Drawing.Size(85, 20);
            this.nudEspresso.TabIndex = 7;
            // 
            // cbxIced
            // 
            this.cbxIced.AutoSize = true;
            this.cbxIced.Location = new System.Drawing.Point(15, 100);
            this.cbxIced.Name = "cbxIced";
            this.cbxIced.Size = new System.Drawing.Size(47, 17);
            this.cbxIced.TabIndex = 8;
            this.cbxIced.Text = "Iced";
            this.cbxIced.UseVisualStyleBackColor = true;
            // 
            // cbxCream
            // 
            this.cbxCream.AutoSize = true;
            this.cbxCream.Location = new System.Drawing.Point(15, 124);
            this.cbxCream.Name = "cbxCream";
            this.cbxCream.Size = new System.Drawing.Size(78, 17);
            this.cbxCream.TabIndex = 9;
            this.cbxCream.Text = "Add Cream";
            this.cbxCream.UseVisualStyleBackColor = true;
            // 
            // cbxMilk
            // 
            this.cbxMilk.AutoSize = true;
            this.cbxMilk.Location = new System.Drawing.Point(15, 145);
            this.cbxMilk.Name = "cbxMilk";
            this.cbxMilk.Size = new System.Drawing.Size(92, 17);
            this.cbxMilk.TabIndex = 10;
            this.cbxMilk.Text = "Use Real Milk";
            this.cbxMilk.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 372);
            this.Controls.Add(this.cbxMilk);
            this.Controls.Add(this.cbxCream);
            this.Controls.Add(this.cbxIced);
            this.Controls.Add(this.nudEspresso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReceipt);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxQuantity);
            this.Controls.Add(this.cbxFlavor);
            this.Name = "Form1";
            this.Text = "Random House Coffee Price Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudEspresso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFlavor;
        private System.Windows.Forms.ComboBox cbxQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtReceipt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudEspresso;
        private System.Windows.Forms.CheckBox cbxIced;
        private System.Windows.Forms.CheckBox cbxCream;
        private System.Windows.Forms.CheckBox cbxMilk;
    }
}

