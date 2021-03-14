---------------------------------------------------------------Form1.cs.old、Form1.designer.cs.old
1. (done)先建立一個Windows Form App
2. (done)在上面放25個按鈕
3. (done)每個按鈕點擊後會在console裡面print出這個按鈕的座標
4. (done)座標以最左上角的按鈕為原點(0,0)
5. (done)參考"地雷位置筆記.xlsx"，先想一想要把地雷放在哪。現在先把地雷位置寫死，之後可以再想辦法用Random類別來產生隨機地雷位置
6. (done)在Form1.cs裡面宣告一個欄位minePosition並建立一個List\<bool\>物件，依序紀錄每一個按鈕是不是地雷。
7. (done)在每個private void buttonX_Click(object sender, EventArgs e)裡面用console print出每個button對應的minePostion是不是true
8. (done)為每一個按鈕建立一個List來記錄每個按鈕的所有相鄰按鈕。不過，因為我們只關心相鄰按鈕是不是地雷，或有幾個地雷，因此這個List裡面只需要裝「"相鄰"按鈕對應的"minePostion"」即可，不需要裝到相鄰按鈕的物件。例如：

  List<bool> btn1NearByBtns = new List<bool>(){minePosition[1], minePosition[5], minePosition[6] };    
  
  List<bool> btn2NearByBtns = new List<bool>(){minePosition[0], minePosition[2], minePosition[5], minePosition[6], minePosition[7] };...以此類推。

9. (done)private void button1_Click(object sender, EventArgs e)裡面定義的是button1被按之後會觸發的反應。如果要讓button1被按了之後能print出週邊有幾個地雷，就只需要先計算btn1NearByBtns裡面有"幾個true"，再把數字用console print出來即可。這樣是不是很聰明R？
10. (done)在private void button2_Click(object sender, EventArgs e)計算btn2NearByBtns裡面有幾個true、在private void button3_Click(object sender, EventArgs e)計算btn3NearByBtns裡面有幾個true...以此類推。

---------------------------------------------------------------Form1.cs.old、Form1.designer.cs.old


---------------------------------------------------------------Form1.cs、Form1.designer.cs
11. (done)在Form1.cs裡面再宣告一個欄位（物件變數）btnIndex並建立一個List\<string\>物件，將25個button的名字（字串）放到這個List裡面{"button1", "button2", "button3" ..., "button25"};
12. (done)接著再宣告一個欄位nearByBtnMines，並建立一個空的List\<List\<bool\>\>物件（List裡面還有List），先不要放任何東西進去。
13. (done)然後在Form1的建構式public Form1(){}裡面，（在InitializeComponent();之後）用nearByBtnMines.Add(引數)這個方法，把每個按鈕的相鄰按鈕對應的minePostion加進nearByBtnMines這個List中。
14. (done)接著先進到表單編輯模式，把每個按鈕的Click事件要觸發的方法（目前會是buttonX_Click）全部刪掉，變成空白。（在每個屬性視窗裡面的閃電頁簽中找"Click"這個項目就會看到buttonX_Click，把他刪掉！）
15. (done)接著就可以把Form1.cs裡面的25個private void buttonX_Click(object sender, EventArgs e)全部刪掉囉！

16. 建立一個新的方法private void btn_Click(object sender, EventArgs e)。
17. 再回到表單編輯模式，把每個按鈕的Click事件要觸發的方法（目前會是空白）改成我們新建立的方法btn_Click。
18. 在private void btn_Click(object sender, EventArgs e)裡面，用var btn = (Button)sender;就可以得到被按的按鈕物件。接著用btn.Name屬性和btnIndex來比對，找出被按的按鈕是第幾個按鈕，再進而從minePostion中比對出被按的按鈕是不是地雷，然後再從nearByBtnMines比對出被按的按鈕的相鄰按鈕有哪些是地雷。

19. 把原本寫死的List\<bool\> minePostion = new List\<bool\> (){true,true,false,...}拿掉，只保留宣告欄位（物件變數）的部分（private List\<bool\> minePostion;）。
20. 定義一個新的方法private List\<bool\> setMines(int howManyMines)，用隨機的方式取代原本的List\<bool\> minePostion。
21. 記得要在建構式中呼叫minePostion = setMines(10);才會執行setMines並將這個方法產生的地雷位置清單（List\<bool\>）傳給minePostion這個變數名稱哦！


