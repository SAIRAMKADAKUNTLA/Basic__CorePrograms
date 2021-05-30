using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Largest
    {
        public void Check(int FirstNumber, int SecondNumber, int ThirdNumber)
        {
            if (FirstNumber > SecondNumber && FirstNumber > ThirdNumber)
                Console.WriteLine("FirstNumber is Largest Number");
            else if (SecondNumber > ThirdNumber)
                Console.WriteLine("SecondNumber is Largest");
            else
                Console.WriteLine("ThirdNumber is Largest");
        }
        }
}
