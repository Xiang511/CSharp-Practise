namespace A904068aC9090704
{
    public partial class A904068aC9090704 : Form
    {
        public A904068aC9090704()
        {
            InitializeComponent();
        }
        string[] StrPoint = new string[13];//�ŧi�Ϋغc�r��}�C���I�Ʀs��
        private void A904068aC9090704_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) StrPoint[i] = (i + 1).ToString();
            StrPoint[10] = "J";
            StrPoint[11] = "Q";
            StrPoint[12] = "K";
            TmrSuit.Enabled = true;//�ҰʤG�ӭp�ɾ��A�������I�Ʃw�ɧ�s
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
            string[] StrSuit = { "����", "�®�", "�j��", "����" };
            Random Rnd = new Random();//�ŧi�Ϋغc�üƪ���
            LblSuit.Text = StrSuit[Rnd.Next(4)];
        }

        private void TmrPoint_Tick(object sender, EventArgs e)
        {
           Random Rnd = new Random();//�ŧi�Ϋغc�üƪ���
            LblPoint.Text = StrPoint[Rnd.Next(13)];
        }
    }
} 