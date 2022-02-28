namespace ITI_user_Form
{
    partial class Instructor_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rb_courses = new System.Windows.Forms.RadioButton();
            this.rb_profile = new System.Windows.Forms.RadioButton();
            this.rb_students = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_inscourses = new System.Windows.Forms.GroupBox();
            this.dgv_courses = new System.Windows.Forms.DataGridView();
            this.gb_students = new System.Windows.Forms.GroupBox();
            this.cb_course = new System.Windows.Forms.ComboBox();
            this.dgv_students = new System.Windows.Forms.DataGridView();
            this.gb_profile = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_insdegree = new System.Windows.Forms.TextBox();
            this.txt_insname = new System.Windows.Forms.TextBox();
            this.lbl_loggedName = new System.Windows.Forms.Label();
            this.gb_inscourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courses)).BeginInit();
            this.gb_students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_students)).BeginInit();
            this.gb_profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_courses
            // 
            this.rb_courses.AutoSize = true;
            this.rb_courses.Checked = true;
            this.rb_courses.Location = new System.Drawing.Point(120, 12);
            this.rb_courses.Name = "rb_courses";
            this.rb_courses.Size = new System.Drawing.Size(80, 17);
            this.rb_courses.TabIndex = 0;
            this.rb_courses.TabStop = true;
            this.rb_courses.Text = "My Courses";
            this.rb_courses.UseVisualStyleBackColor = true;
            // 
            // rb_profile
            // 
            this.rb_profile.AutoSize = true;
            this.rb_profile.Location = new System.Drawing.Point(498, 12);
            this.rb_profile.Name = "rb_profile";
            this.rb_profile.Size = new System.Drawing.Size(71, 17);
            this.rb_profile.TabIndex = 1;
            this.rb_profile.Text = "My Profile";
            this.rb_profile.UseVisualStyleBackColor = true;
            this.rb_profile.CheckedChanged += new System.EventHandler(this.rb_profile_CheckedChanged);
            // 
            // rb_students
            // 
            this.rb_students.AutoSize = true;
            this.rb_students.Location = new System.Drawing.Point(303, 12);
            this.rb_students.Name = "rb_students";
            this.rb_students.Size = new System.Drawing.Size(87, 17);
            this.rb_students.TabIndex = 2;
            this.rb_students.Text = "My  Students";
            this.rb_students.UseVisualStyleBackColor = true;
            this.rb_students.CheckedChanged += new System.EventHandler(this.rb_students_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10000, 2);
            this.label2.TabIndex = 3;
            // 
            // gb_inscourses
            // 
            this.gb_inscourses.Controls.Add(this.dgv_courses);
            this.gb_inscourses.Location = new System.Drawing.Point(120, 70);
            this.gb_inscourses.Name = "gb_inscourses";
            this.gb_inscourses.Size = new System.Drawing.Size(349, 326);
            this.gb_inscourses.TabIndex = 4;
            this.gb_inscourses.TabStop = false;
            this.gb_inscourses.Text = "My Courses";
            // 
            // dgv_courses
            // 
            this.dgv_courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_courses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_courses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_courses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_courses.Location = new System.Drawing.Point(72, 34);
            this.dgv_courses.Name = "dgv_courses";
            this.dgv_courses.ReadOnly = true;
            this.dgv_courses.Size = new System.Drawing.Size(210, 271);
            this.dgv_courses.TabIndex = 0;
            // 
            // gb_students
            // 
            this.gb_students.Controls.Add(this.cb_course);
            this.gb_students.Controls.Add(this.dgv_students);
            this.gb_students.Location = new System.Drawing.Point(104, 90);
            this.gb_students.Name = "gb_students";
            this.gb_students.Size = new System.Drawing.Size(416, 274);
            this.gb_students.TabIndex = 5;
            this.gb_students.TabStop = false;
            this.gb_students.Text = "My Students";
            this.gb_students.Visible = false;
            // 
            // cb_course
            // 
            this.cb_course.FormattingEnabled = true;
            this.cb_course.Location = new System.Drawing.Point(22, 29);
            this.cb_course.Name = "cb_course";
            this.cb_course.Size = new System.Drawing.Size(121, 21);
            this.cb_course.TabIndex = 1;
            this.cb_course.SelectedIndexChanged += new System.EventHandler(this.cb_course_SelectedIndexChanged);
            // 
            // dgv_students
            // 
            this.dgv_students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_students.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_students.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_students.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_students.Location = new System.Drawing.Point(173, 19);
            this.dgv_students.Name = "dgv_students";
            this.dgv_students.ReadOnly = true;
            this.dgv_students.Size = new System.Drawing.Size(192, 255);
            this.dgv_students.TabIndex = 0;
            // 
            // gb_profile
            // 
            this.gb_profile.Controls.Add(this.btn_save);
            this.gb_profile.Controls.Add(this.btn_edit);
            this.gb_profile.Controls.Add(this.label4);
            this.gb_profile.Controls.Add(this.label3);
            this.gb_profile.Controls.Add(this.txt_insdegree);
            this.gb_profile.Controls.Add(this.txt_insname);
            this.gb_profile.Location = new System.Drawing.Point(98, 100);
            this.gb_profile.Name = "gb_profile";
            this.gb_profile.Size = new System.Drawing.Size(592, 230);
            this.gb_profile.TabIndex = 6;
            this.gb_profile.TabStop = false;
            this.gb_profile.Text = "My Profile";
            this.gb_profile.Visible = false;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(438, 147);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(107, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save Changes";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(289, 147);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Degree";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // txt_insdegree
            // 
            this.txt_insdegree.Enabled = false;
            this.txt_insdegree.Location = new System.Drawing.Point(264, 85);
            this.txt_insdegree.Name = "txt_insdegree";
            this.txt_insdegree.Size = new System.Drawing.Size(100, 20);
            this.txt_insdegree.TabIndex = 1;
            // 
            // txt_insname
            // 
            this.txt_insname.Enabled = false;
            this.txt_insname.Location = new System.Drawing.Point(264, 33);
            this.txt_insname.Name = "txt_insname";
            this.txt_insname.Size = new System.Drawing.Size(100, 20);
            this.txt_insname.TabIndex = 0;
            // 
            // lbl_loggedName
            // 
            this.lbl_loggedName.AutoSize = true;
            this.lbl_loggedName.Location = new System.Drawing.Point(710, 54);
            this.lbl_loggedName.Name = "lbl_loggedName";
            this.lbl_loggedName.Size = new System.Drawing.Size(28, 13);
            this.lbl_loggedName.TabIndex = 7;
            this.lbl_loggedName.Text = "Adel";
            this.lbl_loggedName.Visible = false;
            // 
            // Instructor_Form
            // 
            this.ClientSize = new System.Drawing.Size(816, 464);
            this.Controls.Add(this.lbl_loggedName);
            this.Controls.Add(this.gb_students);
            this.Controls.Add(this.gb_inscourses);
            this.Controls.Add(this.gb_profile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb_students);
            this.Controls.Add(this.rb_profile);
            this.Controls.Add(this.rb_courses);
            this.Name = "Instructor_Form";
            this.Load += new System.EventHandler(this.Instructor_Form_Load);
            this.gb_inscourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courses)).EndInit();
            this.gb_students.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_students)).EndInit();
            this.gb_profile.ResumeLayout(false);
            this.gb_profile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_courses;
        private System.Windows.Forms.RadioButton rb_profile;
        private System.Windows.Forms.RadioButton rb_students;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_inscourses;
        private System.Windows.Forms.DataGridView dgv_courses;
        private System.Windows.Forms.GroupBox gb_students;
        private System.Windows.Forms.DataGridView dgv_students;
        private System.Windows.Forms.GroupBox gb_profile;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_insdegree;
        private System.Windows.Forms.TextBox txt_insname;
        private System.Windows.Forms.Label lbl_loggedName;
        private System.Windows.Forms.ComboBox cb_course;
    }
}