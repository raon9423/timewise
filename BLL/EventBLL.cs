using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EventBLL
    {
        EventDAL eventDAL = new EventDAL();
        public List<SuKien> ListEvent(int userId)
        {
            return eventDAL.ListEvent(userId);
        }
        public List<SuKien> SuKienTheoNgay(DateTime dateTime, int userId)
        {
            return eventDAL.TimSKTheoNgay(dateTime, userId); 
        }
        public bool AddEvent(SuKien e)
        {
            return eventDAL.AddEvent(e);
        }
        public bool UpdateEvent(SuKien e)
        {
            return eventDAL.UpdateEvent(e);
        }

        public bool DeleteEvent(SuKien e)
        {
            return eventDAL.DeleteEvent(e);
        }
    }
}
