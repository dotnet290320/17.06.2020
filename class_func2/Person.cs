using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170620a
{
    class Person
    {
        public string _name;
        public int _age;
        public Wallet _wallet;

        public override string ToString()
        {
            return $"Person [name]:{_name} [age]:{_age}";
        }
    }

}
