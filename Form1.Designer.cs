namespace ComLabSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Button loginButton;
        private Label title1;
        private Label title2;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            usernameLabel = new Label();
            passwordLabel = new Label();
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            loginButton = new Button();
            title1 = new Label();
            title2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            aboutButton = new Button();
            logoBox = new PictureBox();
            backButton = new Button();
            aboutLabel = new Label();
            blankLabel = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.ForeColor = Color.Maroon;
            usernameLabel.Location = new Point(807, 515);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(126, 28);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.Maroon;
            passwordLabel.Location = new Point(809, 573);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(124, 28);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password:";
            // 
            // usernameBox
            // 
            usernameBox.Cursor = Cursors.IBeam;
            usernameBox.Location = new Point(929, 512);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(180, 31);
            usernameBox.TabIndex = 2;
            toolTip1.SetToolTip(usernameBox, "Enter Your Username Here.");
            // 
            // passwordBox
            // 
            passwordBox.Cursor = Cursors.IBeam;
            passwordBox.Location = new Point(929, 573);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(180, 31);
            passwordBox.TabIndex = 3;
            toolTip1.SetToolTip(passwordBox, "Enter Your Password Here.");
            passwordBox.UseSystemPasswordChar = true;
            passwordBox.TextChanged += textBox2_TextChanged;
            // 
            // loginButton
            // 
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            loginButton.FlatAppearance.MouseOverBackColor = Color.White;
            loginButton.FlatStyle = FlatStyle.Popup;
            loginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.Maroon;
            loginButton.Location = new Point(885, 623);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(149, 54);
            loginButton.TabIndex = 4;
            loginButton.Text = "Log In";
            toolTip1.SetToolTip(loginButton, "Click to Login.");
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            loginButton.Enter += loginButton_Enter;
            // 
            // title1
            // 
            title1.AutoSize = true;
            title1.BackColor = Color.Transparent;
            title1.Font = new Font("Calibri", 22F, FontStyle.Bold, GraphicsUnit.Point);
            title1.ForeColor = Color.Maroon;
            title1.Location = new Point(718, 392);
            title1.Name = "title1";
            title1.Size = new Size(492, 54);
            title1.TabIndex = 5;
            title1.Text = "Computer Laboratory Log";
            // 
            // title2
            // 
            title2.AutoSize = true;
            title2.BackColor = Color.Transparent;
            title2.Font = new Font("Calibri", 22F, FontStyle.Bold, GraphicsUnit.Point);
            title2.ForeColor = Color.Maroon;
            title2.Location = new Point(756, 446);
            title2.Name = "title2";
            title2.Size = new Size(410, 54);
            title2.TabIndex = 8;
            title2.Text = "Management System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Location = new Point(0, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 1131);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Location = new Point(1777, -8);
            panel2.Name = "panel2";
            panel2.Size = new Size(157, 1131);
            panel2.TabIndex = 10;
            // 
            // aboutButton
            // 
            aboutButton.BackColor = Color.Maroon;
            aboutButton.Cursor = Cursors.Help;
            aboutButton.FlatAppearance.BorderColor = Color.Black;
            aboutButton.FlatAppearance.BorderSize = 2;
            aboutButton.FlatStyle = FlatStyle.Popup;
            aboutButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aboutButton.ForeColor = Color.White;
            aboutButton.Location = new Point(1714, 1014);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(38, 37);
            aboutButton.TabIndex = 0;
            aboutButton.Text = "?";
            toolTip1.SetToolTip(aboutButton, "About.");
            aboutButton.UseVisualStyleBackColor = false;
            aboutButton.Click += aboutButton_Click;
            // 
            // logoBox
            // 
            logoBox.BackColor = Color.Transparent;
            logoBox.Image = Properties.Resources.NBSPI_Logo_transparent;
            logoBox.Location = new Point(868, 207);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(179, 182);
            logoBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox.TabIndex = 11;
            logoBox.TabStop = false;
            toolTip1.SetToolTip(logoBox, "The NBSPI Logo.");
            // 
            // backButton
            // 
            backButton.BackColor = Color.Maroon;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(1582, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(180, 49);
            backButton.TabIndex = 12;
            backButton.Text = "Go Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += button3_Click;
            // 
            // aboutLabel
            // 
            aboutLabel.BackColor = Color.Transparent;
            aboutLabel.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            aboutLabel.Location = new Point(197, 195);
            aboutLabel.Name = "aboutLabel";
            aboutLabel.Size = new Size(1540, 658);
            aboutLabel.TabIndex = 13;
            aboutLabel.Text = resources.GetString("aboutLabel.Text");
            aboutLabel.TextAlign = ContentAlignment.MiddleCenter;
            aboutLabel.Click += label5_Click;
            // 
            // blankLabel
            // 
            blankLabel.BackColor = Color.Transparent;
            blankLabel.Location = new Point(149, 12);
            blankLabel.Name = "blankLabel";
            blankLabel.Size = new Size(1613, 1029);
            blankLabel.TabIndex = 14;
            blankLabel.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1924, 1050);
            ControlBox = false;
            Controls.Add(aboutButton);
            Controls.Add(logoBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(title2);
            Controls.Add(title1);
            Controls.Add(loginButton);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(blankLabel);
            Controls.Add(backButton);
            Controls.Add(aboutLabel);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Form1";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = SystemColors.AppWorkspace;
            WindowState = FormWindowState.Maximized;
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox logoBox;
        private Button aboutButton;
        private Button backButton;
        private Label aboutLabel;
        private Label blankLabel;
        private ToolTip toolTip1;
    }
}