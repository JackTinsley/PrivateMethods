using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateMethods.AnImprovement
{
    public class Car
    {
        public string Make { get; }
        public string Model { get; }
        
        public List<string> ServiceHistory { get; }
        public Car(string Make, string Model)
        {
            this.Make = Make;
            this.Model = Model;
        }

        public bool CanHireCar(string NationalInsuranceNumber, DateTime startDate, DateTime endDate)
        {
            // Because this method was a little long and involved in the previous version a wise coder has made some improvement
            // The code has now been broken up a little more and 
            // Because each step has now been put in a method, the method can be given a name and the readability of the code improves.
            return IsCreditRatingSatisfactory(NationalInsuranceNumber) && IsCarAvailable(startDate, endDate);
        }

        private bool IsCreditRatingSatisfactory(string NationalInsuranceNumber)
        {
            // Use National Insurance number to look up Credit Rating of Customer
            // 10 lines + of code goes here
            return false;
        }

        private bool IsCarAvailable(DateTime startDate, DateTime endDate)
        {
            // Use startDate and endDate to see if the Car Is Available
            // 10 lines + of code goes here
            return false;
        }
    }
}
