using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class ReverseNumber
    {
        //variable
        int number,remainder,reverseNumber=0;
        /// <summary>
        /// Display the reverse number
        /// </summary>
        public void Reverse()
        {
            Console.WriteLine("Enter a positive integer number");
            number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                remainder = number % 10;
                reverseNumber = (reverseNumber * 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine("Reverse number is : " + reverseNumber);
        }
    }
}
