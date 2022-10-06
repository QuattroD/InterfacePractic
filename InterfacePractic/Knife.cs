using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractic
{
    internal class Knife : Weapon, IWeapon, IMeleeAtack
    {
        public Knife() : base(45, "M9 BAYONET", 10, 1)
        {
        }


        public void KnifeAttack()
        {
            if (this.durability > 0)
            {
                this.durability--;
                if (this.durability < 0)
                {
                    this.durability = 0;
                }
                Console.WriteLine($"Player attack a {this.Name} damage done {this.Damage}, current durability - {this.durability}");
            }
            else
            {
                Console.WriteLine($"weapon destroyed");
            }
        }
    }
}
