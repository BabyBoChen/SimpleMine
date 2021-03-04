using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMine
{
    public partial class Form1 : Form
    {
        private List<bool> minePosition = new List<bool>()
        {
            true,   //minePosition[0],  Name=button1
            true,   //minePosition[1],  Name=button2
            false,   //minePosition[2],  Name=button3
            true,   //minePosition[3],  Name=button4
            true,   //minePosition[4],  Name=button5
            true,   //minePosition[5],  Name=button6
            false,   //minePosition[6],  Name=button7
            false,   //minePosition[7],  Name=button8
            false,   //minePosition[8],  Name=button9
            true,   //minePosition[9],  Name=button10
            false,   //minePosition[10],  Name=button11
            false,   //minePosition[11],  Name=button12
            true,   //minePosition[12],  Name=button13
            false,   //minePosition[13],  Name=button14
            false,   //minePosition[14],  Name=button15
            false,   //minePosition[15],  Name=button16
            true,   //minePosition[16],  Name=button17
            false,   //minePosition[17],  Name=button18
            false,   //minePosition[18],  Name=button19
            false,   //minePosition[19],  Name=button20
            true,   //minePosition[20],  Name=button21
            false,   //minePosition[21],  Name=button22
            true,   //minePosition[22],  Name=button23
            false,   //minePosition[23],  Name=button24
            false   //minePosition[24],  Name=button25
        };        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("0,0");
            if (minePosition[0] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("1,0");
            if (minePosition[1] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("2,0");
            if (minePosition[2] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("3,0");
            if (minePosition[3] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.WriteLine("4,0");
            if (minePosition[4] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.WriteLine("0,1");
            if (minePosition[5] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Console.WriteLine("1,1");
            if (minePosition[6] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Console.WriteLine("2,1");
            if (minePosition[7] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Console.WriteLine("3,1");
            if (minePosition[8] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Console.WriteLine("4,1");
            if (minePosition[9] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Console.WriteLine("0,2");
            if (minePosition[10] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Console.WriteLine("1,2");
            if (minePosition[11] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Console.WriteLine("2,2");
            if (minePosition[12] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Console.WriteLine("3,2");
            if (minePosition[13] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Console.WriteLine("4,2");
            if (minePosition[14] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Console.WriteLine("0,3");
            if (minePosition[15] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Console.WriteLine("1,3");
            if (minePosition[16] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Console.WriteLine("2,3");
            if (minePosition[17] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Console.WriteLine("3,3");
            if (minePosition[18] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Console.WriteLine("4,3");
            if (minePosition[19] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Console.WriteLine("0,4");
            if (minePosition[20] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Console.WriteLine("1,4");
            if (minePosition[21] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Console.WriteLine("2,4");
            if (minePosition[22] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Console.WriteLine("3,4");
            if (minePosition[23] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Console.WriteLine("4,4");
            if (minePosition[24] == true)
            {
                Console.WriteLine("Boom！你輸了！");
            }
            else
            {
                Console.WriteLine("沒事...");
            }
        }
    }
}
