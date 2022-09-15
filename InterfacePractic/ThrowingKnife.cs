using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractic
{
    internal class ThrowingKnife : IWeapon, IRangeAttack
    {
        public int Damage => 20;
        public string Name => "Kunai";
        public int Durability => 100;

        public void ShowInfo()
        {
            Console.WriteLine($"RangeHit!");
        }

        public void Throw()
        {
            Console.WriteLine($"Player throw a {Name} damage done {Damage}");
        }
    }
}
