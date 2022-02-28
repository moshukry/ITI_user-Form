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
    public partial class login : Form
    {
        public string loggedName { get; set; }
        DataTable dt;
        public login()
        {
            InitializeComponent();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb_admin.Checked)
                    dt = ALogins_BussLayer.GetInfo(txt_username.Text);
                else if (rb_instructor.Checked)
                    dt = ILogins_BussLayer.GetInfo(txt_username.Text);
                else
                    dt = SLogins_BussLayer.GetInfo(txt_username.Text);

                if (dt.Rows[0][1].ToString() == txt_password.Text)
                {
                    //this.Enabled = false;
                    lbl_erroruser.Visible = false;
                    if (rb_admin.Checked)
                    {
                        Admin_Form adminform = new Admin_Form();
                        adminform.Show();
                    }
                    else if (rb_instructor.Checked)
                    {
                        Instructor_Form insform = new Instructor_Form(Ins_BussLayer.GetID(txt_username.Text));
                        insform.Show();
                    }
                    else
                    {
                        Student_Form stform = new Student_Form(St_BussLayer.GetID(txt_username.Text));
                        stform.Show();
                        }
                }
                else
                {
                    lbl_erroruser.Visible = true;
                }
            }
            catch
            {
                lbl_erroruser.Visible = true;
            }
        }
    }
}
