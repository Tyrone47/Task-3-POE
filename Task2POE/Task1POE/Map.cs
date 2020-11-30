using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1POE
{

    private string[] Enemy = { "Goblin ","Mage" };
     
    class Map
    {
        private int width = 7;
        private int height = 7;
        public  string[,] TileArray;
            
        public Map(int minWidth, int maxWidth , int minHeight , int maxHeight, int enemies )
        {
        
            Random cost = new Random(); 
            int width = cost.Next(minWidth , maxWidth);
            int height = cost.Next(minHeight , maxHeight);
            TileArray = new string [width ,  height];
            Create (enemies);

        
        }     

        Hero(Character )
        { 
        
        }
        string[] Goblin = new Enemy[2,1];
        private Create(int enemies)
        {
            string hero = " H ";
            string walls = " X ";
            string spaces = ".";
            string goblin = "G";
            
            for(int i=0 ; i < width ; i++)
            {
                for (int j = 0; i < width ; i++)
                {
                
                    if (i == 0 && i == width - 1 || j == 0 && j == height - 1)
                    {
                       TileArray[i,j]= walls;
                     
                    
                    }
                    else 
                    {
                        TileArray[i,j]= spaces;
                    }

                }

               int x = 0
                     Random enemyAppear = new Random();
               while(x < enemies)
               {
               int enemyHeight = Random.Next(0,height);
                int enemyWidth = Random.Next(0,width);
                    TileArray[enemyHeight,enemyWidth]= Goblin;
                    x++;
               }
            }

        }
            
        
        
         
    }
}
