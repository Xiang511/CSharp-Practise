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
            LblPay.Text = "��I���B�G";//���F�A���p���٭���
            if (uint.TryParse(TxtBuy.Text, out uint Buy))//�`�N��TryParse���T�~�p��A�䤤��uint�A��X��buy�����rout uint
            //try//�]�i�H��try  catch
            {
                //uint Buy = Convert.ToUInt32(TxtBuy.Text);//��try�ഫ�n�t�g�b���A�P�˥�uint�A�ҥHConvert�n��ToUInt32
                if (Buy > 1000) Buy = Convert.ToUInt32((Buy - 1000) * 0.9) + 1000;//�W�L1000���������E��A�`�N�૬�Υ[�^1000
                //if (Buy > 1000) Buy = (uint)((Buy - 1000) * 0.9) + 1000;//(uint)�j���૬�p�ƵL����˥h�AConvert.ToUInt32()�h�O�|�ˤ��J
                LblPay.Text += Buy.ToString("C0") + "��";//�ƭ��ন�r���J���ҡA�`�N�γf���榡C�A�B�L�p�ƩҥH�OC0�A�̫�["��"
            }
            else
            //catch//
            {
                MessageBox.Show("�п�J�̤j40���������", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);//�ҥ~���`�ΰT���������
            }
        }

        private void TxtBuy_Enter(object sender, EventArgs e)
        {
            TxtBuy.Text = "";//�A����J�e�M��
        }
    }
}