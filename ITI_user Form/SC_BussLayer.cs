using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ITI_user_Form
{
    internal class SC_BussLayer
    {
        //select

        public static DataTable getall()
        {
            return DBLayer.select(new SqlCommand("select ins_id, ins_name, ins_degree, salary,dept_name from instructor i, department d where i.dept_id= d.dept_id"));
        }


        //insert

        public static int add(int st_id, string crs_name)
        {
            return DBLayer.dml(new SqlCommand($"insert into stud_course(st_id, crs_id) values ({st_id},(select Crs_Id from Course where Crs_Name = '{crs_name}'))"));
        }


        //update

        public static int update(int id, string name, string degree, int salary, int dept_id)
        {
            return DBLayer.dml(new SqlCommand($"update instructor set ins_name='{name}', ins_degree='{degree}', salary={salary},dept_id={dept_id} where ins_id={id}"));
        }


        //delete

        public static int delete(int id)
        {
            return DBLayer.dml(new SqlCommand("delete from instructor where ins_id=" + id));
        }

    }
}
