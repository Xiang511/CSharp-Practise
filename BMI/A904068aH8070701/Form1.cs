namespace A904068aH8070701
{
    public partial class A904068aH8070701 : Form
    {
        public A904068aH8070701()
        {
            InitializeComponent();
        }

        private void A904068aH8070701_Load(object sender, EventArgs e)
        {

        }

        private void LblH_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //float HNumber, WNumber;//宣告轉換後數值變數
            LblBMI.Text = "BMI：";//避免每次執行後，BMI標籤文字異動，在此恢復初值
            if (float.TryParse(TxtH.Text, out float HNumber) && float.TryParse(TxtW.Text, out float WNumber))//判斷身高及體重輸入之解析是否皆正確
                LblBMI.Text += (WNumber / Math.Pow(HNumber, 2)).ToString();//正確則計算BMI，其中Math.Pow(x,n)是計算x的n次方，並轉成字串
                                                                           //此處計算也可以使用WNumber / (HNumber * HNumber)，記得要括號
            else
                LblBMI.Text += "輸入錯誤";//若有一個解析錯誤，則顯示輸出錯誤。上個及這個等式都用複合指定運算子+=
        }
    }
}