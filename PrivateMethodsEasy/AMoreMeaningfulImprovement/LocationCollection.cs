using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateMethodsEasy.AMoreMeaningfulImprovement
{
    public class LocationCollection
    {
        public IEnumerable<ILocation> Locations { get; }
        public LocationCollection(IEnumerable<ILocation> locations)
        {
            this.Locations = locations;
        }

        public IEnumerable<LocationAndDistance> GetNearest10ToMe(string postcode)
        {
            List<LocationAndDistance> locationAndDistanceList = new List<LocationAndDistance>();
            foreach (var location in Locations)
            {
                // Take my Postcode and the Post of the location and calculate a distance
                // Format an object with the details of the location.
                // Add this to a new collection with the location and the distance from me.

                locationAndDistanceList.Add(new LocationAndDistance(location, location.GetDistanceFromMe(postcode)));
            }

            // Order the new collection by distance from me.

            // Return the top 10.
            return null;
        }
    }
}
