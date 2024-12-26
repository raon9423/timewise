namespace GUI
{
    partial class UC_SuKienNgay
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
            this.flpSuKien = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSLSK = new System.Windows.Forms.Label();
            this.flpSuKien.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpSuKien
            // 
            this.flpSuKien.AutoScroll = true;
            this.flpSuKien.Controls.Add(this.lblSLSK);
            this.flpSuKien.Controls.Add(this.lblDate);
            this.flpSuKien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSuKien.ForeColor = System.Drawing.Color.Black;
            this.flpSuKien.Location = new System.Drawing.Point(0, 0);
            this.flpSuKien.Margin = new System.Windows.Forms.Padding(0);
            this.flpSuKien.Name = "flpSuKien";
            this.flpSuKien.Size = new System.Drawing.Size(125, 81);
            this.flpSuKien.TabIndex = 0;
            this.flpSuKien.Paint += new System.Windows.Forms.PaintEventHandler(this.flpSuKien_Paint);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(15, 0);
            this.lblDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(91, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblSLSK
            // 
            this.lblSLSK.ForeColor = System.Drawing.Color.Red;
            this.lblSLSK.Location = new System.Drawing.Point(0, 0);
            this.lblSLSK.Margin = new System.Windows.Forms.Padding(0);
            this.lblSLSK.Name = "lblSLSK";
            this.lblSLSK.Size = new System.Drawing.Size(15, 20);
            this.lblSLSK.TabIndex = 0;
            this.lblSLSK.Text = "1";
            this.lblSLSK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_SuKienNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flpSuKien);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(125, 81);
            this.MinimumSize = new System.Drawing.Size(125, 81);
            this.Name = "UC_SuKienNgay";
            this.Size = new System.Drawing.Size(125, 81);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.flpSuKien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSLSK;
        public System.Windows.Forms.FlowLayoutPanel flpSuKien;
        public System.Windows.Forms.Label lblDate;
    }
}
