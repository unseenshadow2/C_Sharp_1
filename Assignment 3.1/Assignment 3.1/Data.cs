using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._1
{
    class Data
    {
        private EntryMenu entryMenu;
        private TransactionMenu transactionMenu;
        private List<Account> accounts = new List<Account>();
        private Random random = new Random();
        public const int accountNumberSize = 10; // In characters

        // Getters and setters
        public EntryMenu getEntryMenu { get { return entryMenu; } }
        public EntryMenu setEntryMenu { set { entryMenu = value; } }

        public TransactionMenu getTransactionMenu { get { return transactionMenu; } }
        public TransactionMenu setTransactionMenu { set { transactionMenu = value; } }

        public List<Account> getAccounts { get { return accounts; } }

        public Random getRandom { get { return random; } }
    }
}
