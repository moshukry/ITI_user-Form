using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ITI_user_Form
{
    internal class DBLayer
    {
        // select 
        public static DataTable select(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
            cmd.Connection = con;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;

        }


        //DML
        public static int dml(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
            cmd.Connection = con;
            con.Open();

            int rowseffected = cmd.ExecuteNonQuery();

            con.Close();

            return rowseffected;

        }
    }
}
