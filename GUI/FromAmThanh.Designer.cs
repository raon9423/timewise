namespace GUI
{
    partial class FromAmThanh
    {
        private System.ComponentModel.IContainer components = null;
    //    private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnAddMusic;
        private System.Windows.Forms.ListBox listBoxMusic;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnChooseSound;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromAmThanh));
            this.btnAddMusic = new System.Windows.Forms.Button();
            this.listBoxMusic = new System.Windows.Forms.ListBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnChooseSound = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddMusic
            // 
            this.btnAddMusic.BackColor = System.Drawing.Color.White;
            this.btnAddMusic.Location = new System.Drawing.Point(12, 12);
            this.btnAddMusic.Name = "btnAddMusic";
            this.btnAddMusic.Size = new System.Drawing.Size(100, 23);
            this.btnAddMusic.TabIndex = 5;
            this.btnAddMusic.Text = "Thêm âm thanh";
            this.btnAddMusic.UseVisualStyleBackColor = false;
            this.btnAddMusic.Click += new System.EventHandler(this.btnAddMusic_Click);
            // 
            // listBoxMusic
            // 
            this.listBoxMusic.FormattingEnabled = true;
            this.listBoxMusic.Location = new System.Drawing.Point(12, 41);
            this.listBoxMusic.Name = "listBoxMusic";
            this.listBoxMusic.Size = new System.Drawing.Size(380, 147);
            this.listBoxMusic.TabIndex = 4;
            this.listBoxMusic.SelectedIndexChanged += new System.EventHandler(this.listBoxMusic_SelectedIndexChanged);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.White;
            this.btnRecord.Location = new System.Drawing.Point(118, 12);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(81, 23);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Text = "Ghi âm";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(205, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(100, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Mở âm";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnChooseSound
            // 
            this.btnChooseSound.BackColor = System.Drawing.Color.White;
            this.btnChooseSound.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnChooseSound.Location = new System.Drawing.Point(292, 194);
            this.btnChooseSound.Name = "btnChooseSound";
            this.btnChooseSound.Size = new System.Drawing.Size(100, 23);
            this.btnChooseSound.TabIndex = 0;
            this.btnChooseSound.Text = "Chọn âm thanh";
            this.btnChooseSound.UseVisualStyleBackColor = false;
            this.btnChooseSound.Click += new System.EventHandler(this.btnChooseSound_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(311, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xóa âm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FromAmThanh
            // 
            this.AcceptButton = this.btnChooseSound;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(405, 224);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChooseSound);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.listBoxMusic);
            this.Controls.Add(this.btnAddMusic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(421, 263);
            this.MinimumSize = new System.Drawing.Size(421, 263);
            this.Name = "FromAmThanh";
            this.Text = "Chọn âm thanh";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FromAmThanh_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button button1;
    }
}
