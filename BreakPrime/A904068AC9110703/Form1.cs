namespace A904068AC9110703
{
    public partial class A904068AC9110703 : Form
    {
        public A904068AC9110703()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int num;
            
            try { num = Convert.ToInt32(TxtInput.Text); }
            catch
            {
                MessageBox.Show("請輸入整數");
                TxtInput.Focus();
                return;
            }
            LblCheck.Text = "是質數";
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    LblCheck.Text = "非質數"; break;
                }
            }
        }

        private void Txtinput_Enter(object sender, EventArgs e)
        {
            TxtInput.Text = "";
            LblCheck.Text = "";
        }
    }
}