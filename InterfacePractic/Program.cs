using System;

namespace InterfacePractic
{
    class Programm
    {
        static void Main(string[] Args)
        {
            IRangeAttack weapon = new ThrowingKnife();
            weapon.ShowInfo();
            weapon.Throw();
            IMeleeAtack weapon2 = new Knife();
            weapon2.ShowInfo();
            weapon2.KnifeAttack();

          
        }
    }
}
