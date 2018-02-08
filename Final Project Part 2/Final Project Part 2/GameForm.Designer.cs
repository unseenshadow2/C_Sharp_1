namespace Final_Project_Part_2
{
    partial class GameForm
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
			this.btnReset = new System.Windows.Forms.Button();
			this.btnGuess = new System.Windows.Forms.Button();
			this.txtGuess = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblOutput = new System.Windows.Forms.Label();
			this.imgGallows = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.imgGallows)).BeginInit();
			this.SuspendLayout();
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(12, 244);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 0;
			this.btnReset.Text = "Reset Game";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnGuess
			// 
			this.btnGuess.Location = new System.Drawing.Point(12, 36);
			this.btnGuess.Name = "btnGuess";
			this.btnGuess.Size = new System.Drawing.Size(75, 23);
			this.btnGuess.TabIndex = 1;
			this.btnGuess.Text = "Make Guess";
			this.btnGuess.UseVisualStyleBackColor = true;
			this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
			// 
			// txtGuess
			// 
			this.txtGuess.Location = new System.Drawing.Point(59, 10);
			this.txtGuess.Name = "txtGuess";
			this.txtGuess.Size = new System.Drawing.Size(169, 20);
			this.txtGuess.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Guess:";
			// 
			// lblOutput
			// 
			this.lblOutput.AutoSize = true;
			this.lblOutput.Location = new System.Drawing.Point(13, 62);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(35, 13);
			this.lblOutput.TabIndex = 4;
			this.lblOutput.Text = "label2";
			this.lblOutput.Visible = false;
			// 
			// imgGallows
			// 
			this.imgGallows.Image = global::Final_Project_Part_2.Properties.Resources.gallows;
			this.imgGallows.Location = new System.Drawing.Point(234, 10);
			this.imgGallows.Name = "imgGallows";
			this.imgGallows.Size = new System.Drawing.Size(201, 264);
			this.imgGallows.TabIndex = 5;
			this.imgGallows.TabStop = false;
			// 
			// GameForm
			// 
			this.AcceptButton = this.btnGuess;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(448, 279);
			this.Controls.Add(this.imgGallows);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtGuess);
			this.Controls.Add(this.btnGuess);
			this.Controls.Add(this.btnReset);
			this.Name = "GameForm";
			this.Text = "Parsch Hangman";
			this.Load += new System.EventHandler(this.GameForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.imgGallows)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnGuess;
		private System.Windows.Forms.TextBox txtGuess;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.PictureBox imgGallows;
	}
}

