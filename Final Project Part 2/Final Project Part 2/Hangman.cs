using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Part_2
{
    public class Hangman
    {
        private readonly string[] PossibleWords =
        {
			"leg", "fasten", "thirsty", "cheat", "winter",
            "hateful", "scattered", "amusing", "afternoon", "order"
        };
		public const int FailureAt = 5;

		private string objective = ""; // What we intend to guess
		private string guessed = ""; // The string as guessed so far. '_' is an unguessed character.
		private char[] chars; // The characters of the guessed string
		private List<char> charGuessed = new List<char>(); // All the characters guessed
		private int guessCount = 0;
		private int badGuesses = 0;
		private Random random = new Random();
		private bool hasStarted = false;

		/// <summary>
		/// Checks to see if the guess given validates.
		/// </summary>
		/// <param name="guess">The guess to be checked</param>
		/// <returns>If the guess validated</returns>
		public static bool IsValidGuess(string guess)
		{
			if (guess.Length == 0) return false;

			foreach (char x in guess)
			{
				if (!((x >= 'a') && (x <= 'z'))) return false;
			}

			return true;
		}

		/// <summary>
		/// Resets the game of hangman.
		/// </summary>
		public void Reset()
		{
			objective = PossibleWords[random.Next(1, 10)]; // Get the new objective

			chars = new char[objective.Length];
			for (int i = 0; i < chars.Length; i++) chars[i] = '_';

			BuildGuessed();

			charGuessed.Clear();
			guessCount = 0;
			badGuesses = 0;

			hasStarted = true;
		}

		/// <summary>
		/// Takes a character guess and updates the game.
		/// </summary>
		/// <param name="guess">The character guess</param>
		/// <returns>Whether the user has won the game</returns>
		public bool MakeGuess(char guess)
		{
			if (!hasStarted) Reset();

			if (charGuessed.Contains(guess)) return false; // If the guess has already been made, ignore it
			else charGuessed.Add(guess);

			bool isBadGuess = true;

			for (int i = 0; i < objective.Length; i++)
			{
				if (guess == objective[i])
				{
					chars[i] = guess;
					isBadGuess = false;
				}
			}

			BuildGuessed();

			++guessCount;
			if (isBadGuess) ++badGuesses;
			return !guessed.Contains("_");
		}

		/// <summary>
		/// Checks if the string guess is the objective word.
		/// </summary>
		/// <param name="guess">The guessed word</param>
		/// <returns>Whether the user has won the game</returns>
		public bool MakeGuess(string guess)
		{
			if (!hasStarted) Reset();

			bool toReturn = (guess == objective);
			++guessCount;
			if (!toReturn) ++badGuesses;

			return toReturn;
		}

		/// <summary>
		/// Has the user failed the game?
		/// </summary>
		/// <returns>If the user failed</returns>
		public bool HasFailed()
		{
			return badGuesses >= FailureAt;
		}

		/// <summary>
		/// Build the guessed string that shows what characters have
		/// been discovered.
		/// </summary>
		private void BuildGuessed()
		{
			guessed = "";

			foreach (char x in chars) guessed += x + " ";
		}

		// Getters and Setters
		public string getObjective { get { return objective; } }

		public string getGuessed { get { return guessed; } }

		public List<char> getCharGuessed { get { return charGuessed; } }

		public int getGuessCount { get { return guessCount; } }

		public int getBadGuesses { get { return badGuesses; } }
    }
}
