using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateMethods.AMoreMeaningfulImprovement
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

        public bool CanHireCar(ICreditRatingChecker creditRatingChecker, ICarAvailabilityChecker carAvailabilityChecker)
        {
            // An even wiser coder has now realised that the private methods indicate dependancies on other elements.
            // and that these dependancies should be passed in as Interface references and not primitive date
            return creditRatingChecker.IsCreditRatingOk() && carAvailabilityChecker.IsCarAvailable();
        }
    }
}
