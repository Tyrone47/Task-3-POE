using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1POE
{
    class Gold : Item
    {

        private int gold { get; set; }
        private Random GoldDrops = new Random () ;
       public Gold(int X, int Y)
        {
            this.X = x;
            this.Y = y;
            int x = GoldDrops.Next(1, 5);
            int y = GoldDrops.Next(1, 5);

        }
    }
}
