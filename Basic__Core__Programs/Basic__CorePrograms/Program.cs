using System;

namespace Basic__CorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs");
            Console.WriteLine("1.Flipcoin,2.LeapYr,3.PowerOf2,4.Factors,5.Swap,6.Division,7.EvenOdd,8.Alphabet,9.Largest,10.Harmonic");
            Console.WriteLine("Enter your choice");
            int Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.Percentage();
                    break;
                case 2:
                    LeapYr leapYr1 = new LeapYr();
                    leapYr1.Year();
                    break;
                case 3:
                    PowerOfTwo powerOfTwo = new PowerOfTwo();
                    powerOfTwo.Power();
                    break;
                case 4:
                    Factors factors = new Factors();
                    factors.Factor();
                    break;
                case 5:
                    Swap swap = new Swap();
                    swap.SwapCheck(2, 3);
                    break;
                case 6:
                    Division division = new Division();
                    division.Check(2, 4);
                    break;
                case 7:
                    EvenOrOdd evenOdd = new EvenOrOdd();
                    evenOdd.Check();
                    break;
                case 8:
                    Alphabet alphabet = new Alphabet();
                    alphabet.Check();
                    break;
                case 9:
                    Largest largest = new Largest();
                    largest.Check(3, 5, 6);
                    break;
                case 10:
                    Harmonic harmonic = new Harmonic();
                    harmonic.Check();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");


            }
    }
}
