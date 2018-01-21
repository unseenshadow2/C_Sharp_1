namespace Assignment_2._1
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
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.nudAnswer = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnswer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(98, 21);
            this.nudMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMin.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(70, 20);
            this.nudMin.TabIndex = 0;
            this.nudMin.ThousandsSeparator = true;
            this.nudMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(98, 47);
            this.nudMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMax.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(70, 20);
            this.nudMax.TabIndex = 1;
            this.nudMax.ThousandsSeparator = true;
            this.nudMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudAnswer
            // 
            this.nudAnswer.Location = new System.Drawing.Point(12, 14);
            this.nudAnswer.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAnswer.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.nudAnswer.Name = "nudAnswer";
            this.nudAnswer.Size = new System.Drawing.Size(70, 20);
            this.nudAnswer.TabIndex = 2;
            this.nudAnswer.ThousandsSeparator = true;
            this.nudAnswer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(7, 66);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(79, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset Game";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(88, 13);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 4;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudMin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudMax);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Minimum Answer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Maximum Answer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 65);
            this.label5.TabIndex = 8;
            this.label5.Text = "The game opens with a randomly\r\ngenerated number within 1 to 100. \r\nIf we wish to" +
    " try again or answer \r\nwithin a different range, press the\r\n \"Reset Game\" button" +
    ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 160);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.nudAnswer);
            this.Name = "Form1";
            this.Text = "Guess the Number";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnswer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown nudAnswer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

