namespace GUI
{
    partial class UserControlLichHoc
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
            this.txtMon = new System.Windows.Forms.TextBox();
            this.txtChiTiet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMon
            // 
            this.txtMon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMon.Location = new System.Drawing.Point(0, 0);
            this.txtMon.Multiline = true;
            this.txtMon.Name = "txtMon";
            this.txtMon.ReadOnly = true;
            this.txtMon.Size = new System.Drawing.Size(140, 36);
            this.txtMon.TabIndex = 2;
            this.txtMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMon.Click += new System.EventHandler(this.txtBox_CLick);
            // 
            // txtChiTiet
            // 
            this.txtChiTiet.BackColor = System.Drawing.Color.White;
            this.txtChiTiet.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtChiTiet.Location = new System.Drawing.Point(0, 35);
            this.txtChiTiet.Margin = new System.Windows.Forms.Padding(0);
            this.txtChiTiet.Multiline = true;
            this.txtChiTiet.Name = "txtChiTiet";
            this.txtChiTiet.ReadOnly = true;
            this.txtChiTiet.Size = new System.Drawing.Size(140, 97);
            this.txtChiTiet.TabIndex = 3;
            this.txtChiTiet.Click += new System.EventHandler(this.txtBox_CLick);
            // 
            // UserControlLichHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtChiTiet);
            this.Controls.Add(this.txtMon);
            this.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.Name = "UserControlLichHoc";
            this.Size = new System.Drawing.Size(139, 133);
            this.Load += new System.EventHandler(this.UserControlLichHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtMon;
        public System.Windows.Forms.TextBox txtChiTiet;
    }
}
