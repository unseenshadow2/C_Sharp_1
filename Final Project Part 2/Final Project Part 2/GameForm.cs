using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_Part_2.Properties;

namespace Final_Project_Part_2
{
    public partial class GameForm : Form
    {
		private Hangman hangman = new Hangman();

		private const string SoFar = "Guess so far: ";
		private const string Guesses = "Guesses: ";
		private const string BadGuesses = "Bad Guesses: ";
		private const string Characters = "Characters Guessed: ";
		private const string VictoryTitle = "You Won";
		private const string VictoryText = "Congratulations, you won!";
		private const string FailureTitle = "Failure";
		private const string FailureText = "Sorry, but you have failed.";
		private const string InvalidCharTitle = "Validation Error";
		private const string InvalidCharText = "Guess is invalid.It cannot contain spaces, numbers, or special characters.";
		private const int CharsPerLine = 5;

		// From 0 to 5 the images to display in the imagebox
		private readonly Image[] images = new Image[]
		{
			Resources.gallows,
			Resources.gallows1,
			Resources.gallows2,
			Resources.gallows3,
			Resources.gallows4,
			Resources.gallows5
		};

        public GameForm()
        {
            InitializeComponent();
        }

		/// <summary>
		/// Start the first game.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GameForm_Load(object sender, EventArgs e)
		{
			hangman.Reset();
			lblOutput.Visible = true;
			UpdateGui();
		}

		/// <summary>
		/// Handle a guess, whether it is a single character or whole string,
		/// and check if the guess is valid.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnGuess_Click(object sender, EventArgs e)
		{
			txtGuess.Text = txtGuess.Text.Trim();
			txtGuess.Text = txtGuess.Text.ToLower();

			if (Hangman.IsValidGuess(txtGuess.Text))
			{
				bool didWin;

				if (txtGuess.Text.Length == 1)
				{
					didWin = hangman.MakeGuess(txtGuess.Text[0]);
				}
				else
				{
					didWin = hangman.MakeGuess(txtGuess.Text);
				}

				// Victory?
				if (didWin)
				{
					UpdateGui();
					MessageBox.Show(VictoryText, VictoryTitle);
					hangman.Reset();
				}
				// Failure?
				else if (hangman.HasFailed())
				{
					UpdateGui();
					MessageBox.Show(FailureText, FailureTitle);
					hangman.Reset();
				}
				
				txtGuess.Text = "";
				txtGuess.Focus();
				UpdateGui();
			}
			else // Oops...
			{
				MessageBox.Show(InvalidCharText, InvalidCharTitle);
				txtGuess.Text = "";
				txtGuess.Focus();
				return;
			}
		}

		/// <summary>
		/// Reset the game... if you wish.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnReset_Click(object sender, EventArgs e)
		{
			hangman.Reset();
			UpdateGui();
		}

		/// <summary>
		/// Update all of the displayed values.
		/// </summary>
		private void UpdateGui()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(SoFar); sb.Append(hangman.getGuessed + '\n');
			sb.Append(Guesses); sb.Append(hangman.getGuessCount); sb.Append('\n');
			sb.Append(BadGuesses); sb.Append(hangman.getBadGuesses); sb.Append('\n');
			sb.Append(Characters);

			for(int i = 0; i < hangman.getCharGuessed.Count; i++)
			{
				if ((i % CharsPerLine) == 0) sb.Append("\n    ");
				sb.Append(hangman.getCharGuessed.ElementAt(i));

				if (i != (hangman.getCharGuessed.Count - 1)) sb.Append(", ");
			}

			lblOutput.Text = sb.ToString();

			// Update the image
			imgGallows.Image = images[hangman.getBadGuesses];
		}
	}
}
