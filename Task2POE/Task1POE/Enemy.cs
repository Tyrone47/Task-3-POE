using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task1POE
{
    internal abstract class Enemy : Character
    {

        protected Random enemy = new Random();
        
        Enemy(int XParameter, int YParameter)
        {
            int randomNumber = enemy.Next();
            XParameter = X;
            YParameter = Y;

            string EnemyClassName = $"[X,Y]  ";
                 
        {
            
        }
    } 
        ReturnMethod()
        {

        }




       
        
    }
}