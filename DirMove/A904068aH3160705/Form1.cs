namespace A904068aH3160705
{
    public partial class A904068aH3160705 : Form
    {
        public A904068aH3160705()
        {
            InitializeComponent();
        }

        private void A904068aH3160705_Load(object sender, EventArgs e)
        {
            DirectoryInfo Dir1 = new DirectoryInfo(@".\one");//�ŧi�غcDir1���V�ؿ�one�A�䤤.��ܦb�ثe�u�@�ؿ�(�Y�����ɪ��ؿ�)�U�A@�N��᭱���@���r�L�S��r��
            if (Dir1.Exists) MessageBox.Show(".\\one�ؿ��w�s�b");//�YDir1���V���ؿ��w�s�b�h�T����ܤw�s�b
            else
            {//�_�h�A����Dir1�N���ؿ��A�ðT����ܥؿ��إߦ��\
                Dir1.Create();
                MessageBox.Show(".\\one�ؿ��إߦ��\");
            }
            DirectoryInfo Dir2 = new DirectoryInfo(@".\two");//�ŧi�غcDir2���V�ؿ�two
            if (Dir2.Exists) { Dir2.Delete(); MessageBox.Show(".\\two�ؿ��s�b�B�R�����\"); }//�ؿ��R���A���ؿ�����Dir2�٦b
            Dir1.MoveTo(@".\two");//�h����ؿ�����Dir1�]�|���Vtwo�A�YDir1��Dir2�����Vtwo
            MessageBox.Show(".\\one�ؿ��w���\�h����.\\two");//�T�������ܥؿ��h�����\
            Application.Exit();//���}���ε{��
        }
    }
}