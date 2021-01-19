using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1POE
{
    public partial class Form1 : Form
    {
        private int mapHeight = 10;
        private int mapWidth = 10;
       
        


        Label[,] MapGrid = new Label [10,10];

        public Form1()
        {
            InitializeComponent(); InitialiseMap();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            InitialiseMap();
        }
        private void InitialiseMap() 
        {
            
            for(int index1 = 0; index1<mapHeight; index1++) 
            {
                for(int index2 = 0; index2 < mapWidth; index2++)
                {
                    MapGrid[index1, index2] = new Label();
                    MapGrid[index1, index2].Text = "X";
                    MapGrid[index1, index2].Location = new Point(25 * index1,25 * index2);
                    MapGrid[index1, index2].Width = 25;
                    MapGrid[index1, index2].Height = 25;
                    Controls.Add(MapGrid[index1, index2]);

                }
            
            }


        }
    }
}
