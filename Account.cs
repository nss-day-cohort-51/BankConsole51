using System;
using System.Collections.Generic;
using System.Linq;

namespace BankConsole51
{
    public class Account
    {
        private static int _accountIncrementer = 0;

        public Account()
        {
            AccountNumber = _accountIncrementer++;
        }

        public int AccountNumber {get;set;}

        public Customer AccountOwner {get;set;}

        public List<Transaction> Transactions {get;set;}

        public decimal Balance
        {
            get
            {
                return Transactions.Select(t => t.Amount).Sum();
            }
        }
    }
}