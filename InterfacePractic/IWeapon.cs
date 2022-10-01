using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractic
{
    internal interface IWeapon
    {
        int Damage { get; }
        string Name { get; }
        int Durability { get; }
        void ShowInfo();
        //void Repair();
    }
}
