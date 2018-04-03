using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace testingDatabase
{
    public partial class Form1 : Form
    {
       MySqlDataAdapter ad , ad1 , srca , dsta;
        DataSet ds , ds1 , srcs , dsts;
        DataTable dt , dt1 , srct , dstt;
        DataRow dr , dr1 , srcr , dstr;
        String finalCost = "";

        String srclat, srclon, dstlat, dstlon, hublat1, hublon1, hublat2, hublon2;
        String pin1, pin2;
        String selected;
        String bookFactor = "5";
        String sortFactor = "10";
        String deliveryFactor = "7";
        MySqlCommand cm = new MySqlCommand("");
        double weightFactor; String distanceFactor = "0.005";
        double R = 6373.0;

        private void height_Click(object sender, EventArgs e)
        {

        }

        private MySqlConnection connection;

        private string server, port;
        private string database;
        private string uid;
        private string password;

        public object Request { get; private set; }
        
        public Form1()
        {
            InitializeComponent();

        }

        public double calcDist (string srclat, string srclon, string dstlat, string dstlon)
        {
            double lat1 = Double.Parse(srclat);
            double lon1 = Double.Parse(srclon);
            double lat2 = Double.Parse(dstlat);
            double lon2 = Double.Parse(dstlon);

            double source_lat = DegreeToRadian(lat1);
            double source_lon = DegreeToRadian(lon1);
            double dest_lat = DegreeToRadian(lat2);
            double dest_lon = DegreeToRadian(lon2);

            double dlon = source_lon - dest_lon;
            double dlat = dest_lat - source_lat;

            return Math.Pow(Math.Sin(dlat / 2), 2) + Math.Cos(source_lat) * Math.Cos(dest_lat) * Math.Pow(Math.Sin(dlon / 2), 2);
        }


        //connecting to mysql
        public void connect1()
        {
            try
            {
                server = "192.168.43.220";
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

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                finalCost = "";
                String text1 = "", text2 = "";
                connect1();
                /*cm.Connection = connection;
                cm.CommandText = "select latitude,longitude from location where pincode = '400001'";
                MySqlDataAdapter sda = new MySqlDataAdapter();
                cm.CommandType = CommandType.Text;
                sda.SelectCommand = cm;
                DataTable dts = new DataTable();
                sda.Fill(dts);
                BindingSource bs = new BindingSource();
                bs.DataSource = dts;
                dataGridView1.DataSource = bs;
                sda.Update(dts);
                Console.WriteLine("");*/

                cm.Connection = connection;
                cm.CommandText = "select latitude,longitude from location where pincode = '" + pin1 + "'";
                srcs = new DataSet();
                srca = new MySqlDataAdapter();
                srca.SelectCommand = cm;
                srca.Fill(srcs, "sql3");
                srct = srcs.Tables["sql3"];
                srcr = srct.Rows[0];
                if (string.IsNullOrEmpty(srcr.ItemArray[0].ToString()))
                {
                    MessageBox.Show(" Destination Pincode doesnt exist in our database !");
                }
                else
                {
                    srclat = srcr["latitude"].ToString();
                    srclon = srcr["longitude"].ToString();
                }
                cm.ExecuteNonQuery();

                MySqlCommand cm1 = new MySqlCommand("");
                cm1.Connection = connection;
                cm1.CommandText = "select latitude,longitude from location where pincode = '" + pin2 + "'";

                dsts = new DataSet();
                dsta = new MySqlDataAdapter();
                dsta.SelectCommand = cm1;
                dsta.Fill(dsts, "sql4");
                dstt = dsts.Tables["sql4"];
                dstr = dstt.Rows[0];
                if (string.IsNullOrEmpty(dstr.ItemArray[0].ToString()))
                {
                    MessageBox.Show(" Destination Pincode doesnt exist in our database !");
                }
                else
                {
                    dstlat = dstr["latitude"].ToString();
                    dstlon = dstr["longitude"].ToString();
                }

                cm1.ExecuteNonQuery();

                if (selected == "Speed Post Letter")
                {
                    text1 = "nsh_latitude";
                    text2 = "nsh_longitude";
                }
                else
                {
                    text1 = "rms_latitude";
                    text2 = "rms_longitude";
                }
                MySqlCommand cm2 = new MySqlCommand("");
                cm2.Connection = connection;
                cm2.CommandText = "select "+text1+","+text2+" from location natural join rms_nsh where pincode = '" + pin1 + "'";
                dsts = new DataSet();
                dsta = new MySqlDataAdapter();
                dsta.SelectCommand = cm2;
                dsta.Fill(dsts, "sql5");
                dstt = dsts.Tables["sql5"];
                dstr = dstt.Rows[0];
                if (string.IsNullOrEmpty(dstr.ItemArray[0].ToString()))
                {
                    MessageBox.Show("Error!");
                }
                else
                {
                    hublat1 = dstr[text1].ToString();
                    hublon1 = dstr[text2].ToString();
                }
                cm2.ExecuteNonQuery();

                MySqlCommand cm3 = new MySqlCommand("");
                cm3.Connection = connection;
                cm3.CommandText = "select " + text1 + "," + text2 + " from location natural join rms_nsh where pincode = '" + pin2 + "'";
                dsts = new DataSet();
                dsta = new MySqlDataAdapter();
                dsta.SelectCommand = cm3;
                dsta.Fill(dsts, "sql6");
                dstt = dsts.Tables["sql6"];
                dstr = dstt.Rows[0];
                if (string.IsNullOrEmpty(dstr.ItemArray[0].ToString()))
                {
                    MessageBox.Show("Error!");
                }
                else
                {
                    hublat2 = dstr[text1].ToString();
                    hublon2 = dstr[text2].ToString();
                }
                cm3.ExecuteNonQuery();

                double a = calcDist(srclat, srclon, hublat1, hublon1) 
                    + calcDist(hublat1, hublon1, hublat2, hublon2)
                    + calcDist(hublat2, hublon2, dstlat, dstlon);

                double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
                double ans = R * c;
                ans = 1.15 * ans;
                Console.WriteLine(ans);
                //MessageBox.Show(ans.ToString());
                double weight = Double.Parse (weightText.Text.ToString()),
                    length = Double.Parse (lengtht.Text.ToString()),
                    width = Double.Parse (widtht.Text.ToString()),
                    height = Double.Parse (heightt.Text.ToString());
                double logisticCost = getDistanceCost(ans) + getWeightVolumeCost(weight, length * width * height);
                //return logisticCost;
                //finalCost += "\nBooking Cost = Rs. " + 1 * 5;

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
                cm4.ExecuteNonQuery();

                double bookCost, sortCost, delvCost;
                bookCost = 1 * Double.Parse(bookFactor);
                sortCost = 1 * Double.Parse(sortFactor);
                delvCost = 1 * Double.Parse(deliveryFactor);
                finalCost += "\nBooking Cost = Rs. " + bookCost;
                finalCost += "\nSorting Cost = Rs. " + sortCost;
                finalCost += "\nDelivery Cost = Rs. " + delvCost;
                finalCost += "\nLogistic Cost = Rs. " + Math.Ceiling(logisticCost);
                finalCost += "\nTotalCost = Rs. " + (Math.Ceiling(bookCost + sortCost + delvCost + logisticCost));
                MessageBox.Show(finalCost);
                connection.Close();
            }
            catch (Exception ew)
            {
                Console.WriteLine("Error AAYA: " + ew);
                connection.Close();
                //return 0;
                // Console.WriteLine(ew.StackTrace);
            }
    }

        private double getWeightVolumeCost (double weight, double volume)
        {
            if (selected == "Letter" )
                return Math.Ceiling (weight * 0.05) * 5;
            else if (selected == "Parcel")
            {
                if (weight <= 500)
                    return Math.Floor(volume / 3000) * 16 + 19;
                else
                    return Math.Floor(weight / 500) * 16 + 19;
            }
            else if (selected == "Book Parcel")
            {
                return 3 * (int) (weight / 50);
            }
            else
            {//speed post
                if (weight > 200)
                    return Math.Floor(weight / 500) * 40 + 80;
                else if (weight > 50)
                    return 60;
                else
                    return 35;
            }
        }

        private double getDistanceCost(double dist)
        {
            return dist * Double.Parse(distanceFactor);
        }

        // selecting article type
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selected = comboBox1.Text.ToString();
            if (selected == "Parcel")
            {
                width.Visible = true;
                height.Visible = true;
                length.Visible = true;
                widtht.Visible = true;
                heightt.Visible = true;
                lengtht.Visible = true;
            }
            else
            {
                width.Visible = false;
                height.Visible = false;
                length.Visible = false;
                widtht.Visible = false;
                heightt.Visible = false;
                lengtht.Visible = false;

            }


        }

       
        // getting destination details
        private void destPincode_TextChanged_1(object sender, EventArgs e)
        {
            connect1();
            try
            {
                if (destPincode.Text.ToString().Length == 6)
                {
                    pin2 = destPincode.Text.ToString();
                    cm.Connection = connection;
                    cm.CommandText = "select cities,state from location where pincode = '" + destPincode.Text.ToString() + "'";
                    ds1 = new DataSet();
                    ad1 = new MySqlDataAdapter();
                    ad1.SelectCommand = cm;
                    ad1.Fill(ds1, "sql2");
                    dt1 = ds1.Tables["sql2"];
                    dr1 = dt1.Rows[0];
                    if (string.IsNullOrEmpty(dr1.ItemArray[0].ToString()))
                    {
                        MessageBox.Show(" Destination Pincode doesnt exist in our database !");
                    }
                    else
                    {
                        string city1 = dr1["cities"].ToString();
                        string state1 = dr1["state"].ToString();

                        destCity.Text = city1;
                        destState.Text = state1;

                    }
                    cm.ExecuteNonQuery();
                }
            }
            catch (Exception erw)
            {
                Console.WriteLine(erw.ToString());
                MessageBox.Show("Enter a valid Pincode");
            }
        }
        // getting source details
        private void srcPincode_TextChanged_1(object sender, EventArgs e)
        {
            Console.WriteLine("i'm here at fgvbhjn");
            connect1();
            try
            {
                if (srcPincode.Text.ToString().Length == 6)
                {
                    pin1 = srcPincode.Text.ToString();
                    cm.Connection = connection;
                    cm.CommandText = "select cities,state from location where pincode = '" + srcPincode.Text.ToString() + "'";
                    ds = new DataSet();
                    ad = new MySqlDataAdapter();
                    ad.SelectCommand = cm;
                    ad.Fill(ds, "sql1");
                    dt = ds.Tables["sql1"];
                    dr = dt.Rows[0];
                    if (string.IsNullOrEmpty(dr.ItemArray[0].ToString()))
                    {
                        MessageBox.Show(" Source Pincode doesnt exist in our database !");
                    }
                    else
                    {
                        string city = dr["cities"].ToString();
                        string state = dr["state"].ToString();

                        srcCity.Text = city;
                        srcState.Text = state;

                    }
                    cm.ExecuteNonQuery();
                }
            }
            catch (Exception epp)
            {
                Console.WriteLine(epp);
            }       
        }

        private double DegreeToRadian(double lon2)
        {
            return Math.PI * lon2 / 180.0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
       
    }
}

/*
 * 
 * public String [] getDB (string cols, string db, string where)
 * {
 * }
 * */