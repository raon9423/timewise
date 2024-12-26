namespace GUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlHomeContainer = new System.Windows.Forms.Panel();
            this.pnlLich = new System.Windows.Forms.Panel();
            this.pnlThongKe = new System.Windows.Forms.Panel();
            this.HomeTimer = new System.Windows.Forms.Timer(this.components);
            this.ThongKeTimer = new System.Windows.Forms.Timer(this.components);
            this.LichTimer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.pnlDesTop = new System.Windows.Forms.Panel();
            this.Timewise = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuStopMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLichToday = new System.Windows.Forms.Button();
            this.btnLichThi = new System.Windows.Forms.Button();
            this.btnLichHoc = new System.Windows.Forms.Button();
            this.btnThemLich = new System.Windows.Forms.Button();
            this.btnDSLN = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLich = new System.Windows.Forms.Button();
            this.btnXepLoai = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnSuKien = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlHomeContainer.SuspendLayout();
            this.pnlLich.SuspendLayout();
            this.pnlThongKe.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlSetting.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Location = new System.Drawing.Point(2, 2);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(159, 42);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlHomeContainer
            // 
            this.pnlHomeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(55)))));
            this.pnlHomeContainer.Controls.Add(this.btnHome);
            this.pnlHomeContainer.Controls.Add(this.button4);
            this.pnlHomeContainer.Controls.Add(this.btnLichToday);
            this.pnlHomeContainer.Controls.Add(this.btnLichThi);
            this.pnlHomeContainer.Controls.Add(this.btnLichHoc);
            this.pnlHomeContainer.Location = new System.Drawing.Point(0, 46);
            this.pnlHomeContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHomeContainer.MaximumSize = new System.Drawing.Size(161, 194);
            this.pnlHomeContainer.MinimumSize = new System.Drawing.Size(161, 35);
            this.pnlHomeContainer.Name = "pnlHomeContainer";
            this.pnlHomeContainer.Size = new System.Drawing.Size(161, 35);
            this.pnlHomeContainer.TabIndex = 2;
            // 
            // pnlLich
            // 
            this.pnlLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(55)))));
            this.pnlLich.Controls.Add(this.btnThemLich);
            this.pnlLich.Controls.Add(this.btnDSLN);
            this.pnlLich.Controls.Add(this.button3);
            this.pnlLich.Controls.Add(this.btnLich);
            this.pnlLich.Location = new System.Drawing.Point(0, 81);
            this.pnlLich.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLich.MaximumSize = new System.Drawing.Size(161, 148);
            this.pnlLich.MinimumSize = new System.Drawing.Size(161, 35);
            this.pnlLich.Name = "pnlLich";
            this.pnlLich.Size = new System.Drawing.Size(161, 35);
            this.pnlLich.TabIndex = 2;
            // 
            // pnlThongKe
            // 
            this.pnlThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(55)))));
            this.pnlThongKe.Controls.Add(this.btnXepLoai);
            this.pnlThongKe.Controls.Add(this.btnThongKe);
            this.pnlThongKe.Controls.Add(this.btnSuKien);
            this.pnlThongKe.ForeColor = System.Drawing.Color.White;
            this.pnlThongKe.Location = new System.Drawing.Point(0, 116);
            this.pnlThongKe.Margin = new System.Windows.Forms.Padding(0);
            this.pnlThongKe.MaximumSize = new System.Drawing.Size(161, 115);
            this.pnlThongKe.MinimumSize = new System.Drawing.Size(161, 35);
            this.pnlThongKe.Name = "pnlThongKe";
            this.pnlThongKe.Size = new System.Drawing.Size(161, 35);
            this.pnlThongKe.TabIndex = 2;
            this.pnlThongKe.Visible = false;
            // 
            // HomeTimer
            // 
            this.HomeTimer.Enabled = true;
            this.HomeTimer.Interval = 10;
            this.HomeTimer.Tick += new System.EventHandler(this.HomeTimer_Tick);
            // 
            // ThongKeTimer
            // 
            this.ThongKeTimer.Interval = 10;
            this.ThongKeTimer.Tick += new System.EventHandler(this.ThongKeTimer_Tick);
            // 
            // LichTimer
            // 
            this.LichTimer.Enabled = true;
            this.LichTimer.Interval = 10;
            this.LichTimer.Tick += new System.EventHandler(this.LichTimer_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnlMenu);
            this.flowLayoutPanel1.Controls.Add(this.pnlHomeContainer);
            this.flowLayoutPanel1.Controls.Add(this.pnlLich);
            this.flowLayoutPanel1.Controls.Add(this.pnlThongKe);
            this.flowLayoutPanel1.Controls.Add(this.pnlSetting);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(161, 672);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(161, 672);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(161, 672);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // pnlSetting
            // 
            this.pnlSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(55)))));
            this.pnlSetting.Controls.Add(this.button2);
            this.pnlSetting.Controls.Add(this.button6);
            this.pnlSetting.Location = new System.Drawing.Point(0, 151);
            this.pnlSetting.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSetting.MaximumSize = new System.Drawing.Size(161, 84);
            this.pnlSetting.MinimumSize = new System.Drawing.Size(159, 35);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(161, 84);
            this.pnlSetting.TabIndex = 3;
            // 
            // pnlDesTop
            // 
            this.pnlDesTop.AutoSize = true;
            this.pnlDesTop.Location = new System.Drawing.Point(164, 2);
            this.pnlDesTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDesTop.MaximumSize = new System.Drawing.Size(1100, 675);
            this.pnlDesTop.Name = "pnlDesTop";
            this.pnlDesTop.Size = new System.Drawing.Size(1100, 672);
            this.pnlDesTop.TabIndex = 3;
            // 
            // Timewise
            // 
            this.Timewise.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.Timewise.BalloonTipText = "Có Thông Báo";
            this.Timewise.BalloonTipTitle = "Thông Báo";
            this.Timewise.ContextMenuStrip = this.contextMenuStrip1;
            this.Timewise.Icon = ((System.Drawing.Icon)(resources.GetObject("Timewise.Icon")));
            this.Timewise.Text = "Timewise";
            this.Timewise.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuStopMusic,
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 70);
            this.contextMenuStrip1.Text = "Open";
            // 
            // toolStripMenuStopMusic
            // 
            this.toolStripMenuStopMusic.Name = "toolStripMenuStopMusic";
            this.toolStripMenuStopMusic.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuStopMusic.Text = "Dừng âm thanh";
            this.toolStripMenuStopMusic.Visible = false;
            this.toolStripMenuStopMusic.Click += new System.EventHandler(this.toolStripMenuStopMusic_Click);
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItemOpen.Text = "Open";
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // SettingTimer
            // 
            this.SettingTimer.Enabled = true;
            this.SettingTimer.Interval = 10;
            this.SettingTimer.Tick += new System.EventHandler(this.SettingTimer_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(66)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, -2);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(157, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "          Trang chủ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(66)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(159, 35);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "           Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(55)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(2, 105);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(159, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "     Tài khoản";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_3);
            // 
            // btnLichToday
            // 
            this.btnLichToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(55)))));
            this.btnLichToday.FlatAppearance.BorderSize = 0;
            this.btnLichToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichToday.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichToday.ForeColor = System.Drawing.Color.White;
            this.btnLichToday.Image = ((System.Drawing.Image)(resources.GetObject("btnLichToday.Image")));
            this.btnLichToday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichToday.Location = new System.Drawing.Point(2, 140);
            this.btnLichToday.Margin = new System.Windows.Forms.Padding(0);
            this.btnLichToday.Name = "btnLichToday";
            this.btnLichToday.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnLichToday.Size = new System.Drawing.Size(159, 35);
            this.btnLichToday.TabIndex = 2;
            this.btnLichToday.Text = "     Hôm nay";
            this.btnLichToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichToday.UseVisualStyleBackColor = false;
            this.btnLichToday.Visible = false;
            this.btnLichToday.Click += new System.EventHandler(this.btnLichToday_Click);
            // 
            // btnLichThi
            // 
            this.btnLichThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(55)))));
            this.btnLichThi.FlatAppearance.BorderSize = 0;
            this.btnLichThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichThi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichThi.ForeColor = System.Drawing.Color.White;
            this.btnLichThi.Image = ((System.Drawing.Image)(resources.GetObject("btnLichThi.Image")));
            this.btnLichThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichThi.Location = new System.Drawing.Point(0, 70);
            this.btnLichThi.Margin = new System.Windows.Forms.Padding(0);
            this.btnLichThi.Name = "btnLichThi";
            this.btnLichThi.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnLichThi.Size = new System.Drawing.Size(159, 35);
            this.btnLichThi.TabIndex = 2;
            this.btnLichThi.Text = "     Lịch thi";
            this.btnLichThi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichThi.UseVisualStyleBackColor = false;
            this.btnLichThi.Click += new System.EventHandler(this.btnLichThi_Click);
            // 
            // btnLichHoc
            // 
            this.btnLichHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(55)))));
            this.btnLichHoc.FlatAppearance.BorderSize = 0;
            this.btnLichHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichHoc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichHoc.ForeColor = System.Drawing.Color.White;
            this.btnLichHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLichHoc.Image")));
            this.btnLichHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichHoc.Location = new System.Drawing.Point(0, 35);
            this.btnLichHoc.Margin = new System.Windows.Forms.Padding(0);
            this.btnLichHoc.Name = "btnLichHoc";
            this.btnLichHoc.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnLichHoc.Size = new System.Drawing.Size(159, 35);
            this.btnLichHoc.TabIndex = 2;
            this.btnLichHoc.Text = "     Lịch học";
            this.btnLichHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichHoc.UseVisualStyleBackColor = false;
            this.btnLichHoc.Click += new System.EventHandler(this.btnLichHoc_Click_1);
            // 
            // btnThemLich
            // 
            this.btnThemLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(55)))));
            this.btnThemLich.FlatAppearance.BorderSize = 0;
            this.btnThemLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLich.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLich.ForeColor = System.Drawing.Color.White;
            this.btnThemLich.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLich.Image")));
            this.btnThemLich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLich.Location = new System.Drawing.Point(0, 105);
            this.btnThemLich.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemLich.Name = "btnThemLich";
            this.btnThemLich.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnThemLich.Size = new System.Drawing.Size(159, 35);
            this.btnThemLich.TabIndex = 2;
            this.btnThemLich.Text = "     Thêm lịch";
            this.btnThemLich.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLich.UseVisualStyleBackColor = false;
            this.btnThemLich.Click += new System.EventHandler(this.btnThemLich_Click);
            // 
            // btnDSLN
            // 
            this.btnDSLN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(55)))));
            this.btnDSLN.FlatAppearance.BorderSize = 0;
            this.btnDSLN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSLN.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSLN.ForeColor = System.Drawing.Color.White;
            this.btnDSLN.Image = ((System.Drawing.Image)(resources.GetObject("btnDSLN.Image")));
            this.btnDSLN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSLN.Location = new System.Drawing.Point(0, 70);
            this.btnDSLN.Margin = new System.Windows.Forms.Padding(0);
            this.btnDSLN.Name = "btnDSLN";
            this.btnDSLN.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnDSLN.Size = new System.Drawing.Size(159, 35);
            this.btnDSLN.TabIndex = 3;
            this.btnDSLN.Text = "     Lịch theo tháng";
            this.btnDSLN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSLN.UseVisualStyleBackColor = false;
            this.btnDSLN.Click += new System.EventHandler(this.btnDSLN_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(55)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 35);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(159, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "     Danh sách lịch";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLich
            // 
            this.btnLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(66)))));
            this.btnLich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLich.FlatAppearance.BorderSize = 0;
            this.btnLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLich.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLich.ForeColor = System.Drawing.Color.White;
            this.btnLich.Image = ((System.Drawing.Image)(resources.GetObject("btnLich.Image")));
            this.btnLich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLich.Location = new System.Drawing.Point(0, 0);
            this.btnLich.Margin = new System.Windows.Forms.Padding(0);
            this.btnLich.Name = "btnLich";
            this.btnLich.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnLich.Size = new System.Drawing.Size(159, 35);
            this.btnLich.TabIndex = 2;
            this.btnLich.Text = "           Lịch nhắc";
            this.btnLich.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLich.UseVisualStyleBackColor = false;
            this.btnLich.Click += new System.EventHandler(this.btnLich_Click);
            // 
            // btnXepLoai
            // 
            this.btnXepLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(55)))));
            this.btnXepLoai.FlatAppearance.BorderSize = 0;
            this.btnXepLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXepLoai.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXepLoai.ForeColor = System.Drawing.Color.White;
            this.btnXepLoai.Image = ((System.Drawing.Image)(resources.GetObject("btnXepLoai.Image")));
            this.btnXepLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXepLoai.Location = new System.Drawing.Point(0, 70);
            this.btnXepLoai.Margin = new System.Windows.Forms.Padding(0);
            this.btnXepLoai.Name = "btnXepLoai";
            this.btnXepLoai.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnXepLoai.Size = new System.Drawing.Size(159, 35);
            this.btnXepLoai.TabIndex = 2;
            this.btnXepLoai.Text = "     Xếp loại ";
            this.btnXepLoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXepLoai.UseVisualStyleBackColor = false;
            this.btnXepLoai.Click += new System.EventHandler(this.btnXepLoai_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(66)))));
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 0);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(0);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(159, 35);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "           Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnSuKien
            // 
            this.btnSuKien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(55)))));
            this.btnSuKien.FlatAppearance.BorderSize = 0;
            this.btnSuKien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuKien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuKien.ForeColor = System.Drawing.Color.White;
            this.btnSuKien.Image = ((System.Drawing.Image)(resources.GetObject("btnSuKien.Image")));
            this.btnSuKien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuKien.Location = new System.Drawing.Point(0, 35);
            this.btnSuKien.Margin = new System.Windows.Forms.Padding(0);
            this.btnSuKien.Name = "btnSuKien";
            this.btnSuKien.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnSuKien.Size = new System.Drawing.Size(159, 35);
            this.btnSuKien.TabIndex = 2;
            this.btnSuKien.Text = "     Sự kiện";
            this.btnSuKien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuKien.UseVisualStyleBackColor = false;
            this.btnSuKien.Click += new System.EventHandler(this.btnSuKien_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(55)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 35);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(159, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "           Sửa màu";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(66)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::GUI.Properties.Resources.icons8_settings_26__1_;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(159, 35);
            this.button6.TabIndex = 2;
            this.button6.Text = "           Cài đặt";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(1)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1266, 681);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlDesTop);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1290, 726);
            this.MinimumSize = new System.Drawing.Size(1280, 712);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time wise";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlHomeContainer.ResumeLayout(false);
            this.pnlLich.ResumeLayout(false);
            this.pnlThongKe.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlSetting.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlHomeContainer;
        private System.Windows.Forms.Button btnLichHoc;
        private System.Windows.Forms.Timer HomeTimer;
        private System.Windows.Forms.Panel pnlThongKe;
        private System.Windows.Forms.Button btnSuKien;
        private System.Windows.Forms.Button btnXepLoai;
        private System.Windows.Forms.Timer ThongKeTimer;
        private System.Windows.Forms.Panel pnlLich;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnThemLich;
        private System.Windows.Forms.Button btnLich;
        private System.Windows.Forms.Timer LichTimer;
        private System.Windows.Forms.Button btnLichThi;
        private System.Windows.Forms.Button btnLichToday;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Panel pnlDesTop;
        public System.Windows.Forms.Button btnDSLN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlSetting;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NotifyIcon Timewise;
        public System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuStopMusic;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.Timer SettingTimer;
    }
}

