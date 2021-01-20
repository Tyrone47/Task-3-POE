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
        string[,] para;
        int vertical = 5;
        int horizontal = 5;





        public Form1()
        {
            InitializeComponent(); InitialiseMap();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string starring = "H";
            Map one = new Map(15, 20, 15, 20, 5, 6);
            para = one.TileArray;

            para[vertical, horizontal] = starring;

            for (int index1 = 0; index1 < para.GetLength(0); index1++)
            {
                for (int index2 = 0; index2 < para.GetLength(1); index2++)
                {
                    label1.Text += para[index1, index2] + " ";


                }
                label1.Text += "\n";

            }
            InitialiseMap();
        }
        private void InitialiseMap()
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int index2 = 0; index2 < para.GetLength(0); index2++)
            {
                for (int index3 = 0; index2 < para.GetLength(1); index2++)
                {
                    if (para[index2, index3] == "G" && para[index2 + 2, index3] != "X")
                    {
                        para[index2 + 2, index3] = "G";
                        para[index2, index3] = ".";
                    }


                }
                

            }
            horizontal--;
            para[horizontal, vertical] = "H";
            para[horizontal + 1, vertical] = ".";
            para[horizontal + 1, vertical - 1] = ".";
            para[horizontal - 1, vertical - 1] = ".";

            for (int index1 = 0; index1 < para.GetLength(0); index1++)
            {
                for (int index = 0; index < para.GetLength(1); index++)
                {
                    label1.Text += para[index1, index] + " ";


                }
                label1.Text += "\n";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int index2 = 0; index2 < para.GetLength(0); index2++)
            {
                for (int index3 = 0; index2 < para.GetLength(1); index2++)
                {
                    if (para[index2, index3] == "G" && para[index2, index3 - 2] != "X")
                    {
                        para[index2, index3 - 2] = "G";
                        para[index2, index3] = ".";
                    }


                }
                
            }
            vertical++;
            para[horizontal, vertical] = "H";
            para[horizontal, vertical - 1] = ".";
            para[horizontal + 1, vertical - 1] = ".";
            para[horizontal - 1, vertical - 1] = ".";

            for (int index1 = 0; index1 < para.GetLength(0); index1++)
            {
                for (int index = 0; index < para.GetLength(1); index++)
                {
                    label1.Text += para[index1, index] + " ";


                }
                label1.Text += "\n";

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(para[horizontal - 1, vertical] == "G")
            {
                horizontal--;
                para[horizontal, vertical] = "H";
                para[horizontal + 1, vertical] = ".";
                para[horizontal + 1, vertical - 1] = ".";
                para[horizontal - 1, vertical - 1] = ".";
            }
            else if(para[horizontal + 1, vertical] == "G")
            {
                horizontal++;
                para[horizontal, vertical] = "H";
                para[horizontal - 1, vertical] = ".";
                para[horizontal + 1, vertical - 1] = ".";
                para[horizontal - 1, vertical - 1] = ".";
            }
            else if (para[horizontal, vertical + 1] == "G")
            {
                vertical++;
                para[horizontal, vertical] = "H";
                para[horizontal, vertical - 1] = ".";
                para[horizontal + 1, vertical - 1] = ".";
                para[horizontal - 1, vertical - 1] = ".";
            }
            else if (para[horizontal, vertical - 1] == "G")
            {
                vertical--;
                para[horizontal, vertical] = "H";
                para[horizontal, vertical + 1] = ".";
                para[horizontal + 1, vertical - 1] = ".";
                para[horizontal - 1, vertical - 1] = ".";
            }


            for (int index1 = 0; index1 < para.GetLength(0); index1++)
            {
                for (int index = 0; index < para.GetLength(1); index++)
                {
                    label1.Text += para[index1, index] + " ";


                }
                label1.Text += "\n";

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int index2 = 0; index2 < para.GetLength(0); index2++)
            {
                for (int index3 = 0; index2 < para.GetLength(1); index2++)
                {
                    if (para[index2, index3] == "G" && para[index2, index3 + 2] != "X")
                    {
                        para[index2, index3 + 2] = "G";
                        para[index2, index3] = ".";
                    }


                }
                
            }
            vertical--;
            para[horizontal, vertical] = "H";
            para[horizontal, vertical + 1] = ".";
            para[horizontal + 1, vertical - 1] = ".";
            para[horizontal - 1, vertical - 1] = ".";

            for (int index1 = 0; index1 < para.GetLength(0); index1++)
            {
                for (int index = 0; index < para.GetLength(1); index++)
                {
                    label1.Text += para[index1, index] + " ";


                }
                label1.Text += "\n";

            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int index2 = 0; index2 < para.GetLength(0); index2++)
            {
                for (int index3 = 0; index2 < para.GetLength(1); index2++)
                {
                    if (para[index2, index3] == "G" && para[index2 - 2, index3] != "X")
                    {
                        para[index2 - 2, index2] = "G";
                        para[index2, index3] = ".";
                    }


                }
                
            }
            horizontal++;
            para[horizontal, vertical] = "H";
            para[horizontal - 1, vertical] = ".";
            para[horizontal + 1, vertical - 1] = ".";
            para[horizontal - 1, vertical - 1] = ".";

            for (int index1 = 0; index1 < para.GetLength(0); index1++)
            {
                for (int index = 0; index < para.GetLength(1); index++)
                {
                    label1.Text += para[index1, index] + " ";


                }
                label1.Text += "\n";

            }
        }
    }
}
