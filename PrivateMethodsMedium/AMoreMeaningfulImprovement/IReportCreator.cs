using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateMethodsMedium.AMoreMeaningfulImprovement
{
    public interface IReportCreator
    {
        string CreateHeader();
        string CreateDetailLine(BankTransaction bankTransaction);
        string CreateTrailer();
    }
}
