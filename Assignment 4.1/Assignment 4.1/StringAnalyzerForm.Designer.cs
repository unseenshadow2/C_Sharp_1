namespace Assignment_4._1
{
    partial class StringAnalyzerForm
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
            this.txtString1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtString2 = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.cbxConcatenate = new System.Windows.Forms.CheckBox();
            this.cbxSubstring = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtString1
            // 
            this.txtString1.Location = new System.Drawing.Point(13, 30);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(214, 20);
            this.txtString1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "String 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "String 2:";
            // 
            // txtString2
            // 
            this.txtString2.Location = new System.Drawing.Point(13, 82);
            this.txtString2.Name = "txtString2";
            this.txtString2.Size = new System.Drawing.Size(214, 20);
            this.txtString2.TabIndex = 2;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(286, 13);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(45, 21);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "label3";
            this.lblOutput.Visible = false;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(13, 153);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(113, 23);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "Process Strings";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // cbxConcatenate
            // 
            this.cbxConcatenate.AutoSize = true;
            this.cbxConcatenate.Location = new System.Drawing.Point(13, 109);
            this.cbxConcatenate.Name = "cbxConcatenate";
            this.cbxConcatenate.Size = new System.Drawing.Size(87, 17);
            this.cbxConcatenate.TabIndex = 6;
            this.cbxConcatenate.Text = "Concatenate";
            this.cbxConcatenate.UseVisualStyleBackColor = true;
            // 
            // cbxSubstring
            // 
            this.cbxSubstring.AutoSize = true;
            this.cbxSubstring.Location = new System.Drawing.Point(13, 132);
            this.cbxSubstring.Name = "cbxSubstring";
            this.cbxSubstring.Size = new System.Drawing.Size(153, 17);
            this.cbxSubstring.TabIndex = 7;
            this.cbxSubstring.Text = "Search String 1 for String 2";
            this.cbxSubstring.UseVisualStyleBackColor = true;
            // 
            // StringAnalyzerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 269);
            this.Controls.Add(this.cbxSubstring);
            this.Controls.Add(this.cbxConcatenate);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtString2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtString1);
            this.Name = "StringAnalyzerForm";
            this.Text = "String Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtString1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtString2;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.CheckBox cbxConcatenate;
        private System.Windows.Forms.CheckBox cbxSubstring;
    }
}

