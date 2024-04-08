namespace A904068aH8070701
{
    partial class A904068aH8070701
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
            this.LblStdBMI = new System.Windows.Forms.Label();
            this.LblH = new System.Windows.Forms.Label();
            this.LblW = new System.Windows.Forms.Label();
            this.TxtH = new System.Windows.Forms.TextBox();
            this.TxtW = new System.Windows.Forms.TextBox();
            this.LblBMI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblStdBMI
            // 
            this.LblStdBMI.Location = new System.Drawing.Point(87, 0);
            this.LblStdBMI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStdBMI.Name = "LblStdBMI";
            this.LblStdBMI.Size = new System.Drawing.Size(279, 91);
            this.LblStdBMI.TabIndex = 0;
            this.LblStdBMI.Text = "BMI=體重公斤數/身高公尺數平方標準參考值18.5~24";
            this.LblStdBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblH
            // 
            this.LblH.AutoSize = true;
            this.LblH.Location = new System.Drawing.Point(95, 91);
            this.LblH.Name = "LblH";
            this.LblH.Size = new System.Drawing.Size(99, 20);
            this.LblH.TabIndex = 1;
            this.LblH.Text = "身高(公尺)：";
            this.LblH.Click += new System.EventHandler(this.LblH_Click);
            // 
            // LblW
            // 
            this.LblW.AutoSize = true;
            this.LblW.Location = new System.Drawing.Point(95, 132);
            this.LblW.Name = "LblW";
            this.LblW.Size = new System.Drawing.Size(99, 20);
            this.LblW.TabIndex = 2;
            this.LblW.Text = "身高(公尺)：";
            // 
            // TxtH
            // 
            this.TxtH.Location = new System.Drawing.Point(200, 83);
            this.TxtH.Name = "TxtH";
            this.TxtH.Size = new System.Drawing.Size(100, 28);
            this.TxtH.TabIndex = 3;
            // 
            // TxtW
            // 
            this.TxtW.Location = new System.Drawing.Point(200, 129);
            this.TxtW.Name = "TxtW";
            this.TxtW.Size = new System.Drawing.Size(100, 28);
            this.TxtW.TabIndex = 4;
            // 
            // LblBMI
            // 
            this.LblBMI.AutoSize = true;
            this.LblBMI.Location = new System.Drawing.Point(101, 179);
            this.LblBMI.Name = "LblBMI";
            this.LblBMI.Size = new System.Drawing.Size(39, 20);
            this.LblBMI.TabIndex = 5;
            this.LblBMI.Text = "BMI";
            this.LblBMI.Click += new System.EventHandler(this.label1_Click);
            // 
            // A904068aH8070701
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 252);
            this.Controls.Add(this.LblBMI);
            this.Controls.Add(this.TxtW);
            this.Controls.Add(this.TxtH);
            this.Controls.Add(this.LblW);
            this.Controls.Add(this.LblH);
            this.Controls.Add(this.LblStdBMI);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "A904068aH8070701";
            this.Text = "A904068aH8070701";
            this.Load += new System.EventHandler(this.A904068aH8070701_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblStdBMI;
        private Label LblH;
        private Label LblW;
        private TextBox TxtH;
        private TextBox TxtW;
        private Label LblBMI;
    }
}