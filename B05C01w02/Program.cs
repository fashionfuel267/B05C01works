using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B05C01w02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age ;
            Console.WriteLine("Plese enter your age");
            age =int.Parse( Console.ReadLine());
            if ((age>50)){
                Console.WriteLine("old");
            }
            else
            {
                Console.WriteLine("Young");
            }
            CheckAge(age);
            Console.ReadKey();
        }
        static void CheckAge(int age)
        {
            if (age >= 50)
            {
                Console.WriteLine($"You are {age} years Old");
            }
            else if (age>=30)
            {
                Console.WriteLine($"You are {age} years young");
            }
            else if (age >= 18)
            {
                Console.WriteLine($"You are {age} years tinager");
            }
            else
            {
                Console.WriteLine($"You are {age} years baby");
            }
        }
    }
}
