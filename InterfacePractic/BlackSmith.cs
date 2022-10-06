using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractic
{
    internal class BlackSmith : human
    {
        public BlackSmith() : base("Кузнец", 90)
        {
        }

        public void Fix(Weapon weapon)
        {
            weapon.durability = weapon.MaxDurability;
            Console.WriteLine($"{weapon.Name} repaired!");
        }

        public void Upgrade(Weapon weapon)
        {
            weapon.lvl += 1;
            weapon.damage += 5;
            Console.WriteLine($"lvl up {weapon.Name}! current {weapon.lvl} lvl and {weapon.damage} damage!");
        }
    }
}
