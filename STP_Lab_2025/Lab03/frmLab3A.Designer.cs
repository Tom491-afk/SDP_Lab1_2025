﻿namespace STP_Lab_2025.Lab03
{
    partial class frmLab3A
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
            this.btnCast = new System.Windows.Forms.Button();
            this.lblCast = new System.Windows.Forms.Label();
            this.cboMovie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCast
            // 
            this.btnCast.Location = new System.Drawing.Point(148, 188);
            this.btnCast.Name = "btnCast";
            this.btnCast.Size = new System.Drawing.Size(121, 23);
            this.btnCast.TabIndex = 0;
            this.btnCast.Text = "Cast your vote";
            this.btnCast.UseVisualStyleBackColor = true;
            this.btnCast.Click += new System.EventHandler(this.btnCast_Click);
            // 
            // lblCast
            // 
            this.lblCast.AutoSize = true;
            this.lblCast.Location = new System.Drawing.Point(145, 73);
            this.lblCast.Name = "lblCast";
            this.lblCast.Size = new System.Drawing.Size(157, 13);
            this.lblCast.TabIndex = 1;
            this.lblCast.Text = "My Choice of Best Movie Series";
            // 
            // cboMovie
            // 
            this.cboMovie.FormattingEnabled = true;
            this.cboMovie.Items.AddRange(new object[] {
            "The Godfather",
            "Terminator",
            "Back to the future",
            "Matrix"});
            this.cboMovie.Location = new System.Drawing.Point(148, 118);
            this.cboMovie.Name = "cboMovie";
            this.cboMovie.Size = new System.Drawing.Size(121, 21);
            this.cboMovie.TabIndex = 2;
            // 
            // frmLab3A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboMovie);
            this.Controls.Add(this.lblCast);
            this.Controls.Add(this.btnCast);
            this.Name = "frmLab3A";
            this.Text = "Lab3A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCast;
        private System.Windows.Forms.Label lblCast;
        private System.Windows.Forms.ComboBox cboMovie;
    }
}