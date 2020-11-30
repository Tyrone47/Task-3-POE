using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3POE
{
    class MeleeWeapon : Weapon
    {
        public enum Types
        {
            Dagger,
            Longsword
        }
        public override Range(int number)
        {
            number = 1;

        }
        public MeleeWeapon(Types type, int Xposition, int YPosition) : base (X,Y)
        {
            if (type == Types.Dagger)
            {
                WeaponType = "Dagger";
                Durability = 10;
                Damage = 3;
                Cost = 3;
            }
            else if (type == Types.Longsword)
            {
                WeaponType = "Longsword";
                Durability = 6;
                Damage = 4;
                Cost = 5;
            }


        }

    }
}
