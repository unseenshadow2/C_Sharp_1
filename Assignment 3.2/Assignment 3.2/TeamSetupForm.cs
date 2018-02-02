/*
 * Anthony Parsch
 * January 28, 2018
 * Assignment 3.2: Team
 * 
 * Custom Features:
 * Players can be named
 * Multiple games can be entered
 * The TeamSetupForm displays the statistics for both the last game and all previously entered games
 * Players have jersey numbers
 */

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
    public partial class TeamSetupForm : Form
    {
        private Player toUpdate;

        public TeamSetupForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ensure that all elements update when the program starts.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TeamSetupForm_Load(object sender, EventArgs e)
        {
            toUpdate = Program.team.getPlayers[0];

            UpdateGui();
            UpdateMath();
        }

        /// <summary>
        /// Update the selected player with the given information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdatePlayer_Click(object sender, EventArgs e)
        {
            toUpdate.setName = txtPlayerName.Text;
            toUpdate.setNumber = (int)nudPlayerNumber.Value;

            UpdateGui();
        }

        /// <summary>
        /// Open the ScoreEntryForm then update the math.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnterScores_Click(object sender, EventArgs e)
        {
            new ScoreEntryForm().Open(this);

            //UpdateMath();
        }

        /// <summary>
        /// Update the player data textboxes when a new player is selected in the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxTeamMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            toUpdate = Program.team.getPlayers[lbxTeamMembers.SelectedIndex];

            UpdatePlayerDisplay();
        }

        /// <summary>
        /// Calculate the total of the given dataset.
        /// </summary>
        /// <param name="data">The integer dataset</param>
        /// <returns>The total of the dataset</returns>
        private int Total(int[] data)
        {
            int toReturn = 0;

            foreach (int x in data) toReturn += x;

            return toReturn;
        }

        /// <summary>
        /// Calculate the decimal mean given integer total and count.
        /// </summary>
        /// <param name="total">The total</param>
        /// <param name="count">The number of items making up the total</param>
        /// <returns>The decimal mean of the numbers given</returns>
        private decimal Mean(int total, int count)
        {
            return (decimal)total / (decimal)count;
        }

        /// <summary>
        /// Calculates the mean of an integer array.
        /// </summary>
        /// <param name="data">The integer array to be processed</param>
        /// <returns>The decimal mean of the data</returns>
        private decimal Mean(int[] data)
        {
            return Mean(Total(data), data.Length);
        }

        /// <summary>
        /// Generate an array of all the scores of the team.
        /// </summary>
        /// <returns>The scores of the entire team</returns>
        private int[] TeamScores()
        {
            List<int> toReturn = new List<int>();

            foreach (Player player in Program.team.getPlayers)
            {
                toReturn.AddRange(player.getPoints);
            }

            return toReturn.ToArray();
        }

        /// <summary>
        /// Generate an array of the scores from the last game.
        /// </summary>
        /// <returns>The scores of the last game</returns>
        private int[] LastGameScores()
        {
            List<int> toReturn = new List<int>();

            foreach (Player player in Program.team.getPlayers)
            {
                toReturn.Add(player.getPoints[0]);
            }

            return toReturn.ToArray();
        }

        /// <summary>
        /// Updates the labels concerning the last game statistics.
        /// </summary>
        private void UpdateLastGame()
        {
            if (Program.team.games == 0)
            {
                lblLastGameMean.Text = "0";
                lblLastGameTotal.Text = "0";
            }
            else
            {
                int[] scores = LastGameScores();
                int total = Total(scores);

                lblLastGameTotal.Text = total.ToString();
                lblLastGameMean.Text = Mean(total, scores.Length).ToString("F");
            }
        }

        /// <summary>
        /// Updates the labels concerning the team total.
        /// </summary>
        private void UpdateTeamTotal()
        {
            if (Program.team.games == 0)
            {
                lblTeamMean.Text = "0";
                lblTeamTotal.Text = "0";
            }
            else
            {
                int[] scores = TeamScores();
                int total = Total(scores);

                lblTeamTotal.Text = total.ToString();
                lblTeamMean.Text = Mean(total, scores.Length).ToString("F");
            }
        }

        /// <summary>
        /// Updates the labels concerning math.
        /// </summary>
        public void UpdateMath()
        {
            UpdateLastGame();
            UpdateTeamTotal();
        }

        /// <summary>
        /// Updates the display listbox for the players.
        /// </summary>
        private void UpdateListbox()
        {
            int selectedIndex = lbxTeamMembers.SelectedIndex;
            lbxTeamMembers.Items.Clear();

            foreach (Player x in Program.team.getPlayers)
            {
                lbxTeamMembers.Items.Add(x.ToString());
            }

            lbxTeamMembers.SelectedIndex = selectedIndex;
        }

        /// <summary>
        /// Updates the textboxes concerning the selected player's information.
        /// </summary>
        private void UpdatePlayerDisplay()
        {
            txtPlayerName.Text = toUpdate.getName;
            nudPlayerNumber.Value = toUpdate.getNumber;
        }

        /// <summary>
        /// Updates the listbox and the textboxes.
        /// </summary>
        private void UpdateGui()
        {
            UpdatePlayerDisplay();
            UpdateListbox();
        }
    }
}
