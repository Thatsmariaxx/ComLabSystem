namespace ComLabSystem
{
    partial class Logout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logout));
            logoutButton = new Button();
            clock = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            logoBox = new PictureBox();
            title1 = new Label();
            title2 = new Label();
            panel2 = new Panel();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.Transparent;
            logoutButton.BackgroundImageLayout = ImageLayout.Center;
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            logoutButton.Location = new Point(214, 264);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(131, 58);
            logoutButton.TabIndex = 0;
            logoutButton.Text = "LOGOUT";
            toolTip1.SetToolTip(logoutButton, "Click to Logout.");
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // clock
            // 
            clock.BackColor = Color.Transparent;
            clock.Cursor = Cursors.No;
            clock.Font = new Font("Microsoft New Tai Lue", 21F, FontStyle.Bold, GraphicsUnit.Point);
            clock.ForeColor = Color.Black;
            clock.Location = new Point(63, 145);
            clock.Name = "clock";
            clock.Size = new Size(437, 54);
            clock.TabIndex = 1;
            clock.Text = "TIME";
            clock.TextAlign = ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(clock, "The Current Date and Time.");
            clock.Click += clock_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Location = new Point(1, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(56, 359);
            panel1.TabIndex = 2;
            // 
            // logoBox
            // 
            logoBox.BackColor = Color.Transparent;
            logoBox.Image = Properties.Resources.NBSPI_Logo_transparent;
            logoBox.Location = new Point(56, 20);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(124, 107);
            logoBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox.TabIndex = 3;
            logoBox.TabStop = false;
            toolTip1.SetToolTip(logoBox, "The NBSPI Logo.");
            logoBox.Click += logoBox_Click;
            // 
            // title1
            // 
            title1.BackColor = Color.Transparent;
            title1.Font = new Font("Microsoft New Tai Lue", 13F, FontStyle.Bold, GraphicsUnit.Point);
            title1.ForeColor = Color.Maroon;
            title1.Location = new Point(152, 36);
            title1.Name = "title1";
            title1.Size = new Size(375, 44);
            title1.TabIndex = 4;
            title1.Text = "Computer Laboratory Log";
            title1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // title2
            // 
            title2.BackColor = Color.Transparent;
            title2.Font = new Font("Microsoft New Tai Lue", 13F, FontStyle.Bold, GraphicsUnit.Point);
            title2.ForeColor = Color.Maroon;
            title2.Location = new Point(152, 76);
            title2.Name = "title2";
            title2.Size = new Size(375, 44);
            title2.TabIndex = 5;
            title2.Text = "Management System";
            title2.TextAlign = ContentAlignment.MiddleCenter;
            title2.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.Location = new Point(506, -6);
            panel2.Name = "panel2";
            panel2.Size = new Size(54, 359);
            panel2.TabIndex = 6;
            // 
            // Logout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Untitled_design__4_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(559, 344);
            ControlBox = false;
            Controls.Add(logoBox);
            Controls.Add(panel2);
            Controls.Add(title2);
            Controls.Add(title1);
            Controls.Add(panel1);
            Controls.Add(clock);
            Controls.Add(logoutButton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Logout";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = " ";
            TransparencyKey = Color.Gold;
            FormClosing += Logout_FormClosing;
            Load += Logout_Load;
            Click += Logout_Click;
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button logoutButton;
        private Label clock;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private PictureBox logoBox;
        private Label title1;
        private Label title2;
        private Panel panel2;
        private ToolTip toolTip1;
    }
}