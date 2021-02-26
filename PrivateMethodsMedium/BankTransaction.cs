using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateMethodsMedium
{
    public class BankTransaction
    {
        public double Amount { get; }
        public DateTime DateOfTransaction { get; }
        
        public BankTransaction(double amount, DateTime dateOfTransaction)
        {
            this.Amount = amount;
            this.DateOfTransaction = dateOfTransaction;
        }
    }
}
