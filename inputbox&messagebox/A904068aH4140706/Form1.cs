using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A904068aH4140706
{
    public partial class A904068aH4140706 : Form
    {
        public A904068aH4140706()
        {
            InitializeComponent();
        }

        private void BtnCal_Click(object sender, EventArgs e)
        {
            try { TxtA.Text = (Convert.ToSingle(TxtW.Text) * Convert.ToSingle(TxtL.Text) * 0.3025).ToString() + "�W"; }
            catch { MessageBox.Show("�п�J���P�e", "�`�N�I", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            //�Y���ҥ~�X�{�T�������ĵ�ܡA�u���T�w���s�A�ϥ�ĵ�ܹϥܡA���ιw�]"�����~"
        }

        private void TxtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtL_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtW_TextChanged(object sender, EventArgs e)
        {

        }

        private void A904068aH4140706_Load(object sender, EventArgs e)
        {
            string InName = Microsoft.VisualBasic.Interaction.InputBox("�п�J�m�W", "��J");//��J������o�m�W
            DialogResult DR = MessageBox.Show(InName + "�w��z�I", "�w��", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            //�T��������T���t�H�W�A���s���T�w�Ψ����A�ϥܥ�i�A�w�]���s������
            if (DR == DialogResult.Cancel) Application.Exit();//�Y�T�����������s�|�����A�ҥ��L���ʧ@�A�ܼ�DR�U�|����u��ܤp�����D
            Text = InName;//�Y���O������A�|�~��A�N�����D�]���H�W
            TxtW.Focus();//����J���o�J�I�A�D�إ��n�D�A�]���Y�إ߶��ǥ��`�ATxtW�|�O�Ĥ@�ӥi���n�����
        }
    }
}