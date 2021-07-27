using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class VendingMachine
    {
        //variable
        int count=0;
        /// <summary>
        /// Return minimum notes of amount and also show count of notes
        /// </summary>
        /// <param name="amount"></param>
        public void Change(int amount)
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            for(int index = 0; index < notes.Length; index++)
            {
                if (amount / notes[index] >= 1)
                {
                    count++;
                    Console.WriteLine("Count of notes is :" + count);
                    Console.WriteLine("Notes are :" + notes[index]);
                    amount = amount - notes[index];
                    if (amount != 0)
                        this.Change(amount);
                    break;
                }                    
            }
        }
    }
}
