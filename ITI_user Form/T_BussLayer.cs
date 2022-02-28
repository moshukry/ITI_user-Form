using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ITI_user_Form
{
    internal class T_BussLayer
    {
        //select

        public static DataTable getall()
        {
            return DBLayer.select(new SqlCommand("select * from Topic"));
        }


        //insert

        public static int add(int id, string name)
        {
            return DBLayer.dml(new SqlCommand($"insert into Topic values({id} ,'{name}')"));
        }


        //update

        public static int update(int id, string name)
        {
            return DBLayer.dml(new SqlCommand($"update Topic set top_name='{name}' where top_id={id}"));
        }


        //delete

        public static int delete(int id)
        {
            return DBLayer.dml(new SqlCommand("delete from topic where top_id=" + id));
        }

    }
}
