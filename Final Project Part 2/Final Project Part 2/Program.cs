/*
 * Anthony Parsch
 * February 7, 2018
 * Final Project Part 2: Game
 * 
 * Custom Features:
 * Displays the number of guesses and bad guesses
 * Ignores repeat characters
 * Displays all characters guessed so far
 * Displays a gallows similar to the pen and paper hangman
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Part_2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameForm());
        }
    }
}
