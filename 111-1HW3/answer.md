# 第2次作業-作業-HW2
>
>學號：10910813
><br />
>姓名：梁舜勛 
><br />
>作業撰寫時間：150 (mins，包含程式撰寫時間)
><br />
>最後撰寫文件日期：2022/11/15
>

本份文件包含以下主題：(至少需下面兩項，若是有多者可以自行新增)
- [x]說明內容
- [x]個人認為完成作業須具備觀念

## 說明程式與內容



```csharp
public void mt_ddl(){
    
}

當程式需使用大量相同程式碼時，
其他區域只要呼叫此區域就可用區域內已完成的程式，
不用再重複打相同的程式。
```

```html
    *為宣告ddl裡面的項目
    string[] sa_dc = new string[2] { "蔬菜", "水果" };
    string[,] sa_df = new string[2, 2] { { "A菜", "空心菜" },{ "番茄", "火龍果" } };
    
    protected void Page_Load(object sender, EventArgs e) {
        
        if (!IsPostBack) {
            *整段迴圈目的為讓ddl_Category顯示sa_dc所宣告的內容
            for (int i_ct = 0; i_ct < sa_dc.Length; i_ct++)
            {
                ListItem o_l = new ListItem();
                o_l.Text = o_l.Value = sa_dc[i_ct];

                ddl_Category.Items.Add(o_l);
            }
            *呼叫mt_ddl這個區域
            mt_ddl();
        }
    }
```


## 個人認為完成作業須具備觀念

開始寫說明，需要說明本次作業個人覺得需學會那些觀念 (需寫成文章，需最少50字，
並且文內不得有你、我、他三種文字)

 if (!IsPostBack)  是此次程式的重要程式，
 如果沒有這程式那每次在下拉選單中點及蔬菜或水果時，
 網頁會記錄你上次執行的結果並疊加，
 造成蔬菜和水果選項不斷增加的bug。


