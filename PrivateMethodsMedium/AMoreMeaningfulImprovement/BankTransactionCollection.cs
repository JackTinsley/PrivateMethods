using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateMethodsMedium.AMoreMeaningfulImprovement
{
    public class BankTransactionCollection
    {
        public IEnumerable<BankTransaction> BankTransactions { get; }

        private IReportCreator ReportCreator;

        public BankTransactionCollection(IEnumerable<BankTransaction> transactions, IReportCreator reportCreator)
        {
            this.BankTransactions = BankTransactions;
            this.ReportCreator = reportCreator;
        }

        public ReportAndBalance ProcessTransactionsAndReport()
        {
            // The thought here is that although the elements that make the report can be put into a class that is injected in,
            // the problem of the side effect (updating the bank balance) is such that it presents a problem.
            // Here we have dealt with it outside of the injected class.

            // Note - That both this method in ProcessTransactionsAndReport and the methods on the ReportCreator are now unit-testable.

            double BankBalance = 0;
            // Create header for report
            string report = ReportCreator.CreateHeader();

            foreach (var transaction in BankTransactions)
            {
                // Create detail line for report
                report += ReportCreator.CreateDetailLine(transaction);
                // Update BankBalance
                BankBalance = +transaction.Amount;
            }

            // Create trailer for report
            report += ReportCreator.CreateTrailer();

            // Return report
            return new ReportAndBalance(report, BankBalance);
        }
    }
}
