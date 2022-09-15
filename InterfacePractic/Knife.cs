using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractic
{
    internal class Knife : IWeapon, IMeleeAtack
    {
        public int Damage => 30;
        public string Name => "M9 BAYONET";
        public int Durability => 100;

        public void ShowInfo()
        {
            Console.WriteLine($"Weapon {Name} damage {Damage}");
        }

        public void KnifeAttack()
        {
            Console.WriteLine($"MeleeHit!");
        }
    }
}
