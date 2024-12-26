using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReminderDAL : Database
    {
        public List<Reminder> DS_Reminder()
        {
            List<Reminder> reminders = new List<Reminder>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From Reminders";
            cmd.Connection = sqlConnection;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Reminder reminder = new Reminder();

                var id = reader.GetInt32(0);
                var time = reader.GetDateTime(1);
                var content = reader.GetString(2);
                var summary = reader.GetString(3);
                var recordingPath = reader.GetString(4);
                var isViewed = reader.GetBoolean(5);
                var userID = reader.GetInt32(6);
                var titleColor = reader.GetString(7);
                var backGroundColor = reader.GetString(8);

                reminder.ReminderId = id;
                reminder.ReminderTime = time;
                reminder.Content = content;
                reminder.Summary = summary;
                reminder.RecordingPath = recordingPath;
                reminder.IsViewed = isViewed;
                reminder.UserId = userID;
                reminder.TitleColor = titleColor;
                reminder.BackgroundColor = backGroundColor;

                reminders.Add(reminder);
                
            }
            return reminders;
        }

        public bool AddReminder(Reminder reminder)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Reminders values (@time, @content, @summary, @recording, @isView, @userId, @title, @backColor)";
            cmd.Connection = sqlConnection;

            cmd.Parameters.AddWithValue("@time",reminder.ReminderId);
            cmd.Parameters.AddWithValue("@content", reminder.Content);
            cmd.Parameters.AddWithValue("@summary", reminder.Summary);
            cmd.Parameters.AddWithValue("@recording", reminder.RecordingPath);
            cmd.Parameters.AddWithValue("@isView", reminder.IsViewed);
            cmd.Parameters.AddWithValue("@userId", reminder.UserId);
            cmd.Parameters.AddWithValue("@title", reminder.TitleColor);
            cmd.Parameters.AddWithValue("@backColor", reminder.BackgroundColor);
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0;
        }
    }
}
