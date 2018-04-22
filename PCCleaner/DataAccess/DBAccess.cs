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
                return "Data Source=CleanerDatabase.sqlite;Version=3;";
            }
        }

        private string DBFileName
        {
            get
            {
                return "CleanerDatabase.sqlite";
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

                //string sql = "create table highscores (name varchar(20), score int)";

                SQLiteCommand command = new SQLiteCommand(query, m_dbConnection);
                command.ExecuteNonQuery();

                //sql = "insert into highscores (name, score) values ('Me', 9001)";

                //command = new SQLiteCommand(sql, m_dbConnection);
                //command.ExecuteNonQuery();

                m_dbConnection.Close();
            }
            catch(Exception ex)
            {
                isSuccess = false;
                MessageBox.Show(ex.Message);
            }
            return isSuccess;
        }

        //public DataSet GetData(string Query)
        //{
        //    SQLiteConnection m_dbConnection = new SQLiteConnection(ConnectionString);
        //    m_dbConnection.Open();

        //    //string sql = "create table highscores (name varchar(20), score int)";

        //    new SQLiteDataAdapter(CommandText, sql_con);

        //    SQLiteCommand command = new SQLiteCommand(query, m_dbConnection);
        //    command.ExecuteNonQuery();

        //    //sql = "insert into highscores (name, score) values ('Me', 9001)";

        //    //command = new SQLiteCommand(sql, m_dbConnection);
        //    //command.ExecuteNonQuery();

        //    m_dbConnection.Close();
        //}  
    }
}
