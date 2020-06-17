using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170620a
{
    class Program
    {

        static void PrintCircleArea(Circle c)
        {
            //Circle c = new Circle() { _radius = 4.5f };

            double area = c._radius * c._radius * Math.PI;

            Console.WriteLine($"{Math.PI} * {c._radius}^2 = {area}");
        }

        static void Add(int x, int y) // Add_x
        {
            //int x;
            //int y;
            Console.WriteLine(x+y); 
        }

        static int AddTwoNumbers(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        static Circle CreateCircle(double radius)
        {
            Circle myNewCircle = new Circle()
            {
                _radius = radius
            };

            return myNewCircle;
        }

        static void Main(string[] args)
        {
            
            Add(4, 5);

            int x = 3;
            Add(x, x); // Main_x

            Circle myCircle = new Circle() { _radius = 5.77 };

            PrintCircleArea(myCircle);

            Circle mySecondsCircle = new Circle()
            {
                _radius = 9.887
            };

            PrintCircleArea(mySecondsCircle);

            int sum = AddTwoNumbers(8, 7);
            Console.WriteLine(sum);

            Circle mythirdCircle = CreateCircle(9.887);
        }
    }
}
