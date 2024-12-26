using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Reminder
    {
            public int ReminderId { get; set; }
            public DateTime ReminderTime { get; set; }
            public string Content { get; set; }
            public string Summary { get; set; }
            public string RecordingPath { get; set; }
            public bool IsViewed { get; set; }
            public int UserId { get; set; }
            public string TitleColor { get; set; }
            public string BackgroundColor { get; set; }
    }
}
