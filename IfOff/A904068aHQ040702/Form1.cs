namespace A904068aHQ040702
{
    public partial class A904068aHQ040702 : Form
    {
        public A904068aHQ040702()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            LblPay.Text = "實付金額：";//為了再次計算還原初值
            if (uint.TryParse(TxtBuy.Text, out uint Buy))//注意用TryParse正確才計算，其中用uint，輸出到buy關健字out uint
            //try//也可以用try  catch
            {
                //uint Buy = Convert.ToUInt32(TxtBuy.Text);//用try轉換要另寫在內，同樣用uint，所以Convert要用ToUInt32
                if (Buy > 1000) Buy = Convert.ToUInt32((Buy - 1000) * 0.9) + 1000;//超過1000的部分打九折，注意轉型及加回1000
                //if (Buy > 1000) Buy = (uint)((Buy - 1000) * 0.9) + 1000;//(uint)強制轉型小數無條件捨去，Convert.ToUInt32()則是四捨五入
                LblPay.Text += Buy.ToString("C0") + "元";//數值轉成字串放入標籤，注意用貨幣格式C，且無小數所以是C0，最後加"元"
            }
            else
            //catch//
            {
                MessageBox.Show("請輸入最大40億的正整數", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);//例外異常用訊息方塊提示
            }
        }

        private void TxtBuy_Enter(object sender, EventArgs e)
        {
            TxtBuy.Text = "";//再次輸入前清空
        }
    }
}