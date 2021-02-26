using System;
using System.Collections.Generic;

namespace PrivateMethodsMedium
{
    public class Person
    {
        public string FirstName { get; }

        public string LastName { get; }

        public string PostCode { get; }
        
        public double BankBalance { get; private set; }

        public Person(string FirstName, string LastName, string PostCode, double bankBalance)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PostCode = PostCode;
            this.BankBalance = bankBalance;
        }

        public string ProcessTransactionAndReport(IEnumerable<BankTransaction> bankTransactions)
        {
            // Create header for report

            foreach (var transaction in bankTransactions)
            {
                // Create detail line for report
                // Update BankBalance
                BankBalance = +transaction.Amount;
            }

            // Create trailer for report

            // Return report
            return string.Empty;
        }
    }
}
