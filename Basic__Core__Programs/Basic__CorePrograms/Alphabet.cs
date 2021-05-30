using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Alphabet
    {
        public void Check()
        {

            Console.WriteLine("Enter any Alphabet");
            int ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'A':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'E':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'I':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'O':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'U':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                default:
                    Console.WriteLine("The Alphabet is Consonent");
                    break;
            }
        }
            }
}
