using System;

namespace PrivateMethodsMedium.AMoreMeaningfulImprovement
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

        public string ProcessTransactionsAndReport(BankTransactionCollection bankTransactions)
        {
            // A wise coder has come along and split the code up into some methods
            string report = CreateHeader();
        
            // Create header for report
            foreach (var transaction in bankTransactions.Transactions)
            {
                // Create detail line for report
                report += CreateDetailLine(transaction);
                // Update BankBalance
                BankBalance = +transaction.Amount;
            }

            // Create trailer for report
            report += CreateTrailer();

            // Return report
            return report;
        }


        private string CreateHeader()
        {
            // Format a header (using details such as SortCode and account that may be on the Person class 
            // but that are not shown here.
            return string.Empty;
        }
        
        private string CreateDetailLine(BankTransaction bankTransaction)
        {
            // Format a detail line using detail from the transaction
            return string.Empty;
        }

        private string CreateTrailer()
        {
            // Format a header (using details such as SortCode and account that may be on the Person class 
            // but that are not shown here.
            return string.Empty;
        }
    }
}
