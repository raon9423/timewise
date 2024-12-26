namespace Time
{
    partial class UC_Ngay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtThu = new System.Windows.Forms.TextBox();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtThu
            // 
            this.txtThu.BackColor = System.Drawing.Color.White;
            this.txtThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThu.Location = new System.Drawing.Point(0, 10);
            this.txtThu.Name = "txtThu";
            this.txtThu.ReadOnly = true;
            this.txtThu.Size = new System.Drawing.Size(140, 17);
            this.txtThu.TabIndex = 0;
            this.txtThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtThu.TextChanged += new System.EventHandler(this.txtThu_TextChanged);
            // 
            // txtNgay
            // 
            this.txtNgay.BackColor = System.Drawing.Color.White;
            this.txtNgay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Location = new System.Drawing.Point(0, 33);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.ReadOnly = true;
            this.txtNgay.Size = new System.Drawing.Size(140, 16);
            this.txtNgay.TabIndex = 1;
            this.txtNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNgay.TextChanged += new System.EventHandler(this.txtNgay_TextChanged);
            // 
            // UC_Ngay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.txtThu);
            this.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Name = "UC_Ngay";
            this.Size = new System.Drawing.Size(140, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtThu;
        public System.Windows.Forms.TextBox txtNgay;
    }
}
