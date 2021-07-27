using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class SquareRoot
    {
        int no = 16;
        double valueT,root;
       
        public void FindSquareRoot()
        {
            valueT = no;
            valueT = ((no / valueT) + valueT) / 2;
            double check = valueT - (no / valueT);
            while (Math.Abs(check)>=1e-15*valueT){
                root = Math.Abs(check);
            }
            Console.WriteLine("Root :" + root);
        }
    }
}
