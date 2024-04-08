namespace A904068aHQ040702
{
    partial class A904068aHQ040702
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblBuy = new System.Windows.Forms.Label();
            this.LblPay = new System.Windows.Forms.Label();
            this.TxtBuy = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblBuy
            // 
            this.LblBuy.AutoSize = true;
            this.LblBuy.Location = new System.Drawing.Point(63, 34);
            this.LblBuy.Name = "LblBuy";
            this.LblBuy.Size = new System.Drawing.Size(79, 16);
            this.LblBuy.TabIndex = 0;
            this.LblBuy.Text = "購買金額:";
            // 
            // LblPay
            // 
            this.LblPay.AutoSize = true;
            this.LblPay.Location = new System.Drawing.Point(63, 81);
            this.LblPay.Name = "LblPay";
            this.LblPay.Size = new System.Drawing.Size(79, 16);
            this.LblPay.TabIndex = 1;
            this.LblPay.Text = "實付金額:";
            // 
            // TxtBuy
            // 
            this.TxtBuy.Location = new System.Drawing.Point(162, 34);
            this.TxtBuy.Name = "TxtBuy";
            this.TxtBuy.Size = new System.Drawing.Size(114, 27);
            this.TxtBuy.TabIndex = 2;
            this.TxtBuy.Enter += new System.EventHandler(this.TxtBuy_Enter);
            // 
            // BtnOK
            // 
            this.BtnOK.AutoSize = true;
            this.BtnOK.Location = new System.Drawing.Point(298, 34);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(86, 26);
            this.BtnOK.TabIndex = 3;
            this.BtnOK.Text = "確定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // A904068aHQ040702
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 130);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtBuy);
            this.Controls.Add(this.LblPay);
            this.Controls.Add(this.LblBuy);
            this.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "A904068aHQ040702";
            this.Text = "A904068aHQ040702";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblBuy;
        private Label LblPay;
        private TextBox TxtBuy;
        private Button BtnOK;
    }
}