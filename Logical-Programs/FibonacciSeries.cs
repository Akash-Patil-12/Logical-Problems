using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class FibonacciSeries
    {
        //varibles
        int number,a = 0, b = 0, c = 1;
        /// <summary>
        /// Display fibonacci series
        /// </summary>
        public void Series()
        {
            Console.WriteLine("Enter a number");
            number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci series : ");
            for(int count = 1; count <= number; count++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.WriteLine(a);
            }
        }
    }
}
