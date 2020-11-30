using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3POE
{
    class RangedWeapon : Weapon
    {
        public enum Types
        {
            Rifle,
            Longbow
        }
        public RangedWeapon(Types type, int Xposition, int YPosition) : base  (X, Y)
        {
            if (type == Types.Rifle)
            {
                WeaponType = "Rifle";
                Durability = 3;
                Range = 3;
                Damage = 5;
                Cost = 7;
            }
            else if (type == Types.Longbow)
            {
                WeaponType = "Longbow";
                Durability = 4;
                Range = 2;
                Damage = 4;
                Cost = 6;
            }
        }
}
