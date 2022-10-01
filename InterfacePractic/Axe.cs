using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractic
{
    internal class Axe : IWeapon, CombinedAttack
    {
        public int Damage => 30;
        public string Name => "Axe";
        public int Durability => 100;

        public void ShowInfo()
        {
            Console.WriteLine($"Weapon {Name} damage {Damage}");
        }

        public void KnifeAttack()
        {
            Console.WriteLine($"MeleeHit!");
        }

        public void Throw()
        {
            Console.WriteLine($"Player throw a {Name} damage done {Damage}");
        }
    }
}
