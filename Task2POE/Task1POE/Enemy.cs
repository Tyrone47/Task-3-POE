﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task1POE
{
     abstract class Enemy : Character
    {

        protected Random enemy = new Random();
        
        public Enemy(int XParameter, int YParameter , int maxHP , int Damage , TileType symbol ): base (XParameter,YParameter, symbol )
        {
            
                 
        }

        protected Enemy(int xPosition, int yPosition, TileType symbol)
        {
        }

        public override string ToString()
        {
        
            string enemyStats = this.GetType().Name + " (" + X + Y + ")";
            return enemyStats;
        
        }





    }
}