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
        private List<bool> minePosition;  //先宣告變數，等等在建構式中用setMines方法隨機產生地電位置
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
            minePosition = setMines(10);  //參考下方的setMines(howManyMines)，10代表要放幾個地雷。這個方法會傳回一個List<bool>。
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
        private List<bool> setMines(int howManyMines)
        {
            if (howManyMines >= 24) howManyMines = 24; //地雷最多24顆
            if (howManyMines <= 0) howManyMines = 1; //地雷最少1顆
            var rn = new Random();
            var canidatate = new List<int>(); //建立一個List<int>，做為簽桶
            for (int i = 0; i < 25; i++)
            {
                canidatate.Add(i); //在簽桶裡面放編號0~24的25支簽
            }
            var buttonIsMines = new List<bool>();  //建立一個List<bool>，用來記錄25個按鈕哪幾個是地雷
            for (int i = 0; i < 25; i++)
            {
                buttonIsMines.Add(false);  //先預設25個按鈕都"不"是地雷
            }
            for (int i = 0; i < howManyMines; i++)  //依據引數howManyMinse決定要做幾次
            {
                var randomNum = rn.Next(0, canidatate.Count);  //在canidatate之中產生一個隨機數字，假設現在產生了"5"這個隨機數
                var mine = canidatate[randomNum];  //接著找出canidatate簽桶中的第"5"個簽，也就是編號5
                buttonIsMines[mine] = true;  //於是把buttonIsMines的第5項元素改成"true"，也就是把button6變成地雷
                canidatate.RemoveAt(randomNum);  //把編號5從canidatate簽桶中移除，避免被重複抽到
            }
            for (int i = 0; i < buttonIsMines.Count; i++)
            {
                if (buttonIsMines[i]) Console.WriteLine("button" + (i + 1).ToString() + " is mine!");
            } //這裡只是用console先print出這局的地雷在哪，可以跟之前寫好的判斷鄰格有幾個地雷互相對照一下

            return buttonIsMines; //放地電的那個for loop做完後，buttonIsMines當中有些是true，也有些是false
                                  //這個就是代替之前參考excel表做出來的那個list<bool> minePostion，不過是用隨機的方式產生

        }
    }
}
