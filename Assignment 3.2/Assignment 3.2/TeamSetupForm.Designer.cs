namespace Assignment_3._2
{
    partial class TeamSetupForm
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
            this.lbxTeamMembers = new System.Windows.Forms.ListBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPlayerNumber = new System.Windows.Forms.NumericUpDown();
            this.btnEnterScores = new System.Windows.Forms.Button();
            this.btnUpdatePlayer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLastGameMean = new System.Windows.Forms.Label();
            this.lblTeamMean = new System.Windows.Forms.Label();
            this.lblLastGameTotal = new System.Windows.Forms.Label();
            this.lblTeamTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerNumber)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxTeamMembers
            // 
            this.lbxTeamMembers.FormattingEnabled = true;
            this.lbxTeamMembers.Location = new System.Drawing.Point(12, 12);
            this.lbxTeamMembers.Name = "lbxTeamMembers";
            this.lbxTeamMembers.Size = new System.Drawing.Size(208, 251);
            this.lbxTeamMembers.TabIndex = 0;
            this.lbxTeamMembers.SelectedIndexChanged += new System.EventHandler(this.lbxTeamMembers_SelectedIndexChanged);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(225, 31);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(222, 20);
            this.txtPlayerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player Number:";
            // 
            // nudPlayerNumber
            // 
            this.nudPlayerNumber.Location = new System.Drawing.Point(456, 31);
            this.nudPlayerNumber.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudPlayerNumber.Name = "nudPlayerNumber";
            this.nudPlayerNumber.Size = new System.Drawing.Size(76, 20);
            this.nudPlayerNumber.TabIndex = 4;
            // 
            // btnEnterScores
            // 
            this.btnEnterScores.Location = new System.Drawing.Point(13, 270);
            this.btnEnterScores.Name = "btnEnterScores";
            this.btnEnterScores.Size = new System.Drawing.Size(92, 23);
            this.btnEnterScores.TabIndex = 5;
            this.btnEnterScores.Text = "Enter a Game";
            this.btnEnterScores.UseVisualStyleBackColor = true;
            this.btnEnterScores.Click += new System.EventHandler(this.btnEnterScores_Click);
            // 
            // btnUpdatePlayer
            // 
            this.btnUpdatePlayer.Location = new System.Drawing.Point(225, 58);
            this.btnUpdatePlayer.Name = "btnUpdatePlayer";
            this.btnUpdatePlayer.Size = new System.Drawing.Size(93, 23);
            this.btnUpdatePlayer.TabIndex = 6;
            this.btnUpdatePlayer.Text = "Update Player";
            this.btnUpdatePlayer.UseVisualStyleBackColor = true;
            this.btnUpdatePlayer.Click += new System.EventHandler(this.btnUpdatePlayer_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLastGameMean, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTeamMean, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLastGameTotal, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTeamTotal, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(226, 87);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(174, 82);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mean\r\nPoints";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(3, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 43);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total\r\nPoints";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(45, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last Game";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Location = new System.Drawing.Point(109, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Team Total";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblLastGameMean
            // 
            this.lblLastGameMean.AutoSize = true;
            this.lblLastGameMean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastGameMean.Location = new System.Drawing.Point(45, 13);
            this.lblLastGameMean.Name = "lblLastGameMean";
            this.lblLastGameMean.Size = new System.Drawing.Size(58, 26);
            this.lblLastGameMean.TabIndex = 4;
            this.lblLastGameMean.Text = "label7";
            this.lblLastGameMean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeamMean
            // 
            this.lblTeamMean.AutoSize = true;
            this.lblTeamMean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTeamMean.Location = new System.Drawing.Point(109, 13);
            this.lblTeamMean.Name = "lblTeamMean";
            this.lblTeamMean.Size = new System.Drawing.Size(62, 26);
            this.lblTeamMean.TabIndex = 5;
            this.lblTeamMean.Text = "label8";
            this.lblTeamMean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastGameTotal
            // 
            this.lblLastGameTotal.AutoSize = true;
            this.lblLastGameTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastGameTotal.Location = new System.Drawing.Point(45, 39);
            this.lblLastGameTotal.Name = "lblLastGameTotal";
            this.lblLastGameTotal.Size = new System.Drawing.Size(58, 43);
            this.lblLastGameTotal.TabIndex = 6;
            this.lblLastGameTotal.Text = "label9";
            this.lblLastGameTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeamTotal
            // 
            this.lblTeamTotal.AutoSize = true;
            this.lblTeamTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTeamTotal.Location = new System.Drawing.Point(109, 39);
            this.lblTeamTotal.Name = "lblTeamTotal";
            this.lblTeamTotal.Size = new System.Drawing.Size(62, 43);
            this.lblTeamTotal.TabIndex = 7;
            this.lblTeamTotal.Text = "label10";
            this.lblTeamTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TeamSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnUpdatePlayer);
            this.Controls.Add(this.btnEnterScores);
            this.Controls.Add(this.nudPlayerNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lbxTeamMembers);
            this.Name = "TeamSetupForm";
            this.Text = "Basketball Score Calculator - Team Entry";
            this.Load += new System.EventHandler(this.TeamSetupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerNumber)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxTeamMembers;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPlayerNumber;
        private System.Windows.Forms.Button btnEnterScores;
        private System.Windows.Forms.Button btnUpdatePlayer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLastGameMean;
        private System.Windows.Forms.Label lblTeamMean;
        private System.Windows.Forms.Label lblLastGameTotal;
        private System.Windows.Forms.Label lblTeamTotal;
    }
}

