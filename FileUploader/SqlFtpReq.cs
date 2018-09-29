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
        public bool Errores;
        public int inserciones;
        public SqlFtpReq()
        {
            mssql = "Data Source=35.238.137.162;" + "Initial Catalog=bases2p1;" + "User id=sa;" + "Password=bases123*;";
            mysql = "Server = 35.225.47.96; Database = bases2p1; Uid = root; Pwd = bases123*;";
            Errores = false;
            inserciones = 0;
        }
        public void sendFtpMSDownload(string file)
        {
            using (SqlConnection cn = new SqlConnection(mssql))
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand("NombreStoreProcedure", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FTPServer" , "ftp://35.238.137.162");

                cmd.Parameters.AddWithValue("@FTPUser" , "bases2p1");

                cmd.Parameters.AddWithValue("@FTPPWD" , "61|Itt<^UwI$M+E");

                cmd.Parameters.AddWithValue("@FTPPath" , "");

                cmd.Parameters.AddWithValue("@FTPFileName" , file);

                cmd.Parameters.AddWithValue("@SourcePath" , "C:\ftp");

                cmd.Parameters.AddWithValue("@SourceFile" , file);

                cmd.Parameters.AddWithValue("@workdir" , @"c:\temp\");
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
                cmd.CommandText = "NombreStoreProcedure";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@<nombre variable>", "<valor variable>");
                cmd.Parameters["@<nombre variable>"].Direction = ParameterDirection.Input;

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
