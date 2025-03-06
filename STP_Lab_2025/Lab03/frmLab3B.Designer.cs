namespace STP_Lab_2025.Lab03
{
    partial class frmLab3B
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblMillion = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.lblMillion2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(126, 56);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(126, 116);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(110, 13);
            this.lblRate.TabIndex = 1;
            this.lblRate.Text = "Interest Rate (Annual)";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(126, 244);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(101, 13);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Value after 10 years";
            // 
            // lblMillion
            // 
            this.lblMillion.AutoSize = true;
            this.lblMillion.Location = new System.Drawing.Point(126, 339);
            this.lblMillion.Name = "lblMillion";
            this.lblMillion.Size = new System.Drawing.Size(100, 13);
            this.lblMillion.TabIndex = 3;
            this.lblMillion.Text = "Years to reach $1M";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCalculate.Location = new System.Drawing.Point(129, 179);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(329, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Start Calculation";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblValue2
            // 
            this.lblValue2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblValue2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValue2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblValue2.Location = new System.Drawing.Point(297, 244);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(151, 23);
            this.lblValue2.TabIndex = 7;
            this.lblValue2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMillion2
            // 
            this.lblMillion2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMillion2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMillion2.Location = new System.Drawing.Point(297, 334);
            this.lblMillion2.Name = "lblMillion2";
            this.lblMillion2.Size = new System.Drawing.Size(151, 23);
            this.lblMillion2.TabIndex = 8;
            this.lblMillion2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(297, 48);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(151, 20);
            this.txtAmount.TabIndex = 11;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(297, 113);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(151, 20);
            this.txtRate.TabIndex = 12;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmLab3B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblMillion2);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblMillion);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblAmount);
            this.Name = "frmLab3B";
            this.Text = "Compound interest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblMillion;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.Label lblMillion2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtRate;
    }
}