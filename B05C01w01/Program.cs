using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B05C01w01
{
    internal class Program
    {
       static int x;
        static void Main(string[] args)
        {
          //declaration
            x = 80;//assignment
            Console.WriteLine(x);
            float rate;
            rate = 0.0F;
            decimal m;
            m = 5.2m;
            //BADMAS
            Console.WriteLine(x++);
            Console.WriteLine(++x);
           Console.WriteLine( ADD());
            Console.WriteLine(ADD(x: 5));//call,named argument
            Console.ReadKey();

        }
      static  int ADD()
        {
            return 8+9;
        }
        static void Add()//overloading
        {
            Console.WriteLine(8+9);
        }
        static int ADD(int x,int y)//parameter signature
        {
            return x + y;
        }
        static int ADD(int x, string y="")//parameter signature
        {
            return x + y.Length;
        }

    }
}
