using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class PerfectNumber
    {    
        //variable
        int number,totalSum;
        /// <summary>
        /// Check perfect number or not
        /// </summary>
        public void CheckPerfectNumber()
        {
            Console.WriteLine("Enter a positive integer number");
            number = Convert.ToInt32(Console.ReadLine());
            for (int count = 1; count <= (number / 2); count++)
            {
                if (number % count == 0)
                {
                    totalSum += count;
                }
            }
            if (number == totalSum)
                Console.WriteLine(number + " is a perfect number");
            else
                Console.WriteLine(number + " is not a perfect number");
        }

    }
}
