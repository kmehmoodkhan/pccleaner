using PCCleaner.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCleaner.DataAccess
{
    public class DBAccess
    {
        private string ConnectionString
        {
            get
            {
                string appBasePath = CleanerApplicationSettings.ApplicationBasePath;
                if(!appBasePath.EndsWith("\\"))
                {
                    appBasePath += "\\";
                }
                return $@"Data Source={appBasePath}DB\CleanerDB.db;Version=3;";
            }
        }

        private string DBFileName
        {
            get
            {
                return "CleanerDB.db";
            }
        }
        public bool ExecuteNonQuery(string query)
        {
            bool isSuccess = true;
            try
            {
                if(! new FileInfo(DBFileName).Exists)
                {
                    SQLiteConnection.CreateFile(DBFileName);
                }                

                SQLiteConnection m_dbConnection = new SQLiteConnection(ConnectionString);
                m_dbConnection.Open();

                SQLiteCommand command = new SQLiteCommand(query, m_dbConnection);
                command.ExecuteNonQuery();

                m_dbConnection.Close();
            }
            catch(Exception ex)
            {
                isSuccess = false;
            }
            return isSuccess;
        }

        public DataSet GetDataSet(string Query)
        {
            DataSet dataSet = new DataSet();
            try
            {
                SQLiteConnection connection = new SQLiteConnection(ConnectionString);
                connection.Open();

                var command = connection.CreateCommand();

                var adapter = new SQLiteDataAdapter(Query, connection);                

                adapter.Fill(dataSet);

                connection.Close();
            }
            catch(Exception ex)
            {
                ;
            }
            return dataSet;
        }
    }
}
