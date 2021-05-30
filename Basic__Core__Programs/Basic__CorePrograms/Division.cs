using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Division
    {
        public void Check(int FirstNumber, int SecondNumber)
        {
            int Quotient = FirstNumber / SecondNumber;
            int Remainder = FirstNumber % SecondNumber;
            Console.WriteLine("the Quotient is" + Quotient + "the Remainder is" + Remainder);
        }
        }
}
