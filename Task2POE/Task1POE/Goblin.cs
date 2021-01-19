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

        public Goblin(int XPosition, int YPosition, int HP, int Damage) : base(XPosition, YPosition,TileType.Goblin)
        {
            this.HP = 10;
            this.Damage = 1;

        }
        public bool CheckMove(int move)
        {

            if (move == 0) //o means up,1 means down, 2 means left, right means 3
            {
                return Tiles[0].GetTileType() == TileType.Empty;
            }
            else if (move == 1)
            {
                return Tiles[1].GetTileType() == TileType.Empty;

            }
            else if (move == 2)
            {
                return Tiles[2].GetTileType() == TileType.Empty;

            }
            else 
            {
                return Tiles[3].GetTileType() == TileType.Empty;
            }

        }

        public override Movement ReturnMove(Movement goblinMove = 0)
        {
            Random move = new Random();
            int randomRoll = move.Next(0, 4);
            while(! CheckMove (randomRoll)) //while the move isnt valid, keep rolling
            {
                 randomRoll = move.Next(0,4);
            }
            
            if (randomRoll == 0)//0 means up,1 means down, 2 means left, right means 3
            {
                return Movement.Up;
            }
            else if (randomRoll == 1)//0 means up,1 means down, 2 means left, right means 3
            {
                return Movement.Down;
            }
            else if (randomRoll == 2)//0 means up,1 means down, 2 means left, right means 3
            {
                return Movement.Left;
            }
            else (randomRoll == 3) //0 means up,1 means down, 2 means left, right means 3
            {
                return Movement.Right;
            }


            /* Array moves = enum.getvalues(Typeof(Movement));
                Random integers = new Random();
            return (Movement) integers.Next(Enum.GetNames(typeof(Movement)).Length); */
        }

    }
}
