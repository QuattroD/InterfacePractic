using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractic
{
    internal class ThrowingKnife : Weapon, IWeapon, IRangeAttack, IRepairWeapon
    {
        public ThrowingKnife() : base(20, "Kunai", 10, 1)
        {
        }

        public void Throw()
        {
            if (this.durability > 0)
            {
                this.durability--; 
                if (this.durability < 0)
                {
                    this.durability = 0;
                }
                Console.WriteLine($"Player throw a {this.Name} damage done {this.Damage}, current durability - {this.durability}");
            }
            else
            {
                Console.WriteLine($"weapon destroyed");
            }
        }
    }
}
