using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class Payment
    {
        //variable
        public double principal_P, year_Y, percent_R, payment;
        /// <summary>
        /// Takes input from user and call MonthlyPayment method
        /// </summary>
        public void InputData()
        {
            Console.WriteLine("Enter value of P");
            principal_P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of Y");
            year_Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of R");
            percent_R = Convert.ToInt32(Console.ReadLine());
            MonthlyPyment();
        }
        /// <summary>
        /// calculate payment and display it
        /// </summary>
        public  void MonthlyPyment()
        {
            double valueN = 12 * year_Y;
            double valueR = percent_R / (12 * 100);
            payment = ((principal_P * valueR) / (1 - Math.Pow(1+valueR,-valueN )));
            Console.WriteLine("Payment :" + payment);
        }
    }
}
