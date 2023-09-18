using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace ComLabSystem
{
    public partial class admin : Form
    {
        string connectionString = "server = 127.0.0.1; user=root; database=sampleconnecrtion; password=";
        public admin()
        {
            InitializeComponent();
        }

        private void datasheetsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshButton1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            {
                searchBar.Clear();
                sqlCon.Open();
                MySqlDataAdapter sqld = new MySqlDataAdapter("SELECT * FROM student ORDER BY lastname ASC;", sqlCon);
                DataTable dt = new DataTable();
                sqld.Fill(dt);

                datasheetsTable.AutoGenerateColumns = false;
                datasheetsTable.DataSource = dt;
                sqlCon.Close();


            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Show();
        }

        private void admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            datasheetsTable.Hide();
            refreshButton1.Hide();

            instructorLabel.Show();
            lastnameLabel.Show();
            firstnameLabel.Show();
            middlenameLabel.Show();
            coursecodeLabel.Show();
            yearlevelLabel.Show();
            departmentLabel.Show();
            genderLabel.Show();
            emailLabel.Show();
            usernameLabel.Show();
            useridLabel.Show();
            passwordLabel.Show();
            typeLabel.Show();
            lastnameBox.Show();
            firstnameBox.Show();
            middlenameBox.Show();
            coursecodeBox.Show();
            instructorBox.Show();
            yearlevelBox.Show();
            departmentBox.Show();
            genderBox.Show();
            emailBox.Show();
            usernameBox.Show();
            useridBox.Show();
            passwordBox.Show();
            searchBar.Hide();
            typeBox.Show();
            logsTable.Hide();
            addButton.Show();
            refreshButton2.Hide();
            recentTimein.Hide();
            recentTimeout.Hide();

        }

        private void datasheetsButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            {
                sqlCon.Open();
                MySqlDataAdapter sqld = new MySqlDataAdapter("SELECT * FROM student ORDER BY lastname ASC", sqlCon);
                DataTable dt = new DataTable();
                sqld.Fill(dt);

                datasheetsTable.AutoGenerateColumns = false;
                datasheetsTable.DataSource = dt;
                sqlCon.Close();
            }

            instructorLabel.Hide();
            lastnameLabel.Hide();
            firstnameLabel.Hide();
            middlenameLabel.Hide();
            coursecodeLabel.Hide();
            yearlevelLabel.Hide();
            departmentLabel.Hide();
            genderLabel.Hide();
            emailLabel.Hide();
            usernameLabel.Hide();
            useridLabel.Hide();
            passwordLabel.Hide();
            typeLabel.Hide();
            lastnameBox.Hide();
            firstnameBox.Hide();
            middlenameBox.Hide();
            coursecodeBox.Hide();
            instructorBox.Hide();
            yearlevelBox.Hide();
            departmentBox.Hide();
            genderBox.Hide();
            emailBox.Hide();
            usernameBox.Hide();
            useridBox.Hide();
            passwordBox.Hide();
            searchBar.Show();
            typeBox.Hide();
            addButton.Hide();
            refreshButton2.Hide();
            recentTimein.Hide();
            recentTimeout.Hide();
            logsTable.Hide();

            datasheetsTable.Show();
            refreshButton1.Show();
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            {
                sqlCon.Open();
                MySqlDataAdapter sqld = new MySqlDataAdapter("SELECT * FROM student ORDER BY lastname ASC", sqlCon);
                DataTable dt = new DataTable();
                sqld.Fill(dt);

                datasheetsTable.AutoGenerateColumns = false;
                datasheetsTable.DataSource = dt;
                sqlCon.Close();
            }


            instructorLabel.Hide();
            lastnameLabel.Hide();
            firstnameLabel.Hide();
            middlenameLabel.Hide();
            coursecodeLabel.Hide();
            yearlevelLabel.Hide();
            departmentLabel.Hide();
            genderLabel.Hide();
            emailLabel.Hide();
            usernameLabel.Hide();
            useridLabel.Hide();
            passwordLabel.Hide();
            typeLabel.Hide();
            lastnameBox.Hide();
            firstnameBox.Hide();
            middlenameBox.Hide();
            coursecodeBox.Hide();
            instructorBox.Hide();
            yearlevelBox.Hide();
            departmentBox.Hide();
            genderBox.Hide();
            emailBox.Hide();
            usernameBox.Hide();
            useridBox.Hide();
            passwordBox.Hide();
            searchBar.Show();
            typeBox.Hide();
            addButton.Hide();
            refreshButton2.Hide();
            recentTimein.Hide();
            recentTimeout.Hide();

            datasheetsTable.Show();
            logsTable.Hide();
            refreshButton1.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=sampleconnecrtion; password=");
            mySqlConnection.Open();

            {

                MySqlCommand cmd = new MySqlCommand("INSERT INTO student (lastname, firstname, middlename, coursecode, instructor, yearlevel, department, gender, email, username, userid, password, type ) VALUES (@lastname, @firstname, @middlename, @coursecode, @instructor, @yearlevel, @department, @gender, @email, @username, @userid, @password, @type)", mySqlConnection);

                cmd.Parameters.AddWithValue("@lastname", lastnameBox.Text);
                cmd.Parameters.AddWithValue("@firstname", firstnameBox.Text);
                cmd.Parameters.AddWithValue("@middlename", middlenameBox.Text);
                cmd.Parameters.AddWithValue("@coursecode", coursecodeBox.Text);
                cmd.Parameters.AddWithValue("@instructor", instructorBox.Text);
                cmd.Parameters.AddWithValue("@yearlevel", yearlevelBox.Text);
                cmd.Parameters.AddWithValue("@department", departmentBox.Text);
                cmd.Parameters.AddWithValue("@gender", genderBox.Text);
                cmd.Parameters.AddWithValue("@email", emailBox.Text);
                cmd.Parameters.AddWithValue("@username", usernameBox.Text);
                cmd.Parameters.AddWithValue("@userid", useridBox.Text);
                cmd.Parameters.AddWithValue("@password", passwordBox.Text);
                cmd.Parameters.AddWithValue("@type", typeBox.Text);
                cmd.ExecuteNonQuery();

                mySqlConnection.Close();

                lastnameBox.Clear();
                firstnameBox.Clear();
                middlenameBox.Clear();
                coursecodeBox.Clear();
                instructorBox.Clear();
                yearlevelBox.Clear();
                departmentBox.Clear();
                genderBox.Clear();
                emailBox.Clear();
                usernameBox.Clear();
                useridBox.Clear();
                passwordBox.Clear();
                typeBox.Clear();
                MessageBox.Show("Successfully Added!");

                instructorLabel.Hide();
                lastnameLabel.Hide();
                firstnameLabel.Hide();
                middlenameLabel.Hide();
                coursecodeLabel.Hide();
                yearlevelLabel.Hide();
                departmentLabel.Hide();
                genderLabel.Hide();
                emailLabel.Hide();
                usernameLabel.Hide();
                useridLabel.Hide();
                passwordLabel.Hide();
                typeLabel.Hide();
                lastnameBox.Hide();
                firstnameBox.Hide();
                middlenameBox.Hide();
                coursecodeBox.Hide();
                instructorBox.Hide();
                yearlevelBox.Hide();
                departmentBox.Hide();
                genderBox.Hide();
                emailBox.Hide();
                usernameBox.Hide();
                useridBox.Hide();
                passwordBox.Hide();
                searchBar.Show();
                typeBox.Hide();
                addButton.Hide();
                logsTable.Hide();

                datasheetsTable.Show();
                refreshButton1.Show();

                using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
                {
                    sqlCon.Open();
                    MySqlDataAdapter sqld = new MySqlDataAdapter("Select * from student", sqlCon);
                    DataTable dt = new DataTable();
                    sqld.Fill(dt);

                    datasheetsTable.AutoGenerateColumns = false;
                    datasheetsTable.DataSource = dt;
                }
            }
        }

        private void logsButton_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            {
                sqlCon.Open();
                MySqlDataAdapter sqld = new MySqlDataAdapter("Select * from logs ", sqlCon);
                DataTable dt = new DataTable();
                sqld.Fill(dt);

                logsTable.AutoGenerateColumns = false;
                logsTable.DataSource = dt;
                sqlCon.Close();
            }

            instructorLabel.Hide();
            lastnameLabel.Hide();
            firstnameLabel.Hide();
            middlenameLabel.Hide();
            coursecodeLabel.Hide();
            yearlevelLabel.Hide();
            departmentLabel.Hide();
            genderLabel.Hide();
            emailLabel.Hide();
            usernameLabel.Hide();
            useridLabel.Hide();
            passwordLabel.Hide();
            typeLabel.Hide();
            lastnameBox.Hide();
            firstnameBox.Hide();
            middlenameBox.Hide();
            coursecodeBox.Hide();
            instructorBox.Hide();
            yearlevelBox.Hide();
            departmentBox.Hide();
            genderBox.Hide();
            emailBox.Hide();
            usernameBox.Hide();
            useridBox.Hide();
            passwordBox.Hide();
            searchBar.Hide();
            typeBox.Hide();
            addButton.Hide();
            datasheetsTable.Hide();
            refreshButton1.Hide();
            refreshButton2.Show();
            recentTimein.Show();
            recentTimeout.Show();

            logsTable.Show();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void logsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void searchBar_TextChanged_1(object sender, EventArgs e)
        {
            searchData(searchBar.Text);
        }

        MySqlConnection connection = new MySqlConnection("server = 127.0.0.1; user=root; database=sampleconnecrtion; password=");


        private void Admin(object sender, EventArgs e)
        {
            searchData("");
        }
        public void searchData(string valueToFind)
        {
            string searchQuery = "SELECT * FROM student WHERE (lastname) LIKE '%" + valueToFind + "%' OR (firstname) LIKE '%" + valueToFind + "%' OR (middlename) LIKE '%" + valueToFind + "%'  OR (coursecode) LIKE '%" + valueToFind + "%' OR (instructor) LIKE '%" + valueToFind + "%'  OR (yearlevel) LIKE '%" + valueToFind + "%'  OR (department) LIKE '%" + valueToFind + "%'  OR (gender) LIKE '%" + valueToFind + "%'  OR (email) LIKE '%" + valueToFind + "%'  OR (username) LIKE '%" + valueToFind + "%'  OR (userid) LIKE '%" + valueToFind + "%' OR (type) LIKE '%" + valueToFind + "%' ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, connection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            datasheetsTable.DataSource = dt;

        }

        private void refreshButton2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            {
                sqlCon.Open();
                MySqlDataAdapter sqld = new MySqlDataAdapter("Select * from logs", sqlCon);
                DataTable dt = new DataTable();
                sqld.Fill(dt);

                logsTable.AutoGenerateColumns = false;
                logsTable.DataSource = dt;
            }
        }

        private void recentTimein_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            {
                sqlCon.Open();
                MySqlDataAdapter sqld = new MySqlDataAdapter("SELECT * FROM logs ORDER BY time_in DESC;", sqlCon);
                DataTable dt = new DataTable();
                sqld.Fill(dt);

                logsTable.AutoGenerateColumns = false;
                logsTable.DataSource = dt;
            }




        }

        private void recentTimeout_Click(object sender, EventArgs e)
        {

            using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            {
                sqlCon.Open();
                MySqlDataAdapter sqld = new MySqlDataAdapter("SELECT * FROM logs ORDER BY time_out DESC;", sqlCon);
                DataTable dt = new DataTable();
                sqld.Fill(dt);

                logsTable.AutoGenerateColumns = false;
                logsTable.DataSource = dt;
            }

        }
    }
}



