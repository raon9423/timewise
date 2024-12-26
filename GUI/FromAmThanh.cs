using BLL;
using DTO;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FromAmThanh : Form
    {
        private ListBox listBox;
        private Button selectButton;
        private List<string> musicList = new List<string>();
        private WaveOutEvent outputDevice;
        private string pathResult;
        private int UserId = 0;
        AmThanhBLL amThanhBLL;
        List<AmThanh> listAmThanh;

        private AudioFileReader audioFile;

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        private object selectedPath;
        private string directoryPath;

        public FromAmThanh()
        {
            InitializeComponent();
            outputDevice = new WaveOutEvent();
        }
        public FromAmThanh(int userid)
        {
            InitializeComponent();
            outputDevice = new WaveOutEvent();
            this.UserId = userid;
            CenterToScreen();
            amThanhBLL = new AmThanhBLL();
            listAmThanh = amThanhBLL.DS_AmThanh(UserId);
            foreach (AmThanh at in listAmThanh)
            {
                musicList.Add(at.Path);
            }
        }

        // Khai báo một List<string> để lưu các đường dẫn của các tệp âm thanh

        private void btnAddMusic_Click(object sender, EventArgs e)
        {


            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Music Files|*.mp3;*.wav;*.ogg|All Files|*.*";
            openFileDialog.Filter = "Audio files (*.mp3;*.wav;*.wma)|*.mp3;*.wav;*.wma|All files (*.*)|*.*";
            openFileDialog.Multiselect = true;
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            AmThanhBLL amThanhBLL = new AmThanhBLL();


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in openFileDialog.FileNames)
                {
                    // Lưu đường dẫn của tệp âm thanh vào danh sách
                    musicList.Add(Path.GetFileName(filename));


                    // Hiển thị đường dẫn tệp âm thanh trong ListBox
                    if (!File.Exists(Path.GetFileName(filename)))
                    {
                        listBoxMusic.Items.Add(Path.GetFileName(filename));
                        AmThanh amThanh = new AmThanh();
                        amThanh.UserId = UserId;
                        amThanh.Path = Path.GetFileName(filename);
                        amThanhBLL.AddAmThanh(amThanh);
                        listAmThanh.Add(amThanh);
                    }

                    string destinationPath = Path.Combine(GetCurrentExecutingDirectory(), Path.GetFileName(filename));
                    // Copy the selected file to the /bin/Debug folder of the project
                    File.Copy(filename, destinationPath, true);

                }
            }
        }

        private string GetCurrentExecutingDirectory()
        {
            // Lấy đường dẫn của tệp thực thi (executable file) của dự án
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }
        private void listBoxMusic_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveFile()
        {

            if (File.Exists(saveFileDialog1.FileName))
            {
                string destinationPath = Path.Combine(GetCurrentExecutingDirectory(), Path.GetFileName(Path.GetFileName(saveFileDialog1.FileName)));
                // Copy the selected file to the /bin/Debug folder of the project
                File.Copy(saveFileDialog1.FileName, destinationPath, true);
                btnRecord.Text = "Ghi âm";
            }
            else
                btnRecord.Text = "Đang lưu";


        }
        //private async Task SaveFileAsync()
        //{
        //        if (File.Exists(saveFileDialog1.FileName))
        //        {
        //            string destinationPath = Path.Combine(GetCurrentExecutingDirectory(), Path.GetFileName(Path.GetFileName(saveFileDialog1.FileName)));
        //            // Copy the selected file to the /bin/Debug folder of the project
        //            await FileCopyAsync(saveFileDialog1.FileName, destinationPath);
        //            if (File.Exists(destinationPath))
        //            {
        //                btnRecord.Text = "Ghi âm";
        //            }

        //        }
        //        else
        //        {
        //            btnRecord.Text = "Đang lưu";
        //        }


        //}
        //private Task FileCopyAsync(string sourceFileName, string destFileName)
        //{
        //    return Task.Run(() => File.Copy(sourceFileName, destFileName, true));
        //}

        #region ghi âm cũ
        private async Task SaveFileAsync()
        {
            if (File.Exists(saveFileDialog1.FileName))
            {
                string destinationPath = Path.Combine(GetCurrentExecutingDirectory(), Path.GetFileName(saveFileDialog1.FileName));
                // Sao chép tệp được chọn đến thư mục /bin/Debug của dự án
                bool success = await FileCopyAsync(saveFileDialog1.FileName, destinationPath);
                if (success)
                {
                    btnRecord.Text = "Ghi âm";
                }
                else
                {
                    MessageBox.Show("Lỗi khi lưu tệp");
                }
            }
            else
            {
                btnRecord.Text = "Đang lưu";
            }
        }

        private async Task<bool> FileCopyAsync(string sourceFileName, string destFileName)
        {
            try
            {
                await Task.Run(() => File.Copy(sourceFileName, destFileName, true));
                return true; // Sao chép thành công
            }
            catch (Exception ex)
            {
                // Xử lý lỗi khi sao chép
                Console.WriteLine("Lỗi khi sao chép tệp: " + ex.Message);
                return false; // Sao chép thất bại
            }
        }


        private async void btnRecord_Click(object sender, EventArgs e)
        {
            if (btnRecord.Text == "Ghi âm")
            {
                record("open new Type waveaudio Alias recsound", "", 0, 0);
                record("record recsound", "", 0, 0);

                btnRecord.Text = "Dừng ghi";
            }
            else
            {
                saveFileDialog1.Filter = "Audio files (.wav)|*.wav";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    record("save recsound " + saveFileDialog1.FileName, "", 0, 0);
                    record("close recsound", "", 0, 0);


                    //string fileAdd = Path.GetFileName(saveFileDialog1.FileName);

                    //musicList.Add(fileAdd); // add vào danh sách
                    //listBoxMusic.Items.Add(fileAdd);// add vào listbox
                    //AmThanh at = new AmThanh();
                    //at.Path = fileAdd;
                    //at.UserId = UserId;
                    //amThanhBLL.AddAmThanh(at); // lưu database

                    //while (true)
                    //{
                    //    if (File.Exists(saveFileDialog1.FileName))
                    //    {
                    //        string destinationPath = Path.Combine(GetCurrentExecutingDirectory(), Path.GetFileName(Path.GetFileName(saveFileDialog1.FileName)));
                    //        // Copy the selected file to the /bin/Debug folder of the project
                    //        File.Copy(saveFileDialog1.FileName, destinationPath, true);
                    //        break;
                    //    }
                    //    btnRecord.Text = "Đang lưu";

                    //}
                    //while (!File.Exists(Path.Combine(GetCurrentExecutingDirectory(), Path.GetFileName(Path.GetFileName(saveFileDialog1.FileName)))))
                    //    if (InvokeRequired)
                    //    {

                    //        Invoke(new MethodInvoker(delegate
                    //        {
                    //            _ = SaveFileAsync();
                    //        }));
                    //    }
                    //    else
                    //    {
                    //        _ = SaveFileAsync();

                    //    }
                    //while (!File.Exists(Path.Combine(GetCurrentExecutingDirectory(), Path.GetFileName(Path.GetFileName(saveFileDialog1.FileName)))))
                    await SaveFileAsync();
                    if (!File.Exists(Path.GetFileName(saveFileDialog1.FileName)))
                        MessageBox.Show("Không lưu được File");
                    else
                    {
                        string fileAdd = Path.GetFileName(saveFileDialog1.FileName);

                        musicList.Add(fileAdd); // add vào danh sách
                        listBoxMusic.Items.Add(fileAdd);// add vào listbox
                        AmThanh at = new AmThanh();
                        at.Path = fileAdd;
                        at.UserId = UserId;
                        amThanhBLL.AddAmThanh(at); // lưu database
                        listAmThanh.Add(at);
                    }

                }

                //btnRecord.Text = "Ghi âm";

            }

        }

        #endregion
        //private async Task SaveFileAsync()
        //{
        //    if (File.Exists(saveFileDialog1.FileName))
        //    {
        //        string destinationPath = Path.Combine(GetCurrentExecutingDirectory(), Path.GetFileName(saveFileDialog1.FileName));
        //        bool success = await FileCopyAsync(saveFileDialog1.FileName, destinationPath);
        //        if (success)
        //        {
        //            btnRecord.Text = "Ghi âm";
        //        }
        //        else
        //        {
        //            MessageBox.Show("Lỗi khi lưu tệp");
        //        }
        //    }
        //    else
        //    {
        //        btnRecord.Text = "Đang lưu";
        //    }
        //}

        //private async void btnRecord_Click(object sender, EventArgs e)
        //{
        //    if (btnRecord.Text == "Ghi âm")
        //    {
        //        record("open new Type waveaudio Alias recsound", "", 0, 0);
        //        record("record recsound", "", 0, 0);
        //        btnRecord.Text = "Dừng ghi";
        //    }
        //    else
        //    {
        //        saveFileDialog1.Filter = "Audio files (.wav)|*.wav";
        //        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        //        {
        //            record("save recsound " + saveFileDialog1.FileName, "", 0, 0);
        //            record("close recsound", "", 0, 0);

        //            await SaveFileAsync(); // Chờ cho phương thức lưu tệp kết thúc

        //            //if (!File.Exists(saveFileDialog1.FileName))
        //            //{
        //            //    MessageBox.Show("Không lưu được File");
        //            //}
        //            //else
        //            //{
        //            string fileAdd = Path.GetFileName(saveFileDialog1.FileName);
        //            musicList.Add(fileAdd); // add vào danh sách
        //            listBoxMusic.Items.Add(fileAdd);// add vào listbox
        //            AmThanh at = new AmThanh();
        //            at.Path = fileAdd;
        //            at.UserId = UserId;
        //            amThanhBLL.AddAmThanh(at); // lưu database
        //            listAmThanh.Add(at);
        //            //}
        //        }
        //    }
        //}

        //private async Task<bool> FileCopyAsync(string sourceFileName, string destFileName)
        //{
        //    try
        //    {
        //        await Task.Run(() => File.Copy(sourceFileName, destFileName, true));
        //        return true; // Sao chép thành công
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Lỗi khi sao chép tệp: " + ex.Message);
        //        return false; // Sao chép thất bại
        //    }
        //}


        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (btnPlay.Text == "Mở âm")
            {
                if (listBoxMusic.SelectedItem != null)
                {
                    string selectedFile = listAmThanh[listBoxMusic.SelectedIndex].Path;
                    try
                    {
                        if (outputDevice != null)
                        {
                            outputDevice.Stop();
                            outputDevice.Dispose();
                            outputDevice = null;
                        }
                        outputDevice = new WaveOutEvent();
                        audioFile = new AudioFileReader(selectedFile);
                        outputDevice.Init(audioFile);
                        outputDevice.Play();

                        btnPlay.Text = "Tắt âm";

                    }
                    catch { }

                }
                else MessageBox.Show("Vui lòng chọn âm thanh !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                outputDevice.Stop();
                btnPlay.Text = "Mở âm";
            }
        }
        private void PlaySound(string soundFilePath)
        {
            if (System.IO.File.Exists(soundFilePath))
            {
                SoundPlayer player = new SoundPlayer(soundFilePath);
                player.Play();
            }
            else
            {
                MessageBox.Show("Không thể tìm thấy tệp âm thanh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnChooseSound_Click(object sender, EventArgs e)
        {

            //string selectedFileName = listBoxMusic.SelectedItem.ToString();
            //string selectedPath = Path.Combine(selectedFileName);
            //if (listBoxMusic.SelectedItem == null)
            //{
            //    MessageBox.Show("Vui lòng chọn âm thanh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            string selectedPath = "";
            if (listBoxMusic.SelectedItem != null)
                selectedPath = listBoxMusic.SelectedItem.ToString();
            pathResult = selectedPath;
            //this.AcceptButton = btnChooseSound;
            //btnChooseSound.DialogResult = DialogResult.OK;

        }
        public string GetPath()
        {
            return this.pathResult;
        }

        private void FromAmThanh_Load(object sender, EventArgs e)
        {

            foreach (AmThanh amThanh in listAmThanh)
            {
                listBoxMusic.Items.Add(amThanh.Path);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxMusic.SelectedItem != null)
            {
                string selectedFile = listAmThanh[listBoxMusic.SelectedIndex].Path;

                if (MessageBox.Show("Bạn có chắc muốn xóa âm thanh này? ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (InvokeRequired)
                    {

                        Invoke(new MethodInvoker(delegate
                        {
                            try
                            {
                                File.Delete(selectedFile);
                                listAmThanh.RemoveAt(listBoxMusic.SelectedIndex);
                                listBoxMusic.Items.Remove(selectedFile);
                                amThanhBLL.DeleteAmThanhByPath(selectedFile);
                                listBoxMusic.SelectedItems.Clear();
                                listBoxMusic.SelectedItem = null;
                            }
                            catch { }
                        }));
                    }
                    else
                    {
                        try
                        {
                            File.Delete(selectedFile);
                            listAmThanh.RemoveAt(listBoxMusic.SelectedIndex);
                            listBoxMusic.Items.Remove(selectedFile);
                            amThanhBLL.DeleteAmThanhByPath(selectedFile);
                            listBoxMusic.SelectedItems.Clear();
                            listBoxMusic.SelectedItem = null;
                        } catch {
                        }
                        

                    }

                }
            }
            else MessageBox.Show("Vui lòng chọn âm thanh !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}