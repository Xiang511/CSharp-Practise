namespace A904068aC9090704
{
    public partial class A904068aC9090704 : Form
    {
        public A904068aC9090704()
        {
            InitializeComponent();
        }
        string[] StrPoint = new string[13];//宣告及建構字串陣列給點數存放
        private void A904068aC9090704_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) StrPoint[i] = (i + 1).ToString();
            StrPoint[10] = "J";
            StrPoint[11] = "Q";
            StrPoint[12] = "K";
            TmrSuit.Enabled = true;//啟動二個計時器，讓花色及點數定時更新
            TmrPoint.Enabled = true;
        }

        private void BtnSuit_Click(object sender, EventArgs e)
        {
            TmrSuit.Enabled = !TmrSuit.Enabled;
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            TmrPoint.Enabled = !TmrPoint.Enabled;
        }

        private void TmrSuit_Tick(object sender, EventArgs e)
        {
            string[] StrSuit = { "紅心", "黑桃", "磚塊", "梅花" };
            Random Rnd = new Random();//宣告及建構亂數物件
            LblSuit.Text = StrSuit[Rnd.Next(4)];
        }

        private void TmrPoint_Tick(object sender, EventArgs e)
        {
           Random Rnd = new Random();//宣告及建構亂數物件
            LblPoint.Text = StrPoint[Rnd.Next(13)];
        }
    }
} 