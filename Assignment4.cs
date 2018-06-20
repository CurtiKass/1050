using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months =
            {
                "January 1st",
                "February 2nd",
                "March 3rd",
                "April 4th",
                "May 5th",
                "June 6th",
                "July 7th",
                "August 8th",
                "September 9th",
                "October 10th",
                "November 11th",
                "December 12th",
            };
            for (int i = 0; i < 12; i++) 
            Console.WriteLine(months[i]);
            Console.WriteLine("\n");

            string[] seasons = {
                "Spring",
                "Summer",
                "Fall",
                "Winterrrrrrrr...",
            };
            int a = 1;
            while (a < 5) {
                Console.WriteLine(seasons[0]);
                a = 2;
                Console.WriteLine(seasons[1]);
                a = 3;
                Console.WriteLine(seasons[2]);
                a = 4;
                Console.WriteLine(seasons[3]+ "\n");
                a = 5;
            };
            string[] names = {
                "Al Dente",
                "Anna Graham",
                "Earle Bird",
                "Ginger Rayle",
                "Iona Ford"
            };

            for (int i = 0; i < 5; i++)
                
                Console.WriteLine(names[i]) ;
            Console.WriteLine("\n");
            foreach (string i in names)
            {
                
                Console.WriteLine(i);
            }
            Random newN = new Random();
           

            int[] random = 
            {
                newN.Next(0,100),
                newN.Next(0,100),
                newN.Next(0,100),
                newN.Next(0,100),
                newN.Next(0,100),
                newN.Next(0,100),
                newN.Next(0,100),
                newN.Next(0,100),
                newN.Next(0,100),
                newN.Next(0,100),
                newN.Next(0,100),
                newN.Next(0,100),
                newN.Next(0,100),
                newN.Next(0,100),
                newN.Next(0,100),
                newN.Next(0,100),
                newN.Next(0,100),
                newN.Next(0,100),
                newN.Next(0,100),
                newN.Next(0,100),
            };
           
            foreach (int rando in random)
            {
                Console.WriteLine(rando);
            }
       
        }

        
            
        }
        
    }

