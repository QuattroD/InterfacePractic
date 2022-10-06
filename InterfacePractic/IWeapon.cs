using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractic
{
    internal interface IWeapon
    {
        public int Damage { get; }
        public string Name { get; }
        public int Durability { get; }
        public void GetInfo();
    }
}
