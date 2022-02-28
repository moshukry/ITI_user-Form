using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITI_user_Form
{
    public partial class Instructor_Form : Form
    {
        public int ins_id { get; set; }
        SqlConnection con;
        public Instructor_Form(int ins_id)
        {
            InitializeComponent();
            this.ins_id = ins_id;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
        }

        private void Instructor_Form_Load(object sender, EventArgs e)
        {
            // course selection
            DataTable dt_courses = c_BussLayer.CoursesPerIns(ins_id);
            dgv_courses.DataSource = dt_courses;
            dgv_courses.Columns["crs_id"].Visible = false;

            // students per course selection
            cb_course.DisplayMember = "courses";
            cb_course.ValueMember = "crs_id";
            cb_course.DataSource = dt_courses;

            DataTable dt_students = St_BussLayer.GetStPerCourse(ins_id, (int)cb_course.SelectedValue);
            dgv_students.DataSource = dt_students;

            // profile section
            DataTable dt_ins = Ins_BussLayer.GetProfile(ins_id);
            txt_insname.Text = dt_ins.Rows[0][0].ToString();
            txt_insdegree.Text = dt_ins.Rows[0][1].ToString();

            gb_students.Visible = rb_students.Checked;
            gb_profile.Visible = rb_profile.Checked;
            gb_inscourses.Visible = rb_courses.Checked;
        }
        private void rb_students_CheckedChanged(object sender, EventArgs e)
        {
            gb_students.Visible = rb_students.Checked;
            gb_profile.Visible = rb_profile.Checked;
            gb_inscourses.Visible = rb_courses.Checked;
        }

        private void rb_profile_CheckedChanged(object sender, EventArgs e)
        {
            gb_students.Visible = rb_students.Checked;
            gb_profile.Visible = rb_profile.Checked;
            gb_inscourses.Visible = rb_courses.Checked;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            txt_insname.Enabled = txt_insdegree.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int roweffected = Ins_BussLayer.update(ins_id,txt_insname.Text,txt_insdegree.Text);
            if(roweffected > 0)
            {
                txt_insname.Enabled = txt_insdegree.Enabled = false;
            }
        }

        private void cb_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt_students = St_BussLayer.GetStPerCourse(ins_id, (int)cb_course.SelectedValue);
            dgv_students.DataSource = dt_students;
        }
    }
}