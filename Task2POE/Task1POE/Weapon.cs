using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3POE
{
    abstract class Weapon : Item
    {
         protected int Damage;
         protected virtual int Range;
         protected int Durability;
         protected int Cost;
         protected string WeaponType;
        
        public Weapon(int XParameter,int YParameter) : base (XParameter,YParameter)
            {
                

            }


    }
}
