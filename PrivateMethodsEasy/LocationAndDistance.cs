using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateMethodsEasy
{
    public class LocationAndDistance
    {
        public IEnumerable<ILocation> Location { get; }
        public double DistanceFromMe { get; }
        public LocationAndDistance(IEnumerable<ILocation> location, double distanceFromMe)
        {
            this.Location = location;
            this.DistanceFromMe = distanceFromMe;
        }
    }
}
