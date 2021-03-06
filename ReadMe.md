1. (done)先建立一個Windows Form App
2. (done)在上面放25個按鈕
3. (done)每個按鈕點擊後會在console裡面print出這個按鈕的座標
4. (done)座標以最左上角的按鈕為原點(0,0)
5. (done)參考"地雷位置筆記.xlsx"，先想一想要把地雷放在哪。現在先把地雷位置寫死，之後可以再想辦法用Random類別來產生隨機地雷位置
6. (done)在Form1.cs裡面宣告一個欄位minePosition並建立一個List\<bool\>物件，依序紀錄每一個按鈕是不是地雷。
7. (done)在每個private void buttonX_Click(object sender, EventArgs e)裡面用console print出每個button對應的minePostion是不是true
8. 為每一個按鈕建立一個List來記錄每個按鈕的所有相鄰按鈕。不過，因為我們只關心相鄰按鈕是不是地雷，或有幾個地雷，因此這個List裡面只需要裝「"相鄰"按鈕對應的minePostion」即可，不用裝自己按鈕對應的minePosition哦！。例如：

  List<bool> btn1NearByBtns = new List<bool>(){minePosition[1], minePosition[5], minePosition[6] };    
  
  List<bool> btn2NearByBtns = new List<bool>(){minePosition[0], minePosition[2], minePosition[5], minePosition[6], minePosition[7] };...以此類推。

9. private void button1_Click(object sender, EventArgs e)裡面定義的是button1被按之後會觸發的反應。如果要讓button1被按了之後能print出週邊有幾個地雷，就只需要先計算btn1NearByBtns裡面有"幾個true"，再把數字用console print出來即可。這樣是不是很聰明R？
10. 在private void button2_Click(object sender, EventArgs e)計算btn2NearByBtns裡面有幾個true、在private void button3_Click(object sender, EventArgs e)計算btn3NearByBtns裡面有幾個true...以此類推。


下一步來把25個private void buttonX_Click(object sender, EventArgs e)通通合併成一個，妳說好不好？

private void buttonX_Click(object sender, EventArgs e)：這個東西通常會稱作"event handler"或是"callback"，就是當某個事件（event）發生後會觸發的事情。
