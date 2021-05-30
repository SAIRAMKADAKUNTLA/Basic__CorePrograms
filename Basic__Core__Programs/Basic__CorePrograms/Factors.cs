using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Factors
    {
        public void Factor()
        {

            Console.WriteLine("Enter any Number");
            int Number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Number; i++)
            {
                if (Number % i == 0)
                {
                    Console.WriteLine("Factors are" + i);

                }
            }
        }
    }
}
