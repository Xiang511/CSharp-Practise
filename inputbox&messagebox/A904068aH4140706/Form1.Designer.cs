namespace A904068aH4140706
{
    partial class A904068aH4140706
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
            this.LblW = new System.Windows.Forms.Label();
            this.LblL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtW = new System.Windows.Forms.TextBox();
            this.TxtL = new System.Windows.Forms.TextBox();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.BtnCal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblW
            // 
            this.LblW.AutoSize = true;
            this.LblW.Location = new System.Drawing.Point(25, 30);
            this.LblW.Name = "LblW";
            this.LblW.Size = new System.Drawing.Size(83, 20);
            this.LblW.TabIndex = 0;
            this.LblW.Text = "寬度(公尺)";
            // 
            // LblL
            // 
            this.LblL.AutoSize = true;
            this.LblL.Location = new System.Drawing.Point(25, 77);
            this.LblL.Name = "LblL";
            this.LblL.Size = new System.Drawing.Size(83, 20);
            this.LblL.TabIndex = 1;
            this.LblL.Text = "長度(公尺)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "面積";
            // 
            // TxtW
            // 
            this.TxtW.Location = new System.Drawing.Point(140, 30);
            this.TxtW.Name = "TxtW";
            this.TxtW.Size = new System.Drawing.Size(100, 28);
            this.TxtW.TabIndex = 3;
            this.TxtW.TextChanged += new System.EventHandler(this.TxtW_TextChanged);
            // 
            // TxtL
            // 
            this.TxtL.Location = new System.Drawing.Point(140, 77);
            this.TxtL.Name = "TxtL";
            this.TxtL.Size = new System.Drawing.Size(100, 28);
            this.TxtL.TabIndex = 4;
            this.TxtL.TextChanged += new System.EventHandler(this.TxtL_TextChanged);
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(140, 124);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(100, 28);
            this.TxtA.TabIndex = 5;
            this.TxtA.TextChanged += new System.EventHandler(this.TxtA_TextChanged);
            // 
            // BtnCal
            // 
            this.BtnCal.AutoSize = true;
            this.BtnCal.Location = new System.Drawing.Point(255, 77);
            this.BtnCal.Name = "BtnCal";
            this.BtnCal.Size = new System.Drawing.Size(75, 30);
            this.BtnCal.TabIndex = 6;
            this.BtnCal.Text = "計算";
            this.BtnCal.UseVisualStyleBackColor = true;
            this.BtnCal.Click += new System.EventHandler(this.BtnCal_Click);
            // 
            // A904068aH4140706
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 183);
            this.Controls.Add(this.BtnCal);
            this.Controls.Add(this.TxtA);
            this.Controls.Add(this.TxtL);
            this.Controls.Add(this.TxtW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblL);
            this.Controls.Add(this.LblW);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "A904068aH4140706";
            this.Text = "A904068aH4140706";
            this.Load += new System.EventHandler(this.A904068aH4140706_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblW;
        private Label LblL;
        private Label label1;
        private TextBox TxtW;
        private TextBox TxtL;
        private TextBox TxtA;
        private Button BtnCal;
    }
}