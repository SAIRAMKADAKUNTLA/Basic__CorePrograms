using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Harmonic
    {
        public void Check()
        {
            Console.WriteLine("Enter the Value");
            int Value = Convert.ToInt32(Console.ReadLine());
            int Temp = 1;
            for (int i = 1; i <= Value; i++)
            {
                Temp = Temp + 1 / i;
                Console.WriteLine("Result is:" + Temp);
            }
        }
            }
}
