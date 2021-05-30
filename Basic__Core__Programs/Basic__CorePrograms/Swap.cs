using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Swap
    {
        public void SwapCheck(int FirstNumber, int SecondNumber)
        {

            Console.WriteLine("Before Swap FirstNumber=" + FirstNumber + "SecondNumber=" + SecondNumber);
            FirstNumber = FirstNumber + SecondNumber;
            SecondNumber = FirstNumber - SecondNumber;
            FirstNumber = FirstNumber - SecondNumber;
            Console.WriteLine("After Swap FirstNumber=" + FirstNumber + "SecondNumber=" + SecondNumber);
        }
        }
}
