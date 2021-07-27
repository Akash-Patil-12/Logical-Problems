using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class Temperature
    {
        //variables
        double fahrenheit, celsuis, resultCelsuis, resultFahrenheit;
        //constant
        const double VALUE5 = 5, VALUES9 = 9;
        /// <summary>
        /// convert fahrenheit to celsuis
        /// </summary>
        public void Celsuis()
        {
            Console.WriteLine("Enter a value of Fahrenheit");
            fahrenheit =Convert.ToDouble(Console.ReadLine());
            resultCelsuis = (fahrenheit - 32) * (VALUE5 / VALUES9);
            Console.WriteLine("Celsuis :" + resultCelsuis);
        }
        /// <summary>
        /// convert celsuis to fahrenheit
        /// </summary>
        public void Fahrenheit()
        {
            Console.WriteLine("Enter a value of celsuis");
            celsuis = Convert.ToInt32(Console.ReadLine());
            resultFahrenheit = (celsuis * (9 / 5)) + 32;
            Console.WriteLine("Fahrenheit :" + resultFahrenheit);
        }
    }
}
