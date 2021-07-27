using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class DecimalToBinary
    {
        //variables
        int no = 106;
        String number;
        /// <summary>
        /// Display the binary representation of entered number
        /// </summary>
        public void Conversion()
        {
            while (no > 0)
            {
                int remainder = no % 2;
                number = number + remainder;
                no = no / 2;
            }
            Console.WriteLine("Binary representation is :");
            for (int count = number.Length - 1; count >= 0; count--)
            {
                Console.Write(number[count]);
            }
            Console.WriteLine();
        }
    }
}
