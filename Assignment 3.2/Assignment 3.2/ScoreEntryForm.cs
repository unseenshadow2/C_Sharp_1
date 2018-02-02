using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3._2
{
    public partial class ScoreEntryForm : Form
    {
        private TeamSetupForm owner;
        private Player currentPlayer;
        private int position = -1;
        private int[] scores = new int[Program.team.getPlayers.Length];

        private const string playerBase = "Player: ";

        public ScoreEntryForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Select the first player.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScoreEntryForm_Load(object sender, EventArgs e)
        {
            NextPlayer();
        }

        /// <summary>
        /// Update the score and advance to the next player.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            scores[position] = (int)nudScore.Value;

            NextPlayer();
        }

        /// <summary>
        /// Open the owner when this window is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScoreEntryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            owner.Show();
        }

        /// <summary>
        /// Move to the next player or exit the ScoreEntryForm window. The scores will only update
        /// when the ScoreEntryForm is closed by this function.
        /// </summary>
        private void NextPlayer()
        {
            if (position < (scores.Length - 1))
            {
                position += 1;
                currentPlayer = Program.team.getPlayers[position];

                lblPlayer.Text = playerBase + currentPlayer.ToString();
                nudScore.Value = 0;
                nudScore.Focus();
            }
            else
            {
                // Place the values into the players scores only when we have a full game.
                for (int i = 0; i < scores.Length; i++) Program.team.getPlayers[i].getPoints.Insert(0, scores[i]);
                owner.UpdateMath();

                Close();
            }
        }

        /// <summary>
        /// Open the ScoreEntryForm window and hide the TeamSetupForm window.
        /// </summary>
        /// <param name="opener">The TeamSetupForm that opens this ScoreEntryForm</param>
        public void Open(TeamSetupForm opener)
        {
            owner = opener;
            owner.Hide();
            this.Show();
        }
    }
}
