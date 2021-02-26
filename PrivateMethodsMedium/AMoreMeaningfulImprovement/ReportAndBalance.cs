using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateMethodsMedium.AMoreMeaningfulImprovement
{
    public class ReportAndBalance
    {
        public string Report { get; }
        public double Balance { get; }
        public ReportAndBalance(string report, double balance)
        {
            this.Report = report;
            this.Balance = balance;
        }
    }
}
