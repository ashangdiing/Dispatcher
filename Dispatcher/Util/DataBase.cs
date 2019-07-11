using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace System.Util
{
   public  class DataBase
    {
        SqlDataReader sdr;
        public  SqlConnection connection;
        public  SqlCommand command;
        private string dataBaeIP,user,passWord,dataBase;
        public DataBase(string dataBaeIP,string dataBase,string user,string passWord) {
            this.dataBaeIP = dataBaeIP;
            this.dataBase = dataBase;
            this.user = user;
            this.passWord = passWord;
        }
        public bool init (){
            try
            {
                connection = new SqlConnection("server=" + dataBaeIP + ";uid=" + user + ";pwd=" + passWord + ";database=" + dataBase);
                command = new SqlCommand();
                command.Connection = connection;
            }
            catch {
                return false;
            }
            return true;
        }
        public SqlDataReader queryData(string sql)
        {
            command.CommandText = sql;
            if (connection.State == System.Data.ConnectionState.Closed)
            connection.Open();    
             sdr=command.ExecuteReader();
             //command.ExecuteNonQuery();
            return sdr;
        }
        public void closeDataBase() {
            sdr.Close();
            connection.Close();

        }
    }
}
