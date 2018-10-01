using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;



namespace FileUploader
{
    public class SqlFtpReq
    {
        private string mysql;
        private string mssql;
        //private string querymysql;
        public bool Errores;
        public int inserciones;
        public SqlFtpReq()
        {
            mssql = "Data Source=35.238.137.162;" + "Initial Catalog=bases2p1;" + "User id=sa;" + "Password=bases123*;";
            mysql = "Server = 35.225.47.96; Database = bases2p1; Uid = root; Pwd = bases123*;";
            Errores = false;
            inserciones = 0;
            //querymysql = getquery();
        }
        /*private string getquery() {
            string resp = "";
            using (System.IO.StreamReader sr = new System.IO.StreamReader("QuerryString.txt", System.Text.Encoding.Default)) {
                resp = sr.ReadLine();
            }
            return resp;
        }*/

        public void sendFtpMSDownload(string file)
        {
            using (SqlConnection cn = new SqlConnection(mssql))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("[bases2p1].[dbo].[insertar]", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    inserciones = cmd.ExecuteNonQuery();
                    Errores = false;
                }
                catch (Exception)
                {
                    Errores = true;
                }
            }
        }
        public void sendFtpMyDownload(string url)
        {
            using (MySqlConnection conn = new MySqlConnection(mysql))
            {    //watch out for this SQL injection vulnerability below
                MySqlCommand cmd = conn.CreateCommand();
                conn.Open();
                cmd.CommandText = "LOAD XML INFILE 'http://35.238.137.162/datos.xml' INTO TABLE personas ROWS IDENTIFIED BY '<VOTANTE>';" ;
                cmd.CommandType = CommandType.Text;

                try
                {
                    inserciones = cmd.ExecuteNonQuery();
                    Errores = false;
                }
                catch (Exception)
                {
                    Errores = true;
                }
            }
        }

        public bool IsServerConnected(int server)
        {
            if (server == 0)
            {
                using (SqlConnection Connection = new SqlConnection(mssql))
                {
                    try
                    {
                        Connection.Open();
                        if (Connection.State == ConnectionState.Open)
                            return true;
                        else
                            return false;
                    }
                    catch (SqlException)
                    {
                        return false;
                    }
                }
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(mysql))
                {
                    try
                    {
                        conn.Open();
                        if (conn.State.ToString() == "Open")
                                return true;
                        else
                            return false;
                    }
                    catch (MySql.Data.MySqlClient.MySqlException)
                    {
                        return false;
                    }
                }
            }
        }
    }
}
