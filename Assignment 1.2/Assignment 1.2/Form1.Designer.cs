namespace Assignment_1._2
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
            this.nudNum1 = new System.Windows.Forms.NumericUpDown();
            this.nudNum2 = new System.Windows.Forms.NumericUpDown();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSign = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.rdbSub = new System.Windows.Forms.RadioButton();
            this.rdbMult = new System.Windows.Forms.RadioButton();
            this.rdbDiv = new System.Windows.Forms.RadioButton();
            this.rdbRem = new System.Windows.Forms.RadioButton();
            this.lblRandomOperation = new System.Windows.Forms.Label();
            this.chbGenerateOperation = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudNum1
            // 
            this.nudNum1.DecimalPlaces = 4;
            this.nudNum1.Location = new System.Drawing.Point(12, 25);
            this.nudNum1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudNum1.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudNum1.Name = "nudNum1";
            this.nudNum1.Size = new System.Drawing.Size(75, 20);
            this.nudNum1.TabIndex = 1;
            this.nudNum1.ThousandsSeparator = true;
            this.nudNum1.ValueChanged += new System.EventHandler(this.InputNumberUpDown_ValueChanged);
            // 
            // nudNum2
            // 
            this.nudNum2.DecimalPlaces = 4;
            this.nudNum2.Location = new System.Drawing.Point(124, 25);
            this.nudNum2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudNum2.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudNum2.Name = "nudNum2";
            this.nudNum2.Size = new System.Drawing.Size(75, 20);
            this.nudNum2.TabIndex = 2;
            this.nudNum2.ThousandsSeparator = true;
            this.nudNum2.ValueChanged += new System.EventHandler(this.InputNumberUpDown_ValueChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(236, 24);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(100, 20);
            this.txtOutput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // lblSign
            // 
            this.lblSign.AutoSize = true;
            this.lblSign.Location = new System.Drawing.Point(99, 27);
            this.lblSign.Name = "lblSign";
            this.lblSign.Size = new System.Drawing.Size(13, 13);
            this.lblSign.TabIndex = 5;
            this.lblSign.Text = "+";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(124, 51);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbRem);
            this.groupBox1.Controls.Add(this.rdbDiv);
            this.groupBox1.Controls.Add(this.rdbMult);
            this.groupBox1.Controls.Add(this.rdbSub);
            this.groupBox1.Controls.Add(this.rdbAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(84, 143);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation:";
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Checked = true;
            this.rdbAdd.Location = new System.Drawing.Point(7, 20);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(31, 17);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "+";
            this.rdbAdd.UseVisualStyleBackColor = true;
            this.rdbAdd.Click += new System.EventHandler(this.OperationsRadioButton_Click);
            // 
            // rdbSub
            // 
            this.rdbSub.AutoSize = true;
            this.rdbSub.Location = new System.Drawing.Point(7, 44);
            this.rdbSub.Name = "rdbSub";
            this.rdbSub.Size = new System.Drawing.Size(28, 17);
            this.rdbSub.TabIndex = 1;
            this.rdbSub.TabStop = true;
            this.rdbSub.Text = "-";
            this.rdbSub.UseVisualStyleBackColor = true;
            this.rdbSub.Click += new System.EventHandler(this.OperationsRadioButton_Click);
            // 
            // rdbMult
            // 
            this.rdbMult.AutoSize = true;
            this.rdbMult.Location = new System.Drawing.Point(7, 68);
            this.rdbMult.Name = "rdbMult";
            this.rdbMult.Size = new System.Drawing.Size(30, 17);
            this.rdbMult.TabIndex = 2;
            this.rdbMult.TabStop = true;
            this.rdbMult.Text = "x";
            this.rdbMult.UseVisualStyleBackColor = true;
            this.rdbMult.Click += new System.EventHandler(this.OperationsRadioButton_Click);
            // 
            // rdbDiv
            // 
            this.rdbDiv.AutoSize = true;
            this.rdbDiv.Location = new System.Drawing.Point(7, 91);
            this.rdbDiv.Name = "rdbDiv";
            this.rdbDiv.Size = new System.Drawing.Size(30, 17);
            this.rdbDiv.TabIndex = 3;
            this.rdbDiv.TabStop = true;
            this.rdbDiv.Text = "/";
            this.rdbDiv.UseVisualStyleBackColor = true;
            this.rdbDiv.Click += new System.EventHandler(this.OperationsRadioButton_Click);
            // 
            // rdbRem
            // 
            this.rdbRem.AutoSize = true;
            this.rdbRem.Location = new System.Drawing.Point(7, 114);
            this.rdbRem.Name = "rdbRem";
            this.rdbRem.Size = new System.Drawing.Size(76, 17);
            this.rdbRem.TabIndex = 4;
            this.rdbRem.TabStop = true;
            this.rdbRem.Text = "Remainder";
            this.rdbRem.UseVisualStyleBackColor = true;
            this.rdbRem.Click += new System.EventHandler(this.OperationsRadioButton_Click);
            // 
            // lblRandomOperation
            // 
            this.lblRandomOperation.AutoSize = true;
            this.lblRandomOperation.Location = new System.Drawing.Point(236, 51);
            this.lblRandomOperation.Name = "lblRandomOperation";
            this.lblRandomOperation.Size = new System.Drawing.Size(0, 13);
            this.lblRandomOperation.TabIndex = 8;
            // 
            // chbGenerateOperation
            // 
            this.chbGenerateOperation.AutoSize = true;
            this.chbGenerateOperation.Checked = true;
            this.chbGenerateOperation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbGenerateOperation.Location = new System.Drawing.Point(124, 81);
            this.chbGenerateOperation.Name = "chbGenerateOperation";
            this.chbGenerateOperation.Size = new System.Drawing.Size(162, 17);
            this.chbGenerateOperation.TabIndex = 9;
            this.chbGenerateOperation.Text = "Generate Random Operation";
            this.chbGenerateOperation.UseVisualStyleBackColor = true;
            this.chbGenerateOperation.CheckedChanged += new System.EventHandler(this.chbGenerateOperation_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 262);
            this.Controls.Add(this.chbGenerateOperation);
            this.Controls.Add(this.lblRandomOperation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblSign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.nudNum2);
            this.Controls.Add(this.nudNum1);
            this.Name = "Form1";
            this.Text = "Assignment 1.2";
            ((System.ComponentModel.ISupportInitialize)(this.nudNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNum1;
        private System.Windows.Forms.NumericUpDown nudNum2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSign;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbRem;
        private System.Windows.Forms.RadioButton rdbDiv;
        private System.Windows.Forms.RadioButton rdbMult;
        private System.Windows.Forms.RadioButton rdbSub;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.Label lblRandomOperation;
        private System.Windows.Forms.CheckBox chbGenerateOperation;
    }
}

