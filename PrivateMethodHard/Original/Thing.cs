using System;

namespace PrivateMethodHard
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
            if (input_Int == 1)
            {
                field1++;
                field2--;
                // Perform some complex calculation using the four fields and return - assume that this takes 20+ lines
                return 0; 
            }

            if (input_Int == 2)
            {
                field2++;
                field3--;
                field4 = field1 + field2;
                // Perform some complex calculation using the four fields and return - assume that this takes 20+ lines
                return 0;
            }

            if (input_Int == 3)
            {
                field1 = 4;
                field3 = (int) Math.Pow(field2, field4);
                field4 = field1 + field2;
                // Perform some complex calculation using the four fields and return - assume that this takes 20+ lines
                return 0;
            }

            return 0;
            // and this could go on indefintely but we will leave it here.
        }
    }
}
