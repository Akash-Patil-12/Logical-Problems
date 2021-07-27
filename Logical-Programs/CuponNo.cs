using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class CuponNo
    {
        //variable
        int no,countUniqueNumber=0;
        bool firstItration = true;
        public void CheckNumber()
        {
            Console.WriteLine("Enter a number");
            no = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            List<int> randomNumbers = new List<int>();
            for(int count = 1; count <= no; count++)
            {
                int tempRandomNo = random.Next(1, no);
                Console.WriteLine("Random number :" + tempRandomNo);

                if (firstItration == true)
                {
                    randomNumbers.Add(tempRandomNo);
                    countUniqueNumber++;
                    firstItration = false;
                    Console.WriteLine("Random if :" + tempRandomNo+"count "+countUniqueNumber);
                }
                else
                {
                    if (randomNumbers.Contains(tempRandomNo))
                    {
                        countUniqueNumber--;
                        Console.WriteLine("Random if :" + tempRandomNo + "count " + countUniqueNumber);

                    }

                    else
                    {
                        randomNumbers.Add(tempRandomNo);
                        countUniqueNumber++;
                        Console.WriteLine("Random if :" + tempRandomNo + "count " + countUniqueNumber);

                    }

                }
             
            }
            Console.WriteLine(countUniqueNumber);
        }
    }
}
