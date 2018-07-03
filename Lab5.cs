using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Vehicle
    {
        
            public string color, make, model;
            public int speed;
        
    }
    class Car : Vehicle { }
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car();
            myCar1.make = “Ford”;
            myCar1.model = “Focus”;
            myCar1.color = “blue”;

            Car myCar 2 = new Car();
            myCar1.make = “Chevy”;
            myCar1.model = “Cruze”;
            myCar1.color = “red”;

            for (int i = 0; i < 35; i++)
            {
                myCar2.speedUp();
                myCar1.speedUp();
                myCar 2.speedUp();
            }
            for (int i = 0; i < 10; i++)
            {
                myCar2.slowDown();
            }
            myCar1.Describe();
            myCar2.Describe();


        }
        public string Describe()
        {
            return "this car is a(n)" + color + make + model + "and is going" + speed;
        }
    }
}
