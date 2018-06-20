using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
             int a = 0;
            {
                while (a < 11)
                {

                    Console.WriteLine(3 * a);
                    a++;
                }
            };
            for (int i = 1; i < 11; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine(i + "is even");
                }
                else
                {
                    Console.WriteLine(i + "is odd");
                }
            }
                Console.WriteLine("What is the temperature today?");
                
                int temp = 0 + Convert.ToInt32(Console.ReadLine());
                if (temp < 32)
                {
                    Console.WriteLine(temp + " is freezing!");
                }
                else if (temp < 50)
                {
                    Console.WriteLine(temp + "is cold");
                }
                else if (temp < 70)
                {
                    Console.WriteLine(temp + "is mild");
                }
                else if (temp < 90)
                {
                    Console.WriteLine(temp + "is warm!");
                }
                else
                {
                    Console.WriteLine("IT'S HOT!");
                    }
                    
            
        }
    }
}
