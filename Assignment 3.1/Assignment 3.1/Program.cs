/*
 * Anthony Parsch
 * January 27, 2018
 * Assignment 3.1: Class
 * 
 * Custom Features:
 * Displays accounts and transactions in Listboxes (instead of requiring explicit inputs)
 * TransactionMenu is a form in place of a while loop
 * TransactionMenu displays current balance
 * Uses List<> where arrays were instructed
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3._1
{
    static class Program
    {
        public static Data data = new Data();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Stuff needed to create forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create our forms
            data.setEntryMenu = new EntryMenu();
            data.setTransactionMenu = new TransactionMenu();

            // Enter the program
            Application.Run(data.getEntryMenu);
        }
    }
}
