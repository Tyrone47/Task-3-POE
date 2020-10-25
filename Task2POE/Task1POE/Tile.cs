using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1POE
{
    abstract class Tile //Question 2.1
    {
        protected int X;
        protected int Y;
        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon
        }
        public int x //X Constructor
        {
            get { return X; }
            set { X = value; }
        }
        public Tile(int X , int Y)//A constructor for the following values
            {
            this.X = X;
            this.Y = Y;
        
     
        
        }

            public int y //Y Constructor
        {
            get { return Y; }
            set { Y = value; }
        
        }

        //Dont forget to add getters & setters for the enum TileType.

        private TileType tileType;

        public TileType GetTileType()
        {
           return tileType ;
        }
        public void SetTileType (TileType value)
        {
            tileType = value;
        }
        
        //public Tile (char XPosition , char YPosition , enum TypeOfTile)
         
            

            


        
    }
}
