using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1POE
{
     class Goblin : Enemy
    {

        public Goblin(int X, int Y ,int HP = 10, int maxHP = 10, int Damage = 1) : base (int X, int Y ,int HP , int maxHP, int Damage)
        {
              


        }

        public override Movement ReturnMove(Movement moves )
        {
         Array moves = enum.getvalues(Typeof(Movement));
            Random integers = new Random();
        return (Movement) integers.Next(Enum.GetNames(typeof(Movement)).Length);
        }

    }
}
