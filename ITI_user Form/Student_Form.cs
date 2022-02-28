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
    public partial class Student_Form : Form
    {
        public int st_id { get; set; }
        public string selectedCourse { get; set; }
        public Student_Form(int st_id)
        {
            InitializeComponent();
            this.st_id = st_id;
        }
        public void FillTopics()
        {
            DataTable dt_topics = T_BussLayer.getall();
            cb_topic.DisplayMember = "top_name";
            cb_mytopics.DisplayMember = "top_name";
            cb_topic.ValueMember = "top_id";
            cb_mytopics.ValueMember = "top_id";
            cb_topic.DataSource = dt_topics;
            cb_mytopics.DataSource = dt_topics;
        }
        public void FillInsPerCrs()
        {
            DataTable dt_ins = Ins_BussLayer.GetInsPerCrs((int)cb_course.SelectedValue);
            DGV_instructors.DataSource = dt_ins;
        }
        public void FillCrsInfo()
        {
            DataTable dt_courses = c_BussLayer.GetInfo();
            cb_course.DisplayMember = "crs_name";
            cb_course.ValueMember = "crs_id";
            cb_course.DataSource = dt_courses;
        }
        public void FillCrsPerTopic()
        {
            DataTable dt_crs = c_BussLayer.GetCrsPerTopic((int)cb_topic.SelectedValue);
            DGV_courses.DataSource = dt_crs;
        }
        public void FillStCourses()
        {
            DataTable dt_crs = c_BussLayer.GetStCourses(st_id, (int)cb_mytopics.SelectedValue);
            DGV_mycourses.DataSource = dt_crs;
        }
        private void Student_Form_Load(object sender, EventArgs e)
        {
            FillTopics();
            FillCrsInfo();
            FillInsPerCrs();
            FillStCourses();
        }

        private void DGV_cources_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_register.Enabled = true;
            lbl_alreadyregistered.Visible = false;
            lbl_select.Visible = false;
            selectedCourse = DGV_courses.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void cb_topic_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCrsPerTopic();
        }
        private void cb_mytopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillStCourses();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                int roweffect = SC_BussLayer.add(st_id, selectedCourse);
                if (roweffect > 0)
                {
                    btn_register.Enabled = false;
                    lbl_alreadyregistered.Visible = false;
                    lbl_select.Visible = true;
                }
            }
            catch
            {
                btn_register.Enabled = false;
                lbl_select.Visible = true;
                lbl_alreadyregistered.Visible = true;
            }
            FillStCourses();
        }
        private void cb_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillInsPerCrs();
        }
        private void rb_ins_CheckedChanged(object sender, EventArgs e)
        {
            gb_ins.Visible = rb_ins.Checked;
        }
        private void rb_courses_CheckedChanged(object sender, EventArgs e)
        {
            gb_courses.Visible = rb_courses.Checked;
        }
        private void rb_mycourses_CheckedChanged(object sender, EventArgs e)
        {
            gb_mycourses.Visible = rb_mycourses.Checked;
        }
    }
}
