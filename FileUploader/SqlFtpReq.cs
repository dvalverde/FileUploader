using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;



namespace FileUploader
{
    public class SqlFtpReq
    {
        string mysql;
        string mssql;
        public SqlFtpReq()
        {
            mssql = "Data Source=ServerName;" + "Initial Catalog=DataBaseName;" + "User id=;" + "Password=;";
            mysql = "Server = 35.238.137.16; Database = bases2p1; Uid = sa; Pwd = bases123*;";

        }
        public void sendFtpMSDownload(string ulr)
        {
            using (SqlConnection cn = new SqlConnection(mssql))
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand("NombreStoreProcedure", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@param", Convert.ToInt32("string"));

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    //aqui cargas la lista
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

                cmd.ExecuteNonQuery();
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
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        return false;
                    }
                }
            }
        }
    }
}
