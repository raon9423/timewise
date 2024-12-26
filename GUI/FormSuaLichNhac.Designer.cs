namespace GUI
{
    partial class FormSuaLichNhac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuaLichNhac));
            this.txtDiemRL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemLich = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.txtGio = new System.Windows.Forms.TextBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblAmThanh = new System.Windows.Forms.Label();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.lblGio = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblThemLichNhac = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnChangePath = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMauNen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMauChu = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDiemRL
            // 
            this.txtDiemRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemRL.Location = new System.Drawing.Point(85, 196);
            this.txtDiemRL.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiemRL.Multiline = true;
            this.txtDiemRL.Name = "txtDiemRL";
            this.txtDiemRL.Size = new System.Drawing.Size(260, 19);
            this.txtDiemRL.TabIndex = 65;
            this.txtDiemRL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemRL_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.MinimumSize = new System.Drawing.Size(77, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Điểm RL:";
            // 
            // btnThemLich
            // 
            this.btnThemLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.btnThemLich.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLich.ForeColor = System.Drawing.Color.White;
            this.btnThemLich.Location = new System.Drawing.Point(246, 458);
            this.btnThemLich.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemLich.Name = "btnThemLich";
            this.btnThemLich.Size = new System.Drawing.Size(100, 32);
            this.btnThemLich.TabIndex = 62;
            this.btnThemLich.Text = "Lưu";
            this.btnThemLich.UseVisualStyleBackColor = false;
            this.btnThemLich.Click += new System.EventHandler(this.btnThemLich_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(85, 269);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(260, 104);
            this.txtGhiChu.TabIndex = 61;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaDiem.Location = new System.Drawing.Point(85, 158);
            this.txtDiaDiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaDiem.Multiline = true;
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(260, 19);
            this.txtDiaDiem.TabIndex = 60;
            // 
            // txtGio
            // 
            this.txtGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGio.Location = new System.Drawing.Point(268, 119);
            this.txtGio.Margin = new System.Windows.Forms.Padding(2);
            this.txtGio.Multiline = true;
            this.txtGio.Name = "txtGio";
            this.txtGio.Size = new System.Drawing.Size(77, 19);
            this.txtGio.TabIndex = 59;
            this.txtGio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGio_KeyPress);
            // 
            // dtpNgay
            // 
            this.dtpNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.Location = new System.Drawing.Point(85, 119);
            this.dtpNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(135, 21);
            this.dtpNgay.TabIndex = 58;
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.BackColor = System.Drawing.Color.White;
            this.txtTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTieuDe.Location = new System.Drawing.Point(85, 80);
            this.txtTieuDe.Margin = new System.Windows.Forms.Padding(2);
            this.txtTieuDe.Multiline = true;
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(260, 21);
            this.txtTieuDe.TabIndex = 57;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.ForeColor = System.Drawing.Color.White;
            this.lblGhiChu.Location = new System.Drawing.Point(4, 269);
            this.lblGhiChu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGhiChu.MinimumSize = new System.Drawing.Size(79, 20);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(79, 20);
            this.lblGhiChu.TabIndex = 56;
            this.lblGhiChu.Text = "Chi tiết:";
            // 
            // lblAmThanh
            // 
            this.lblAmThanh.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmThanh.ForeColor = System.Drawing.Color.White;
            this.lblAmThanh.Location = new System.Drawing.Point(4, 232);
            this.lblAmThanh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmThanh.MinimumSize = new System.Drawing.Size(79, 20);
            this.lblAmThanh.Name = "lblAmThanh";
            this.lblAmThanh.Size = new System.Drawing.Size(79, 20);
            this.lblAmThanh.TabIndex = 55;
            this.lblAmThanh.Text = "Âm thanh:";
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaDiem.ForeColor = System.Drawing.Color.White;
            this.lblDiaDiem.Location = new System.Drawing.Point(4, 158);
            this.lblDiaDiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaDiem.MinimumSize = new System.Drawing.Size(79, 20);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(79, 20);
            this.lblDiaDiem.TabIndex = 54;
            this.lblDiaDiem.Text = "Địa Điểm:";
            // 
            // lblGio
            // 
            this.lblGio.AutoSize = true;
            this.lblGio.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGio.ForeColor = System.Drawing.Color.White;
            this.lblGio.Location = new System.Drawing.Point(230, 120);
            this.lblGio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGio.Name = "lblGio";
            this.lblGio.Size = new System.Drawing.Size(34, 20);
            this.lblGio.TabIndex = 53;
            this.lblGio.Text = "Giờ:";
            // 
            // lblNgay
            // 
            this.lblNgay.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.ForeColor = System.Drawing.Color.White;
            this.lblNgay.Location = new System.Drawing.Point(2, 120);
            this.lblNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(60, 20);
            this.lblNgay.TabIndex = 52;
            this.lblNgay.Text = "Ngày:";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(4, 80);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTieuDe.MinimumSize = new System.Drawing.Size(77, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(77, 20);
            this.lblTieuDe.TabIndex = 51;
            this.lblTieuDe.Text = "Tiêu đề:";
            // 
            // lblThemLichNhac
            // 
            this.lblThemLichNhac.AutoSize = true;
            this.lblThemLichNhac.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemLichNhac.ForeColor = System.Drawing.Color.White;
            this.lblThemLichNhac.Location = new System.Drawing.Point(138, 33);
            this.lblThemLichNhac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThemLichNhac.Name = "lblThemLichNhac";
            this.lblThemLichNhac.Size = new System.Drawing.Size(104, 26);
            this.lblThemLichNhac.TabIndex = 50;
            this.lblThemLichNhac.Text = "Lịch Nhắc";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(38, 458);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 32);
            this.btnXoa.TabIndex = 66;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(142, 458);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 32);
            this.btnClear.TabIndex = 67;
            this.btnClear.Text = "Làm sạch";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(9, 10);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(76, 20);
            this.txtId.TabIndex = 68;
            this.txtId.Visible = false;
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(84, 233);
            this.txtPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(191, 19);
            this.txtPath.TabIndex = 69;
            // 
            // btnChangePath
            // 
            this.btnChangePath.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePath.Location = new System.Drawing.Point(280, 232);
            this.btnChangePath.Name = "btnChangePath";
            this.btnChangePath.Size = new System.Drawing.Size(64, 20);
            this.btnChangePath.TabIndex = 70;
            this.btnChangePath.Text = "Chọn";
            this.btnChangePath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangePath.UseVisualStyleBackColor = true;
            this.btnChangePath.Click += new System.EventHandler(this.btnChangePath_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblMauNen);
            this.panel2.Location = new System.Drawing.Point(191, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 25);
            this.panel2.TabIndex = 76;
            // 
            // lblMauNen
            // 
            this.lblMauNen.BackColor = System.Drawing.Color.White;
            this.lblMauNen.Location = new System.Drawing.Point(13, 0);
            this.lblMauNen.Name = "lblMauNen";
            this.lblMauNen.Size = new System.Drawing.Size(50, 25);
            this.lblMauNen.TabIndex = 56;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblMauChu);
            this.panel1.Location = new System.Drawing.Point(85, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 25);
            this.panel1.TabIndex = 75;
            // 
            // lblMauChu
            // 
            this.lblMauChu.BackColor = System.Drawing.Color.Black;
            this.lblMauChu.Location = new System.Drawing.Point(13, 0);
            this.lblMauChu.Name = "lblMauChu";
            this.lblMauChu.Size = new System.Drawing.Size(50, 25);
            this.lblMauChu.TabIndex = 56;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(191, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 23);
            this.button3.TabIndex = 74;
            this.button3.Text = "Màu Nền";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(85, 409);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 23);
            this.button4.TabIndex = 73;
            this.button4.Text = "Màu chữ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormSuaLichNhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(369, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnChangePath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtDiemRL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThemLich);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.txtGio);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblAmThanh);
            this.Controls.Add(this.lblDiaDiem);
            this.Controls.Add(this.lblGio);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblThemLichNhac);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSuaLichNhac";
            this.Text = "Sửa lịch sự kiện";
            this.Load += new System.EventHandler(this.FormSuaLichNhac_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiemRL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemLich;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.TextBox txtGio;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblAmThanh;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.Label lblGio;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblThemLichNhac;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnChangePath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMauNen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMauChu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}