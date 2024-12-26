namespace Time
{
    partial class UC_LichHoc
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
            this.flpLich = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpLich
            // 
            this.flpLich.AutoSize = true;
            this.flpLich.Location = new System.Drawing.Point(0, 0);
            this.flpLich.Margin = new System.Windows.Forms.Padding(0);
            this.flpLich.MaximumSize = new System.Drawing.Size(150, 0);
            this.flpLich.MinimumSize = new System.Drawing.Size(140, 0);
            this.flpLich.Name = "flpLich";
            this.flpLich.Size = new System.Drawing.Size(140, 0);
            this.flpLich.TabIndex = 0;
            // 
            // UC_LichHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flpLich);
            this.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Name = "UC_LichHoc";
            this.Size = new System.Drawing.Size(140, 265);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flpLich;
    }
}
