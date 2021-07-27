using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class PrimeNumber
    {
        //variable
        int number;
        bool checkPrime=true;
        
        public void CheckPrimeNumber()
        {
            Console.WriteLine("Enter a positive integer number");
            number = Convert.ToInt32(Console.ReadLine());
            if (number >= 2)
            {
                for (int count = 2; count < number; count++)
                {
                    if (number % count == 0)
                    {
                        checkPrime = false;
                        break;
                    }
                }
                if (checkPrime)
                    Console.WriteLine(number + " : is a prime number");
                else
                    Console.WriteLine(number + " : is not a prime number");
            }
            else
                Console.WriteLine(number + " : is not a prime number");
        }
    }
}
