using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComLabSystem
{
    public partial class Logout : Form
    {
        public static int LogId;
        public Logout()
        {
            InitializeComponent();
        }

        DateTime datetime = new DateTime();


        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Show();

        }

        private void clock_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Logout_Load(object sender, EventArgs e)
        {

            datetime = DateTime.Now;
            this.clock.Text = datetime.ToString();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datetime = DateTime.Now;
            this.clock.Text = datetime.ToString();
        }

        private void Logout_FormClosing(object sender, FormClosingEventArgs e)
        {

            string mysqlCon = "server=127.0.0.1; user=root; database=sampleconnecrtion; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            mySqlConnection.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE logs SET time_out = now() WHERE id = " + LogId, mySqlConnection);
            cmd.ExecuteNonQuery();
            mySqlConnection.Close();

            this.Owner.Show();

        
        }
    }
}


