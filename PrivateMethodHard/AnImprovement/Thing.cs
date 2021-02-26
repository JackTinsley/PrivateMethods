using System;

namespace PrivateMethodHard.AnImprovement
{
    // Note - The class here is called Thing because i wish to demonstrate an extreme set up, and I couldn't think of a real-life example.
    // So  this exercise does not have a real world parallel.  We are simply looking at the mechanics of refactoring.
    public class Thing
    {
        private int field1;
        private int field2;
        private int field3;
        private int field4;

        public Thing()
        {

        }

        public int PerformSomeCalculation(int input_Int)
        {
            // A wise coder comes along and refactors this to use some private methods to tidy up
            if (input_Int == 1)
            {
                return PerformCalculation1();
            }

            if (input_Int == 2)
            {
                return PerformCalculation2();
            }

            if (input_Int == 3)
            {
                return PerformCalculation3();
            }

            return 0;
            // and this could go on indefintely but we will leave it here.
        }

        private int PerformCalculation1()
        {
            field1++;
            field2--;
            // Perform some complex calculation using the four fields and return - assume that this takes 20+ lines
            return 0;
        }

        private int PerformCalculation2()
        {
            field2++;
            field3--;
            field4 = field1 + field2;
            // Perform some complex calculation using the four fields and return - assume that this takes 20+ lines
            return 0;
        }

        private int PerformCalculation3()
        {
            field1 = 4;
            field3 = (int)Math.Pow(field2, field4);
            field4 = field1 + field2;
            // Perform some complex calculation using the four fields and return - assume that this takes 20+ lines
            return 0;
        }
    }
}
