using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateMethods.AMoreMeaningfulImprovement
{
    class CreditRatingChecker : ICreditRatingChecker
    {
        // The Car.CanHireCar method of the original example took the NationalInsuranceNumber.
        // This data still exist - it is now here, with the code that uses it.
        public string NationalInsuranceNumber { get; }

        public CreditRatingChecker(string NationalInsuranceNumber)
        {
            this.NationalInsuranceNumber = NationalInsuranceNumber;
        }
        public bool IsCreditRatingOk()
        {
            // The code that originated Car.CanHireCar and that was refactored into Car.IsCreditRatingSatisfactory
            // has now been further refactored into this class.

            // Note - The content is now in a method that is public, which means it can be unit-tested directly.
        }
    }
}
