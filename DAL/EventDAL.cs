using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class EventDAL : Database
    {
        public List<SuKien> ListEvent(int uId)
        {
            List<SuKien> events = new List<SuKien>();
            OpenConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From Events where UserId = @uId";
            cmd.Connection = sqlConnection;
            cmd.Parameters.AddWithValue("@uId", uId);


            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int eventId = reader.GetInt32(0);
                string eventName = reader.GetString(1);
                DateTime eventDate = reader.GetDateTime(2);
                string eventTime = reader.GetString(3);
                string eventLocation = reader.GetString(4);
                int userId = reader.GetInt32(5);
                int diemRL = reader.GetInt32(6);
                string note = reader.GetString(7);
                string recordingPath = reader.GetString(8);
                string titleColor = reader.GetString(9);
                string backgroundColor = reader.GetString(10);

                SuKien ev = new SuKien();

                ev.EventId = eventId;
                ev.EventName = eventName;
                ev.EventDate = eventDate;
                ev.EventTime = eventTime;
                ev.Location = eventLocation;
                ev.UserId = userId;
                ev.Score = diemRL;
                ev.Note = note;
                ev.RecordingPath = recordingPath;
                ev.TitleColor = titleColor;
                ev.BackgroundColor = backgroundColor;
                events.Add(ev);
            }
            reader.Close();
            return events;
        }

        public bool AddEvent(SuKien ev)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Insert into Events Values (@name, @date, @time, @location, @userId, @score, @note, @record, @titlecolor, @backgroundcolor)";

            SqlParameter parName = new SqlParameter("@name",SqlDbType.NVarChar);
            parName.Value = ev.EventName;
            sqlCommand.Parameters.Add(parName);

            SqlParameter pardate = new SqlParameter("@date", SqlDbType.DateTime);
            pardate.Value = ev.EventDate;
            sqlCommand.Parameters.Add(pardate);

            SqlParameter parTime = new SqlParameter("@time", SqlDbType.VarChar);
            parTime.Value = ev.EventTime;
            sqlCommand.Parameters.Add(parTime);

            SqlParameter parLocation = new SqlParameter("@location", SqlDbType.NVarChar);
            parLocation.Value = ev.Location;
            sqlCommand.Parameters.Add(parLocation);

            SqlParameter parUserId = new SqlParameter("@userId", SqlDbType.Int);
            parUserId.Value = ev.UserId;
            sqlCommand.Parameters.Add(parUserId);

            SqlParameter parScore = new SqlParameter("@score", SqlDbType.Int);
            parScore.Value = ev.Score;
            sqlCommand.Parameters.Add(parScore);
            
            SqlParameter parNote = new SqlParameter("@note", SqlDbType.NVarChar);
            parNote.Value = ev.Note;
            sqlCommand.Parameters.Add(parNote);

            SqlParameter parRecord = new SqlParameter("@record", SqlDbType.NVarChar);
            parRecord.Value = ev.RecordingPath;
            sqlCommand.Parameters.Add(parRecord);

            SqlParameter partitleColor = new SqlParameter("@titlecolor", SqlDbType.NVarChar);
            partitleColor.Value = ev.TitleColor;
            sqlCommand.Parameters.Add(partitleColor);

            SqlParameter parbackgroundColor = new SqlParameter("@backgroundcolor", SqlDbType.NVarChar);
            parbackgroundColor.Value = ev.BackgroundColor;
            sqlCommand.Parameters.Add(parbackgroundColor);

            sqlCommand.Connection = sqlConnection;

            try
            {
                int check = sqlCommand.ExecuteNonQuery();
                if (check > 0)
                    return true;
            }
            catch
            {

            }
            return false;
        }

        public bool UpdateEvent(SuKien ev)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Events set EventName = @name, Eventdate = @date, EventTime = @time, Location = @location, Score = @score, Note = @note, RecordingPath = @record, TitleColor = @titlecolor, BackgroundColor =@backcolor where EventId = @id and UserId = @userId";
            //sqlCommand.CommandText = "Update Events set EventName = @name, Eventdate = @date, EventTime = @time, Location = @location, Score = @score, Note = @note, RecordingPath = @record, TitleColor = @titlecolor, BackgroundColor =@backcolor where EventId = @id";

            SqlParameter parId = new SqlParameter("@id", SqlDbType.Int);
            parId.Value = ev.EventId;
            sqlCommand.Parameters.Add(parId);

            SqlParameter parName = new SqlParameter("@name", SqlDbType.NVarChar);
            parName.Value = ev.EventName;
            sqlCommand.Parameters.Add(parName);

            SqlParameter pardate = new SqlParameter("@date", SqlDbType.DateTime);
            pardate.Value = ev.EventDate;
            sqlCommand.Parameters.Add(pardate);

            SqlParameter parTime = new SqlParameter("@time", SqlDbType.VarChar);
            parTime.Value = ev.EventTime;
            sqlCommand.Parameters.Add(parTime);

            SqlParameter parLocation = new SqlParameter("@location", SqlDbType.NVarChar);
            parLocation.Value = ev.Location;
            sqlCommand.Parameters.Add(parLocation);

            SqlParameter parScore = new SqlParameter("@score", SqlDbType.Int);
            parScore.Value = ev.Score;
            sqlCommand.Parameters.Add(parScore);

            SqlParameter parNote = new SqlParameter("@note", SqlDbType.NVarChar);
            parNote.Value = ev.Note;
            sqlCommand.Parameters.Add(parNote);

            SqlParameter parRecord = new SqlParameter("@record", SqlDbType.NVarChar);
            parRecord.Value = ev.RecordingPath;
            sqlCommand.Parameters.Add(parRecord);

            SqlParameter parUserId = new SqlParameter("@userId", SqlDbType.Int);
            parUserId.Value = ev.UserId;
            sqlCommand.Parameters.Add(parUserId);

            SqlParameter parTitleColor = new SqlParameter("@titlecolor", SqlDbType.NVarChar);
            parTitleColor.Value = ev.TitleColor;
            sqlCommand.Parameters.Add(parTitleColor);

            SqlParameter parBackcolor = new SqlParameter("@backcolor", SqlDbType.NVarChar);
            parBackcolor.Value = ev.BackgroundColor;
            sqlCommand.Parameters.Add(parBackcolor);

            sqlCommand.Connection = sqlConnection;

            try
            {
                int check = sqlCommand.ExecuteNonQuery();
                if (check > 0)
                    return true;
            }
            catch
            {

            }
            return false;
        }
        public bool DeleteEvent(SuKien ev)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            //sqlCommand.CommandText = "Delete Events where EventId = @id and UserId = @userId";
            sqlCommand.CommandText = "Delete Events where EventId = @id and UserId = @userId";

            SqlParameter parId = new SqlParameter("@id", SqlDbType.Int);
            parId.Value = ev.EventId;
            sqlCommand.Parameters.Add(parId);

            SqlParameter parUserId = new SqlParameter("@userId", SqlDbType.Int);
            parUserId.Value = ev.UserId;
            sqlCommand.Parameters.Add(parUserId);

            sqlCommand.Connection = sqlConnection;

            try
            {
                int check = sqlCommand.ExecuteNonQuery();
                if (check > 0)
                    return true;
            }
            catch
            {

            }
            return false;
        }

        public List<SuKien> TimSKTheoNgay(DateTime dateTime, int uid)
        {
            List<SuKien> suKiens = new List<SuKien>();
            OpenConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From Events where Eventdate = @date and UserId = @uid";
            cmd.Connection = sqlConnection;

            cmd.Parameters.AddWithValue("@date", dateTime);
            cmd.Parameters.AddWithValue("@uid", uid); 

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int eventId = reader.GetInt32(0);
                string eventName = reader.GetString(1);
                DateTime eventDate = reader.GetDateTime(2);
                string eventTime = reader.GetString(3);
                string eventLocation = reader.GetString(4);
                int userId = reader.GetInt32(5);
                int diemRL = reader.GetInt32(6);
                string note = reader.GetString(7);
                string recordingPath = reader.GetString(8);
                string titleColor = reader.GetString(9);
                string backgroundColor = reader.GetString(10);
                SuKien ev = new SuKien();

                ev.EventId = eventId;
                ev.EventName = eventName;
                ev.EventDate = eventDate;
                ev.EventTime = eventTime;
                ev.Location = eventLocation;
                ev.UserId = userId;
                ev.Score = diemRL;
                ev.Note = note;
                ev.RecordingPath = recordingPath;
                ev.TitleColor = titleColor;
                ev.BackgroundColor = backgroundColor;
                suKiens.Add(ev);
            }
            reader.Close();
            return suKiens;
        }
    }
}
