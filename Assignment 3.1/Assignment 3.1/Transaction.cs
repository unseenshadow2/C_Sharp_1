using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._1
{
    public enum TransactionType { Withdraw, Deposit, CurrentBalance }

    public class Transaction
    {
        private TransactionType type;
        private decimal value;
        private decimal accountValue;

        private Transaction() { }
        public Transaction(TransactionType type, decimal value, decimal accountValue)
        {
            this.type = type;
            this.value = value;
            this.accountValue = accountValue;
        }

        /// <summary>
        /// Generate a display string for the transaction.
        /// </summary>
        /// <returns>A string representing the Transaction</returns>
        public override string ToString()
        {
            string toReturn = "";

            switch (type)
            {
                case TransactionType.Withdraw:
                    toReturn += "Withdraw: ";
                    break;
                case TransactionType.Deposit:
                    toReturn += "Deposit: ";
                    break;
            }

            toReturn += " Amount: " + value.ToString("C2") + " | Balance: " + accountValue.ToString("C2");

            return toReturn;
        }

        // Getters and setters
        public TransactionType getTransactionType { get { return type; } }

        public decimal getValue { get { return value; } }

        public decimal getAccountValue { get { return accountValue; } }
    }
}
