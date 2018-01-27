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
    public partial class TransactionMenu : Form
    {
        private const string baseTitle = "Bank of Advancing Technology - ";
        private const string baseBalance = "Current Balance: ";

        private Account account;

        public TransactionMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Update the title to show the current account name and number.
        /// Also update the display listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TransactionMenu_Load(object sender, EventArgs e)
        {
            Text = baseTitle + account.getName + " #" + account.getNumber;
            UpdateOutputs();
        }

        /// <summary>
        /// Reopen our EntryMenu when we close our transaction menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TransactionMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.data.getEntryMenu.Reset();
            Program.data.getEntryMenu.Show();
        }

        /// <summary>
        /// Deposit to the account.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            NewTransaction(TransactionType.Deposit);
        }

        /// <summary>
        /// Withdraw from the account.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            NewTransaction(TransactionType.Withdraw);
        }

        /// <summary>
        /// Return to the EntryMenu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Enter the TransactionMenu from another window.
        /// </summary>
        /// <param name="account"></param>
        public static void EnterTransactionMenu(Account account)
        {
            TransactionMenu transactionMenu = new TransactionMenu();
            transactionMenu.account = account;
            transactionMenu.Show();
        }

        /// <summary>
        /// Update the outputs of the TransactionMenu.
        /// </summary>
        private void UpdateOutputs()
        {
            Transaction[] transactions = account.getTransactions.ToArray();
            lbxTransactions.Items.Clear();

            for (int i = transactions.Length-1; i >= 0; i--)
            {
                lbxTransactions.Items.Add(transactions[i].ToString());
            }

            nudTransactionValue.Value = 0m;

            lblCurrentBalance.Text = baseBalance + account.getBalance.ToString("C2");
        }

        /// <summary>
        /// Process a new transaction of the given type, drawing values from the TransactionMenu.
        /// </summary>
        /// <param name="type"></param>
        private void NewTransaction(TransactionType type)
        {
            if (type == TransactionType.Withdraw) account.setBalance = account.getBalance - nudTransactionValue.Value;
            else if (type == TransactionType.Deposit) account.setBalance = account.getBalance + nudTransactionValue.Value;

            Transaction transaction = new Transaction(type, nudTransactionValue.Value, account.getBalance);
            account.getTransactions.Add(transaction);

            UpdateOutputs();
        }
    }
}
