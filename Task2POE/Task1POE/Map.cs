using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1POE
{

    
     
  class Map
    {
        private int width = 15;
        private int height = 15;
        private int gold;

        public  string[,] TileArray;
        private Random cost = new Random();

        public Map(int minWidth, int maxWidth , int minHeight , int maxHeight, int enemies, int treas )
        {
        
            
            
            width = height;
            TileArray = new string [height ,width];
            treas = gold;
            Create (enemies);

        
        }     

        
        
        private void Create(int enemies)
        {
            string hero = " H ";
            string walls = "X";
            string spaces = ".";
            string goblin = "G";
            
            for(int row =0 ; row < height; row++)
            {
                for (int colown = 0; colown < width ; colown++)
                {
                
                    if (row == 0 || row == width - 1 || colown == 0 || colown == height - 1)
                    {
                       TileArray[row,colown]= walls;
                     
                    
                    }
                    else 
                    {
                        TileArray[row,colown]= spaces;
                    }

                }

            }

            int x = 0;
            Random enemyAppear = new Random();
            int enemyHeight;
            int enemyWidth;
            string goblinenemy = "G";

            while (x < enemies)
            {
                enemyHeight = enemyAppear.Next(1, height - 1);
                enemyWidth = enemyAppear.Next(1, width - 1);
                TileArray[enemyHeight, enemyWidth] = goblin;
                x++;
            }
            string gold = "T";
            int y = 0;
            while (y < enemies)
            {
                enemyHeight = enemyAppear.Next(1, height - 1);
                enemyWidth = enemyAppear.Next(1, width - 1);
                TileArray[enemyHeight, enemyWidth] = gold;
                y++;
            }



        }
            
        
        
         
    }
}
