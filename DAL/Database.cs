using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Database
    {
        //string strConnection = "Data Source=KHANGLAP;Initial Catalog=SoftwareLegends;Integrated Security=True;Encrypt=False";
        protected SqlConnection sqlConnection = null;
        
        public bool Connect()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = Properties.Settings.Default.ConnectionData;
            if(sqlConnection.State == ConnectionState.Open)
            {
                return true;
            }
            return false;
        }
        

        public void OpenConnection()
        {
            //if (sqlConnection == null)
            //    sqlConnection = new SqlConnection(strConnection);
            try
            {
                sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = Properties.Settings.Default.ConnectionData;

                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
            }
            catch
            {

            }
           

        }

        public void CloseConnection()
        {
            //if (sqlConnection.State == ConnectionState.Open && sqlConnection != null)
            //    sqlConnection.Close();
            if (sqlConnection.State == ConnectionState.Open && sqlConnection.ConnectionString != null)
                sqlConnection.Close();
        }
    }
}
