using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractic
{
    abstract internal class Weapon : IWeapon, IRepairWeapon
    {
        public int damage { get; set; }
        public string name { get; set; }
        public int durability { get; set; }
        public int lvl { get; set; }
        public int MaxDurability;

        public Weapon(int damage, string name, int durabiity, int lvl)
        {
            this.damage = damage;
            this.name = name;
            this.durability = durabiity;
            this.lvl = lvl;
            MaxDurability = durability;
        }

        public int Damage => damage;
        public string Name => name;
        public int Lvl => lvl;
        public int Durability => durability;

        public void GetInfo()
        {
            Console.WriteLine($"Weapon - {Name} Damage - {Damage} Lvl - {lvl}");
        }
    }
}
