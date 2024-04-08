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
            try { TxtA.Text = (Convert.ToSingle(TxtW.Text) * Convert.ToSingle(TxtL.Text) * 0.3025).ToString() + "坪"; }
            catch { MessageBox.Show("請輸入長與寬", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            //若有例外出現訊息方塊之警示，只有確定按鈕，使用警示圖示，不用預設"未成年"
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
            string InName = Microsoft.VisualBasic.Interaction.InputBox("請輸入姓名", "輸入");//輸入方塊取得姓名
            DialogResult DR = MessageBox.Show(InName + "歡迎您！", "歡迎", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            //訊息方塊之訊息含人名，按鈕有確定及取消，圖示用i，預設按鈕為取消
            if (DR == DialogResult.Cancel) Application.Exit();//若訊息方塊選取消鈕會結束，課本無此動作，變數DR下會有虛線表示小有問題
            Text = InName;//若不是選取消，會繼續，將表單標題設為人名
            TxtW.Focus();//讓輸入取得焦點，題目未要求，因為若建立順序正常，TxtW會是第一個可停駐的控制項
        }
    }
}