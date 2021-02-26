using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateMethodsEasy.AnImprovement
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

        public IEnumerable<LocationAndDistance> GetNearest10Locations(IEnumerable<string> Postcodes)
        {
            foreach (var postcode in Postcodes)
            {
                // The wise coder has seen that there is a lot of mess in here and has decided to move it into a method
                var distanceFromMe = GetDistanceFromMe(postcode);
            }

            // Order the new collection by distance from me.

            // Return the top 10.
            return null;
        }

        private LocationAndDistance GetDistanceFromMe(string postcode)
        {
            // Take my Postcode and the Post of the location and calculate a distance
            // Format an object with the details of the location.
            // Add this to a new collection with the location and the distance from me.
            return null;
        }
    }
}
