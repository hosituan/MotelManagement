using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace test.DB_Layer
{
    class clsDB
    {
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public clsDB()
        {
            string ConnStr = "Data Source=(local);Initial Catalog=nhatro;Integrated Security=True";
            conn = new SqlConnection(ConnStr);
        }
        public DataSet ExecuteQueryDataSet(string strSQL)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            da = new SqlDataAdapter(strSQL, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public bool MyExecuteNonQuery(string strSQL)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            comm = new SqlCommand(strSQL, conn);
            comm.Connection.Open();
            try
            {

                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        public string FindNameExecute(string strSQL)
        {
            string ok = null;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            comm = new SqlCommand(strSQL, conn);
            comm.Connection.Open();
            try
            {
                var reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    ok = reader.GetString(1);
                }

            }
            catch (SqlException ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return ok;
        }
        public string Sum(string strSQL)
        {
            string ok = null;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            comm = new SqlCommand(strSQL, conn);
            comm.Connection.Open();
            try
            {
                ok = comm.ExecuteScalar().ToString();

            }
            catch (SqlException ex)
            {
                ok = "error";
            }
            finally
            {
                conn.Close();
            }
            return ok;
        }

    }
}
