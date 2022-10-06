using System;
namespace InterfacePractic
{
    class Programm
    {
        static void Main(string[] Args)
        {
            Warrior warrior = new Warrior();
            BlackSmith smithy = new BlackSmith();
            Axe axe = new Axe();
            human people = new Warrior();
            warrior.KnifeAttack(axe, people);
            warrior.Throw(axe, people);
            smithy.Fix(axe);
            smithy.Upgrade(axe);
            axe.GetInfo();

        }
    }
}
