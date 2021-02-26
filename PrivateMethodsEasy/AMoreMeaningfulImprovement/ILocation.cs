namespace PrivateMethodsEasy.AMoreMeaningfulImprovement
{
    public interface ILocation
    {
        public string Postcode { get; set; }

        // This functionality that was on the Person class has been moved
        // to the location class in such a way that it can now be unit-tested.
        public double GetDistanceFromMe(string Postcode);
    }
}