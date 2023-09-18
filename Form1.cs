using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;


namespace ComLabSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            blankLabel.Hide();
            backButton.Hide();
            aboutLabel.Hide();
            string mysqlCon = "server=127.0.0.1; user=root; database=sampleconnecrtion; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();

                string qry = "select * from student";

                MySqlCommand mySqlCommand = new MySqlCommand(qry);
                mySqlCommand.Connection = mySqlConnection;

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }

        }




        private void loginButton_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=sampleconnecrtion; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();

                string qry = "select username, type from student where username='" + usernameBox.Text + "' and password='" + passwordBox.Text + "';";

                MySqlCommand mySqlCommand = new MySqlCommand(qry);
                mySqlCommand.Connection = mySqlConnection;

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    if (dt.Rows[0][1].ToString().ToLower() == "admin")
                    {
                        MessageBox.Show("Access Granted!");
                        usernameBox.Clear();
                        passwordBox.Clear();
                        this.Hide();
                        admin frmadmin = new admin();
                        this.AddOwnedForm(frmadmin);
                        frmadmin.ShowDialog();

                    }

                    else
                    {

                        MessageBox.Show("Welcome Back, Brightonian!");
                        this.Hide();

                        MySqlCommand cmd = new MySqlCommand("INSERT INTO logs (usersname, time_in) VALUES (@usersname, now())", mySqlConnection);
                        cmd.Parameters.AddWithValue("@usersname", usernameBox.Text);
                        cmd.ExecuteNonQuery();
                        int logid = (int)cmd.LastInsertedId;
                        Logout.LogId = logid;
                        mySqlConnection.Close();

                        usernameBox.Clear();
                        passwordBox.Clear();
                        Logout l = new Logout();
                        this.AddOwnedForm(l);
                        l.ShowDialog();

                    }
                }
                else
                {
                    MessageBox.Show("Invalid Login, Incorrect Username/Password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();


            }

        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            blankLabel.Hide();
            logoBox.Hide();
            usernameLabel.Hide();
            passwordLabel.Hide();
            title1.Hide();
            title2.Hide();
            usernameBox.Hide();
            passwordBox.Hide();
            loginButton.Hide();
            aboutButton.Hide();
            backButton.Show();
            aboutLabel.Show();



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            blankLabel.Hide();
            logoBox.Show();
            usernameLabel.Show();
            passwordLabel.Show();
            title1.Show();
            title2.Show();
            usernameBox.Show();
            passwordBox.Show();
            loginButton.Show();
            aboutButton.Show();
            backButton.Hide();
            aboutLabel.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Enter(object sender, EventArgs e)
        {



        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


        }
    }
}





