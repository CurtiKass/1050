using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath math = new MyMath();
            Console.WriteLine(math.add(9, 19));
            Console.WriteLine(math.factorial(9));
            Console.WriteLine(math.Min(20, 21));
            Console.WriteLine(math.multiply(19, 2));
        }




           public class MyMath
            {

                public int add(int a, int b)
                {
                return a + b;
                }
            public  int factorial(int n)
            {
                int answer = 1;
                for (int i = 2; i <= n; i++)
                    answer *= i;
                return answer;

            }
                public int multiply (int a, int b)
                {
                        int ans = a * b;
                        return ans;
                }
                    public  int  Min ( int y, int z)
            {
                if (y > z) { return z; }
                else { return y; }
            }

                } 

                }
                }
        
        
    

