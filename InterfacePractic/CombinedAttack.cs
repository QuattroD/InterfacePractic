using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractic
{
    internal interface CombinedAttack : IWeapon, IRangeAttack, IMeleeAtack
    {
        public int Damage => 25;
        public string Name => "Axe";
        public int Durability => 100;

        public void ShowInfo()
        {
            Console.WriteLine($"Hit!");
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
