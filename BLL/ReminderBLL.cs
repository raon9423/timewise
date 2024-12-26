using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ReminderBLL
    {
        ReminderDAL reminderDAL = new ReminderDAL();

        public List<Reminder> DS_Reminder()
        {
            return reminderDAL.DS_Reminder();
        }
        public bool AddReminder(Reminder reminder)
        {
            return reminderDAL.AddReminder(reminder);
        }
        // XOng roi ok đa tạ 
    }
}
