using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateMethods.Original
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
            // Use National Insurance number to look up Credit Rating of Customer
            // 10 lines + of code goes here

            // Use startDate and endDate to see if the Car Is Available
            // 10 lines + of code goes here

            return false;
        }
    }
}
