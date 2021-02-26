using System;
using System.Collections.Generic;

namespace PrivateMethodsEasy
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

        public IEnumerable<LocationAndDistance> GetNearest10Locations(IEnumerable<ILocation> locations)
        {
            foreach (var location in locations)
            {
                // Take my Postcode and the Post of the location and calculate a distance
                // Format an object with the details of the location.
                // Add this to a new collection with the location and the distance from me.
            }

            // Order the new collection by distance from me.

            // Return the top 10.
            return null;
        }
    }
}
