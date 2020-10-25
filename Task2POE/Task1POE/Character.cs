using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1POE
{
    abstract class Character : Tile //another abstract base class called Character that inherits from Tile.
    {
        protected int HP;
        protected int maxHP;
        protected int Damage;
        protected Tile[] Tiles;
        public enum Movement
        {
            NoMovement,Up,Down,Left,Right
        }
        protected char[] CharacterTypes = { 'H', 'E' };


        private TileType tileType;
        public Character(int x , int y) : base (x,y)
           /* A constructor that receives X and Y positions and a symbol and delegates
             the setting of those variables to the Tile class via a constructor initializer.*/
        {
           
        }

        public virtual void Attack (Character target)

        {
            // maxHP = HP - Damage;
            target.HP -= Damage;
            
        }
        public bool IsDead (int maxHP)
        {
            if (maxHP <= 0)
            {
                return true;
            
            }
            else
            {
                return false;
            }
        }

        private int Distanceto(Character target)//Determines distance between 
        {
            int XDifference = X - target.X;
            int YDifference = Y - target.Y;
            return ;

        }
        public virtual bool CheckRange(Character target)
        {
             target.Distanceto;
        }
        public void Move(Movement )
        {

        }

        public abstract Movement(Movement)
        {

        }
        public abstract override ToString()
        {

        }
    }
}
