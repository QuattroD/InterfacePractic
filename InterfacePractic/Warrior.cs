using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractic
{
    internal class Warrior : human
    {
        public Warrior() : base("Danil", 100)
        {
        }

        public void KnifeAttack(IMeleeAtack weapon, human human)
        {
            if (human.HP > 0)
            {
                weapon.KnifeAttack();
                human.HP -= weapon.Damage;
                if (human.HP < 0)
                {
                    human.HP = 0;
                }
                Console.WriteLine($"У {human.Name} осталось {human.HP} hp!");
            }

            else
            {
                Console.WriteLine("Невозможно атаковать!");
            }
        }

        public void Throw(IRangeAttack weapon, human human)
        {

            if (human.HP > 0)
            {
                weapon.Throw();
                human.HP -= weapon.Damage;
                if (human.HP < 0)
                {
                    human.HP = 0;
                }
                Console.WriteLine($"У {human.Name} осталось {human.HP} hp!");
            }

            else
            {
                Console.WriteLine($"Невозможно атаковать! {human.Name} мёртв");
            }
        }
    }
}
