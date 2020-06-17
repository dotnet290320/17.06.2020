using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170620a
{
    abstract class Shape
    {
        public double _area;
        public void TellMeTheArea()
        {
            Console.WriteLine($"{_area}");
        }
    }
    class Triangle : Shape
    {
        //public double _area;
        //public void TellMeTheArea()
        //{
        //    Console.WriteLine($"{_area}");
        //}
    }
    class Circle : Shape
    {
        //public double _area;
        //public void TellMeTheArea()
        //{
        //    Console.WriteLine($"{_area}");
        //}
    }
    abstract class Rectangle : Shape
    {
        double _a, _b;
        //public double _area;
        //public void TellMeTheArea()
        //{
        //    Console.WriteLine($"{_area}");
        //}
    }

    class StandardRectangle : Rectangle
    {
        //double _a, _b;
        //public double _area;
        //public void TellMeTheArea()
        //{
        //    Console.WriteLine($"{_area}");
        //}
    }

    class NonStandardRectangle : Rectangle
    {
        //double _a, _b;
        //public double _area;
        //public void TellMeTheArea()
        //{
        //    Console.WriteLine($"{_area}");
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new StandardRectangle() { _area = 77.5 };
            r.TellMeTheArea();
            Circle c = new Circle() { _area = 99 };
            c.TellMeTheArea();
            Triangle t = new Triangle() { _area = 45 };
            t.TellMeTheArea();

            //Shape s = new Shape() { _area = 0 };
        }
        
       

    }
}
