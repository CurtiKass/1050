using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Console.WriteLine("input a number and press the return key please...");
            int x = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("please input one more number followed by the return key...");
            int y = (Convert.ToInt32(Console.ReadLine()));
            int z = x + y;
            int product = (x + y) * (z + 10);

            Console.WriteLine("the sum of these two numbers is {0}", z);
            Console.WriteLine("thank you! that data was tasty. I'm gonna tell you a secret now... \nif the numbers you fed me were considered to be x and y, and their sum z\ngiven the equation (x+y)*(z+10) the outcome is {0}", product);
            Console.WriteLine("may I ask, what is your name?");
            string name = (Console.ReadLine());
            string greeting = ("my name is Paul :)");
            Console.WriteLine("Hello {0}! {1}", name, greeting);
            Console.WriteLine("I've something on my mind, may i say it?\nGood I was gonna say it any way\nfirst I would like to say..\nHello\tWorld!\nnext..\nHello\nWorld\nand of course i would have to say\n\"Hello World!\"\nbut if i could say one thing to the youth of America,\nit would probably be something like\nHello\\World!");
            Console.WriteLine("Thanks for listening to me {0}, you are a wonderful listener, I would love to see you again sometime. Good day!", name);
        }
    }
}
