using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class LeapYr
    {
        public void Year()
        {
            int Checkyear;
            Console.WriteLine("Enter any Year");
            Checkyear = Convert.ToInt32(Console.ReadLine());
            if ((Checkyear % 400) == 0)
                Console.WriteLine("It is a leap year", Checkyear);
            else if ((Checkyear % 100) == 0)
                Console.WriteLine("It is not a leap year", Checkyear);
            else if ((Checkyear % 4) == 0)
                Console.WriteLine("It is a leap year", Checkyear);

            else
                Console.WriteLine("It is not a leap year", Checkyear);
        }
        }
}
