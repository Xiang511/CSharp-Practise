namespace A904068AC9110703
{
    partial class A904068AC9110703
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
            this.LBlInput = new System.Windows.Forms.Label();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.LblCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBlInput
            // 
            this.LBlInput.AutoSize = true;
            this.LBlInput.Location = new System.Drawing.Point(12, 9);
            this.LBlInput.Name = "LBlInput";
            this.LBlInput.Size = new System.Drawing.Size(231, 16);
            this.LBlInput.TabIndex = 0;
            this.LBlInput.Text = "請輸入正整數以判斷是否為質數";
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(12, 41);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(56, 27);
            this.TxtInput.TabIndex = 1;
            this.TxtInput.Enter += new System.EventHandler(this.Txtinput_Enter);
            // 
            // BtnCheck
            // 
            this.BtnCheck.AutoSize = true;
            this.BtnCheck.Location = new System.Drawing.Point(168, 45);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(75, 26);
            this.BtnCheck.TabIndex = 2;
            this.BtnCheck.Text = "檢查";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // LblCheck
            // 
            this.LblCheck.AutoSize = true;
            this.LblCheck.Location = new System.Drawing.Point(87, 50);
            this.LblCheck.Name = "LblCheck";
            this.LblCheck.Size = new System.Drawing.Size(0, 16);
            this.LblCheck.TabIndex = 3;
            // 
            // A904068AC9110703
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 91);
            this.Controls.Add(this.LblCheck);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.LBlInput);
            this.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "A904068AC9110703";
            this.Text = "A904068AC9110703";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LBlInput;
        private TextBox TxtInput;
        private Button BtnCheck;
        private Label LblCheck;
    }
}