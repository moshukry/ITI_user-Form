using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ITI_user_Form
{
    internal class Ins_BussLayer
    {
        //select
        public static DataTable GetAll()
        {
            return DBLayer.select(new SqlCommand($"select * from instructor"));

        }

        public static int GetID(string user_name)
        {
            return (int) DBLayer.select(new SqlCommand($"select ins_id from instructor where ins_Name = '{user_name}'")).Rows[0][0];
        }
        public static DataTable GetProfile(int ins_id)
        {
            return DBLayer.select(new SqlCommand($"select ins_name,ins_degree from instructor where ins_id = {ins_id}"));
        }
        public static DataTable GetInsPerCrs(int ins_id)
        {
            return DBLayer.select(new SqlCommand("select Ins_Name from Instructor i,Ins_Course ic, course c " +
                $"where i.Ins_Id = ic.Ins_Id and ic.Crs_Id = c.Crs_Id and c.Crs_id = {ins_id}"));
        }

        //insert

        public static int add(int id, string name, string degree, double salary, int dept_id)
        {
            return DBLayer.dml(new SqlCommand($"insert into instructor values({id} ,'{name}', '{degree}', {salary}, {dept_id})"));
        }


        //update

        public static int update(int id, string name, string degree)
        {
            return DBLayer.dml(new SqlCommand($"update instructor set ins_name = '{name}', ins_degree = '{degree}' where ins_id = {id}"));
        }


        //delete

        public static int delete(int id)
        {
            return DBLayer.dml(new SqlCommand("delete from instructor where ins_id=" + id));
        }
    }
}
