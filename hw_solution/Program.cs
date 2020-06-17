using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170620
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer myMac = new Computer()
            {
                model = "IOS 10",
                numberOfProcessors = 8,
                price = 10000,
                isTurnOn = true
            };
            myMac.screenSize = 24;

            Console.WriteLine(myMac);

            Computer MyHP = new Computer()
            {
                model = "HP 8000",
                numberOfProcessors = 16,
                price = 7000,
                screenSize = 28
            };

            Console.WriteLine(MyHP);

            MyHP.TellMeThePrice(); // void

            MyHP.TellMeTheScreenSize(); // this is bad ... nothing will happen

            // 1. good - create variable to store the screen size , and print it
            float sizeOfMyHP = MyHP.TellMeTheScreenSize();
            Console.WriteLine(sizeOfMyHP);

            // 2. good - print the screen size return value
            Console.WriteLine(MyHP.TellMeTheScreenSize());

            // 3.
            Console.WriteLine(MyHP.screenSize);

            MyHP.AddProcessor(8);

            MyHP.TurnOn();
            MyHP.TurnOn();

            Console.WriteLine(MyHP);

        }
    }
}
