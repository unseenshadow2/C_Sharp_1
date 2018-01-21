/*
 * Anthony Parsch
 * January 20, 2018
 * Assignment 2.1: Integer
 * 
 * Custom Features:
 * Reset button that allows the user to replay without having to reopen the program
 * Guess counter
 * User assignable range for the random number
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

namespace Assignment_2._1
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int answer = 0;
        private int guesses = 0;

        // Display Messages
        private const string equalsMessage = "Guess is correct - you win!";
        private const string tooLowMessage = "Guess is too low, please try again...";
        private const string tooHighMessage = "Guess is too high, please try again...";
        private const string baseTitle = "Guess the Number - Guesses: ";

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generate the answer based on the minimum and maximum values
        /// provided by the user.
        /// </summary>
        private void GenerateAnswer()
        {
            // Max is exclusive, so add 1
            answer = random.Next((int)nudMin.Value, (int)nudMax.Value+1);
        }

        /// <summary>
        /// Update the title to display the number of guesses.
        /// </summary>
        private void UpdateTitle()
        {
            Text = baseTitle + guesses;
        }

        /// <summary>
        /// Reset the game, including the number of guesses, the title
        /// and the current answer.
        /// </summary>
        private void ResetGame()
        {
            GenerateAnswer();
            guesses = 0;
            UpdateTitle();
        }

        /// <summary>
        /// Start the game with the "defaults" at the start.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetGame();
        }

        /// <summary>
        /// Check if the user's guess and display if it was
        /// equal, too high, or too low.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuess_Click(object sender, EventArgs e)
        {
            ++guesses;
            UpdateTitle();

            // Check our guess
            int guess = (int)nudAnswer.Value;

            if (guess > answer) MessageBox.Show(tooHighMessage);
            else if (guess < answer) MessageBox.Show(tooLowMessage);
            else MessageBox.Show(equalsMessage);
        }

        /// <summary>
        /// Reset the game when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
