using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITI_user_Form
{
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }
        #region Radio Buttons
        private void rb_topic_CheckedChanged(object sender, EventArgs e)
        {
            gb_courses.Visible = rb_courses.Checked;
            gb_instructors.Visible = rb_ins.Checked;
            gb_students.Visible = rb_students.Checked;
            gb_topic.Visible = rb_topic.Checked;
        }

        private void rb_students_CheckedChanged(object sender, EventArgs e)
        {
            gb_courses.Visible = rb_courses.Checked;
            gb_instructors.Visible = rb_ins.Checked;
            gb_students.Visible = rb_students.Checked;
            gb_topic.Visible = rb_topic.Checked;
        }

        private void rb_ins_CheckedChanged(object sender, EventArgs e)
        {
            gb_courses.Visible = rb_courses.Checked;
            gb_instructors.Visible = rb_ins.Checked;
            gb_students.Visible = rb_students.Checked;
            gb_topic.Visible = rb_topic.Checked;
        }
        #endregion

        #region Load
        private void Admin_Form_Load(object sender, EventArgs e)
        {
            //course
            DGV_courses.DataSource = c_BussLayer.getall();
            cb_topics.DataSource = T_BussLayer.getall();
            cb_topics.DisplayMember = "top_name";
            cb_topics.ValueMember = "top_id";
            // topic
            DGV_topics.DataSource = T_BussLayer.getall();
            //Student
            DGV_students.DataSource = St_BussLayer.getall();
            cb_sup_id.DataSource =  St_BussLayer.GetInfo();
            cb_sup_id.DisplayMember = "full_name";
            cb_sup_id.ValueMember = "st_id";
            cb_dept.DataSource = D_BussLayer.GetInfo();
            cb_dept.ValueMember = "dept_id";
            cb_dept.DisplayMember = "dept_name";
            // Instructor
            DGV_instructors.DataSource = Ins_BussLayer.GetAll();
            cb_dept2.DataSource = D_BussLayer.GetInfo();
            cb_dept2.ValueMember = "dept_id";
            cb_dept2.DisplayMember = "dept_name";
        }
        #endregion

        #region Course
        private void DGV_courses_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_crs_update.Enabled = true;
            btn_crs_delete.Enabled = true;
            txt_crs_id.Text = DGV_courses.SelectedRows[0].Cells[0].Value.ToString();
            txt_crs_name.Text = DGV_courses.SelectedRows[0].Cells[1].Value.ToString();
            txt_crs_duration.Text = DGV_courses.SelectedRows[0].Cells[2].Value.ToString();
            cb_topics.SelectedValue = (int)DGV_courses.SelectedRows[0].Cells[3].Value;
            lbl_duplicate.Visible = false;
            lbl_invalid.Visible = false;
        }

        private void btn_crs_add_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_duplicate.Visible = false;
                lbl_invalid.Visible = false;
                c_BussLayer.Add(int.Parse(txt_crs_id.Text), txt_crs_name.Text, int.Parse(txt_crs_duration.Text), (int)cb_topics.SelectedValue);
                DGV_courses.DataSource = c_BussLayer.getall();
                btn_crs_update.Enabled = false;
                btn_crs_delete.Enabled = false;
            }
            catch
            {
                lbl_duplicate.Visible = true;
            }
        }
        private void btn_crs_update_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_duplicate.Visible = false;
                lbl_invalid.Visible = false;
                c_BussLayer.update(int.Parse(txt_crs_id.Text), txt_crs_name.Text, int.Parse(txt_crs_duration.Text), (int)cb_topics.SelectedValue);
                DGV_courses.DataSource = c_BussLayer.getall();
                btn_crs_update.Enabled = false;
                btn_crs_delete.Enabled = false;
            }
            catch
            {
                lbl_invalid.Visible = true;
            }
        }

        private void btn_crs_delete_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_duplicate.Visible = false;
                lbl_invalid.Visible = false;
                c_BussLayer.delete(int.Parse(txt_crs_id.Text));
                DGV_courses.DataSource = c_BussLayer.getall();
                btn_crs_update.Enabled = false;
                btn_crs_delete.Enabled = false;
            }
            catch
            {
                lbl_invalid.Visible=true;
            }
        }
        #endregion

        # region topic
        private void DGV_topics_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_update_topic.Enabled = true;
            btn_delete_topic.Enabled = true;
            txt_top_id.Text = DGV_topics.SelectedRows[0].Cells[0].Value.ToString();
            txt_top_name.Text = DGV_topics.SelectedRows[0].Cells[1].Value.ToString();
            lbl_dub_top.Visible = false;
            lbl_invalid_top.Visible = false;
        }

        private void btn_add_topic_Click_1(object sender, EventArgs e)
        {
            try
            {
                lbl_dub_top.Visible = false;
                lbl_invalid_top.Visible = false;
                T_BussLayer.add(int.Parse(txt_top_id.Text), txt_top_name.Text);
                DGV_topics.DataSource = T_BussLayer.getall();
                btn_update_topic.Enabled = false;
                btn_delete_topic.Enabled = false;
            }
            catch
            {
                lbl_dub_top.Visible = true;
            }
        }
        private void btn_update_topic_Click_1(object sender, EventArgs e)
        {
            try
            {
                lbl_dub_top.Visible = false;
                lbl_invalid_top.Visible = false;
                T_BussLayer.update(int.Parse(txt_top_id.Text), txt_top_name.Text);
                DGV_topics.DataSource = T_BussLayer.getall();
                btn_update_topic.Enabled = false;
                btn_delete_topic.Enabled = false;
            }
            catch
            {
                lbl_invalid_top.Visible = true;
            }
        }

        private void btn_delete_topic_Click_1(object sender, EventArgs e)
        {
            try
            {
                lbl_dub_top.Visible = false;
                lbl_invalid_top.Visible = false;
                T_BussLayer.delete(int.Parse(txt_top_id.Text));
                DGV_topics.DataSource = T_BussLayer.getall();
                btn_update_topic.Enabled = false;
                btn_delete_topic.Enabled = false;
            }
            catch
            {
                lbl_invalid_top.Visible = true;
            }
        }
        #endregion

        #region Student
        private void DGV_students_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_st_delete.Enabled = true;
            txt_st_id.Text = DGV_students.SelectedRows[0].Cells[0].Value.ToString();
            txt_st_fname.Text = DGV_students.SelectedRows[0].Cells[1].Value.ToString();
            txt_st_lname.Text = DGV_students.SelectedRows[0].Cells[2].Value.ToString();
            txt_st_address.Text = DGV_students.SelectedRows[0].Cells[3].Value.ToString();
            txt_st_age.Text = DGV_students.SelectedRows[0].Cells[4].Value.ToString();
            cb_dept.SelectedValue = (int)DGV_students.SelectedRows[0].Cells[5].Value;
            
            int x;
            if (int.TryParse(DGV_students.SelectedRows[0].Cells[6].Value.ToString(), out x))
                cb_sup_id.SelectedValue = (int)DGV_students.SelectedRows[0].Cells[6].Value;
            
            lbl_dup_st.Visible = false;
            lbl_error_delete.Visible = false;
        }
        
        private void btn_st_add_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_dup_st.Visible = false;
                lbl_error_delete.Visible = false;
                St_BussLayer.Add(
                        int.Parse(txt_st_id.Text),
                        txt_st_fname.Text,
                        txt_st_lname.Text,
                        txt_st_address.Text,
                        int.Parse(txt_st_age.Text),
                        (int)cb_dept.SelectedValue,
                        (int)cb_sup_id.SelectedValue
                    );
                DGV_students.DataSource = St_BussLayer.getall();
                btn_st_delete.Enabled = false;
            }
            catch
            {
                lbl_dup_st.Visible = true;
            }
        }

        private void txt_st_delete_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_dup_st.Visible = false;
                lbl_error_delete.Visible = false;
                St_BussLayer.delete(int.Parse(txt_st_id.Text));
                DGV_students.DataSource = St_BussLayer.getall();
                btn_st_delete.Enabled = false;
            }
            catch
            {
                lbl_error_delete.Visible = true;
            }
        }
        #endregion

        #region Instructors
        private void DGV_instructors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_ins_delete.Enabled = true;
            txt_ins_id.Text = DGV_instructors.SelectedRows[0].Cells[0].Value.ToString();
            txt_ins_name.Text = DGV_instructors.SelectedRows[0].Cells[1].Value.ToString();
            txt_ins_degree.Text = DGV_instructors.SelectedRows[0].Cells[2].Value.ToString();
            txt_ins_salary.Text = DGV_instructors.SelectedRows[0].Cells[3].Value.ToString();
            cb_dept2.SelectedValue = (int)DGV_instructors.SelectedRows[0].Cells[4].Value;

            lbl_duplicate.Visible = false;
            lbl_invalid.Visible = false;
        }


        private void btn_ins_add_Click(object sender, EventArgs e)
        {
           try
           {
                lbl_ins_dup.Visible = false;
                lbl_ins_related.Visible = false;
                Ins_BussLayer.add(int.Parse(txt_ins_id.Text), txt_ins_name.Text,txt_ins_degree.Text,Convert.ToDouble(txt_ins_salary.Text),(int)cb_dept2.SelectedValue);
                DGV_instructors.DataSource = Ins_BussLayer.GetAll();
            }
            catch
            {
                lbl_ins_dup.Visible = true;
            }
        }
        private void btn_ins_delete_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_ins_dup.Visible = false;
                lbl_ins_related.Visible = false;
                Ins_BussLayer.delete(int.Parse(txt_ins_id.Text));
                DGV_instructors.DataSource = Ins_BussLayer.GetAll();
                btn_ins_add.Enabled = true;
                btn_ins_delete.Enabled = false;
            }
            catch
            {
                lbl_ins_related.Visible = true;
            }
}
        #endregion

    }
}