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
            DirectoryInfo Dir1 = new DirectoryInfo(@".\one");//宣告建構Dir1指向目錄one，其中.表示在目前工作目錄(即執行檔的目錄)下，@代表後面為一般文字無特殊字元
            if (Dir1.Exists) MessageBox.Show(".\\one目錄已存在");//若Dir1指向的目錄已存在則訊息顯示已存在
            else
            {//否則，產生Dir1代表的目錄，並訊息顯示目錄建立成功
                Dir1.Create();
                MessageBox.Show(".\\one目錄建立成功");
            }
            DirectoryInfo Dir2 = new DirectoryInfo(@".\two");//宣告建構Dir2指向目錄two
            if (Dir2.Exists) { Dir2.Delete(); MessageBox.Show(".\\two目錄存在且刪除成功"); }//目錄刪除，但目錄物件Dir2還在
            Dir1.MoveTo(@".\two");//搬移後目錄物件Dir1也會指向two，即Dir1及Dir2都指向two
            MessageBox.Show(".\\one目錄已成功搬移到.\\two");//訊息方塊顯示目錄搬移成功
            Application.Exit();//離開應用程式
        }
    }
}