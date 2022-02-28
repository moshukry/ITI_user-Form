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
    internal class c_BussLayer
    {

        //select

        public static DataTable getall()
        {
            return DBLayer.select(new SqlCommand("select * from Course"));
        }
        public static DataTable CoursesPerIns(int ins_id)
        {
            return DBLayer.select(new SqlCommand($"select c.crs_id, crs_name as courses from instructor i,ins_course ic, course c where c.crs_id=ic.crs_id and ic.ins_id = i.ins_id and i.ins_id = {ins_id} "));
        }
        public static DataTable GetInfo()
        {
            return DBLayer.select(new SqlCommand($"select crs_id, crs_name from course"));
        }
        public static DataTable GetStCourses(int st_id, int top_id)
        {
            return DBLayer.select(new SqlCommand($"select crs_name from student s " +
                $"join Stud_Course sc on s.St_Id=sc.St_Id and s.st_id={st_id} " +
                "join Course c on c.Crs_Id=sc.Crs_Id " +
                $"join Topic t on t.Top_Id=c.Top_Id and t.Top_Id= {top_id}"));
        }
        public static DataTable GetCrsPerTopic(int top_id)
        {
            return DBLayer.select(new SqlCommand($"select crs_name from course c, topic t " +
                $"where c.top_id = t.top_id and t.top_id = {top_id}"));
        }
        //insert

        public static int Add(int id, string name, int duration,int top_id)
        {
            return DBLayer.dml(new SqlCommand($"insert into Course Values({id} ,'{name}', {duration}, {top_id})"));
        }


        //update

        public static int update(int id, string name, int duration, int top_id)
        {
            return DBLayer.dml(new SqlCommand($"update Course set crs_name='{name}', crs_duration={duration}, top_id ={top_id} where crs_id={id}"));
        }


        //delete

        public static int delete(int id)
        {
            return DBLayer.dml(new SqlCommand("delete from Course where crs_id=" + id));
        }
    }
}
