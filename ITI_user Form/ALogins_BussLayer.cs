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
    internal class ALogins_BussLayer
    {
        public static DataTable GetInfo(string name)
        {
            return DBLayer.select(new SqlCommand(
                $"select * from admin_logins where admin_name = '{name}'"
                ));
        }
    }
}
