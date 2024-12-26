using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DanhSachLichNhac_ChinhSua : UserControl
    {
        public int UserId;
        public static DanhSachLichNhac_ChinhSua _instance;
        public static DanhSachLichNhac_ChinhSua Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DanhSachLichNhac_ChinhSua();
                return _instance;
            }
        }
        public DanhSachLichNhac_ChinhSua()
        {
            InitializeComponent();
            lsvLichNhac.SelectedIndexChanged += LsvDSSelectedIndexChanged;
        } 
        public DanhSachLichNhac_ChinhSua(int id)
        {
            InitializeComponent();
            lsvLichNhac.SelectedIndexChanged += LsvDSSelectedIndexChanged;
            this.UserId = id;
        }
        public void LoadDSSK_ListView()
        {
            lsvLichNhac.Items.Clear();
            EventBLL eventBLL = new EventBLL();
            var events = eventBLL.ListEvent(UserId);
            foreach (var ev in events)
            {
                ListViewItem item = new ListViewItem(ev.EventId.ToString());
                item.SubItems.Add(ev.EventName);
                item.SubItems.Add(ev.EventDate.ToString("dd/MM/yyyy"));
                item.SubItems.Add(ev.EventTime);
                item.SubItems.Add(ev.Location);
                item.SubItems.Add(ev.Score.ToString());
                item.SubItems.Add(ev.Note);
                item.SubItems.Add(ev.RecordingPath);
                item.SubItems.Add(ev.TitleColor);
                item.SubItems.Add(ev.BackgroundColor);
                AddItemToListView(item);
            }
        }
        public void AddItemToListView(ListViewItem item)
        {
            lsvLichNhac.Items.Add(item);
        }
        private DateTime ConvertToDateTime(string dateString)
        {
            if (string.IsNullOrEmpty(dateString)) return default;
            // Tạo một mảng các chuỗi tách ra từ dateString bằng dấu "/"
            string[] dateParts = dateString.Split('/');

            // Kiểm tra xem dateString có đúng định dạng không
            if (dateParts.Length != 3)
            {
                throw new ArgumentException("Chuỗi ngày không đúng định dạng.");
            }

            // Lấy ra ngày, tháng, năm từ mảng dateParts
            int day = int.Parse(dateParts[0]);
            int month = int.Parse(dateParts[1]);
            int year = int.Parse(dateParts[2]);

            // Tạo một đối tượng DateTime từ ngày, tháng, năm
            DateTime date = new DateTime(year, month, day);

            return date;
        }
        private void LsvDSSelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvLichNhac.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvLichNhac.SelectedItems[0];
                var Column1Value = selectedItem.SubItems[0].Text;
                var Column2Value = selectedItem.SubItems[1].Text;
                var Column3Value = ConvertToDateTime(selectedItem.SubItems[2].Text);
                var Column4Value = selectedItem.SubItems[3].Text;
                var Column5Value = selectedItem.SubItems[4].Text;
                var Column6Value = selectedItem.SubItems[5].Text;
                var Column7Value = selectedItem.SubItems[6].Text;
                var Column8Value = selectedItem.SubItems[7].Text;
                var Column9Value = selectedItem.SubItems[8].Text;
                var Column10Value = selectedItem.SubItems[9].Text;
                using (FormSuaLichNhac formSuaLN = new FormSuaLichNhac(UserId, Column1Value, Column2Value, Column3Value, Column4Value, Column5Value, Column6Value, Column7Value, Column8Value, Column9Value,Column10Value))
                {
                        if (formSuaLN.ShowDialog() == DialogResult.OK)
                        {
                            formSuaLN.Close();
                    }


                }

            }


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDSSK_ListView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DanhSachLichNhac_ChinhSua_Load(object sender, EventArgs e)
        {
            LoadDSSK_ListView();
        }
    }
}
