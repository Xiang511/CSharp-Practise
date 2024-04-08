namespace A904068aC9090704
{
    partial class A904068aC9090704
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
            this.components = new System.ComponentModel.Container();
            this.LblSuit = new System.Windows.Forms.Label();
            this.LblPoint = new System.Windows.Forms.Label();
            this.BtnSuit = new System.Windows.Forms.Button();
            this.BtnPoint = new System.Windows.Forms.Button();
            this.TmrSuit = new System.Windows.Forms.Timer(this.components);
            this.TmrPoint = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblSuit
            // 
            this.LblSuit.AutoSize = true;
            this.LblSuit.Font = new System.Drawing.Font("標楷體", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSuit.Location = new System.Drawing.Point(65, 48);
            this.LblSuit.Name = "LblSuit";
            this.LblSuit.Size = new System.Drawing.Size(194, 80);
            this.LblSuit.TabIndex = 0;
            this.LblSuit.Text = "紅心";
            this.LblSuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPoint
            // 
            this.LblPoint.AutoSize = true;
            this.LblPoint.Font = new System.Drawing.Font("標楷體", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPoint.Location = new System.Drawing.Point(312, 48);
            this.LblPoint.Name = "LblPoint";
            this.LblPoint.Size = new System.Drawing.Size(114, 80);
            this.LblPoint.TabIndex = 1;
            this.LblPoint.Text = "10";
            this.LblPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSuit
            // 
            this.BtnSuit.Location = new System.Drawing.Point(113, 163);
            this.BtnSuit.Name = "BtnSuit";
            this.BtnSuit.Size = new System.Drawing.Size(75, 23);
            this.BtnSuit.TabIndex = 2;
            this.BtnSuit.Text = "花色";
            this.BtnSuit.UseVisualStyleBackColor = true;
            this.BtnSuit.Click += new System.EventHandler(this.BtnSuit_Click);
            // 
            // BtnPoint
            // 
            this.BtnPoint.Location = new System.Drawing.Point(324, 163);
            this.BtnPoint.Name = "BtnPoint";
            this.BtnPoint.Size = new System.Drawing.Size(75, 23);
            this.BtnPoint.TabIndex = 3;
            this.BtnPoint.Text = "點數";
            this.BtnPoint.UseVisualStyleBackColor = true;
            this.BtnPoint.Click += new System.EventHandler(this.BtnPoint_Click);
            // 
            // TmrSuit
            // 
            this.TmrSuit.Tick += new System.EventHandler(this.TmrSuit_Tick);
            // 
            // TmrPoint
            // 
            this.TmrPoint.Tick += new System.EventHandler(this.TmrPoint_Tick);
            // 
            // A904068aC9090704
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 225);
            this.Controls.Add(this.BtnPoint);
            this.Controls.Add(this.BtnSuit);
            this.Controls.Add(this.LblPoint);
            this.Controls.Add(this.LblSuit);
            this.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "A904068aC9090704";
            this.Text = "A904068aC9090704";
            this.Load += new System.EventHandler(this.A904068aC9090704_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblSuit;
        private Label LblPoint;
        private Button BtnSuit;
        private Button BtnPoint;
        private System.Windows.Forms.Timer TmrSuit;
        private System.Windows.Forms.Timer TmrPoint;
    }
}