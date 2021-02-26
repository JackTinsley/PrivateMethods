using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateMethodsEasy.AMoreMeaningfulImprovement
{
    public class LocationAndDistance
    {
        public ILocation Location { get; }
        public double DistanceFromMe { get; }
        public LocationAndDistance(ILocation location, double distanceFromMe)
        {
            this.Location = location;
            this.DistanceFromMe = distanceFromMe;
        }
    }
}
