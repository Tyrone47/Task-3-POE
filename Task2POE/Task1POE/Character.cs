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
        //protected char[] CharacterTypes = { 'H', 'E' };

        
        
        public Character(int x , int y  ) : base (x,y)
           // A constructor that receives X and Y positions and a symbol and delegates
            // the setting of those variables to the Tile class via a constructor initializer.
        {
            Tiles = new Tile[4];
        }

        public virtual void Attack (Character target)

        {
            target.HP = target.HP - Damage; 
        }
        public bool IsDead ()
        {
            if (HP <= 0)
            {
                return true;
            
            }
            else
            {
                return false;
            }
        }

        private int DistanceTo(Character target)//Determines distance between 
        {
            int XDifference = Math.Abs( X - target.X);
            int YDifference = Math.Abs ( Y - target.Y);
             return XDifference + YDifference;       
        }
        public virtual bool CheckRange(Character target)
        {
             
            if(DistanceTo(target) == 1 )
            {
                
                return true;
            }
            else
            {
                return false;
            }
        } 
        public void Move(Movement moving)
        {
            if (moving == Movement.Up)
            {
            Y= Y -1 ;
            }
            else if(moving == Movement.Down)
            {
                Y = Y + 1;
            }
            else if (moving == Movement.Left)
            {
            X = X - 1;
            }
            else if (moving == Movement.Right)
            {
            X = X + 1;
            }
            
        }

        public abstract Movement ReturnMove(Movement move = 0);
        
        public abstract override string ToString( );

        
    }
}
