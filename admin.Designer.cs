namespace ComLabSystem
{
    partial class admin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            dataGridView1 = new DataGridView();
            button1 = new Button();
            datasheetsTable = new DataGridView();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            middlename = new DataGridViewTextBoxColumn();
            coursecode = new DataGridViewTextBoxColumn();
            instructor = new DataGridViewTextBoxColumn();
            yearlevel = new DataGridViewTextBoxColumn();
            department = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            userid = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            refreshButton1 = new Button();
            logout = new Button();
            panel1 = new Panel();
            logsButton = new Button();
            datasheetsButton = new Button();
            registerButton = new Button();
            logoBox = new PictureBox();
            titleLabel = new Label();
            id = new DataGridViewTextBoxColumn();
            addButton = new Button();
            lastnameLabel = new Label();
            firstnameLabel = new Label();
            middlenameLabel = new Label();
            coursecodeLabel = new Label();
            yearlevelLabel = new Label();
            departmentLabel = new Label();
            genderLabel = new Label();
            emailLabel = new Label();
            usernameLabel = new Label();
            useridLabel = new Label();
            passwordLabel = new Label();
            instructorLabel = new Label();
            lastnameBox = new TextBox();
            firstnameBox = new TextBox();
            middlenameBox = new TextBox();
            coursecodeBox = new TextBox();
            instructorBox = new TextBox();
            yearlevelBox = new TextBox();
            departmentBox = new TextBox();
            genderBox = new TextBox();
            emailBox = new TextBox();
            usernameBox = new TextBox();
            useridBox = new TextBox();
            passwordBox = new TextBox();
            searchBar = new TextBox();
            logsTable = new DataGridView();
            usersname = new DataGridViewTextBoxColumn();
            time_in = new DataGridViewTextBoxColumn();
            time_out = new DataGridViewTextBoxColumn();
            refreshButton2 = new Button();
            typeBox = new TextBox();
            typeLabel = new Label();
            recentTimein = new Button();
            recentTimeout = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datasheetsTable).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logsTable).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // datasheetsTable
            // 
            datasheetsTable.AllowUserToAddRows = false;
            datasheetsTable.AllowUserToDeleteRows = false;
            datasheetsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datasheetsTable.Columns.AddRange(new DataGridViewColumn[] { LastName, FirstName, middlename, coursecode, instructor, yearlevel, department, gender, email, userid, username, password, type });
            datasheetsTable.Location = new Point(12, 268);
            datasheetsTable.Name = "datasheetsTable";
            datasheetsTable.ReadOnly = true;
            datasheetsTable.RowHeadersWidth = 62;
            datasheetsTable.Size = new Size(1896, 801);
            datasheetsTable.TabIndex = 0;
            datasheetsTable.CellContentClick += datasheetsTable_CellContentClick;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "lastname";
            LastName.HeaderText = "Last Name";
            LastName.MinimumWidth = 8;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Width = 150;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "firstname";
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 8;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Width = 150;
            // 
            // middlename
            // 
            middlename.DataPropertyName = "middlename";
            middlename.HeaderText = "Middle Name";
            middlename.MinimumWidth = 8;
            middlename.Name = "middlename";
            middlename.ReadOnly = true;
            middlename.Width = 150;
            // 
            // coursecode
            // 
            coursecode.DataPropertyName = "coursecode";
            coursecode.HeaderText = "Course Code";
            coursecode.MinimumWidth = 8;
            coursecode.Name = "coursecode";
            coursecode.ReadOnly = true;
            coursecode.Width = 150;
            // 
            // instructor
            // 
            instructor.DataPropertyName = "instructor";
            instructor.HeaderText = "Instructor";
            instructor.MinimumWidth = 8;
            instructor.Name = "instructor";
            instructor.ReadOnly = true;
            instructor.Width = 150;
            // 
            // yearlevel
            // 
            yearlevel.DataPropertyName = "yearlevel";
            yearlevel.HeaderText = "Year Level";
            yearlevel.MinimumWidth = 8;
            yearlevel.Name = "yearlevel";
            yearlevel.ReadOnly = true;
            yearlevel.Width = 150;
            // 
            // department
            // 
            department.DataPropertyName = "department";
            department.HeaderText = "Department";
            department.MinimumWidth = 8;
            department.Name = "department";
            department.ReadOnly = true;
            department.Width = 150;
            // 
            // gender
            // 
            gender.DataPropertyName = "gender";
            gender.HeaderText = "Gender";
            gender.MinimumWidth = 8;
            gender.Name = "gender";
            gender.ReadOnly = true;
            gender.Width = 150;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.MinimumWidth = 8;
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 150;
            // 
            // userid
            // 
            userid.DataPropertyName = "userid";
            userid.HeaderText = "User ID";
            userid.MinimumWidth = 8;
            userid.Name = "userid";
            userid.ReadOnly = true;
            userid.Width = 150;
            // 
            // username
            // 
            username.DataPropertyName = "username";
            username.HeaderText = "Username";
            username.MinimumWidth = 8;
            username.Name = "username";
            username.ReadOnly = true;
            username.Width = 150;
            // 
            // password
            // 
            password.DataPropertyName = "password";
            password.HeaderText = "Password";
            password.MinimumWidth = 8;
            password.Name = "password";
            password.ReadOnly = true;
            password.Width = 150;
            // 
            // type
            // 
            type.DataPropertyName = "type";
            type.HeaderText = "Type";
            type.MinimumWidth = 8;
            type.Name = "type";
            type.ReadOnly = true;
            type.Width = 150;
            // 
            // refreshButton1
            // 
            refreshButton1.Cursor = Cursors.Hand;
            refreshButton1.Location = new Point(12, 222);
            refreshButton1.Name = "refreshButton1";
            refreshButton1.Size = new Size(153, 40);
            refreshButton1.TabIndex = 1;
            refreshButton1.Text = "REFRESH";
            toolTip1.SetToolTip(refreshButton1, "Click to Refresh the Table.");
            refreshButton1.UseVisualStyleBackColor = true;
            refreshButton1.Click += refreshButton1_Click;
            // 
            // logout
            // 
            logout.BackColor = Color.Maroon;
            logout.ForeColor = SystemColors.ButtonHighlight;
            logout.Location = new Point(1760, 14);
            logout.Name = "logout";
            logout.Size = new Size(148, 65);
            logout.TabIndex = 2;
            logout.Text = "LOGOUT";
            toolTip1.SetToolTip(logout, "Click to Logout.");
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(logsButton);
            panel1.Controls.Add(datasheetsButton);
            panel1.Controls.Add(registerButton);
            panel1.Controls.Add(logout);
            panel1.Location = new Point(0, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(1939, 94);
            panel1.TabIndex = 3;
            // 
            // logsButton
            // 
            logsButton.BackColor = Color.Maroon;
            logsButton.Cursor = Cursors.Hand;
            logsButton.ForeColor = Color.White;
            logsButton.Location = new Point(380, 14);
            logsButton.Name = "logsButton";
            logsButton.Size = new Size(128, 65);
            logsButton.TabIndex = 5;
            logsButton.Text = "LOGS";
            toolTip1.SetToolTip(logsButton, "Click to Show the Logs (It contains the History of recent Time in/Time out of every Users).");
            logsButton.UseVisualStyleBackColor = false;
            logsButton.Click += logsButton_Click_1;
            // 
            // datasheetsButton
            // 
            datasheetsButton.BackColor = Color.Maroon;
            datasheetsButton.Cursor = Cursors.Hand;
            datasheetsButton.ForeColor = Color.White;
            datasheetsButton.Location = new Point(41, 14);
            datasheetsButton.Name = "datasheetsButton";
            datasheetsButton.Size = new Size(124, 65);
            datasheetsButton.TabIndex = 4;
            datasheetsButton.Text = "Data Sheets";
            toolTip1.SetToolTip(datasheetsButton, "Click to Show the Data Sheets (It contains all the registered Users in a table).");
            datasheetsButton.UseVisualStyleBackColor = false;
            datasheetsButton.Click += datasheetsButton_Click;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.Maroon;
            registerButton.Cursor = Cursors.Hand;
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(210, 14);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(128, 65);
            registerButton.TabIndex = 3;
            registerButton.Text = "REGISTER";
            toolTip1.SetToolTip(registerButton, "Click to open the Register Form (This is where you can add a new User).");
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // logoBox
            // 
            logoBox.Image = Properties.Resources.NBSPI_Logo_transparent;
            logoBox.Location = new Point(41, -1);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(144, 120);
            logoBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox.TabIndex = 4;
            logoBox.TabStop = false;
            toolTip1.SetToolTip(logoBox, "The NBSPI Logo.");
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.Maroon;
            titleLabel.Location = new Point(191, -1);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(1019, 120);
            titleLabel.TabIndex = 5;
            titleLabel.Text = "Computer Laboratory Log Management System";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            id.DataPropertyName = "(id";
            id.HeaderText = "Student ID";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.Width = 150;
            // 
            // addButton
            // 
            addButton.Cursor = Cursors.Hand;
            addButton.Location = new Point(1203, 631);
            addButton.Name = "addButton";
            addButton.Size = new Size(137, 59);
            addButton.TabIndex = 18;
            addButton.Text = "ADD";
            toolTip1.SetToolTip(addButton, "Click to Add.");
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // lastnameLabel
            // 
            lastnameLabel.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lastnameLabel.Location = new Point(418, 342);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new Size(173, 38);
            lastnameLabel.TabIndex = 20;
            lastnameLabel.Text = "Last Name:";
            lastnameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // firstnameLabel
            // 
            firstnameLabel.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point);
            firstnameLabel.Location = new Point(418, 396);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new Size(173, 38);
            firstnameLabel.TabIndex = 21;
            firstnameLabel.Text = "First Name:";
            firstnameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // middlenameLabel
            // 
            middlenameLabel.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point);
            middlenameLabel.Location = new Point(418, 444);
            middlenameLabel.Name = "middlenameLabel";
            middlenameLabel.Size = new Size(173, 38);
            middlenameLabel.TabIndex = 22;
            middlenameLabel.Text = "Middle Name:";
            middlenameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // coursecodeLabel
            // 
            coursecodeLabel.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point);
            coursecodeLabel.Location = new Point(418, 490);
            coursecodeLabel.Name = "coursecodeLabel";
            coursecodeLabel.Size = new Size(173, 38);
            coursecodeLabel.TabIndex = 23;
            coursecodeLabel.Text = "Course Code:";
            coursecodeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yearlevelLabel
            // 
            yearlevelLabel.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point);
            yearlevelLabel.Location = new Point(418, 576);
            yearlevelLabel.Name = "yearlevelLabel";
            yearlevelLabel.Size = new Size(173, 38);
            yearlevelLabel.TabIndex = 24;
            yearlevelLabel.Text = "Year Level:";
            yearlevelLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // departmentLabel
            // 
            departmentLabel.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point);
            departmentLabel.Location = new Point(418, 624);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(173, 38);
            departmentLabel.TabIndex = 25;
            departmentLabel.Text = "Department:";
            departmentLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // genderLabel
            // 
            genderLabel.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point);
            genderLabel.Location = new Point(970, 342);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(139, 38);
            genderLabel.TabIndex = 26;
            genderLabel.Text = "Gender:";
            genderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            emailLabel.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.Location = new Point(970, 396);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(139, 38);
            emailLabel.TabIndex = 27;
            emailLabel.Text = "Email:";
            emailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            usernameLabel.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.Location = new Point(970, 444);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(139, 38);
            usernameLabel.TabIndex = 28;
            usernameLabel.Text = "Username:";
            usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // useridLabel
            // 
            useridLabel.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point);
            useridLabel.Location = new Point(970, 490);
            useridLabel.Name = "useridLabel";
            useridLabel.Size = new Size(139, 38);
            useridLabel.TabIndex = 29;
            useridLabel.Text = "User ID:";
            useridLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            passwordLabel.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(970, 534);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(139, 38);
            passwordLabel.TabIndex = 30;
            passwordLabel.Text = "Password:";
            passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            passwordLabel.Click += passwordLabel_Click;
            // 
            // instructorLabel
            // 
            instructorLabel.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point);
            instructorLabel.Location = new Point(418, 534);
            instructorLabel.Name = "instructorLabel";
            instructorLabel.Size = new Size(173, 38);
            instructorLabel.TabIndex = 32;
            instructorLabel.Text = "Instructor:";
            instructorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lastnameBox
            // 
            lastnameBox.Cursor = Cursors.IBeam;
            lastnameBox.Location = new Point(588, 349);
            lastnameBox.Name = "lastnameBox";
            lastnameBox.Size = new Size(334, 31);
            lastnameBox.TabIndex = 33;
            // 
            // firstnameBox
            // 
            firstnameBox.Cursor = Cursors.IBeam;
            firstnameBox.Location = new Point(588, 401);
            firstnameBox.Name = "firstnameBox";
            firstnameBox.Size = new Size(334, 31);
            firstnameBox.TabIndex = 34;
            // 
            // middlenameBox
            // 
            middlenameBox.Cursor = Cursors.IBeam;
            middlenameBox.Location = new Point(588, 449);
            middlenameBox.Name = "middlenameBox";
            middlenameBox.Size = new Size(334, 31);
            middlenameBox.TabIndex = 35;
            // 
            // coursecodeBox
            // 
            coursecodeBox.Cursor = Cursors.IBeam;
            coursecodeBox.Location = new Point(588, 495);
            coursecodeBox.Name = "coursecodeBox";
            coursecodeBox.Size = new Size(334, 31);
            coursecodeBox.TabIndex = 36;
            // 
            // instructorBox
            // 
            instructorBox.Cursor = Cursors.IBeam;
            instructorBox.Location = new Point(588, 539);
            instructorBox.Name = "instructorBox";
            instructorBox.Size = new Size(334, 31);
            instructorBox.TabIndex = 37;
            // 
            // yearlevelBox
            // 
            yearlevelBox.Cursor = Cursors.IBeam;
            yearlevelBox.Location = new Point(588, 583);
            yearlevelBox.Name = "yearlevelBox";
            yearlevelBox.Size = new Size(334, 31);
            yearlevelBox.TabIndex = 38;
            // 
            // departmentBox
            // 
            departmentBox.Cursor = Cursors.IBeam;
            departmentBox.Location = new Point(588, 631);
            departmentBox.Name = "departmentBox";
            departmentBox.Size = new Size(334, 31);
            departmentBox.TabIndex = 39;
            // 
            // genderBox
            // 
            genderBox.Cursor = Cursors.IBeam;
            genderBox.Location = new Point(1105, 347);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(334, 31);
            genderBox.TabIndex = 40;
            // 
            // emailBox
            // 
            emailBox.Cursor = Cursors.IBeam;
            emailBox.Location = new Point(1105, 401);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(334, 31);
            emailBox.TabIndex = 41;
            // 
            // usernameBox
            // 
            usernameBox.Cursor = Cursors.IBeam;
            usernameBox.Location = new Point(1105, 449);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(334, 31);
            usernameBox.TabIndex = 42;
            // 
            // useridBox
            // 
            useridBox.Cursor = Cursors.IBeam;
            useridBox.Location = new Point(1105, 495);
            useridBox.Name = "useridBox";
            useridBox.Size = new Size(334, 31);
            useridBox.TabIndex = 43;
            // 
            // passwordBox
            // 
            passwordBox.Cursor = Cursors.IBeam;
            passwordBox.Location = new Point(1105, 539);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(334, 31);
            passwordBox.TabIndex = 44;
            // 
            // searchBar
            // 
            searchBar.Location = new Point(171, 227);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(360, 31);
            searchBar.TabIndex = 47;
            toolTip1.SetToolTip(searchBar, "Search Bar.");
            searchBar.TextChanged += searchBar_TextChanged_1;
            // 
            // logsTable
            // 
            logsTable.AllowUserToAddRows = false;
            logsTable.AllowUserToDeleteRows = false;
            logsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            logsTable.Columns.AddRange(new DataGridViewColumn[] { usersname, time_in, time_out });
            logsTable.Location = new Point(612, 227);
            logsTable.Name = "logsTable";
            logsTable.ReadOnly = true;
            logsTable.RowHeadersWidth = 62;
            logsTable.Size = new Size(610, 842);
            logsTable.TabIndex = 46;
            logsTable.CellContentClick += logsTable_CellContentClick;
            // 
            // usersname
            // 
            usersname.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            usersname.DataPropertyName = "usersname";
            usersname.HeaderText = "User's Name";
            usersname.MinimumWidth = 8;
            usersname.Name = "usersname";
            usersname.ReadOnly = true;
            usersname.Width = 147;
            // 
            // time_in
            // 
            time_in.DataPropertyName = "time_in";
            time_in.HeaderText = "Time In";
            time_in.MinimumWidth = 8;
            time_in.Name = "time_in";
            time_in.ReadOnly = true;
            time_in.Width = 200;
            // 
            // time_out
            // 
            time_out.DataPropertyName = "time_out";
            time_out.HeaderText = "Time Out";
            time_out.MinimumWidth = 8;
            time_out.Name = "time_out";
            time_out.ReadOnly = true;
            time_out.Width = 200;
            // 
            // refreshButton2
            // 
            refreshButton2.Location = new Point(1228, 227);
            refreshButton2.Name = "refreshButton2";
            refreshButton2.Size = new Size(153, 50);
            refreshButton2.TabIndex = 48;
            refreshButton2.Text = "REFRESH";
            toolTip1.SetToolTip(refreshButton2, "Click to Refresh the Table.");
            refreshButton2.UseVisualStyleBackColor = true;
            refreshButton2.Click += refreshButton2_Click;
            // 
            // typeBox
            // 
            typeBox.Cursor = Cursors.IBeam;
            typeBox.Location = new Point(1105, 583);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(334, 31);
            typeBox.TabIndex = 49;
            // 
            // typeLabel
            // 
            typeLabel.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Bold, GraphicsUnit.Point);
            typeLabel.Location = new Point(970, 578);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(139, 38);
            typeLabel.TabIndex = 50;
            typeLabel.Text = "Type:";
            typeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // recentTimein
            // 
            recentTimein.Location = new Point(453, 227);
            recentTimein.Name = "recentTimein";
            recentTimein.Size = new Size(153, 50);
            recentTimein.TabIndex = 52;
            recentTimein.Text = "Recent Time In";
            toolTip1.SetToolTip(recentTimein, "Click to See who recently Timed In.");
            recentTimein.UseVisualStyleBackColor = true;
            recentTimein.Click += recentTimein_Click;
            // 
            // recentTimeout
            // 
            recentTimeout.Location = new Point(453, 289);
            recentTimeout.Name = "recentTimeout";
            recentTimeout.Size = new Size(153, 50);
            recentTimeout.TabIndex = 53;
            recentTimeout.Text = "Recent Time Out";
            toolTip1.SetToolTip(recentTimeout, "Click to See who recently Timed out.");
            recentTimeout.UseVisualStyleBackColor = true;
            recentTimeout.Click += recentTimeout_Click;
            // 
            // admin
            // 
            ClientSize = new Size(1940, 1100);
            ControlBox = false;
            Controls.Add(recentTimeout);
            Controls.Add(recentTimein);
            Controls.Add(searchBar);
            Controls.Add(typeLabel);
            Controls.Add(typeBox);
            Controls.Add(passwordBox);
            Controls.Add(useridBox);
            Controls.Add(usernameBox);
            Controls.Add(emailBox);
            Controls.Add(genderBox);
            Controls.Add(departmentBox);
            Controls.Add(yearlevelBox);
            Controls.Add(instructorBox);
            Controls.Add(coursecodeBox);
            Controls.Add(middlenameBox);
            Controls.Add(firstnameBox);
            Controls.Add(lastnameBox);
            Controls.Add(instructorLabel);
            Controls.Add(passwordLabel);
            Controls.Add(useridLabel);
            Controls.Add(usernameLabel);
            Controls.Add(emailLabel);
            Controls.Add(genderLabel);
            Controls.Add(departmentLabel);
            Controls.Add(yearlevelLabel);
            Controls.Add(coursecodeLabel);
            Controls.Add(middlenameLabel);
            Controls.Add(firstnameLabel);
            Controls.Add(lastnameLabel);
            Controls.Add(addButton);
            Controls.Add(titleLabel);
            Controls.Add(logoBox);
            Controls.Add(panel1);
            Controls.Add(refreshButton2);
            Controls.Add(logsTable);
            Controls.Add(refreshButton1);
            Controls.Add(datasheetsTable);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "admin";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)datasheetsTable).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)logsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DataGridView datasheetsTable;
        private Button refreshButton1;
        private Button logout;
        private Panel panel1;
        private PictureBox logoBox;
        private Label titleLabel;
        private DataGridViewTextBoxColumn id;
        private Button registerButton;
        private Button datasheetsButton;
        private Button addButton;
        private Label lastnameLabel;
        private Label firstnameLabel;
        private Label middlenameLabel;
        private Label coursecodeLabel;
        private Label yearlevelLabel;
        private Label departmentLabel;
        private Label genderLabel;
        private Label emailLabel;
        private Label usernameLabel;
        private Label useridLabel;
        private Label passwordLabel;
        private Label instructorLabel;
        private TextBox lastnameBox;
        private TextBox firstnameBox;
        private TextBox middlenameBox;
        private TextBox coursecodeBox;
        private TextBox instructorBox;
        private TextBox yearlevelBox;
        private TextBox departmentBox;
        private TextBox genderBox;
        private TextBox emailBox;
        private TextBox usernameBox;
        private TextBox useridBox;
        private TextBox passwordBox;
        private Button logsButton;
        private TextBox searchBar;
        private DataGridView logsTable;
        private Button refreshButton2;
        private TextBox typeBox;
        private Label typeLabel;
        private Button recentTimein;
        private Button recentTimeout;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn middlename;
        private DataGridViewTextBoxColumn coursecode;
        private DataGridViewTextBoxColumn instructor;
        private DataGridViewTextBoxColumn yearlevel;
        private DataGridViewTextBoxColumn department;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn userid;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn type;
        private ToolTip toolTip1;
        private DataGridViewTextBoxColumn usersname;
        private DataGridViewTextBoxColumn time_in;
        private DataGridViewTextBoxColumn time_out;
    }
}