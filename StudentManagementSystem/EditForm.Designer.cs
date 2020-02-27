namespace Student_Management_System
{
    partial class EditForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDatabaseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_EditStudent = new System.Windows.Forms.Label();
            this.rb_Postgrad = new System.Windows.Forms.RadioButton();
            this.rb_Undergrad = new System.Windows.Forms.RadioButton();
            this.cb_Course = new System.Windows.Forms.ComboBox();
            this.cbo_County = new System.Windows.Forms.ComboBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_StudentId = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_StudentId = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.txt_AddressL2 = new System.Windows.Forms.TextBox();
            this.txt_AddressL1 = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_AddressL2 = new System.Windows.Forms.Label();
            this.lbl_AddressL1 = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.dg_SearchEdit = new System.Windows.Forms.DataGridView();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_SearchEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.deleteStudentToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.viewDatabaseHistoryToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addStudentToolStripMenuItem.Text = "New Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.deleteStudentToolStripMenuItem.Text = "Edit Student";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.modifyToolStripMenuItem.Text = "Delete Student";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // viewDatabaseHistoryToolStripMenuItem
            // 
            this.viewDatabaseHistoryToolStripMenuItem.Name = "viewDatabaseHistoryToolStripMenuItem";
            this.viewDatabaseHistoryToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.viewDatabaseHistoryToolStripMenuItem.Text = "View Database History";
            this.viewDatabaseHistoryToolStripMenuItem.Click += new System.EventHandler(this.viewDatabaseHistoryToolStripMenuItem_Click);
            // 
            // lbl_EditStudent
            // 
            this.lbl_EditStudent.AutoSize = true;
            this.lbl_EditStudent.Font = new System.Drawing.Font("Arial Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EditStudent.Location = new System.Drawing.Point(24, 37);
            this.lbl_EditStudent.Name = "lbl_EditStudent";
            this.lbl_EditStudent.Size = new System.Drawing.Size(107, 20);
            this.lbl_EditStudent.TabIndex = 63;
            this.lbl_EditStudent.Text = "EDIT STUDENT";
            // 
            // rb_Postgrad
            // 
            this.rb_Postgrad.AutoSize = true;
            this.rb_Postgrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Postgrad.Location = new System.Drawing.Point(505, 542);
            this.rb_Postgrad.Name = "rb_Postgrad";
            this.rb_Postgrad.Size = new System.Drawing.Size(83, 21);
            this.rb_Postgrad.TabIndex = 61;
            this.rb_Postgrad.TabStop = true;
            this.rb_Postgrad.Text = "Postgrad";
            this.rb_Postgrad.UseVisualStyleBackColor = true;
            // 
            // rb_Undergrad
            // 
            this.rb_Undergrad.AutoSize = true;
            this.rb_Undergrad.Checked = true;
            this.rb_Undergrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Undergrad.Location = new System.Drawing.Point(396, 542);
            this.rb_Undergrad.Name = "rb_Undergrad";
            this.rb_Undergrad.Size = new System.Drawing.Size(94, 21);
            this.rb_Undergrad.TabIndex = 60;
            this.rb_Undergrad.TabStop = true;
            this.rb_Undergrad.Text = "Undergrad";
            this.rb_Undergrad.UseVisualStyleBackColor = true;
            // 
            // cb_Course
            // 
            this.cb_Course.Enabled = false;
            this.cb_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Course.FormattingEnabled = true;
            this.cb_Course.Items.AddRange(new object[] {
            "Accounting & Management",
            "Information Technology",
            "Law",
            "Marketing",
            "Psychology"});
            this.cb_Course.Location = new System.Drawing.Point(125, 545);
            this.cb_Course.Name = "cb_Course";
            this.cb_Course.Size = new System.Drawing.Size(174, 24);
            this.cb_Course.TabIndex = 59;
            // 
            // cbo_County
            // 
            this.cbo_County.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_County.FormattingEnabled = true;
            this.cbo_County.Items.AddRange(new object[] {
            "Carlow",
            "Dublin",
            "Wexford",
            "Wicklow",
            "Louth",
            "Kildare",
            "Meath",
            "Westmeath",
            "Kilkenny",
            "Laois",
            "Offaly",
            "Longford",
            "Clare",
            "Cork",
            "Kerry",
            "Limerick",
            "Tipperary",
            "Waterford",
            "Galway",
            "Leitrim",
            "Mayo",
            "Roscommon",
            "Sligo",
            "Cavan",
            "Donegal",
            "Monaghan",
            "Antrim",
            "Armagh",
            "Down",
            "Derry",
            "Fermanagh",
            "Tyrone"});
            this.cbo_County.Location = new System.Drawing.Point(454, 510);
            this.cbo_County.Name = "cbo_County";
            this.cbo_County.Size = new System.Drawing.Size(213, 24);
            this.cbo_County.TabIndex = 58;
            // 
            // txt_City
            // 
            this.txt_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_City.Location = new System.Drawing.Point(125, 511);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(174, 23);
            this.txt_City.TabIndex = 57;
            // 
            // txt_StudentId
            // 
            this.txt_StudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentId.Location = new System.Drawing.Point(125, 585);
            this.txt_StudentId.Name = "txt_StudentId";
            this.txt_StudentId.ReadOnly = true;
            this.txt_StudentId.Size = new System.Drawing.Size(174, 23);
            this.txt_StudentId.TabIndex = 62;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Location = new System.Drawing.Point(125, 372);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(542, 23);
            this.txt_Phone.TabIndex = 53;
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.Location = new System.Drawing.Point(24, 545);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(53, 17);
            this.lbl_Course.TabIndex = 52;
            this.lbl_Course.Text = "Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "County";
            // 
            // lbl_StudentId
            // 
            this.lbl_StudentId.AutoSize = true;
            this.lbl_StudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentId.Location = new System.Drawing.Point(24, 585);
            this.lbl_StudentId.Name = "lbl_StudentId";
            this.lbl_StudentId.Size = new System.Drawing.Size(83, 17);
            this.lbl_StudentId.TabIndex = 51;
            this.lbl_StudentId.Text = "Student No.";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.Location = new System.Drawing.Point(25, 511);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(31, 17);
            this.lbl_City.TabIndex = 49;
            this.lbl_City.Text = "City";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.Location = new System.Drawing.Point(25, 372);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(49, 17);
            this.lbl_Phone.TabIndex = 48;
            this.lbl_Phone.Text = "Phone";
            // 
            // txt_Surname
            // 
            this.txt_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Surname.Location = new System.Drawing.Point(125, 339);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.ReadOnly = true;
            this.txt_Surname.Size = new System.Drawing.Size(542, 23);
            this.txt_Surname.TabIndex = 47;
            // 
            // txt_AddressL2
            // 
            this.txt_AddressL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddressL2.Location = new System.Drawing.Point(125, 476);
            this.txt_AddressL2.Name = "txt_AddressL2";
            this.txt_AddressL2.Size = new System.Drawing.Size(542, 23);
            this.txt_AddressL2.TabIndex = 56;
            // 
            // txt_AddressL1
            // 
            this.txt_AddressL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddressL1.Location = new System.Drawing.Point(125, 441);
            this.txt_AddressL1.Name = "txt_AddressL1";
            this.txt_AddressL1.Size = new System.Drawing.Size(542, 23);
            this.txt_AddressL1.TabIndex = 55;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(125, 406);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(542, 23);
            this.txt_Email.TabIndex = 54;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FirstName.Location = new System.Drawing.Point(125, 306);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.ReadOnly = true;
            this.txt_FirstName.Size = new System.Drawing.Size(542, 23);
            this.txt_FirstName.TabIndex = 46;
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Surname.Location = new System.Drawing.Point(25, 339);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(65, 17);
            this.lbl_Surname.TabIndex = 44;
            this.lbl_Surname.Text = "Surname";
            // 
            // lbl_AddressL2
            // 
            this.lbl_AddressL2.AutoSize = true;
            this.lbl_AddressL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddressL2.Location = new System.Drawing.Point(24, 476);
            this.lbl_AddressL2.Name = "lbl_AddressL2";
            this.lbl_AddressL2.Size = new System.Drawing.Size(92, 17);
            this.lbl_AddressL2.TabIndex = 43;
            this.lbl_AddressL2.Text = "Address Ln 2";
            // 
            // lbl_AddressL1
            // 
            this.lbl_AddressL1.AutoSize = true;
            this.lbl_AddressL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddressL1.Location = new System.Drawing.Point(24, 441);
            this.lbl_AddressL1.Name = "lbl_AddressL1";
            this.lbl_AddressL1.Size = new System.Drawing.Size(92, 17);
            this.lbl_AddressL1.TabIndex = 42;
            this.lbl_AddressL1.Text = "Address Ln 1";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(25, 406);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(47, 17);
            this.lbl_Email.TabIndex = 45;
            this.lbl_Email.Text = "E-mail";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FirstName.Location = new System.Drawing.Point(25, 306);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(76, 17);
            this.lbl_FirstName.TabIndex = 41;
            this.lbl_FirstName.Text = "First Name";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Update.Location = new System.Drawing.Point(125, 628);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(542, 40);
            this.btn_Update.TabIndex = 64;
            this.btn_Update.Text = "UPDATE";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // dg_SearchEdit
            // 
            this.dg_SearchEdit.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dg_SearchEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_SearchEdit.Location = new System.Drawing.Point(28, 99);
            this.dg_SearchEdit.Name = "dg_SearchEdit";
            this.dg_SearchEdit.ReadOnly = true;
            this.dg_SearchEdit.Size = new System.Drawing.Size(639, 168);
            this.dg_SearchEdit.TabIndex = 65;
            this.dg_SearchEdit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_SearchEdit_CellClick);
            this.dg_SearchEdit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_SearchEdit_CellContentClick);
            this.dg_SearchEdit.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_SearchEdit_CellDoubleClick);
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Arial Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search.Location = new System.Drawing.Point(24, 70);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(176, 20);
            this.lbl_Search.TabIndex = 66;
            this.lbl_Search.Text = "SEARCH BY STUDENT NO";
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(206, 70);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(461, 23);
            this.txt_Search.TabIndex = 67;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(742, 680);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.dg_SearchEdit);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.lbl_EditStudent);
            this.Controls.Add(this.rb_Postgrad);
            this.Controls.Add(this.rb_Undergrad);
            this.Controls.Add(this.cb_Course);
            this.Controls.Add(this.cbo_County);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.txt_StudentId);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_StudentId);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.txt_Surname);
            this.Controls.Add(this.txt_AddressL2);
            this.Controls.Add(this.txt_AddressL1);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.lbl_Surname);
            this.Controls.Add(this.lbl_AddressL2);
            this.Controls.Add(this.lbl_AddressL1);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EditForm";
            this.ShowIcon = false;
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_SearchEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDatabaseHistoryToolStripMenuItem;
        private System.Windows.Forms.Label lbl_EditStudent;
        private System.Windows.Forms.RadioButton rb_Postgrad;
        private System.Windows.Forms.RadioButton rb_Undergrad;
        private System.Windows.Forms.ComboBox cb_Course;
        private System.Windows.Forms.ComboBox cbo_County;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.TextBox txt_StudentId;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_StudentId;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.TextBox txt_AddressL2;
        private System.Windows.Forms.TextBox txt_AddressL1;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.Label lbl_AddressL2;
        private System.Windows.Forms.Label lbl_AddressL1;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridView dg_SearchEdit;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.TextBox txt_Search;
    }
}