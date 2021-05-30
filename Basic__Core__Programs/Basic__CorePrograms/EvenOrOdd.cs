using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class EvenOrOdd
    {
        public void Check()
        {
            Console.WriteLine("Enter any Number");
            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number % 2 == 0)
                Console.WriteLine("it is a even Number");
            else
                Console.WriteLine("it is a odd Number");
        }
        }
}
