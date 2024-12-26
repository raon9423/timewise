namespace GUI
{
    partial class DanhSachLichNhac_ChinhSua
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
            this.lsvLichNhac = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPathAmThanh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTitleColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBackgroundColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvLichNhac
            // 
            this.lsvLichNhac.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lsvLichNhac.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnName,
            this.columnDate,
            this.columnTime,
            this.columnLocation,
            this.columnScore,
            this.columnNote,
            this.columnPathAmThanh,
            this.columnTitleColor,
            this.columnBackgroundColor});
            this.lsvLichNhac.HideSelection = false;
            this.lsvLichNhac.Location = new System.Drawing.Point(2, 67);
            this.lsvLichNhac.Margin = new System.Windows.Forms.Padding(2);
            this.lsvLichNhac.Name = "lsvLichNhac";
            this.lsvLichNhac.Size = new System.Drawing.Size(1090, 601);
            this.lsvLichNhac.TabIndex = 0;
            this.lsvLichNhac.UseCompatibleStateImageBehavior = false;
            this.lsvLichNhac.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "ID";
            this.columnId.Width = 49;
            // 
            // columnName
            // 
            this.columnName.Text = "Tên sự kiện";
            this.columnName.Width = 102;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Ngày diễn ra ";
            this.columnDate.Width = 97;
            // 
            // columnTime
            // 
            this.columnTime.Text = "Thời gian";
            this.columnTime.Width = 91;
            // 
            // columnLocation
            // 
            this.columnLocation.Text = "Địa điểm";
            this.columnLocation.Width = 77;
            // 
            // columnScore
            // 
            this.columnScore.Text = "Điểm rèn luyện";
            this.columnScore.Width = 98;
            // 
            // columnNote
            // 
            this.columnNote.Text = "Chi tiết sự kiện";
            this.columnNote.Width = 142;
            // 
            // columnPathAmThanh
            // 
            this.columnPathAmThanh.Text = "Âm thanh thông báo";
            this.columnPathAmThanh.Width = 118;
            // 
            // columnTitleColor
            // 
            this.columnTitleColor.Text = "Màu chữ";
            this.columnTitleColor.Width = 70;
            // 
            // columnBackgroundColor
            // 
            this.columnBackgroundColor.Text = "Màu nền";
            this.columnBackgroundColor.Width = 71;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1090, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách tất cả sự kiện";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(2, 33);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 30);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // DanhSachLichNhac_ChinhSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvLichNhac);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DanhSachLichNhac_ChinhSua";
            this.Size = new System.Drawing.Size(1094, 670);
            this.Load += new System.EventHandler(this.DanhSachLichNhac_ChinhSua_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvLichNhac;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnLocation;
        private System.Windows.Forms.ColumnHeader columnScore;
        private System.Windows.Forms.ColumnHeader columnNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ColumnHeader columnPathAmThanh;
        private System.Windows.Forms.ColumnHeader columnTitleColor;
        private System.Windows.Forms.ColumnHeader columnBackgroundColor;
    }
}
