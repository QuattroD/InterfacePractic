using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractic
{
    abstract internal class human
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public human(string name, int hP)
        {
            Name = name;
            HP = hP;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Human - {Name} hp - {HP}");
        }
    }
}
