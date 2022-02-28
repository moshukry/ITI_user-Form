using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace ITI_user_Form
{
    internal class D_BussLayer
    {
        public static DataTable GetAll()
        {
            return DBLayer.select(new SqlCommand("select * from Department"));
        }
        public static DataTable GetInfo()
        {
            return DBLayer.select(new SqlCommand("select dept_id, dept_name from Department"));
        }
    }
}
