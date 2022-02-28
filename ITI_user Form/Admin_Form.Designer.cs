namespace ITI_user_Form
{
    partial class Admin_Form
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
            this.cb_topics = new System.Windows.Forms.ComboBox();
            this.rb_courses = new System.Windows.Forms.RadioButton();
            this.rb_ins = new System.Windows.Forms.RadioButton();
            this.rb_students = new System.Windows.Forms.RadioButton();
            this.rb_topic = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_crs_id = new System.Windows.Forms.TextBox();
            this.txt_crs_name = new System.Windows.Forms.TextBox();
            this.txt_crs_duration = new System.Windows.Forms.TextBox();
            this.gb_courses = new System.Windows.Forms.GroupBox();
            this.lbl_invalid = new System.Windows.Forms.Label();
            this.lbl_duplicate = new System.Windows.Forms.Label();
            this.btn_crs_update = new System.Windows.Forms.Button();
            this.btn_crs_delete = new System.Windows.Forms.Button();
            this.btn_crs_add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_topic = new System.Windows.Forms.GroupBox();
            this.lbl_invalid_top = new System.Windows.Forms.Label();
            this.lbl_dub_top = new System.Windows.Forms.Label();
            this.btn_update_topic = new System.Windows.Forms.Button();
            this.btn_delete_topic = new System.Windows.Forms.Button();
            this.btn_add_topic = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DGV_topics = new System.Windows.Forms.DataGridView();
            this.txt_top_name = new System.Windows.Forms.TextBox();
            this.txt_top_id = new System.Windows.Forms.TextBox();
            this.gb_students = new System.Windows.Forms.GroupBox();
            this.lbl_error_delete = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_sup_id = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_st_age = new System.Windows.Forms.TextBox();
            this.txt_st_lname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_st_address = new System.Windows.Forms.TextBox();
            this.lbl_dup_st = new System.Windows.Forms.Label();
            this.btn_st_delete = new System.Windows.Forms.Button();
            this.btn_st_add = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DGV_students = new System.Windows.Forms.DataGridView();
            this.cb_dept = new System.Windows.Forms.ComboBox();
            this.txt_st_fname = new System.Windows.Forms.TextBox();
            this.txt_st_id = new System.Windows.Forms.TextBox();
            this.gb_instructors = new System.Windows.Forms.GroupBox();
            this.lbl_ins_related = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_ins_degree = new System.Windows.Forms.TextBox();
            this.txt_ins_salary = new System.Windows.Forms.TextBox();
            this.lbl_ins_dup = new System.Windows.Forms.Label();
            this.btn_ins_delete = new System.Windows.Forms.Button();
            this.btn_ins_add = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.DGV_instructors = new System.Windows.Forms.DataGridView();
            this.cb_dept2 = new System.Windows.Forms.ComboBox();
            this.txt_ins_name = new System.Windows.Forms.TextBox();
            this.txt_ins_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_courses)).BeginInit();
            this.gb_courses.SuspendLayout();
            this.gb_topic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_topics)).BeginInit();
            this.gb_students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_students)).BeginInit();
            this.gb_instructors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_instructors)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_courses
            // 
            this.DGV_courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DGV_courses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_courses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_courses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_courses.Location = new System.Drawing.Point(6, 19);
            this.DGV_courses.Name = "DGV_courses";
            this.DGV_courses.Size = new System.Drawing.Size(454, 389);
            this.DGV_courses.TabIndex = 1;
            this.DGV_courses.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_courses_RowHeaderMouseClick);
            // 
            // cb_topics
            // 
            this.cb_topics.FormattingEnabled = true;
            this.cb_topics.Location = new System.Drawing.Point(596, 223);
            this.cb_topics.Name = "cb_topics";
            this.cb_topics.Size = new System.Drawing.Size(144, 21);
            this.cb_topics.TabIndex = 2;
            // 
            // rb_courses
            // 
            this.rb_courses.AutoSize = true;
            this.rb_courses.Checked = true;
            this.rb_courses.Location = new System.Drawing.Point(74, 12);
            this.rb_courses.Name = "rb_courses";
            this.rb_courses.Size = new System.Drawing.Size(63, 17);
            this.rb_courses.TabIndex = 3;
            this.rb_courses.TabStop = true;
            this.rb_courses.Text = "Courses";
            this.rb_courses.UseVisualStyleBackColor = true;
            // 
            // rb_ins
            // 
            this.rb_ins.AutoSize = true;
            this.rb_ins.Location = new System.Drawing.Point(574, 12);
            this.rb_ins.Name = "rb_ins";
            this.rb_ins.Size = new System.Drawing.Size(74, 17);
            this.rb_ins.TabIndex = 4;
            this.rb_ins.Text = "Instructors";
            this.rb_ins.UseVisualStyleBackColor = true;
            this.rb_ins.CheckedChanged += new System.EventHandler(this.rb_ins_CheckedChanged);
            // 
            // rb_students
            // 
            this.rb_students.AutoSize = true;
            this.rb_students.Location = new System.Drawing.Point(404, 12);
            this.rb_students.Name = "rb_students";
            this.rb_students.Size = new System.Drawing.Size(67, 17);
            this.rb_students.TabIndex = 5;
            this.rb_students.Text = "Students";
            this.rb_students.UseVisualStyleBackColor = true;
            this.rb_students.CheckedChanged += new System.EventHandler(this.rb_students_CheckedChanged);
            // 
            // rb_topic
            // 
            this.rb_topic.AutoSize = true;
            this.rb_topic.Location = new System.Drawing.Point(241, 12);
            this.rb_topic.Name = "rb_topic";
            this.rb_topic.Size = new System.Drawing.Size(57, 17);
            this.rb_topic.TabIndex = 6;
            this.rb_topic.Text = "Topics";
            this.rb_topic.UseVisualStyleBackColor = true;
            this.rb_topic.CheckedChanged += new System.EventHandler(this.rb_topic_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.CausesValidation = false;
            this.label1.Location = new System.Drawing.Point(-7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65535, 2);
            this.label1.TabIndex = 7;
            // 
            // txt_crs_id
            // 
            this.txt_crs_id.Location = new System.Drawing.Point(640, 86);
            this.txt_crs_id.Name = "txt_crs_id";
            this.txt_crs_id.Size = new System.Drawing.Size(100, 20);
            this.txt_crs_id.TabIndex = 8;
            // 
            // txt_crs_name
            // 
            this.txt_crs_name.Location = new System.Drawing.Point(640, 132);
            this.txt_crs_name.Name = "txt_crs_name";
            this.txt_crs_name.Size = new System.Drawing.Size(100, 20);
            this.txt_crs_name.TabIndex = 9;
            // 
            // txt_crs_duration
            // 
            this.txt_crs_duration.Location = new System.Drawing.Point(640, 179);
            this.txt_crs_duration.Name = "txt_crs_duration";
            this.txt_crs_duration.Size = new System.Drawing.Size(100, 20);
            this.txt_crs_duration.TabIndex = 10;
            // 
            // gb_courses
            // 
            this.gb_courses.Controls.Add(this.lbl_invalid);
            this.gb_courses.Controls.Add(this.lbl_duplicate);
            this.gb_courses.Controls.Add(this.btn_crs_update);
            this.gb_courses.Controls.Add(this.btn_crs_delete);
            this.gb_courses.Controls.Add(this.btn_crs_add);
            this.gb_courses.Controls.Add(this.label5);
            this.gb_courses.Controls.Add(this.label4);
            this.gb_courses.Controls.Add(this.label3);
            this.gb_courses.Controls.Add(this.label2);
            this.gb_courses.Controls.Add(this.DGV_courses);
            this.gb_courses.Controls.Add(this.txt_crs_duration);
            this.gb_courses.Controls.Add(this.cb_topics);
            this.gb_courses.Controls.Add(this.txt_crs_name);
            this.gb_courses.Controls.Add(this.txt_crs_id);
            this.gb_courses.Location = new System.Drawing.Point(43, 73);
            this.gb_courses.Name = "gb_courses";
            this.gb_courses.Size = new System.Drawing.Size(776, 414);
            this.gb_courses.TabIndex = 11;
            this.gb_courses.TabStop = false;
            this.gb_courses.Text = "Courses";
            // 
            // lbl_invalid
            // 
            this.lbl_invalid.AutoSize = true;
            this.lbl_invalid.ForeColor = System.Drawing.Color.Red;
            this.lbl_invalid.Location = new System.Drawing.Point(519, 294);
            this.lbl_invalid.Name = "lbl_invalid";
            this.lbl_invalid.Size = new System.Drawing.Size(238, 13);
            this.lbl_invalid.TabIndex = 23;
            this.lbl_invalid.Text = "Can\'t perfom because it is related to another data";
            this.lbl_invalid.Visible = false;
            // 
            // lbl_duplicate
            // 
            this.lbl_duplicate.AutoSize = true;
            this.lbl_duplicate.ForeColor = System.Drawing.Color.Red;
            this.lbl_duplicate.Location = new System.Drawing.Point(615, 307);
            this.lbl_duplicate.Name = "lbl_duplicate";
            this.lbl_duplicate.Size = new System.Drawing.Size(142, 13);
            this.lbl_duplicate.TabIndex = 22;
            this.lbl_duplicate.Text = "ID duplicated or Invalid Data";
            this.lbl_duplicate.Visible = false;
            // 
            // btn_crs_update
            // 
            this.btn_crs_update.Enabled = false;
            this.btn_crs_update.Location = new System.Drawing.Point(581, 340);
            this.btn_crs_update.Name = "btn_crs_update";
            this.btn_crs_update.Size = new System.Drawing.Size(78, 29);
            this.btn_crs_update.TabIndex = 17;
            this.btn_crs_update.Text = "Update";
            this.btn_crs_update.UseVisualStyleBackColor = true;
            this.btn_crs_update.Click += new System.EventHandler(this.btn_crs_update_Click);
            // 
            // btn_crs_delete
            // 
            this.btn_crs_delete.Enabled = false;
            this.btn_crs_delete.Location = new System.Drawing.Point(468, 340);
            this.btn_crs_delete.Name = "btn_crs_delete";
            this.btn_crs_delete.Size = new System.Drawing.Size(78, 29);
            this.btn_crs_delete.TabIndex = 16;
            this.btn_crs_delete.Text = "Delete";
            this.btn_crs_delete.UseVisualStyleBackColor = true;
            this.btn_crs_delete.Click += new System.EventHandler(this.btn_crs_delete_Click);
            // 
            // btn_crs_add
            // 
            this.btn_crs_add.Location = new System.Drawing.Point(683, 340);
            this.btn_crs_add.Name = "btn_crs_add";
            this.btn_crs_add.Size = new System.Drawing.Size(85, 29);
            this.btn_crs_add.TabIndex = 15;
            this.btn_crs_add.Text = "Add Course";
            this.btn_crs_add.UseVisualStyleBackColor = true;
            this.btn_crs_add.Click += new System.EventHandler(this.btn_crs_add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Course ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Topic";
            // 
            // gb_topic
            // 
            this.gb_topic.Controls.Add(this.lbl_invalid_top);
            this.gb_topic.Controls.Add(this.lbl_dub_top);
            this.gb_topic.Controls.Add(this.btn_update_topic);
            this.gb_topic.Controls.Add(this.btn_delete_topic);
            this.gb_topic.Controls.Add(this.btn_add_topic);
            this.gb_topic.Controls.Add(this.label8);
            this.gb_topic.Controls.Add(this.label9);
            this.gb_topic.Controls.Add(this.DGV_topics);
            this.gb_topic.Controls.Add(this.txt_top_name);
            this.gb_topic.Controls.Add(this.txt_top_id);
            this.gb_topic.Location = new System.Drawing.Point(49, 67);
            this.gb_topic.Name = "gb_topic";
            this.gb_topic.Size = new System.Drawing.Size(692, 393);
            this.gb_topic.TabIndex = 12;
            this.gb_topic.TabStop = false;
            this.gb_topic.Text = "Topics";
            this.gb_topic.Visible = false;
            // 
            // lbl_invalid_top
            // 
            this.lbl_invalid_top.AutoSize = true;
            this.lbl_invalid_top.ForeColor = System.Drawing.Color.Red;
            this.lbl_invalid_top.Location = new System.Drawing.Point(447, 301);
            this.lbl_invalid_top.Name = "lbl_invalid_top";
            this.lbl_invalid_top.Size = new System.Drawing.Size(239, 13);
            this.lbl_invalid_top.TabIndex = 37;
            this.lbl_invalid_top.Text = "can\'t delete becausse it is related to another data";
            this.lbl_invalid_top.Visible = false;
            // 
            // lbl_dub_top
            // 
            this.lbl_dub_top.AutoSize = true;
            this.lbl_dub_top.ForeColor = System.Drawing.Color.Red;
            this.lbl_dub_top.Location = new System.Drawing.Point(537, 288);
            this.lbl_dub_top.Name = "lbl_dub_top";
            this.lbl_dub_top.Size = new System.Drawing.Size(142, 13);
            this.lbl_dub_top.TabIndex = 36;
            this.lbl_dub_top.Text = "ID duplicated or Invalid Data";
            this.lbl_dub_top.Visible = false;
            // 
            // btn_update_topic
            // 
            this.btn_update_topic.Enabled = false;
            this.btn_update_topic.Location = new System.Drawing.Point(488, 334);
            this.btn_update_topic.Name = "btn_update_topic";
            this.btn_update_topic.Size = new System.Drawing.Size(78, 29);
            this.btn_update_topic.TabIndex = 35;
            this.btn_update_topic.Text = "Update";
            this.btn_update_topic.UseVisualStyleBackColor = true;
            this.btn_update_topic.Click += new System.EventHandler(this.btn_update_topic_Click_1);
            // 
            // btn_delete_topic
            // 
            this.btn_delete_topic.Enabled = false;
            this.btn_delete_topic.Location = new System.Drawing.Point(375, 334);
            this.btn_delete_topic.Name = "btn_delete_topic";
            this.btn_delete_topic.Size = new System.Drawing.Size(78, 29);
            this.btn_delete_topic.TabIndex = 34;
            this.btn_delete_topic.Text = "Delete";
            this.btn_delete_topic.UseVisualStyleBackColor = true;
            this.btn_delete_topic.Click += new System.EventHandler(this.btn_delete_topic_Click_1);
            // 
            // btn_add_topic
            // 
            this.btn_add_topic.Location = new System.Drawing.Point(594, 334);
            this.btn_add_topic.Name = "btn_add_topic";
            this.btn_add_topic.Size = new System.Drawing.Size(85, 29);
            this.btn_add_topic.TabIndex = 33;
            this.btn_add_topic.Text = "Add Topic";
            this.btn_add_topic.UseVisualStyleBackColor = true;
            this.btn_add_topic.Click += new System.EventHandler(this.btn_add_topic_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Topic ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(439, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Topic Name";
            // 
            // DGV_topics
            // 
            this.DGV_topics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DGV_topics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_topics.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_topics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_topics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_topics.Location = new System.Drawing.Point(30, 19);
            this.DGV_topics.Name = "DGV_topics";
            this.DGV_topics.Size = new System.Drawing.Size(269, 350);
            this.DGV_topics.TabIndex = 24;
            this.DGV_topics.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_topics_RowHeaderMouseClick_1);
            // 
            // txt_top_name
            // 
            this.txt_top_name.Location = new System.Drawing.Point(547, 126);
            this.txt_top_name.Name = "txt_top_name";
            this.txt_top_name.Size = new System.Drawing.Size(100, 20);
            this.txt_top_name.TabIndex = 27;
            // 
            // txt_top_id
            // 
            this.txt_top_id.Location = new System.Drawing.Point(547, 80);
            this.txt_top_id.Name = "txt_top_id";
            this.txt_top_id.Size = new System.Drawing.Size(100, 20);
            this.txt_top_id.TabIndex = 26;
            // 
            // gb_students
            // 
            this.gb_students.Controls.Add(this.lbl_error_delete);
            this.gb_students.Controls.Add(this.label12);
            this.gb_students.Controls.Add(this.cb_sup_id);
            this.gb_students.Controls.Add(this.label16);
            this.gb_students.Controls.Add(this.label17);
            this.gb_students.Controls.Add(this.txt_st_age);
            this.gb_students.Controls.Add(this.txt_st_lname);
            this.gb_students.Controls.Add(this.label14);
            this.gb_students.Controls.Add(this.txt_st_address);
            this.gb_students.Controls.Add(this.lbl_dup_st);
            this.gb_students.Controls.Add(this.btn_st_delete);
            this.gb_students.Controls.Add(this.btn_st_add);
            this.gb_students.Controls.Add(this.label10);
            this.gb_students.Controls.Add(this.label11);
            this.gb_students.Controls.Add(this.label13);
            this.gb_students.Controls.Add(this.DGV_students);
            this.gb_students.Controls.Add(this.cb_dept);
            this.gb_students.Controls.Add(this.txt_st_fname);
            this.gb_students.Controls.Add(this.txt_st_id);
            this.gb_students.Location = new System.Drawing.Point(58, 73);
            this.gb_students.Name = "gb_students";
            this.gb_students.Size = new System.Drawing.Size(725, 427);
            this.gb_students.TabIndex = 13;
            this.gb_students.TabStop = false;
            this.gb_students.Text = "Students";
            this.gb_students.Visible = false;
            // 
            // lbl_error_delete
            // 
            this.lbl_error_delete.AutoSize = true;
            this.lbl_error_delete.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_delete.Location = new System.Drawing.Point(487, 290);
            this.lbl_error_delete.Name = "lbl_error_delete";
            this.lbl_error_delete.Size = new System.Drawing.Size(223, 13);
            this.lbl_error_delete.TabIndex = 48;
            this.lbl_error_delete.Text = "Can\'t delete because it is related to other data";
            this.lbl_error_delete.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(512, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Supervisor";
            // 
            // cb_sup_id
            // 
            this.cb_sup_id.FormattingEnabled = true;
            this.cb_sup_id.Location = new System.Drawing.Point(584, 186);
            this.cb_sup_id.Name = "cb_sup_id";
            this.cb_sup_id.Size = new System.Drawing.Size(135, 21);
            this.cb_sup_id.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(511, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Last Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(511, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Adderss";
            // 
            // txt_st_age
            // 
            this.txt_st_age.Location = new System.Drawing.Point(619, 123);
            this.txt_st_age.Name = "txt_st_age";
            this.txt_st_age.Size = new System.Drawing.Size(100, 20);
            this.txt_st_age.TabIndex = 43;
            // 
            // txt_st_lname
            // 
            this.txt_st_lname.Location = new System.Drawing.Point(619, 71);
            this.txt_st_lname.Name = "txt_st_lname";
            this.txt_st_lname.Size = new System.Drawing.Size(100, 20);
            this.txt_st_lname.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(511, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Age";
            // 
            // txt_st_address
            // 
            this.txt_st_address.Location = new System.Drawing.Point(619, 97);
            this.txt_st_address.Name = "txt_st_address";
            this.txt_st_address.Size = new System.Drawing.Size(100, 20);
            this.txt_st_address.TabIndex = 38;
            // 
            // lbl_dup_st
            // 
            this.lbl_dup_st.AutoSize = true;
            this.lbl_dup_st.ForeColor = System.Drawing.Color.Red;
            this.lbl_dup_st.Location = new System.Drawing.Point(528, 273);
            this.lbl_dup_st.Name = "lbl_dup_st";
            this.lbl_dup_st.Size = new System.Drawing.Size(142, 13);
            this.lbl_dup_st.TabIndex = 36;
            this.lbl_dup_st.Text = "ID duplicated or Invalid Data";
            this.lbl_dup_st.Visible = false;
            // 
            // btn_st_delete
            // 
            this.btn_st_delete.Enabled = false;
            this.btn_st_delete.Location = new System.Drawing.Point(490, 306);
            this.btn_st_delete.Name = "btn_st_delete";
            this.btn_st_delete.Size = new System.Drawing.Size(78, 29);
            this.btn_st_delete.TabIndex = 34;
            this.btn_st_delete.Text = "Delete";
            this.btn_st_delete.UseVisualStyleBackColor = true;
            this.btn_st_delete.Click += new System.EventHandler(this.txt_st_delete_Click);
            // 
            // btn_st_add
            // 
            this.btn_st_add.Location = new System.Drawing.Point(614, 306);
            this.btn_st_add.Name = "btn_st_add";
            this.btn_st_add.Size = new System.Drawing.Size(85, 29);
            this.btn_st_add.TabIndex = 33;
            this.btn_st_add.Text = "Add Student";
            this.btn_st_add.UseVisualStyleBackColor = true;
            this.btn_st_add.Click += new System.EventHandler(this.btn_st_add_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(511, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Student ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(511, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "First Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(512, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Department";
            // 
            // DGV_students
            // 
            this.DGV_students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DGV_students.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_students.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_students.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_students.Location = new System.Drawing.Point(6, 19);
            this.DGV_students.Name = "DGV_students";
            this.DGV_students.Size = new System.Drawing.Size(454, 389);
            this.DGV_students.TabIndex = 24;
            this.DGV_students.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_students_RowHeaderMouseClick);
            // 
            // cb_dept
            // 
            this.cb_dept.FormattingEnabled = true;
            this.cb_dept.Location = new System.Drawing.Point(584, 159);
            this.cb_dept.Name = "cb_dept";
            this.cb_dept.Size = new System.Drawing.Size(135, 21);
            this.cb_dept.TabIndex = 25;
            // 
            // txt_st_fname
            // 
            this.txt_st_fname.Location = new System.Drawing.Point(619, 45);
            this.txt_st_fname.Name = "txt_st_fname";
            this.txt_st_fname.Size = new System.Drawing.Size(100, 20);
            this.txt_st_fname.TabIndex = 27;
            // 
            // txt_st_id
            // 
            this.txt_st_id.Location = new System.Drawing.Point(619, 19);
            this.txt_st_id.Name = "txt_st_id";
            this.txt_st_id.Size = new System.Drawing.Size(100, 20);
            this.txt_st_id.TabIndex = 26;
            // 
            // gb_instructors
            // 
            this.gb_instructors.Controls.Add(this.lbl_ins_related);
            this.gb_instructors.Controls.Add(this.label15);
            this.gb_instructors.Controls.Add(this.label18);
            this.gb_instructors.Controls.Add(this.txt_ins_degree);
            this.gb_instructors.Controls.Add(this.txt_ins_salary);
            this.gb_instructors.Controls.Add(this.lbl_ins_dup);
            this.gb_instructors.Controls.Add(this.btn_ins_delete);
            this.gb_instructors.Controls.Add(this.btn_ins_add);
            this.gb_instructors.Controls.Add(this.label21);
            this.gb_instructors.Controls.Add(this.label22);
            this.gb_instructors.Controls.Add(this.label23);
            this.gb_instructors.Controls.Add(this.DGV_instructors);
            this.gb_instructors.Controls.Add(this.cb_dept2);
            this.gb_instructors.Controls.Add(this.txt_ins_name);
            this.gb_instructors.Controls.Add(this.txt_ins_id);
            this.gb_instructors.Location = new System.Drawing.Point(74, 67);
            this.gb_instructors.Name = "gb_instructors";
            this.gb_instructors.Size = new System.Drawing.Size(750, 427);
            this.gb_instructors.TabIndex = 49;
            this.gb_instructors.TabStop = false;
            this.gb_instructors.Text = "Instructors";
            this.gb_instructors.Visible = false;
            // 
            // lbl_ins_related
            // 
            this.lbl_ins_related.AutoSize = true;
            this.lbl_ins_related.ForeColor = System.Drawing.Color.Red;
            this.lbl_ins_related.Location = new System.Drawing.Point(511, 293);
            this.lbl_ins_related.Name = "lbl_ins_related";
            this.lbl_ins_related.Size = new System.Drawing.Size(223, 13);
            this.lbl_ins_related.TabIndex = 48;
            this.lbl_ins_related.Text = "Can\'t delete because it is related to other data";
            this.lbl_ins_related.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(536, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Instructor Degree";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(536, 155);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 44;
            this.label18.Text = "Salary";
            // 
            // txt_ins_degree
            // 
            this.txt_ins_degree.Location = new System.Drawing.Point(644, 104);
            this.txt_ins_degree.Name = "txt_ins_degree";
            this.txt_ins_degree.Size = new System.Drawing.Size(100, 20);
            this.txt_ins_degree.TabIndex = 42;
            // 
            // txt_ins_salary
            // 
            this.txt_ins_salary.Location = new System.Drawing.Point(644, 148);
            this.txt_ins_salary.Name = "txt_ins_salary";
            this.txt_ins_salary.Size = new System.Drawing.Size(100, 20);
            this.txt_ins_salary.TabIndex = 38;
            // 
            // lbl_ins_dup
            // 
            this.lbl_ins_dup.AutoSize = true;
            this.lbl_ins_dup.ForeColor = System.Drawing.Color.Red;
            this.lbl_ins_dup.Location = new System.Drawing.Point(592, 280);
            this.lbl_ins_dup.Name = "lbl_ins_dup";
            this.lbl_ins_dup.Size = new System.Drawing.Size(142, 13);
            this.lbl_ins_dup.TabIndex = 36;
            this.lbl_ins_dup.Text = "Invalid Data or ID duplicated";
            this.lbl_ins_dup.Visible = false;
            // 
            // btn_ins_delete
            // 
            this.btn_ins_delete.Enabled = false;
            this.btn_ins_delete.Location = new System.Drawing.Point(514, 309);
            this.btn_ins_delete.Name = "btn_ins_delete";
            this.btn_ins_delete.Size = new System.Drawing.Size(78, 29);
            this.btn_ins_delete.TabIndex = 34;
            this.btn_ins_delete.Text = "Delete";
            this.btn_ins_delete.UseVisualStyleBackColor = true;
            this.btn_ins_delete.Click += new System.EventHandler(this.btn_ins_delete_Click);
            // 
            // btn_ins_add
            // 
            this.btn_ins_add.Location = new System.Drawing.Point(638, 309);
            this.btn_ins_add.Name = "btn_ins_add";
            this.btn_ins_add.Size = new System.Drawing.Size(85, 29);
            this.btn_ins_add.TabIndex = 33;
            this.btn_ins_add.Text = "Add Instructor";
            this.btn_ins_add.UseVisualStyleBackColor = true;
            this.btn_ins_add.Click += new System.EventHandler(this.btn_ins_add_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(536, 37);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 13);
            this.label21.TabIndex = 32;
            this.label21.Text = "Instructor ID";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(536, 74);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 13);
            this.label22.TabIndex = 31;
            this.label22.Text = "Instructor Name";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(537, 197);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 13);
            this.label23.TabIndex = 29;
            this.label23.Text = "Department";
            // 
            // DGV_instructors
            // 
            this.DGV_instructors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DGV_instructors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_instructors.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_instructors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_instructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_instructors.Location = new System.Drawing.Point(6, 19);
            this.DGV_instructors.Name = "DGV_instructors";
            this.DGV_instructors.Size = new System.Drawing.Size(483, 389);
            this.DGV_instructors.TabIndex = 24;
            this.DGV_instructors.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_instructors_RowHeaderMouseClick);
            // 
            // cb_dept2
            // 
            this.cb_dept2.FormattingEnabled = true;
            this.cb_dept2.Location = new System.Drawing.Point(609, 189);
            this.cb_dept2.Name = "cb_dept2";
            this.cb_dept2.Size = new System.Drawing.Size(135, 21);
            this.cb_dept2.TabIndex = 25;
            // 
            // txt_ins_name
            // 
            this.txt_ins_name.Location = new System.Drawing.Point(644, 67);
            this.txt_ins_name.Name = "txt_ins_name";
            this.txt_ins_name.Size = new System.Drawing.Size(100, 20);
            this.txt_ins_name.TabIndex = 27;
            // 
            // txt_ins_id
            // 
            this.txt_ins_id.Location = new System.Drawing.Point(644, 30);
            this.txt_ins_id.Name = "txt_ins_id";
            this.txt_ins_id.Size = new System.Drawing.Size(100, 20);
            this.txt_ins_id.TabIndex = 26;
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 528);
            this.Controls.Add(this.gb_instructors);
            this.Controls.Add(this.gb_topic);
            this.Controls.Add(this.gb_students);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_topic);
            this.Controls.Add(this.rb_students);
            this.Controls.Add(this.rb_ins);
            this.Controls.Add(this.gb_courses);
            this.Controls.Add(this.rb_courses);
            this.Name = "Admin_Form";
            this.Text = "Admin_Form";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_courses)).EndInit();
            this.gb_courses.ResumeLayout(false);
            this.gb_courses.PerformLayout();
            this.gb_topic.ResumeLayout(false);
            this.gb_topic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_topics)).EndInit();
            this.gb_students.ResumeLayout(false);
            this.gb_students.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_students)).EndInit();
            this.gb_instructors.ResumeLayout(false);
            this.gb_instructors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_instructors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_courses;
        private System.Windows.Forms.ComboBox cb_topics;
        private System.Windows.Forms.RadioButton rb_courses;
        private System.Windows.Forms.RadioButton rb_ins;
        private System.Windows.Forms.RadioButton rb_students;
        private System.Windows.Forms.RadioButton rb_topic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_crs_id;
        private System.Windows.Forms.TextBox txt_crs_name;
        private System.Windows.Forms.TextBox txt_crs_duration;
        private System.Windows.Forms.GroupBox gb_courses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_crs_update;
        private System.Windows.Forms.Button btn_crs_delete;
        private System.Windows.Forms.Button btn_crs_add;
        private System.Windows.Forms.Label lbl_duplicate;
        private System.Windows.Forms.Label lbl_invalid;
        private System.Windows.Forms.GroupBox gb_topic;
        private System.Windows.Forms.Label lbl_invalid_top;
        private System.Windows.Forms.Label lbl_dub_top;
        private System.Windows.Forms.Button btn_update_topic;
        private System.Windows.Forms.Button btn_delete_topic;
        private System.Windows.Forms.Button btn_add_topic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DGV_topics;
        private System.Windows.Forms.TextBox txt_top_name;
        private System.Windows.Forms.TextBox txt_top_id;
        private System.Windows.Forms.GroupBox gb_students;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_st_age;
        private System.Windows.Forms.TextBox txt_st_lname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_st_address;
        private System.Windows.Forms.Label lbl_dup_st;
        private System.Windows.Forms.Button btn_st_delete;
        private System.Windows.Forms.Button btn_st_add;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView DGV_students;
        private System.Windows.Forms.ComboBox cb_dept;
        private System.Windows.Forms.TextBox txt_st_fname;
        private System.Windows.Forms.TextBox txt_st_id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_sup_id;
        private System.Windows.Forms.Label lbl_error_delete;
        private System.Windows.Forms.GroupBox gb_instructors;
        private System.Windows.Forms.Label lbl_ins_related;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_ins_degree;
        private System.Windows.Forms.TextBox txt_ins_salary;
        private System.Windows.Forms.Label lbl_ins_dup;
        private System.Windows.Forms.Button btn_ins_delete;
        private System.Windows.Forms.Button btn_ins_add;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView DGV_instructors;
        private System.Windows.Forms.ComboBox cb_dept2;
        private System.Windows.Forms.TextBox txt_ins_name;
        private System.Windows.Forms.TextBox txt_ins_id;
    }
}