using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B05C01w03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WhileEx();
            ForEx();
            Console.ReadKey();
        }
        static void WhileEx()
        {
            int i = 0;
            while (i <= 10)
            {
                Console.Write (i+"\t");
                i++;
            }
            Console.WriteLine();
        }
        static void ForEx()
        {
            for(int i =10; i >= 0; i--)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }

    }
}
