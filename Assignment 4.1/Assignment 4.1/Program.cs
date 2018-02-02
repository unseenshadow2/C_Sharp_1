/*
 * Anthony Parsch
 * February 1, 2018
 * Assignment 4.1: Strings
 * 
 * Custom Features:
 * The output label uses the font Segoe Print
 * Concatenation and searching the first string are optional
 * If a second string is provided, the first 3 operations will be done for it as well
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._1
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
            Application.Run(new StringAnalyzerForm());
        }
    }
}
