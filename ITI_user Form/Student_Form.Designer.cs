namespace ITI_user_Form
{
    partial class Student_Form
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
            this.DGV_courses = new System.Windows.Forms.DataGridView();
            this.rb_courses = new System.Windows.Forms.RadioButton();
            this.rb_ins = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_topic = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.gb_courses = new System.Windows.Forms.GroupBox();
            this.lbl_alreadyregistered = new System.Windows.Forms.Label();
            this.lbl_select = new System.Windows.Forms.Label();
            this.rb_mycourses = new System.Windows.Forms.RadioButton();
            this.gb_mycourses = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_mytopics = new System.Windows.Forms.ComboBox();
            this.DGV_mycourses = new System.Windows.Forms.DataGridView();
            this.gb_ins = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_course = new System.Windows.Forms.ComboBox();
            this.DGV_instructors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_courses)).BeginInit();
            this.gb_courses.SuspendLayout();
            this.gb_mycourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_mycourses)).BeginInit();
            this.gb_ins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_instructors)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_courses
            // 
            this.DGV_courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_courses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_courses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_courses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_courses.Location = new System.Drawing.Point(171, 56);
            this.DGV_courses.Name = "DGV_courses";
            this.DGV_courses.ReadOnly = true;
            this.DGV_courses.Size = new System.Drawing.Size(240, 281);
            this.DGV_courses.TabIndex = 0;
            this.DGV_courses.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_cources_RowHeaderMouseClick);
            // 
            // rb_courses
            // 
            this.rb_courses.AutoSize = true;
            this.rb_courses.Location = new System.Drawing.Point(332, 12);
            this.rb_courses.Name = "rb_courses";
            this.rb_courses.Size = new System.Drawing.Size(63, 17);
            this.rb_courses.TabIndex = 1;
            this.rb_courses.Text = "Courses";
            this.rb_courses.UseVisualStyleBackColor = true;
            this.rb_courses.CheckedChanged += new System.EventHandler(this.rb_courses_CheckedChanged);
            // 
            // rb_ins
            // 
            this.rb_ins.AutoSize = true;
            this.rb_ins.Location = new System.Drawing.Point(540, 12);
            this.rb_ins.Name = "rb_ins";
            this.rb_ins.Size = new System.Drawing.Size(74, 17);
            this.rb_ins.TabIndex = 2;
            this.rb_ins.Text = "Instructors";
            this.rb_ins.UseVisualStyleBackColor = true;
            this.rb_ins.CheckedChanged += new System.EventHandler(this.rb_ins_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-1, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10000, 2);
            this.label1.TabIndex = 3;
            // 
            // cb_topic
            // 
            this.cb_topic.FormattingEnabled = true;
            this.cb_topic.Location = new System.Drawing.Point(6, 56);
            this.cb_topic.Name = "cb_topic";
            this.cb_topic.Size = new System.Drawing.Size(148, 21);
            this.cb_topic.TabIndex = 4;
            this.cb_topic.SelectedIndexChanged += new System.EventHandler(this.cb_topic_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Topic";
            // 
            // btn_register
            // 
            this.btn_register.Enabled = false;
            this.btn_register.Location = new System.Drawing.Point(451, 68);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(89, 42);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // gb_courses
            // 
            this.gb_courses.Controls.Add(this.lbl_alreadyregistered);
            this.gb_courses.Controls.Add(this.lbl_select);
            this.gb_courses.Controls.Add(this.cb_topic);
            this.gb_courses.Controls.Add(this.DGV_courses);
            this.gb_courses.Controls.Add(this.btn_register);
            this.gb_courses.Controls.Add(this.label2);
            this.gb_courses.Location = new System.Drawing.Point(12, 44);
            this.gb_courses.Name = "gb_courses";
            this.gb_courses.Size = new System.Drawing.Size(776, 400);
            this.gb_courses.TabIndex = 16;
            this.gb_courses.TabStop = false;
            this.gb_courses.Text = "Courses";
            this.gb_courses.Visible = false;
            // 
            // lbl_alreadyregistered
            // 
            this.lbl_alreadyregistered.AutoSize = true;
            this.lbl_alreadyregistered.ForeColor = System.Drawing.Color.Red;
            this.lbl_alreadyregistered.Location = new System.Drawing.Point(448, 133);
            this.lbl_alreadyregistered.Name = "lbl_alreadyregistered";
            this.lbl_alreadyregistered.Size = new System.Drawing.Size(96, 13);
            this.lbl_alreadyregistered.TabIndex = 8;
            this.lbl_alreadyregistered.Text = "Already Registered";
            this.lbl_alreadyregistered.Visible = false;
            // 
            // lbl_select
            // 
            this.lbl_select.AutoSize = true;
            this.lbl_select.Location = new System.Drawing.Point(193, 40);
            this.lbl_select.Name = "lbl_select";
            this.lbl_select.Size = new System.Drawing.Size(145, 13);
            this.lbl_select.TabIndex = 7;
            this.lbl_select.Text = "Select A course to register in.";
            // 
            // rb_mycourses
            // 
            this.rb_mycourses.AutoSize = true;
            this.rb_mycourses.Checked = true;
            this.rb_mycourses.Location = new System.Drawing.Point(117, 12);
            this.rb_mycourses.Name = "rb_mycourses";
            this.rb_mycourses.Size = new System.Drawing.Size(80, 17);
            this.rb_mycourses.TabIndex = 17;
            this.rb_mycourses.TabStop = true;
            this.rb_mycourses.Text = "My Courses";
            this.rb_mycourses.UseVisualStyleBackColor = true;
            this.rb_mycourses.CheckedChanged += new System.EventHandler(this.rb_mycourses_CheckedChanged);
            // 
            // gb_mycourses
            // 
            this.gb_mycourses.Controls.Add(this.label3);
            this.gb_mycourses.Controls.Add(this.cb_mytopics);
            this.gb_mycourses.Controls.Add(this.DGV_mycourses);
            this.gb_mycourses.Location = new System.Drawing.Point(62, 73);
            this.gb_mycourses.Name = "gb_mycourses";
            this.gb_mycourses.Size = new System.Drawing.Size(656, 318);
            this.gb_mycourses.TabIndex = 18;
            this.gb_mycourses.TabStop = false;
            this.gb_mycourses.Text = "My Courses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Topic";
            // 
            // cb_mytopics
            // 
            this.cb_mytopics.FormattingEnabled = true;
            this.cb_mytopics.Location = new System.Drawing.Point(20, 51);
            this.cb_mytopics.Name = "cb_mytopics";
            this.cb_mytopics.Size = new System.Drawing.Size(138, 21);
            this.cb_mytopics.TabIndex = 1;
            this.cb_mytopics.SelectedIndexChanged += new System.EventHandler(this.cb_mytopics_SelectedIndexChanged);
            // 
            // DGV_mycourses
            // 
            this.DGV_mycourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DGV_mycourses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_mycourses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_mycourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_mycourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_mycourses.Location = new System.Drawing.Point(199, 51);
            this.DGV_mycourses.Name = "DGV_mycourses";
            this.DGV_mycourses.ReadOnly = true;
            this.DGV_mycourses.Size = new System.Drawing.Size(207, 212);
            this.DGV_mycourses.TabIndex = 0;
            // 
            // gb_ins
            // 
            this.gb_ins.Controls.Add(this.label4);
            this.gb_ins.Controls.Add(this.cb_course);
            this.gb_ins.Controls.Add(this.DGV_instructors);
            this.gb_ins.Location = new System.Drawing.Point(117, 73);
            this.gb_ins.Name = "gb_ins";
            this.gb_ins.Size = new System.Drawing.Size(530, 291);
            this.gb_ins.TabIndex = 19;
            this.gb_ins.TabStop = false;
            this.gb_ins.Text = "Instructors";
            this.gb_ins.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Course";
            // 
            // cb_course
            // 
            this.cb_course.FormattingEnabled = true;
            this.cb_course.Location = new System.Drawing.Point(20, 51);
            this.cb_course.Name = "cb_course";
            this.cb_course.Size = new System.Drawing.Size(138, 21);
            this.cb_course.TabIndex = 1;
            this.cb_course.SelectedIndexChanged += new System.EventHandler(this.cb_course_SelectedIndexChanged);
            // 
            // DGV_instructors
            // 
            this.DGV_instructors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DGV_instructors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_instructors.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_instructors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_instructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_instructors.Location = new System.Drawing.Point(199, 51);
            this.DGV_instructors.Name = "DGV_instructors";
            this.DGV_instructors.ReadOnly = true;
            this.DGV_instructors.Size = new System.Drawing.Size(207, 212);
            this.DGV_instructors.TabIndex = 0;
            // 
            // Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_ins);
            this.Controls.Add(this.gb_mycourses);
            this.Controls.Add(this.rb_mycourses);
            this.Controls.Add(this.gb_courses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_ins);
            this.Controls.Add(this.rb_courses);
            this.Name = "Student_Form";
            this.Text = "Student_Form";
            this.Load += new System.EventHandler(this.Student_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_courses)).EndInit();
            this.gb_courses.ResumeLayout(false);
            this.gb_courses.PerformLayout();
            this.gb_mycourses.ResumeLayout(false);
            this.gb_mycourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_mycourses)).EndInit();
            this.gb_ins.ResumeLayout(false);
            this.gb_ins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_instructors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_courses;
        private System.Windows.Forms.RadioButton rb_courses;
        private System.Windows.Forms.RadioButton rb_ins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_topic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.GroupBox gb_courses;
        private System.Windows.Forms.Label lbl_select;
        private System.Windows.Forms.Label lbl_alreadyregistered;
        private System.Windows.Forms.RadioButton rb_mycourses;
        private System.Windows.Forms.GroupBox gb_mycourses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_mytopics;
        private System.Windows.Forms.DataGridView DGV_mycourses;
        private System.Windows.Forms.GroupBox gb_ins;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_course;
        private System.Windows.Forms.DataGridView DGV_instructors;
    }
}