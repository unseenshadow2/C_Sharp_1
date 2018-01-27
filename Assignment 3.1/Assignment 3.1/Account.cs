using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._1
{
    public class Account
    {
        private decimal balance = 100.00m;
        private string number = "";
        private string name = "";
        private List<Transaction> transactions = new List<Transaction>();

        public Account()
        {
            number = GenerateNumber(Data.accountNumberSize);
        }

        /// <summary>
        /// Generates a string that represents an account number.
        /// </summary>
        /// <param name="size">The number of characters in the account number</param>
        /// <returns>A string that represents an account number</returns>
        private string GenerateNumber(int size)
        {
            StringBuilder toReturn = new StringBuilder();

            for (int i = 0; i < size; i++)
            {
                toReturn.Append(Program.data.getRandom.Next(0, 10));
            }

            // If our account number isn't valid, retry
            if (!CheckNumberValidity(toReturn.ToString())) return GenerateNumber(size);

            return toReturn.ToString();
        }

        /// <summary>
        /// Checks whether an account number is valid (whether it is unique in the list).
        /// </summary>
        /// <param name="toCheck">The account number to check</param>
        /// <returns>Whether the account number is valid</returns>
        private bool CheckNumberValidity(string toCheck)
        {
            foreach (Account x in Program.data.getAccounts)
            {
                if (x.getNumber == toCheck) return false;
            }

            return true;
        }

        // Getters and setters
        public decimal getBalance { get { return balance; } }
        public decimal setBalance { set { balance = value; } }

        public string getNumber { get { return number; } }
        public string setNumber { set { number = value; } }

        public string getName { get { return name; } }
        public string setName { set { name = value; } }

        public List<Transaction> getTransactions { get { return transactions; } }
        public List<Transaction> setTransactions { set { transactions = value; } }
    }
}
