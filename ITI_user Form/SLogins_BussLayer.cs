using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ITI_user_Form
{
    internal class SLogins_BussLayer
    {
        public static DataTable GetInfo(string name)
        {
            return DBLayer.select(new SqlCommand(
                $"select * from st_logins where user_name = '{name}'"
                ));
        }
    }
}
