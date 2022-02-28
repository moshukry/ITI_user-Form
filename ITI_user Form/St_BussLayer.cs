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
    internal class St_BussLayer
    {
        //select

        public static DataTable getall()
        {
            return DBLayer.select(new SqlCommand("select * from student"));
        }
        public static DataTable GetStPerCourse(int ins_id, int crs_id)
        {
            return DBLayer.select(new SqlCommand("select full_name as students from student s,stud_course sc, course c " +
                "where c.crs_id=sc.crs_id and sc.st_id = s.st_id and crs_name in (" +
                "select crs_name from instructor i,ins_course ic, course c " +
                $"where c.crs_id=ic.crs_id and ic.ins_id = i.ins_id and i.ins_id = {ins_id} and c.crs_id ={crs_id})"));

        }
        public static int GetID(string user_name)
        {
            return (int)DBLayer.select(new SqlCommand($"select st_id from student where full_Name = '{user_name}'")).Rows[0][0];
        }
        public static DataTable GetInfo()
        {
            return DBLayer.select(new SqlCommand("select st_id,full_name from student"));
        }
        //insert

        public static int Add(int id, string fname, string lname, string Address, int age, int dept_id, int sup_id)
        {
            return DBLayer.dml(new SqlCommand($"insert into Student" +
                $"(st_id,st_fname,st_lname,st_address,st_age,dept_id,st_super) " +
                $"values(" +
                $"{id} ,'{fname}','{lname}', '{Address}', {age}, {dept_id},{sup_id})"));
        }


        ////update

        //public static int update()
        //{
        //    return DBLayer.dml(new SqlCommand($"update  set "));
        //}


        ////delete

        public static int delete(int id)
        {
            return DBLayer.dml(new SqlCommand("delete from Student where st_id=" + id));
        }

    }
}
