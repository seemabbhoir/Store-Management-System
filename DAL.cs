using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    public class DAL
    {


        public ConnectionState Connection = ConnectionState.Closed;
        public bool isProCall = false;
        List<SqlParameter> parameters = new List<SqlParameter>();

        public SqlConnection GetConnection()
        {
            //string connectionstring = Conf.AppSettings["SQLconnectionString"];
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-78QFL1O\\SQLEXPRESS;Initial Catalog=dotnetdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            return con;

        }
        public void Clearparameter()
        {
            parameters.Clear();
        }

        public void Addparameter(string paraname, string value)
        {
            parameters.Add(new SqlParameter(paraname, value));


        }

        public SqlCommand GetCommand(string query)
        {
            SqlCommand cmd = new SqlCommand();
            if (isProCall)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters.ToArray());
            }
            else
                cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;

            cmd.Connection = GetConnection();
            return cmd;
        }
        public SqlDataReader GetReader(string query)
        {
            SqlCommand cmd = GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            //cmd.Connection.Close();
            return rdr;
        }
        public DataSet GetTables(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(GetCommand(query));
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataTable GetTable(string query)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr != null && rdr.HasRows)
            {
                dt.Load(rdr);
            }
            return dt;
        }
        public int ExecuteQuery(string query)
        {
            SqlCommand cmd = GetCommand(query);
            cmd.Connection.Open();
            int res = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return res;
        }


        public object GetID(string query)
        {
            SqlCommand cmd = GetCommand(query);
            cmd.Connection.Open();
            object maxid = cmd.ExecuteScalar();
            cmd.Connection.Close();
            return maxid;
        }
    }
}
