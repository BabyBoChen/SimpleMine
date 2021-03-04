1. (done)先建立一個Windows Form App
2. (done)在上面放25個按鈕
3. (done)每個按鈕點擊後會在console裡面print出這個按鈕的座標
4. (done)座標以最左上角的按鈕為原點(0,0)
5. 參考"地雷位置筆記.xlsx"，先想一想要把地雷放在哪。現在先把地雷寫死，之後可以再想辦法用Random類別來產生隨機地雷位置
6. 在Form1.cs裡面的第15行到第42行宣告並建立一個List<bool>物件（想想為什麼要"宣告"在這裡而不是宣告在Form1()建構式裡面）
7. 在每個private void buttonX_Click(object sender, EventArgs e)裡面用console print出每個button對應的minePostion是不是true
8. 現在先用麻煩的方式，以後可以再慢慢修改成厲害的寫法，越寫越漂亮




再接下來就是計算每個button周邊藏有幾個地雷...
