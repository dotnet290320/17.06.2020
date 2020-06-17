using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170620
{
    [DebuggerDisplay("{model}")]
    class Computer
    {
        public string model;
        public int price;
        public int numberOfProcessors;
        public float screenSize;
        public bool isTurnOn = false;

        public void TellMeThePrice()
        {
            Console.WriteLine($"{model} price is {price}");
        }
        public float TellMeTheScreenSize()
        {
            return screenSize;
        }
        public void TurnOn()
        {
            if (isTurnOn) // same as if (isTurnOn == true)
            {
                Console.WriteLine($"{model} is already on!");
            }
            else
            {
                isTurnOn = true;
                Console.WriteLine($"turning on {model}...");
            }
        }

        public void TurnOff()
        {
            if (!isTurnOn) // same as if (isTurnOn == false)
            {
                Console.WriteLine($"{model} is already off!");
            }
            else
            {
                isTurnOn = false;
                Console.WriteLine($"turning off {model}...");
            }
        }

        public void AddProcessor(int processors)
        {
            numberOfProcessors = numberOfProcessors + processors;
            Console.WriteLine($"{model} has got {processors} new processors. and now have {numberOfProcessors} processors");
        }

        public override string ToString()
        {
            return $"Computer [model]:{model} [price]:{price} [numberOfProcessors]:{numberOfProcessors} [screenSize]:{screenSize} [isTurnOn]:{isTurnOn}";
        }


    }
}
