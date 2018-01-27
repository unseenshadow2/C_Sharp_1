using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3._1
{
    public partial class EntryMenu : Form
    {
        public EntryMenu()
        {
            InitializeComponent();
        }

        private void EntryMenu_Load(object sender, EventArgs e)
        {
            Reset();
        }

        /// <summary>
        /// Reset the EntryMenu to prepare it for being reopened
        /// </summary>
        public void Reset()
        {
            // Clear inputs and outputs
            lbxAccounts.Items.Clear();
            txtNewAccountName.Text = "";

            // Fill our listbox on reset
            if (Program.data.getAccounts.Count > 0)
            {
                foreach (Account x in Program.data.getAccounts)
                {
                    lbxAccounts.Items.Add(x.getName + " - #" + x.getNumber);
                }
            }
        }

        /// <summary>
        /// Close the window and go to the TransactionMenu for the selected account.
        /// </summary>
        /// <param name="account"></param>
        private void GoToTransactionMenu(Account account)
        {
            Hide();
            TransactionMenu.EnterTransactionMenu(account);
        }

        /// <summary>
        /// Create a new account.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNewAccountName.Text))
            {
                DialogResult dr = MessageBox.Show(
                    "Warning: Creating an account requires $100 in cash to initialize the account. Do you still wish to create the account?",
                    "Creating Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Account toAdd = new Account();
                    toAdd.setName = txtNewAccountName.Text;

                    // Add the account
                    Program.data.getAccounts.Add(toAdd);

                    // Open the TransactionMenu and close the EntryMenu
                    GoToTransactionMenu(toAdd);
                }
                else
                {
                    Reset();
                }
            }
            else
            {
                MessageBox.Show("ERROR: No name for the account has been given!", 
                    "There Was a Problem Creating Your Account!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            GoToTransactionMenu(Program.data.getAccounts[lbxAccounts.SelectedIndex]);
        }
    }
}
