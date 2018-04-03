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
    public partial class UpdateParameters : Form
    {

        MySqlDataAdapter ad, ad1, srca, dsta;
        DataSet ds, ds1, srcs, dsts;
        DataTable dt, dt1, srct, dstt;
        DataRow dr, dr1, srcr, dstr;

        private MySqlConnection connection;

        private string server, port;
        private string database;
        private string uid;
        private string password;

        public object Request { get; private set; }

        public UpdateParameters()
        {
            InitializeComponent();
            connect1();
            MySqlCommand cm4 = new MySqlCommand("");
            cm4.Connection = connection;
            cm4.CommandText = "select bookf , sortf , delif , distf from factors";
            dsts = new DataSet();
            dsta = new MySqlDataAdapter();
            dsta.SelectCommand = cm4;
            dsta.Fill(dsts, "sql16");
            dstt = dsts.Tables["sql16"];
            dstr = dstt.Rows[0];
            if (string.IsNullOrEmpty(dstr.ItemArray[0].ToString()))
            {
                MessageBox.Show("Error!");
            }
            else
            {
                bookFactor = dstr["bookf"].ToString();
                sortFactor = dstr["sortf"].ToString();
                deliveryFactor = dstr["delif"].ToString();
                distanceFactor = dstr["distf"].ToString();
            }

            bfu.Text = bookFactor.ToString();
            sfu.Text = sortFactor.ToString();
            defu.Text = deliveryFactor.ToString();
            dfu.Text = distanceFactor.ToString();
        }
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
                Console.WriteLine("YAYY! Connected");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        private void UpdateParameters_Load(object sender, EventArgs e)
        {

        }
        String bookFactor;
        String sortFactor;
        String deliveryFactor;
        String distanceFactor;
        private void button1_Click(object sender, EventArgs e)
        {
           

            MySqlCommand cm5 = new MySqlCommand("");
            cm5.Connection = connection;
            cm5.CommandText = "update factors set bookf='"+bfu.Text+"'";
            cm5.ExecuteNonQuery();
            cm5.CommandText = "update factors set sortf='" + sfu.Text + "'";
            cm5.ExecuteNonQuery();
            cm5.CommandText = "update factors set delif='" + defu.Text + "'";
            cm5.ExecuteNonQuery();
            cm5.CommandText = "update factors set distf='" + dfu.Text + "'";
            cm5.ExecuteNonQuery();

        }
    }
}
