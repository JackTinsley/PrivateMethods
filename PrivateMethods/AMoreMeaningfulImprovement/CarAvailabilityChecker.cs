using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateMethods.AMoreMeaningfulImprovement
{
    public class CarAvailabilityChecker : ICarAvailabilityChecker
    {
        // The Car.CanHireCar method of the original example took the StartDate and EndDate.
        // This data still exist - it is now here, with the code that uses it.
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public CarAvailabilityChecker(DateTime startDate, DateTime endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public bool IsCarAvailable()
        {
            // The code that originated Car.CanHireCar and that was refactored into Car.IsCreditRatingSatisfactory
            // has now been further refactored into this class.

            // Note - The content is now in a method that is public, which means it can be unit-tested directly.
        }
    }
}
