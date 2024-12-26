using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SuKien
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventTime { get; set; }
        public string  Location { get; set; }
        public int UserId { get; set; }
        public int Score { get; set; }
        public string Note { get; set; }
        public string RecordingPath { get; set; }   
        public string TitleColor { get; set; }
        public string BackgroundColor { get; set; }

        public override string ToString()
        {
            //return $"Mã Sự kiện: {EventId}\r\n" +
            //  $"Tên Sự kiện: {EventName}\r\n" +
            //  $"Ngày Sự kiện: {EventDate.ToString("dd/MM/yyyy")}\r\n" +
            //  $"Thời gian Sự kiện: {EventTime}\r\n" +
            //  $"Địa điểm: {Location}\r\n" +
            //  $"ID Người dùng: {UserId}\r\n" +
            //  $"Điểm: {Score}\r\n" +
            //  $"Ghi chú: {Note}\r\n" +
            //  $"Đường dẫn Ghi âm: {RecordingPath}\r\n" +
            //  $"Màu Tiêu đề: {TitleColor}\r\n" +
            //  $"Màu Nền: {BackgroundColor}";
            return
              $"Tên Sự kiện: {EventName}<br/> Ngày Sự kiện: {EventDate.ToString("dd/MM/yyyy")} <br/>Thời gian Sự kiện: {EventTime} <br/> Địa điểm: {Location} <br/>Điểm: {Score} <br/>Chi tiết: {Note}";
        }
    }
}
