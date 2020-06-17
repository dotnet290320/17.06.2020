using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170620a
{
    class Program
    {

        // class as a function argumner
        // class as a function return type
        // class inside a class

        static void GoIntoClub(Person person)
        {
            if (person._age >= 18)
            {
                Console.WriteLine($"{person._name} can go into the club ...");
            }
            else
            {
                Console.WriteLine($"{person._name} can NOT go into the club. must be over 18");
            }
        }

        static Person WhoIsBigger(Person person1, Person person2)
        {
            if (person1._age > person2._age)
                return person1;
            else
                return person2;
        }

        static void Main(string[] args)
        {
            Airplane boieng = new Airplane()
            {
                _model = "Boieng 707",
                _passengers = 707,
                _weight = 10,
                _engine = new Engine()
                {
                    _cylinders = 4000,
                    _heat = 200,
                    _modelName = "T900"
                }
            };
            Console.WriteLine(boieng);

            boieng._engine.TurnOn();
            boieng.Land();

            Person jerry = new Person()
            {
                _age = 17,
                _name = "Jerry",
                _wallet = new Wallet()
                {
                    _color = "black",
                    _money = 1000
                }
            };

            GoIntoClub(jerry);

            Person suzi = new Person()
            {
                _age = 30,
                _name = "Suzi",
                _wallet = new Wallet()
                {
                    _color = "red",
                    _money = 3000
                }
            };

            GoIntoClub(suzi);

            Person bigger = WhoIsBigger(jerry, suzi);

            Console.WriteLine($"jerry has {jerry._wallet._money} dollars in his wallet");

            Console.WriteLine(bigger);
        }

    }
}
