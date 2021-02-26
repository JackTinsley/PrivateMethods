using PrivateMethodHard.AnImprovement;
using System;

namespace PrivateMethodHard.AMoreMeaningfulImprovement
{
    // Note - The class here is called Thing because i wish to demonstrate an extreme set up, and I couldn't think of a real-life example.
    // So  this exercise does not have a real world parallel.  We are simply looking at the mechanics of refactoring.
    public class Thing
    {
        private int field1;
        private int field2;
        private int field3;
        private int field4;

        public int PerformSomeCalculation(IPerformCalculator calculator)
        {
            // A more Object-Oriented minded coder now endevours to use objects (the problem is the side-effects).
            // The updates to Field1 - Field4 are a pain here. Sure you could pass all the fields to the ICalculator
            // and take back a DTO with the updated Field1 - Field4 and the actual answer and so on.
            // But the point is that this is messy and your calculators are now sharing information and knowledge
            // with this original class, and really get us nowhere fast.
            return calculator.PerformCalculate();

            // The point is that side-effects make extracting classes either difficult or yield dissapointing results.
            // This is a nod towards pure methods (where possible).

            // Note - I have not included any implementations of IPerformCalculator as I don't see the point.
            // Feel free to do so, if you think I have missed something and that it is possible to do something that could be considered interesting or satisfactory.
        }
    }
}
