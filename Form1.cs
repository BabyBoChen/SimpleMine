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
        private List<string> btnIndex = new List<string>()
        {
            "button1","button2","button3","button4","button5",
            "button6","button7","button8","button9","button10",
            "button11","button12","button13","button14","button15",
            "button16","button17","button18","button19","button20",
            "button21","button22","button23","button24","button25"
        };
        private List<List<bool>> nearByBtnMines = new List<List<bool>>();
        public Form1()
        {
            InitializeComponent();
            //nearByBtnMines.Add();
            nearByBtnMines.Add(new List<bool>() { minePosition[1], minePosition[5], minePosition[6] });                                     //btn1 near by btns mine position
            nearByBtnMines.Add(new List<bool>() { minePosition[0], minePosition[2], minePosition[5], minePosition[6], minePosition[7] });   //btn2 near by btns mine position
            nearByBtnMines.Add(new List<bool>() { minePosition[1], minePosition[3], minePosition[6], minePosition[7], minePosition[8] });   //btn3 near by btns mine position
            nearByBtnMines.Add(new List<bool>() { minePosition[2], minePosition[4], minePosition[7], minePosition[8], minePosition[9] });   //etc...
            nearByBtnMines.Add(new List<bool>() { minePosition[3], minePosition[8], minePosition[9] });
            nearByBtnMines.Add(new List<bool>() { minePosition[0], minePosition[1], minePosition[6], minePosition[10], minePosition[11] });
            nearByBtnMines.Add(new List<bool>() { minePosition[0], minePosition[1], minePosition[2], minePosition[5], minePosition[7], minePosition[10], minePosition[11], minePosition[12] });
            nearByBtnMines.Add(new List<bool>() { minePosition[1], minePosition[2], minePosition[3], minePosition[6], minePosition[8], minePosition[11], minePosition[12], minePosition[13] });
            nearByBtnMines.Add(new List<bool>() { minePosition[2], minePosition[3], minePosition[4], minePosition[7], minePosition[9], minePosition[12], minePosition[13], minePosition[14] });
            nearByBtnMines.Add(new List<bool>() { minePosition[3], minePosition[4], minePosition[8], minePosition[13], minePosition[14] });
            nearByBtnMines.Add(new List<bool>() { minePosition[5], minePosition[6], minePosition[11], minePosition[15], minePosition[16] });
            nearByBtnMines.Add(new List<bool>() { minePosition[5], minePosition[6], minePosition[7], minePosition[10], minePosition[12], minePosition[15], minePosition[16], minePosition[17] });
            nearByBtnMines.Add(new List<bool>() { minePosition[6], minePosition[7], minePosition[8], minePosition[11], minePosition[13], minePosition[16], minePosition[17], minePosition[18] });
            nearByBtnMines.Add(new List<bool>() { minePosition[7], minePosition[8], minePosition[9], minePosition[12], minePosition[14], minePosition[17], minePosition[18], minePosition[19] });
            nearByBtnMines.Add(new List<bool>() { minePosition[8], minePosition[9], minePosition[13], minePosition[18], minePosition[19] });
            nearByBtnMines.Add(new List<bool>() { minePosition[10], minePosition[11], minePosition[16], minePosition[20], minePosition[21] });
            nearByBtnMines.Add(new List<bool>() { minePosition[10], minePosition[11], minePosition[12], minePosition[15], minePosition[17], minePosition[20], minePosition[21], minePosition[22] });
            nearByBtnMines.Add(new List<bool>() { minePosition[11], minePosition[12], minePosition[13], minePosition[16], minePosition[18], minePosition[21], minePosition[22], minePosition[23] });
            nearByBtnMines.Add(new List<bool>() { minePosition[12], minePosition[13], minePosition[14], minePosition[17], minePosition[19], minePosition[22], minePosition[23], minePosition[24] });
            nearByBtnMines.Add(new List<bool>() { minePosition[13], minePosition[14], minePosition[18], minePosition[23], minePosition[24] });
            nearByBtnMines.Add(new List<bool>() { minePosition[15], minePosition[16], minePosition[21] });
            nearByBtnMines.Add(new List<bool>() { minePosition[15], minePosition[16], minePosition[17], minePosition[20], minePosition[22] });
            nearByBtnMines.Add(new List<bool>() { minePosition[16], minePosition[17], minePosition[18], minePosition[21], minePosition[23] });
            nearByBtnMines.Add(new List<bool>() { minePosition[17], minePosition[18], minePosition[19], minePosition[22], minePosition[24] });
            nearByBtnMines.Add(new List<bool>() { minePosition[18], minePosition[19], minePosition[23] });
        }

        private void btn_Click(object sender, EventArgs e)
        {            
            var btn = (Button)sender;
            var index = btnIndex.IndexOf(btn.Name);

            if (minePosition[index] == true)
            {
                Console.WriteLine("Boom! 你輸了!");
                return;
            }
            if (minePosition[index] != true)
            {
                var mineCount = 0;
                foreach (var mine in nearByBtnMines[index])
                {
                    if (mine == true) mineCount++;
                }
                btn.Font = new Font("新細明體", 15F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(136)));
                btn.Text = mineCount.ToString();
                btn.Enabled = false;
            }
        }
    }
}
