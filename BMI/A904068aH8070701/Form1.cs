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
            //float HNumber, WNumber;//�ŧi�ഫ��ƭ��ܼ�
            LblBMI.Text = "BMI�G";//�קK�C�������ABMI���Ҥ�r���ʡA�b����_���
            if (float.TryParse(TxtH.Text, out float HNumber) && float.TryParse(TxtW.Text, out float WNumber))//�P�_�������魫��J���ѪR�O�_�ҥ��T
                LblBMI.Text += (WNumber / Math.Pow(HNumber, 2)).ToString();//���T�h�p��BMI�A�䤤Math.Pow(x,n)�O�p��x��n����A���ন�r��
                                                                           //���B�p��]�i�H�ϥ�WNumber / (HNumber * HNumber)�A�O�o�n�A��
            else
                LblBMI.Text += "��J���~";//�Y���@�ӸѪR���~�A�h��ܿ�X���~�C�W�Ӥγo�ӵ������νƦX���w�B��l+=
        }
    }
}