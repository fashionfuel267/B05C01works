using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B05C01w04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commision(4500);
            Console.ReadKey();
        }
        static void Commision(int salesamount)
        {
            float c = 0;
            if(salesamount >4000)
            {
                c= salesamount*(5/(float)100);
            }
           else if (salesamount > 3000)
            {
                c = salesamount * (4 / (float)100);
            }
            else if (salesamount > 2000)
            {
                c = salesamount * (3 / (float)100);
            }
            else if (salesamount > 1000)
            {
                c = salesamount * (2 / (float)100);
            }
            else  
            {
                c = salesamount * (1 / (float)100);
            }
            Console.Write($"For {salesamount} you will get commision {c}tk.");
        }
    }
}
