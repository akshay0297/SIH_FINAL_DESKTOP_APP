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

namespace testingDatabase
{
    public partial class login : Form
    {
        MySqlDataAdapter ad;
        DataSet ds;
        DataTable dt;
        DataRow dr;

        private MySqlConnection connection;

        private string server, port;
        private string database;
        private string uid;
        private string password;

        public object Request { get; private set; }



        public void connect1()
        {
            try
            {
                server = "localhost";
                // port = "3306";
                database = "sih18local";
                uid = "root";
                password = "akshay";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Connected");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }
        public login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                connect1();
                MySqlCommand cm = new MySqlCommand("");
                cm.Connection = connection;
                if (user.Text != "" && pass.Text != "")
                {
                    cm.CommandText = "select username from users where username = '" + user.Text.ToString() + "' and password = '" + pass.Text.ToString() + "'";
                    cm.CommandType = CommandType.Text;
                    ds = new DataSet();
                    ad = new MySqlDataAdapter();
                    ad.SelectCommand = cm;
                    ad.Fill(ds, "sql10");
                    dt = ds.Tables["sql10"];
                    dr = dt.Rows[0];

                    if (string.IsNullOrEmpty(dr.ItemArray[0].ToString()))
                    {
                        MessageBox.Show("Invalid UserName or Password ");
                    }
                    else
                    {
                         
                        MessageBox.Show("Login Successful !");
                        //  string nm = dr["name"].ToString();
                        Console.WriteLine(user.Text);
                        if (user.Text == "admin")
                        {
                            UpdateParameters p = new UpdateParameters();
                            this.Hide();
                            p.Show();
                        }
                        else
                        { 
                            Form1 f1 = new Form1();
                            this.Hide();
                            f1.Show();
                        }
                    }
                    cm.ExecuteNonQuery();
                    //MessageBox.Show("YOU ARE GRANTED WITH ACCESS");
                }

            }
            catch (Exception eop)
            {
                MessageBox.Show("Enter Valid Username or Password");
            }

        }
    }
}
