using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateMethodsEasy.AMoreMeaningfulImprovement
{
    public class Person
    {
        public string FirstName { get; }

        public string LastName { get; }

        public string PostCode { get; }
        public Person(string FirstName, string LastName, string PostCode)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PostCode = PostCode;
        }

        public IEnumerable<LocationAndDistance> GetNearest10Locations(LocationCollection locations)
        {
            // This is the expert version of this example.
            // The functionality needs to move onto the location object; avoiding primitive obsession etc.
            return locations.GetNearest10ToMe(PostCode);
        }
    }
}
