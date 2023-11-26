using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using CustomerSQLite;
using System.IO;
using System.Diagnostics;



namespace WindowsFormsApplication1
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView.Items.Clear();
            SQLiteConnection conx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            {
                SQLiteDataAdapter recententry = new SQLiteDataAdapter("Select * from customers order by id desc limit 250", conx);
                DataTable dt = new DataTable();
                recententry.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                    listitem.SubItems.Add(dr["first"].ToString());
                    listitem.SubItems.Add(dr["last"].ToString());
                    listitem.SubItems.Add(dr["make"].ToString());
                    listitem.SubItems.Add(dr["model"].ToString());
                    listitem.SubItems.Add(dr["prodyear"].ToString());
                    listitem.SubItems.Add(dr["phone1"].ToString());
                    listitem.SubItems.Add(dr["phone2"].ToString());
                    listitem.SubItems.Add(dr["vin"].ToString());
                    listitem.SubItems.Add(dr["datetow"].ToString());
                    listitem.SubItems.Add(dr["notes"].ToString());
                    listitem.SubItems.Add(dr["daterelease"].ToString());
                    listitem.SubItems.Add(dr["ownadd"].ToString());
                    listitem.SubItems.Add(dr["owncit"].ToString());
                    listitem.SubItems.Add(dr["tagn"].ToString());
                    listitem.SubItems.Add(dr["towmiles"].ToString());
                    listitem.SubItems.Add(dr["laborcharge"].ToString());
                    listitem.SubItems.Add(dr["other1charge"].ToString());
                    listitem.SubItems.Add(dr["other2charge"].ToString());
                    listitem.SubItems.Add(dr["wrecknum"].ToString());
                    listitem.SubItems.Add(dr["wreckdriver"].ToString());
                    listitem.SubItems.Add(dr["lotkeys"].ToString());
                    listitem.SubItems.Add(dr["ccrcase"].ToString());
                    listitem.SubItems.Add(dr["towaddress"].ToString());
                    listitem.SubItems.Add(dr["lienholder"].ToString());
                    listitem.SubItems.Add(dr["charge1desc"].ToString());
                    listitem.SubItems.Add(dr["charge2desc"].ToString());
                    // tagex, winched, crashfilm, certmail, towreason, towhold, towable, iscar, isbike
                    listitem.SubItems.Add(dr["tagex"].ToString());
                    listitem.SubItems.Add(dr["winched"].ToString());
                    listitem.SubItems.Add(dr["crashfilm"].ToString());
                    listitem.SubItems.Add(dr["certmail"].ToString());
                    listitem.SubItems.Add(dr["towreason"].ToString());
                    listitem.SubItems.Add(dr["towhold"].ToString());
                    listitem.SubItems.Add(dr["towable"].ToString());
                    listitem.SubItems.Add(dr["iscar"].ToString());
                    listitem.SubItems.Add(dr["isbike"].ToString());


                    listView.Items.Add(listitem);
                    listView.View = View.Details;
                }
            }
            listView1.Items.Clear();
            SQLiteConnection conx1 = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            {
                SQLiteDataAdapter recententry = new SQLiteDataAdapter("Select * from customers order by id desc limit 250", conx);
                DataTable dt = new DataTable();
                recententry.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                    listitem.SubItems.Add(dr["first"].ToString());
                    listitem.SubItems.Add(dr["last"].ToString());
                    listitem.SubItems.Add(dr["make"].ToString());
                    listitem.SubItems.Add(dr["model"].ToString());
                    listitem.SubItems.Add(dr["prodyear"].ToString());
                    listitem.SubItems.Add(dr["phone1"].ToString());
                    listitem.SubItems.Add(dr["phone2"].ToString());
                    listitem.SubItems.Add(dr["vin"].ToString());
                    listitem.SubItems.Add(dr["datetow"].ToString());
                    listitem.SubItems.Add(dr["notes"].ToString());
                    listitem.SubItems.Add(dr["daterelease"].ToString());
                    listitem.SubItems.Add(dr["ownadd"].ToString());
                    listitem.SubItems.Add(dr["owncit"].ToString());
                    listitem.SubItems.Add(dr["tagn"].ToString());
                    listitem.SubItems.Add(dr["towmiles"].ToString());
                    listitem.SubItems.Add(dr["laborcharge"].ToString());
                    listitem.SubItems.Add(dr["other1charge"].ToString());
                    listitem.SubItems.Add(dr["other2charge"].ToString());
                    listitem.SubItems.Add(dr["wrecknum"].ToString());
                    listitem.SubItems.Add(dr["wreckdriver"].ToString());
                    listitem.SubItems.Add(dr["lotkeys"].ToString());
                    listitem.SubItems.Add(dr["ccrcase"].ToString());
                    listitem.SubItems.Add(dr["towaddress"].ToString());
                    listitem.SubItems.Add(dr["lienholder"].ToString());
                    listitem.SubItems.Add(dr["charge1desc"].ToString());
                    listitem.SubItems.Add(dr["charge2desc"].ToString());
                    listitem.SubItems.Add(dr["tagex"].ToString());
                    listitem.SubItems.Add(dr["winched"].ToString());
                    listitem.SubItems.Add(dr["crashfilm"].ToString());
                    listitem.SubItems.Add(dr["certmail"].ToString());
                    listitem.SubItems.Add(dr["towreason"].ToString());
                    listitem.SubItems.Add(dr["towhold"].ToString());
                    listitem.SubItems.Add(dr["towable"].ToString());
                    listitem.SubItems.Add(dr["iscar"].ToString());
                    listitem.SubItems.Add(dr["isbike"].ToString());
                    listView1.Items.Add(listitem);
                    listView1.View = View.Details;
                }

            }
            SQLiteConnection conx2 = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            {
                SQLiteCommand getrate1 = new SQLiteCommand("Select hookup from rates", conx2);
                {
                    conx2.Open();
                    decimal hook2 = 1.00m;
                    string gotrate = getrate1.ExecuteScalar().ToString();
                    decimal.TryParse(gotrate, out hook2);
                    numericUpDown3.Value = hook2;
                    conx2.Close();
                }

                SQLiteCommand getrate2 = new SQLiteCommand("Select towmile from rates", conx2);
                {
                    conx2.Open();
                    decimal towmile2 = 1.00m;
                    string gotmile = getrate2.ExecuteScalar().ToString();
                    decimal.TryParse(gotmile, out towmile2);
                    numericUpDown4.Value = towmile2;
                    conx2.Close();
                }

                SQLiteCommand getrate3 = new SQLiteCommand("Select storage from rates", conx2);
                {
                    conx2.Open();
                    decimal store2 = 1.00m;
                    string gotstore = getrate3.ExecuteScalar().ToString();
                    decimal.TryParse(gotstore, out store2);
                    numericUpDown5.Value = store2;
                    conx2.Close();
                }

                SQLiteCommand getrate4 = new SQLiteCommand("Select bikeday from rates", conx2);
                {
                    conx2.Open();
                    decimal bikeday2 = 1.00m;
                    string gotbikeday = getrate4.ExecuteScalar().ToString();
                    decimal.TryParse(gotbikeday, out bikeday2);
                    numericUpDown10.Value = bikeday2;
                    conx2.Close();
                }

                SQLiteCommand getrate5 = new SQLiteCommand("Select winchrate from rates", conx2);
                {
                    conx2.Open();
                    decimal winch2 = 1.00m;
                    string gotwinch = getrate5.ExecuteScalar().ToString();
                    decimal.TryParse(gotwinch, out winch2);
                    numericUpDown13.Value = winch2;
                    conx2.Close();
                }

                SQLiteCommand getrate6 = new SQLiteCommand("Select crashfilmrate from rates", conx2);
                {
                    conx2.Open();
                    decimal crash2 = 1.00m;
                    string gotcrash = getrate6.ExecuteScalar().ToString();
                    decimal.TryParse(gotcrash, out crash2);
                    numericUpDown12.Value = crash2;
                    conx2.Close();
                }

                SQLiteCommand getrate7 = new SQLiteCommand("Select adminrate from rates", conx2);
                {
                    conx2.Open();
                    decimal admin2 = 1.00m;
                    string gotadmin = getrate7.ExecuteScalar().ToString();
                    decimal.TryParse(gotadmin, out admin2);
                    numericUpDown11.Value = admin2;
                    conx2.Close();
                }

            }
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {
            listView.Items.Clear();
            SQLiteConnection conx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            {
                SQLiteDataAdapter recententry = new SQLiteDataAdapter("Select * from customers order by id desc limit 250", conx);
                DataTable dt = new DataTable();
                recententry.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                    listitem.SubItems.Add(dr["first"].ToString());
                    listitem.SubItems.Add(dr["last"].ToString());
                    listitem.SubItems.Add(dr["make"].ToString());
                    listitem.SubItems.Add(dr["model"].ToString());
                    listitem.SubItems.Add(dr["prodyear"].ToString());
                    listitem.SubItems.Add(dr["phone1"].ToString());
                    listitem.SubItems.Add(dr["phone2"].ToString());
                    listitem.SubItems.Add(dr["vin"].ToString());
                    listitem.SubItems.Add(dr["datetow"].ToString());
                    listitem.SubItems.Add(dr["notes"].ToString());
                    listitem.SubItems.Add(dr["daterelease"].ToString());
                    listitem.SubItems.Add(dr["ownadd"].ToString());
                    listitem.SubItems.Add(dr["owncit"].ToString());
                    listitem.SubItems.Add(dr["tagn"].ToString());
                    listitem.SubItems.Add(dr["towmiles"].ToString());
                    listitem.SubItems.Add(dr["laborcharge"].ToString());
                    listitem.SubItems.Add(dr["other1charge"].ToString());
                    listitem.SubItems.Add(dr["other2charge"].ToString());
                    listitem.SubItems.Add(dr["wrecknum"].ToString());
                    listitem.SubItems.Add(dr["wreckdriver"].ToString());
                    listitem.SubItems.Add(dr["lotkeys"].ToString());
                    listitem.SubItems.Add(dr["ccrcase"].ToString());
                    listitem.SubItems.Add(dr["towaddress"].ToString());
                    listitem.SubItems.Add(dr["lienholder"].ToString());
                    listitem.SubItems.Add(dr["charge1desc"].ToString());
                    listitem.SubItems.Add(dr["charge2desc"].ToString());
                    listitem.SubItems.Add(dr["tagex"].ToString());
                    listitem.SubItems.Add(dr["winched"].ToString());
                    listitem.SubItems.Add(dr["crashfilm"].ToString());
                    listitem.SubItems.Add(dr["certmail"].ToString());
                    listitem.SubItems.Add(dr["towreason"].ToString());
                    listitem.SubItems.Add(dr["towhold"].ToString());
                    listitem.SubItems.Add(dr["towable"].ToString());
                    listitem.SubItems.Add(dr["iscar"].ToString());
                    listitem.SubItems.Add(dr["isbike"].ToString());

                    listView.Items.Add(listitem);
                    listView.View = View.Details;
                }
            }
            listView1.Items.Clear();
            SQLiteConnection conx1 = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            {
                SQLiteDataAdapter recententry = new SQLiteDataAdapter("Select * from customers order by id desc limit 250", conx);
                DataTable dt = new DataTable();
                recententry.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                    listitem.SubItems.Add(dr["first"].ToString());
                    listitem.SubItems.Add(dr["last"].ToString());
                    listitem.SubItems.Add(dr["make"].ToString());
                    listitem.SubItems.Add(dr["model"].ToString());
                    listitem.SubItems.Add(dr["prodyear"].ToString());
                    listitem.SubItems.Add(dr["phone1"].ToString());
                    listitem.SubItems.Add(dr["phone2"].ToString());
                    listitem.SubItems.Add(dr["vin"].ToString());
                    listitem.SubItems.Add(dr["datetow"].ToString());
                    listitem.SubItems.Add(dr["notes"].ToString());
                    listitem.SubItems.Add(dr["daterelease"].ToString());
                    listitem.SubItems.Add(dr["ownadd"].ToString());
                    listitem.SubItems.Add(dr["owncit"].ToString());
                    listitem.SubItems.Add(dr["tagn"].ToString());
                    listitem.SubItems.Add(dr["towmiles"].ToString());
                    listitem.SubItems.Add(dr["laborcharge"].ToString());
                    listitem.SubItems.Add(dr["other1charge"].ToString());
                    listitem.SubItems.Add(dr["other2charge"].ToString());
                    listitem.SubItems.Add(dr["wrecknum"].ToString());
                    listitem.SubItems.Add(dr["wreckdriver"].ToString());
                    listitem.SubItems.Add(dr["lotkeys"].ToString());
                    listitem.SubItems.Add(dr["ccrcase"].ToString());
                    listitem.SubItems.Add(dr["towaddress"].ToString());
                    listitem.SubItems.Add(dr["lienholder"].ToString());
                    listitem.SubItems.Add(dr["charge1desc"].ToString());
                    listitem.SubItems.Add(dr["charge2desc"].ToString());
                    listitem.SubItems.Add(dr["tagex"].ToString());
                    listitem.SubItems.Add(dr["winched"].ToString());
                    listitem.SubItems.Add(dr["crashfilm"].ToString());
                    listitem.SubItems.Add(dr["certmail"].ToString());
                    listitem.SubItems.Add(dr["towreason"].ToString());
                    listitem.SubItems.Add(dr["towhold"].ToString());
                    listitem.SubItems.Add(dr["towable"].ToString());
                    listitem.SubItems.Add(dr["iscar"].ToString());
                    listitem.SubItems.Add(dr["isbike"].ToString());
                    listView1.Items.Add(listitem);
                    listView1.View = View.Details;
                }

            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
        //This is where numeric fields such as phone-numbers are validated to contain numbers and dashes only
        //
        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
        
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to create this new entry?", "New Entry Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SQLiteConnection conx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                {
                    SQLiteCommand newentry = new SQLiteCommand("Insert into customers (first, last, make, model, prodyear, phone1, phone2, vin, datetow, timetow, notes, ownadd, owncit, tagn, towmiles, laborcharge, other1charge, other2charge, wrecknum, wreckdriver, lotkeys, ccrcase, towaddress, lienholder, charge1desc, charge2desc, tagex, winched, crashfilm, certmail, towreason, towhold, towable, iscar, isbike) Values(@first, @last, @make, @model, @prodyear, @phone1, @phone2, @vin, @datetow, @timetow, @notes, @ownadd, @owncit, @tagn, @towmiles, @laborcharge, @other1charge, @other2charge, @wrecknum, @wreckdriver, @lotkeys, @ccrcase, @towaddress, @lienholder, @charge1desc, @charge2desc,@tagex, @winched, @crashfilm, @certmail, @towreason, @towhold, @towable, @iscar, @isbike)", conx);
                    newentry.Parameters.AddWithValue("@first", textBox1.Text);
                    newentry.Parameters.AddWithValue("@last", textBox2.Text);
                    newentry.Parameters.AddWithValue("@make", textBox3.Text);
                    newentry.Parameters.AddWithValue("@model", textBox5.Text);
                    newentry.Parameters.AddWithValue("@prodyear", numericUpDown1.Value);
                    newentry.Parameters.AddWithValue("@phone1", textBox6.Text);
                    newentry.Parameters.AddWithValue("@phone2", textBox7.Text);
                    newentry.Parameters.AddWithValue("@vin", textBox8.Text);
                    newentry.Parameters.AddWithValue("@datetow", dateTimePicker1.Value);
                    newentry.Parameters.AddWithValue("@timetow", dateTimePicker1.Value);
                    newentry.Parameters.AddWithValue("@notes", textBox12.Text);
                    //newentry.Parameters.AddWithValue("@daterelease", dateTimePicker2.Value);
                    newentry.Parameters.AddWithValue("@ownadd", textBox25.Text);
                    newentry.Parameters.AddWithValue("@owncit", textBox24.Text);
                    newentry.Parameters.AddWithValue("@tagn", textBox15.Text);
                    newentry.Parameters.AddWithValue("@towmiles", numericUpDown6.Value);
                    newentry.Parameters.AddWithValue("@laborcharge", numericUpDown7.Value);
                    newentry.Parameters.AddWithValue("@other1charge", numericUpDown8.Value);
                    newentry.Parameters.AddWithValue("@charge1desc", textBox17.Text);
                    newentry.Parameters.AddWithValue("@other2charge", numericUpDown9.Value);
                    newentry.Parameters.AddWithValue("@charge2desc", textBox18.Text);
                    newentry.Parameters.AddWithValue("@wrecknum", textBox21.Text);
                    newentry.Parameters.AddWithValue("@wreckdriver", textBox20.Text);
                    newentry.Parameters.AddWithValue("@lotkeys", textBox19.Text);
                    newentry.Parameters.AddWithValue("@ccrcase", textBox14.Text);
                    newentry.Parameters.AddWithValue("@towaddress", textBox16.Text);
                    newentry.Parameters.AddWithValue("@lienholder", textBox22.Text);
                    //new entries after this line - added corresponding SQL columns and SQL action in conx above
                    newentry.Parameters.AddWithValue("@tagex", textBox28.Text);
                    newentry.Parameters.AddWithValue("@winched", checkBox1.Checked);
                    newentry.Parameters.AddWithValue("@crashfilm", checkBox2.Checked);
                    newentry.Parameters.AddWithValue("@certmail", checkBox3.Checked);
                    newentry.Parameters.AddWithValue("@towreason", textBox23.Text);
                    newentry.Parameters.AddWithValue("@towhold", textBox26.Text);
                    newentry.Parameters.AddWithValue("@towable", textBox27.Text);
                    newentry.Parameters.AddWithValue("@iscar", radioButton1.Checked);
                    newentry.Parameters.AddWithValue("@isbike", radioButton2.Checked);

                    // @tagex, @winched, @crashfilm, @certmail, @towreason, @towhold, @towable, @iscar, @isbike
                    // tagex, winched, crashfilm, certmail, towreason, towhold, towable, iscar, isbike




                    conx.Open();
                    newentry.ExecuteNonQuery();
                    conx.Close();

                    listView1.Items.Clear();
                    SQLiteConnection conx1 = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                    {
                        SQLiteDataAdapter recententry = new SQLiteDataAdapter("Select * from customers order by id desc limit 250", conx);
                        DataTable dt = new DataTable();
                        recententry.Fill(dt);
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            DataRow dr = dt.Rows[i];
                            ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                            listitem.SubItems.Add(dr["first"].ToString());
                            listitem.SubItems.Add(dr["last"].ToString());
                            listitem.SubItems.Add(dr["make"].ToString());
                            listitem.SubItems.Add(dr["model"].ToString());
                            listitem.SubItems.Add(dr["prodyear"].ToString());
                            listitem.SubItems.Add(dr["phone1"].ToString());
                            listitem.SubItems.Add(dr["phone2"].ToString());
                            listitem.SubItems.Add(dr["vin"].ToString());
                            listitem.SubItems.Add(dr["datetow"].ToString());
                            listitem.SubItems.Add(dr["notes"].ToString());
                            listitem.SubItems.Add(dr["daterelease"].ToString());
                            listitem.SubItems.Add(dr["ownadd"].ToString());
                            listitem.SubItems.Add(dr["owncit"].ToString());
                            listitem.SubItems.Add(dr["tagn"].ToString());
                            listitem.SubItems.Add(dr["towmiles"].ToString());
                            listitem.SubItems.Add(dr["laborcharge"].ToString());
                            listitem.SubItems.Add(dr["other1charge"].ToString());
                            listitem.SubItems.Add(dr["other2charge"].ToString());
                            listitem.SubItems.Add(dr["wrecknum"].ToString());
                            listitem.SubItems.Add(dr["wreckdriver"].ToString());
                            listitem.SubItems.Add(dr["lotkeys"].ToString());
                            listitem.SubItems.Add(dr["ccrcase"].ToString());
                            listitem.SubItems.Add(dr["towaddress"].ToString());
                            listitem.SubItems.Add(dr["lienholder"].ToString());
                            listitem.SubItems.Add(dr["charge1desc"].ToString());
                            listitem.SubItems.Add(dr["charge2desc"].ToString());
                            listitem.SubItems.Add(dr["tagex"].ToString());
                            listitem.SubItems.Add(dr["winched"].ToString());
                            listitem.SubItems.Add(dr["crashfilm"].ToString());
                            listitem.SubItems.Add(dr["certmail"].ToString());
                            listitem.SubItems.Add(dr["towreason"].ToString());
                            listitem.SubItems.Add(dr["towhold"].ToString());
                            listitem.SubItems.Add(dr["towable"].ToString());
                            listitem.SubItems.Add(dr["iscar"].ToString());
                            listitem.SubItems.Add(dr["isbike"].ToString());
                            listView1.Items.Add(listitem);
                            listView1.View = View.Details;
                        }
                    }
                }
            }
        }

        public event TabControlEventHandler Selected;




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            SQLiteConnection conx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            {
                SQLiteDataAdapter recententry = new SQLiteDataAdapter("Select * from customers order by id desc limit 250", conx);
                DataTable dt = new DataTable();
                recententry.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                    listitem.SubItems.Add(dr["first"].ToString());
                    listitem.SubItems.Add(dr["last"].ToString());
                    listitem.SubItems.Add(dr["make"].ToString());
                    listitem.SubItems.Add(dr["model"].ToString());
                    listitem.SubItems.Add(dr["prodyear"].ToString());
                    listitem.SubItems.Add(dr["phone1"].ToString());
                    listitem.SubItems.Add(dr["phone2"].ToString());
                    listitem.SubItems.Add(dr["vin"].ToString());
                    listitem.SubItems.Add(dr["datetow"].ToString());
                    listitem.SubItems.Add(dr["notes"].ToString());
                    listitem.SubItems.Add(dr["daterelease"].ToString());
                    listitem.SubItems.Add(dr["ownadd"].ToString());
                    listitem.SubItems.Add(dr["owncit"].ToString());
                    listitem.SubItems.Add(dr["tagn"].ToString());
                    listitem.SubItems.Add(dr["towmiles"].ToString());
                    listitem.SubItems.Add(dr["laborcharge"].ToString());
                    listitem.SubItems.Add(dr["other1charge"].ToString());
                    listitem.SubItems.Add(dr["other2charge"].ToString());
                    listitem.SubItems.Add(dr["wrecknum"].ToString());
                    listitem.SubItems.Add(dr["wreckdriver"].ToString());
                    listitem.SubItems.Add(dr["lotkeys"].ToString());
                    listitem.SubItems.Add(dr["ccrcase"].ToString());
                    listitem.SubItems.Add(dr["towaddress"].ToString());
                    listitem.SubItems.Add(dr["lienholder"].ToString());
                    listitem.SubItems.Add(dr["charge1desc"].ToString());
                    listitem.SubItems.Add(dr["charge2desc"].ToString());
                    listitem.SubItems.Add(dr["tagex"].ToString());
                    listitem.SubItems.Add(dr["winched"].ToString());
                    listitem.SubItems.Add(dr["crashfilm"].ToString());
                    listitem.SubItems.Add(dr["certmail"].ToString());
                    listitem.SubItems.Add(dr["towreason"].ToString());
                    listitem.SubItems.Add(dr["towhold"].ToString());
                    listitem.SubItems.Add(dr["towable"].ToString());
                    listitem.SubItems.Add(dr["iscar"].ToString());
                    listitem.SubItems.Add(dr["isbike"].ToString());
                    listView.Items.Add(listitem);
                    listView.View = View.Details;
                }
            }
        }

        public static string edid, edfirst, edlast, edmake, edmodel, edyear, edph1, edph2, edvin, ednotes, eddate, eddaterelease, edownadd, edowncit, edtagn, edtowmiles, edlaborcharge, edother1charge, edother2charge, edwrecknum, edwreckdriver, edlotkeys, edccrcase, edtowaddress, edlienholder, edcharge1desc, edcharge2desc, edtagex, edwinched, edcrashfilm, edcertmail, edtowreason, edtowhold, edtowable, ediscar, edisbike;

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public static string incert1a, incert1b, inwinch1a, inwinch1b, inhook, gotrate, inid, infirst, inlast, inmake, inmodel, inyear, inph1, inph2, invin, innotes, indate, indaterelease, inownadd, inowncit, intagn, intowmiles, inlaborcharge, inother1charge, inother2charge, inwrecknum, inwreckdriver, inlotkeys, inccrcase, intowaddress, inlienholder, incharge1desc, incharge2desc, inch1a, inch1b, inch2a, inch2b, intagex, inwinched, incrashfilm, incertmail, intowreason, intowhold, intowable, iniscar, inisbike, instore, incrash1a, incrash1b;

        private void button16_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                inid = listView1.SelectedItems[0].SubItems[0].Text;
                infirst = listView1.SelectedItems[0].SubItems[1].Text;
                inlast = listView1.SelectedItems[0].SubItems[2].Text;
                inmake = listView1.SelectedItems[0].SubItems[3].Text;
                inmodel = listView1.SelectedItems[0].SubItems[4].Text;
                inyear = listView1.SelectedItems[0].SubItems[5].Text;
                inph1 = listView1.SelectedItems[0].SubItems[6].Text;
                inph2 = listView1.SelectedItems[0].SubItems[7].Text;
                invin = listView1.SelectedItems[0].SubItems[8].Text;
                indate = listView1.SelectedItems[0].SubItems[9].Text;
                innotes = listView1.SelectedItems[0].SubItems[10].Text;
                indaterelease = listView1.SelectedItems[0].SubItems[11].Text;
                inownadd = listView1.SelectedItems[0].SubItems[12].Text;
                inowncit = listView1.SelectedItems[0].SubItems[13].Text;
                intagn = listView1.SelectedItems[0].SubItems[14].Text;
                intowmiles = listView1.SelectedItems[0].SubItems[15].Text;
                inlaborcharge = listView1.SelectedItems[0].SubItems[16].Text;
                inother1charge = listView1.SelectedItems[0].SubItems[17].Text;
                inother2charge = listView1.SelectedItems[0].SubItems[18].Text;
                inwrecknum = listView1.SelectedItems[0].SubItems[19].Text;
                inwreckdriver = listView1.SelectedItems[0].SubItems[20].Text;
                inlotkeys = listView1.SelectedItems[0].SubItems[21].Text;
                inccrcase = listView1.SelectedItems[0].SubItems[22].Text;
                intowaddress = listView1.SelectedItems[0].SubItems[23].Text;
                inlienholder = listView1.SelectedItems[0].SubItems[24].Text;
                incharge1desc = listView1.SelectedItems[0].SubItems[25].Text;
                incharge2desc = listView1.SelectedItems[0].SubItems[26].Text;
                intagex = listView1.SelectedItems[0].SubItems[27].Text;
                inwinched = listView1.SelectedItems[0].SubItems[28].Text;
                incrashfilm = listView1.SelectedItems[0].SubItems[29].Text;
                incertmail = listView1.SelectedItems[0].SubItems[30].Text;
                intowreason = listView1.SelectedItems[0].SubItems[31].Text;
                intowhold = listView1.SelectedItems[0].SubItems[32].Text;
                intowable = listView1.SelectedItems[0].SubItems[33].Text;
                iniscar = listView1.SelectedItems[0].SubItems[34].Text;
                inisbike = listView1.SelectedItems[0].SubItems[35].Text;





                const string fileName = "c:\\towjax\\invoice\\invoice.html";

                //Read HTML from file and create new filename
                var content = File.ReadAllText(fileName);
                var invdate = DateTime.Now.ToString("MM-dd-yyyy");
                var filenamenew = "C:\\towjax\\invoice\\" + inid + "-" + invdate + ".html";
                string filenameonly = "C:\\towjax\\invoice\\" + inid + "-" + invdate;
                int count = 1;
                while (File.Exists(filenamenew))
                {
                    string filenametemp = string.Format("{0}({1})", filenameonly, count++);
                    filenamenew = filenametemp + ".html";
                }


                //Manipulate HTML as needed
                inhook = numericUpDown3.Value.ToString();
                decimal inhookdec = numericUpDown3.Value;
                decimal inmiles = 0.0m;
                decimal.TryParse(intowmiles, out inmiles);
                decimal towtotaled = 0.0m;
                towtotaled = (decimal)inmiles * numericUpDown4.Value;
                decimal towdec = 0.00m;
                towdec = Math.Round(towtotaled, 2, MidpointRounding.ToEven);
                string towtotals = towdec.ToString("0.00");
                string trate = numericUpDown4.Value.ToString("0.00");
                decimal indecstore = 0.00m;
                if (iniscar == "1")
                { indecstore = numericUpDown5.Value;  }
                else { indecstore = numericUpDown10.Value; }

                //decimal instoredec = numericUpDown5.Value;
                
                DateTime inrel;
                DateTime.TryParse(indaterelease, out inrel);
                DateTime indtow;
                DateTime.TryParse(indate, out indtow);
                //var indays = inrel - indtow;
                TimeSpan difference = inrel - indtow;
                var indays = difference.Days;
                decimal indaysdec = 0.00m;
                string sindays = indays.ToString();
                decimal.TryParse(sindays, out indaysdec);
                decimal indaysdecfix = indaysdec + 1;
                decimal stortot = indaysdecfix * indecstore;
                decimal stortot2;
                stortot2 = Math.Round(stortot, 2, MidpointRounding.AwayFromZero);
                string instoretotal = stortot2.ToString("0.00");
                string sindaysfixed = indaysdecfix.ToString();
                decimal inlabor = 0.00m;
                decimal.TryParse(inlaborcharge, out inlabor);
                decimal inlabordec = 0.00m;
                inlabordec = Math.Round(inlabor, 2, MidpointRounding.ToEven);
                string inlabortotal = inlabordec.ToString("0.00");


                decimal incert = 0.00m;
                decimal inwinch = 0.00m;
                decimal incrash = 0.00m;
                decimal inch1 = 0.00m;
                decimal.TryParse(inother1charge, out inch1);
                if ( inch1 == 0.00m )
                { inch1a = "<!--";
                  inch1b = "--!>"; }
                else { inch1a = "&nbsp;";
                       inch1b = "&nbsp;"; }

                decimal inch1dec = 0.00m;
                inch1dec = Math.Round(inch1, 2, MidpointRounding.ToEven);
                string inch1total = inch1dec.ToString("0.00");
               
                decimal inch2 = 0.00m;
                decimal.TryParse(inother2charge, out inch2);
                if (inch2 == 0.00m)
                {
                    inch2a = "<!--";
                    inch2b = "--!>";
                }
                else
                {
                    inch2a = "&nbsp;";
                    inch2b = "&nbsp;";
                }
                //new boxes
                if (incrashfilm == "0")
                {
                    incrash1a = "<!--";
                    incrash1b = "--!>";
                }
                else
                {
                    incrash = numericUpDown12.Value;
                    incrash1a = "&nbsp;";
                    incrash1b = "&nbsp;";
                }
                if (inwinched == "0")
                {
                    inwinch1a = "<!--";
                    inwinch1b = "--!>";
                }
                else
                {
                    inwinch = numericUpDown13.Value;
                    inwinch1a = "&nbsp;";
                    inwinch1b = "&nbsp;";
                }
                if (incertmail == "0")
                {
                    incert1a = "<!--";
                    incert1b = "--!>";
                }
                else
                {
                    incert = numericUpDown11.Value;
                    incert1a = "&nbsp;";
                    incert1b = "&nbsp;";              
                }

                decimal inch2dec = 0.00m;
                inch2dec = Math.Round(inch2, 2, MidpointRounding.ToEven);
                string inch2total = inch2dec.ToString("0.00");

                decimal alltotdec = 0.00m;
                alltotdec = (decimal)inhookdec + towdec + inlabordec + inch1dec + inch2dec + stortot2 + incert + inwinch + incrash;
                decimal alltot2 = Math.Round(alltotdec, 2, MidpointRounding.ToEven);
                string thetotal = alltot2.ToString("0.00");
                instore = indecstore.ToString();
                //Replace all values in the HTML
                content = content.Replace("{inid}", inid);
                content = content.Replace("{inreleasedate}", invdate);
                content = content.Replace("{infirst}", infirst);
                content = content.Replace("{inlast}", inlast);
                content = content.Replace("{inownadd}", inownadd);
                content = content.Replace("{inowncit}", inowncit);
                content = content.Replace("{inph1}", inph1);
                content = content.Replace("{inhookrate}", inhook);
                content = content.Replace("{inhookrate}", inhook);
                content = content.Replace("{incharge1desc}", incharge1desc);
                content = content.Replace("{incharge2desc}", incharge2desc);
                content = content.Replace("{inother1charge}", inch1total);
                content = content.Replace("{inother2charge}", inch2total);
                content = content.Replace("{inlabor}", inlabortotal);
                content = content.Replace("{intowmilebyrate}", towtotals);
                content = content.Replace("{instorage}", instoretotal);
                content = content.Replace("{miles}", intowmiles);
                content = content.Replace("{trate}", trate);
                content = content.Replace("{days}", sindaysfixed);
                content = content.Replace("{srate}", instore);
                content = content.Replace("{inch1a}", inch1a);
                content = content.Replace("{inch1b}", inch1b);
                content = content.Replace("{inch2a}", inch2a);
                content = content.Replace("{inch2b}", inch2b);
                content = content.Replace("{inwrap}", incrash.ToString("0.00"));
                content = content.Replace("{inwrap1a}", incrash1a);
                content = content.Replace("{inwrap1b}", incrash1b);
                content = content.Replace("{inwinch}", inwinch.ToString("0.00"));
                content = content.Replace("{inwinch1a}", inwinch1a);
                content = content.Replace("{inwinch1b}", inwinch1b);
                content = content.Replace("{incert}", incert.ToString("0.00"));
                content = content.Replace("{incert1a}", incert1a);
                content = content.Replace("{incert1b}", incert1b);


                content = content.Replace("{intotal}", "$" + thetotal);



                //Write new HTML string to file
                File.WriteAllText(filenamenew, content);

                //Show it in the default application for handling .html files
                Process.Start(filenamenew);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            //string selector = string.Format("{0}", comboBox1.GetItemText(comboBox1.SelectedItem));
            string notesstring = string.Format("%{0}%", textBox13.Text);
            //MessageBox.Show(selector);
            listView.Items.Clear();
            using (SQLiteConnection vonx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            using (SQLiteCommand ventry = new SQLiteCommand("SELECT * FROM customers WHERE notes LIKE @notes", vonx))
            {
                //ventry.Parameters.AddWithValue("@tables", selector);
                ventry.Parameters.AddWithValue("@notes", notesstring);
                //ventry.Parameters.AddWithValue("@table", selector);
                SQLiteDataAdapter myda = new SQLiteDataAdapter(ventry);
                DataTable vt = new DataTable();
                myda.Fill(vt);
                for (int i = 0; i < vt.Rows.Count; i++)
                {
                    DataRow dr = vt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                    listitem.SubItems.Add(dr["first"].ToString());
                    listitem.SubItems.Add(dr["last"].ToString());
                    listitem.SubItems.Add(dr["make"].ToString());
                    listitem.SubItems.Add(dr["model"].ToString());
                    listitem.SubItems.Add(dr["prodyear"].ToString());
                    listitem.SubItems.Add(dr["phone1"].ToString());
                    listitem.SubItems.Add(dr["phone2"].ToString());
                    listitem.SubItems.Add(dr["vin"].ToString());
                    listitem.SubItems.Add(dr["datetow"].ToString());
                    listitem.SubItems.Add(dr["notes"].ToString());
                    listitem.SubItems.Add(dr["daterelease"].ToString());
                    listitem.SubItems.Add(dr["ownadd"].ToString());
                    listitem.SubItems.Add(dr["owncit"].ToString());
                    listitem.SubItems.Add(dr["tagn"].ToString());
                    listitem.SubItems.Add(dr["towmiles"].ToString());
                    listitem.SubItems.Add(dr["laborcharge"].ToString());
                    listitem.SubItems.Add(dr["other1charge"].ToString());
                    listitem.SubItems.Add(dr["other2charge"].ToString());
                    listitem.SubItems.Add(dr["wrecknum"].ToString());
                    listitem.SubItems.Add(dr["wreckdriver"].ToString());
                    listitem.SubItems.Add(dr["lotkeys"].ToString());
                    listitem.SubItems.Add(dr["ccrcase"].ToString());
                    listitem.SubItems.Add(dr["towaddress"].ToString());
                    listitem.SubItems.Add(dr["lienholder"].ToString());
                    listitem.SubItems.Add(dr["charge1desc"].ToString());
                    listitem.SubItems.Add(dr["charge2desc"].ToString());
                    listitem.SubItems.Add(dr["tagex"].ToString());
                    listitem.SubItems.Add(dr["winched"].ToString());
                    listitem.SubItems.Add(dr["crashfilm"].ToString());
                    listitem.SubItems.Add(dr["certmail"].ToString());
                    listitem.SubItems.Add(dr["towreason"].ToString());
                    listitem.SubItems.Add(dr["towhold"].ToString());
                    listitem.SubItems.Add(dr["towable"].ToString());
                    listitem.SubItems.Add(dr["iscar"].ToString());
                    listitem.SubItems.Add(dr["isbike"].ToString());
                    listView.Items.Add(listitem);
                    listView.View = View.Details;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to make these changes?", "Edit Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SQLiteConnection rateconx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                    SQLiteCommand ratemod = new SQLiteCommand("UPDATE rates SET hookup = @hookup", rateconx);
                    ratemod.Parameters.AddWithValue("@hookup", numericUpDown3.Value);
                    rateconx.Open();
                    ratemod.ExecuteNonQuery();
                    rateconx.Close();

                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to make these changes?", "Edit Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SQLiteConnection rateconx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                    SQLiteCommand ratemod = new SQLiteCommand("UPDATE rates SET towmile = @towmile", rateconx);
                    ratemod.Parameters.AddWithValue("@towmile", numericUpDown4.Value);
                    rateconx.Open();
                    ratemod.ExecuteNonQuery();
                    rateconx.Close();

                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to make these changes?", "Edit Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SQLiteConnection rateconx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                    SQLiteCommand ratemod = new SQLiteCommand("UPDATE rates SET storage = @storage", rateconx);
                    ratemod.Parameters.AddWithValue("@storage", numericUpDown5.Value);
                    rateconx.Open();
                    ratemod.ExecuteNonQuery();
                    rateconx.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to make these changes?", "Edit Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SQLiteConnection rateconx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                    SQLiteCommand ratemod = new SQLiteCommand("UPDATE rates SET bikeday = @bikeday", rateconx);
                    ratemod.Parameters.AddWithValue("@bikeday", numericUpDown10.Value);
                    rateconx.Open();
                    ratemod.ExecuteNonQuery();
                    rateconx.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to make these changes?", "Edit Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SQLiteConnection rateconx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                    SQLiteCommand ratemod = new SQLiteCommand("UPDATE rates SET winchrate = @winchrate", rateconx);
                    ratemod.Parameters.AddWithValue("@winchrate", numericUpDown13.Value);
                    rateconx.Open();
                    ratemod.ExecuteNonQuery();
                    rateconx.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to make these changes?", "Edit Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SQLiteConnection rateconx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                    SQLiteCommand ratemod = new SQLiteCommand("UPDATE rates SET adminrate = @adminrate", rateconx);
                    ratemod.Parameters.AddWithValue("@adminrate", numericUpDown11.Value);
                    rateconx.Open();
                    ratemod.ExecuteNonQuery();
                    rateconx.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }




        private void button15_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to make these changes?", "Edit Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SQLiteConnection rateconx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                    SQLiteCommand ratemod = new SQLiteCommand("UPDATE rates SET crashfilmrate = @crashfilmrate", rateconx);
                    ratemod.Parameters.AddWithValue("@crashfilmrate", numericUpDown12.Value);
                    rateconx.Open();
                    ratemod.ExecuteNonQuery();
                    rateconx.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }


        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //string selector = string.Format("{0}", comboBox1.GetItemText(comboBox1.SelectedItem));
            string yearstring = string.Format("{0}", numericUpDown2.Value);
            //MessageBox.Show(selector);
            listView.Items.Clear();
            using (SQLiteConnection vonx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            using (SQLiteCommand ventry = new SQLiteCommand("SELECT * FROM customers WHERE prodyear LIKE @year", vonx))
            {
                //ventry.Parameters.AddWithValue("@tables", selector);
                ventry.Parameters.AddWithValue("@year", yearstring);
                //ventry.Parameters.AddWithValue("@table", selector);
                SQLiteDataAdapter myda = new SQLiteDataAdapter(ventry);
                DataTable vt = new DataTable();
                myda.Fill(vt);
                for (int i = 0; i < vt.Rows.Count; i++)
                {
                    DataRow dr = vt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                    listitem.SubItems.Add(dr["first"].ToString());
                    listitem.SubItems.Add(dr["last"].ToString());
                    listitem.SubItems.Add(dr["make"].ToString());
                    listitem.SubItems.Add(dr["model"].ToString());
                    listitem.SubItems.Add(dr["prodyear"].ToString());
                    listitem.SubItems.Add(dr["phone1"].ToString());
                    listitem.SubItems.Add(dr["phone2"].ToString());
                    listitem.SubItems.Add(dr["vin"].ToString());
                    listitem.SubItems.Add(dr["datetow"].ToString());
                    listitem.SubItems.Add(dr["notes"].ToString());
                    listitem.SubItems.Add(dr["daterelease"].ToString());
                    listitem.SubItems.Add(dr["ownadd"].ToString());
                    listitem.SubItems.Add(dr["owncit"].ToString());
                    listitem.SubItems.Add(dr["tagn"].ToString());
                    listitem.SubItems.Add(dr["towmiles"].ToString());
                    listitem.SubItems.Add(dr["laborcharge"].ToString());
                    listitem.SubItems.Add(dr["other1charge"].ToString());
                    listitem.SubItems.Add(dr["other2charge"].ToString());
                    listitem.SubItems.Add(dr["wrecknum"].ToString());
                    listitem.SubItems.Add(dr["wreckdriver"].ToString());
                    listitem.SubItems.Add(dr["lotkeys"].ToString());
                    listitem.SubItems.Add(dr["ccrcase"].ToString());
                    listitem.SubItems.Add(dr["towaddress"].ToString());
                    listitem.SubItems.Add(dr["lienholder"].ToString());
                    listitem.SubItems.Add(dr["charge1desc"].ToString());
                    listitem.SubItems.Add(dr["charge2desc"].ToString());
                    listitem.SubItems.Add(dr["tagex"].ToString());
                    listitem.SubItems.Add(dr["winched"].ToString());
                    listitem.SubItems.Add(dr["crashfilm"].ToString());
                    listitem.SubItems.Add(dr["certmail"].ToString());
                    listitem.SubItems.Add(dr["towreason"].ToString());
                    listitem.SubItems.Add(dr["towhold"].ToString());
                    listitem.SubItems.Add(dr["towable"].ToString());
                    listitem.SubItems.Add(dr["iscar"].ToString());
                    listitem.SubItems.Add(dr["isbike"].ToString());
                    listView.Items.Add(listitem);
                    listView.View = View.Details;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //string selector = string.Format("{0}", comboBox1.GetItemText(comboBox1.SelectedItem));
            string ph1string = string.Format("%{0}%", textBox10.Text);
            //MessageBox.Show(selector);
            listView.Items.Clear();
            using (SQLiteConnection vonx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            using (SQLiteCommand ventry = new SQLiteCommand("SELECT * FROM customers WHERE phone1 LIKE @ph1", vonx))
            {
                //ventry.Parameters.AddWithValue("@tables", selector);
                ventry.Parameters.AddWithValue("@ph1", ph1string);
                //ventry.Parameters.AddWithValue("@table", selector);
                SQLiteDataAdapter myda = new SQLiteDataAdapter(ventry);
                DataTable vt = new DataTable();
                myda.Fill(vt);
                for (int i = 0; i < vt.Rows.Count; i++)
                {
                    DataRow dr = vt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                    listitem.SubItems.Add(dr["first"].ToString());
                    listitem.SubItems.Add(dr["last"].ToString());
                    listitem.SubItems.Add(dr["make"].ToString());
                    listitem.SubItems.Add(dr["model"].ToString());
                    listitem.SubItems.Add(dr["prodyear"].ToString());
                    listitem.SubItems.Add(dr["phone1"].ToString());
                    listitem.SubItems.Add(dr["phone2"].ToString());
                    listitem.SubItems.Add(dr["vin"].ToString());
                    listitem.SubItems.Add(dr["datetow"].ToString());
                    listitem.SubItems.Add(dr["notes"].ToString());
                    listitem.SubItems.Add(dr["daterelease"].ToString());
                    listitem.SubItems.Add(dr["ownadd"].ToString());
                    listitem.SubItems.Add(dr["owncit"].ToString());
                    listitem.SubItems.Add(dr["tagn"].ToString());
                    listitem.SubItems.Add(dr["towmiles"].ToString());
                    listitem.SubItems.Add(dr["laborcharge"].ToString());
                    listitem.SubItems.Add(dr["other1charge"].ToString());
                    listitem.SubItems.Add(dr["other2charge"].ToString());
                    listitem.SubItems.Add(dr["wrecknum"].ToString());
                    listitem.SubItems.Add(dr["wreckdriver"].ToString());
                    listitem.SubItems.Add(dr["lotkeys"].ToString());
                    listitem.SubItems.Add(dr["ccrcase"].ToString());
                    listitem.SubItems.Add(dr["towaddress"].ToString());
                    listitem.SubItems.Add(dr["lienholder"].ToString());
                    listitem.SubItems.Add(dr["charge1desc"].ToString());
                    listitem.SubItems.Add(dr["charge2desc"].ToString());
                    listitem.SubItems.Add(dr["tagex"].ToString());
                    listitem.SubItems.Add(dr["winched"].ToString());
                    listitem.SubItems.Add(dr["crashfilm"].ToString());
                    listitem.SubItems.Add(dr["certmail"].ToString());
                    listitem.SubItems.Add(dr["towreason"].ToString());
                    listitem.SubItems.Add(dr["towhold"].ToString());
                    listitem.SubItems.Add(dr["towable"].ToString());
                    listitem.SubItems.Add(dr["iscar"].ToString());
                    listitem.SubItems.Add(dr["isbike"].ToString());
                    listView.Items.Add(listitem);
                    listView.View = View.Details;
                }
            }

            //string selector = string.Format("{0}", comboBox1.GetItemText(comboBox1.SelectedItem));
            string ph2string = string.Format("%{0}%", textBox10.Text);
            //MessageBox.Show(selector);
            listView.Items.Clear();
            using (SQLiteConnection vonx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            using (SQLiteCommand ventry = new SQLiteCommand("SELECT * FROM customers WHERE phone2 LIKE @ph2", vonx))
            {
                //ventry.Parameters.AddWithValue("@tables", selector);
                ventry.Parameters.AddWithValue("@ph2", ph2string);
                //ventry.Parameters.AddWithValue("@table", selector);
                SQLiteDataAdapter myda = new SQLiteDataAdapter(ventry);
                DataTable vt = new DataTable();
                myda.Fill(vt);
                for (int i = 0; i < vt.Rows.Count; i++)
                {
                    DataRow dr = vt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                    listitem.SubItems.Add(dr["first"].ToString());
                    listitem.SubItems.Add(dr["last"].ToString());
                    listitem.SubItems.Add(dr["make"].ToString());
                    listitem.SubItems.Add(dr["model"].ToString());
                    listitem.SubItems.Add(dr["prodyear"].ToString());
                    listitem.SubItems.Add(dr["phone1"].ToString());
                    listitem.SubItems.Add(dr["phone2"].ToString());
                    listitem.SubItems.Add(dr["vin"].ToString());
                    listitem.SubItems.Add(dr["datetow"].ToString());
                    listitem.SubItems.Add(dr["notes"].ToString());
                    listitem.SubItems.Add(dr["daterelease"].ToString());
                    listitem.SubItems.Add(dr["ownadd"].ToString());
                    listitem.SubItems.Add(dr["owncit"].ToString());
                    listitem.SubItems.Add(dr["tagn"].ToString());
                    listitem.SubItems.Add(dr["towmiles"].ToString());
                    listitem.SubItems.Add(dr["laborcharge"].ToString());
                    listitem.SubItems.Add(dr["other1charge"].ToString());
                    listitem.SubItems.Add(dr["other2charge"].ToString());
                    listitem.SubItems.Add(dr["wrecknum"].ToString());
                    listitem.SubItems.Add(dr["wreckdriver"].ToString());
                    listitem.SubItems.Add(dr["lotkeys"].ToString());
                    listitem.SubItems.Add(dr["ccrcase"].ToString());
                    listitem.SubItems.Add(dr["towaddress"].ToString());
                    listitem.SubItems.Add(dr["lienholder"].ToString());
                    listitem.SubItems.Add(dr["charge1desc"].ToString());
                    listitem.SubItems.Add(dr["charge2desc"].ToString());
                    listitem.SubItems.Add(dr["tagex"].ToString());
                    listitem.SubItems.Add(dr["winched"].ToString());
                    listitem.SubItems.Add(dr["crashfilm"].ToString());
                    listitem.SubItems.Add(dr["certmail"].ToString());
                    listitem.SubItems.Add(dr["towreason"].ToString());
                    listitem.SubItems.Add(dr["towhold"].ToString());
                    listitem.SubItems.Add(dr["towable"].ToString());
                    listitem.SubItems.Add(dr["iscar"].ToString());
                    listitem.SubItems.Add(dr["isbike"].ToString());
                    listView.Items.Add(listitem);
                    listView.View = View.Details;
                }
            }
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            //string selector = string.Format("{0}", comboBox1.GetItemText(comboBox1.SelectedItem));
            string makestring = string.Format("%{0}%", textBox11.Text);
            //MessageBox.Show(selector);
            listView.Items.Clear();
            using (SQLiteConnection vonx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            using (SQLiteCommand ventry = new SQLiteCommand("SELECT * FROM customers WHERE make LIKE @make", vonx))
            {
                //ventry.Parameters.AddWithValue("@tables", selector);
                ventry.Parameters.AddWithValue("@make", makestring);
                //ventry.Parameters.AddWithValue("@table", selector);
                SQLiteDataAdapter myda = new SQLiteDataAdapter(ventry);
                DataTable vt = new DataTable();
                myda.Fill(vt);
                for (int i = 0; i < vt.Rows.Count; i++)
                {
                    DataRow dr = vt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                    listitem.SubItems.Add(dr["first"].ToString());
                    listitem.SubItems.Add(dr["last"].ToString());
                    listitem.SubItems.Add(dr["make"].ToString());
                    listitem.SubItems.Add(dr["model"].ToString());
                    listitem.SubItems.Add(dr["prodyear"].ToString());
                    listitem.SubItems.Add(dr["phone1"].ToString());
                    listitem.SubItems.Add(dr["phone2"].ToString());
                    listitem.SubItems.Add(dr["vin"].ToString());
                    listitem.SubItems.Add(dr["datetow"].ToString());
                    listitem.SubItems.Add(dr["notes"].ToString());
                    listitem.SubItems.Add(dr["daterelease"].ToString());
                    listitem.SubItems.Add(dr["ownadd"].ToString());
                    listitem.SubItems.Add(dr["owncit"].ToString());
                    listitem.SubItems.Add(dr["tagn"].ToString());
                    listitem.SubItems.Add(dr["towmiles"].ToString());
                    listitem.SubItems.Add(dr["laborcharge"].ToString());
                    listitem.SubItems.Add(dr["other1charge"].ToString());
                    listitem.SubItems.Add(dr["other2charge"].ToString());
                    listitem.SubItems.Add(dr["wrecknum"].ToString());
                    listitem.SubItems.Add(dr["wreckdriver"].ToString());
                    listitem.SubItems.Add(dr["lotkeys"].ToString());
                    listitem.SubItems.Add(dr["ccrcase"].ToString());
                    listitem.SubItems.Add(dr["towaddress"].ToString());
                    listitem.SubItems.Add(dr["lienholder"].ToString());
                    listitem.SubItems.Add(dr["charge1desc"].ToString());
                    listitem.SubItems.Add(dr["charge2desc"].ToString());
                    listitem.SubItems.Add(dr["tagex"].ToString());
                    listitem.SubItems.Add(dr["winched"].ToString());
                    listitem.SubItems.Add(dr["crashfilm"].ToString());
                    listitem.SubItems.Add(dr["certmail"].ToString());
                    listitem.SubItems.Add(dr["towreason"].ToString());
                    listitem.SubItems.Add(dr["towhold"].ToString());
                    listitem.SubItems.Add(dr["towable"].ToString());
                    listitem.SubItems.Add(dr["iscar"].ToString());
                    listitem.SubItems.Add(dr["isbike"].ToString());
                    listView.Items.Add(listitem);
                    listView.View = View.Details;
                }
            }

            //string selector = string.Format("{0}", comboBox1.GetItemText(comboBox1.SelectedItem));
            string modstring = string.Format("%{0}%", textBox11.Text);
            //MessageBox.Show(selector);
            using (SQLiteConnection vonx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            using (SQLiteCommand ventry = new SQLiteCommand("SELECT * FROM customers WHERE model LIKE @model", vonx))
            {
                //ventry.Parameters.AddWithValue("@tables", selector);
                ventry.Parameters.AddWithValue("@model", modstring);
                //ventry.Parameters.AddWithValue("@table", selector);
                SQLiteDataAdapter myda = new SQLiteDataAdapter(ventry);
                DataTable vt = new DataTable();
                myda.Fill(vt);
                for (int i = 0; i < vt.Rows.Count; i++)
                {
                    DataRow dr = vt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                    listitem.SubItems.Add(dr["first"].ToString());
                    listitem.SubItems.Add(dr["last"].ToString());
                    listitem.SubItems.Add(dr["make"].ToString());
                    listitem.SubItems.Add(dr["model"].ToString());
                    listitem.SubItems.Add(dr["prodyear"].ToString());
                    listitem.SubItems.Add(dr["phone1"].ToString());
                    listitem.SubItems.Add(dr["phone2"].ToString());
                    listitem.SubItems.Add(dr["vin"].ToString());
                    listitem.SubItems.Add(dr["datetow"].ToString());
                    listitem.SubItems.Add(dr["notes"].ToString());
                    listitem.SubItems.Add(dr["daterelease"].ToString());
                    listitem.SubItems.Add(dr["ownadd"].ToString());
                    listitem.SubItems.Add(dr["owncit"].ToString());
                    listitem.SubItems.Add(dr["tagn"].ToString());
                    listitem.SubItems.Add(dr["towmiles"].ToString());
                    listitem.SubItems.Add(dr["laborcharge"].ToString());
                    listitem.SubItems.Add(dr["other1charge"].ToString());
                    listitem.SubItems.Add(dr["other2charge"].ToString());
                    listitem.SubItems.Add(dr["wrecknum"].ToString());
                    listitem.SubItems.Add(dr["wreckdriver"].ToString());
                    listitem.SubItems.Add(dr["lotkeys"].ToString());
                    listitem.SubItems.Add(dr["ccrcase"].ToString());
                    listitem.SubItems.Add(dr["towaddress"].ToString());
                    listitem.SubItems.Add(dr["lienholder"].ToString());
                    listitem.SubItems.Add(dr["charge1desc"].ToString());
                    listitem.SubItems.Add(dr["charge2desc"].ToString());
                    listitem.SubItems.Add(dr["tagex"].ToString());
                    listitem.SubItems.Add(dr["winched"].ToString());
                    listitem.SubItems.Add(dr["crashfilm"].ToString());
                    listitem.SubItems.Add(dr["certmail"].ToString());
                    listitem.SubItems.Add(dr["towreason"].ToString());
                    listitem.SubItems.Add(dr["towhold"].ToString());
                    listitem.SubItems.Add(dr["towable"].ToString());
                    listitem.SubItems.Add(dr["iscar"].ToString());
                    listitem.SubItems.Add(dr["isbike"].ToString());
                    listView.Items.Add(listitem);
                    listView.View = View.Details;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string selector = string.Format("{0}", comboBox1.GetItemText(comboBox1.SelectedItem));
            string namestring = string.Format("%{0}%", textBox9.Text);
            //MessageBox.Show(selector);
            listView.Items.Clear();
            using (SQLiteConnection vonx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            using (SQLiteCommand ventry = new SQLiteCommand("SELECT * FROM customers WHERE first LIKE @first", vonx))
            {
                //ventry.Parameters.AddWithValue("@tables", selector);
                ventry.Parameters.AddWithValue("@first", namestring);
                //ventry.Parameters.AddWithValue("@table", selector);
                SQLiteDataAdapter myda = new SQLiteDataAdapter(ventry);
                DataTable vt = new DataTable();
                myda.Fill(vt);
                for (int i = 0; i < vt.Rows.Count; i++)
                {
                    DataRow dr = vt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                    listitem.SubItems.Add(dr["first"].ToString());
                    listitem.SubItems.Add(dr["last"].ToString());
                    listitem.SubItems.Add(dr["make"].ToString());
                    listitem.SubItems.Add(dr["model"].ToString());
                    listitem.SubItems.Add(dr["prodyear"].ToString());
                    listitem.SubItems.Add(dr["phone1"].ToString());
                    listitem.SubItems.Add(dr["phone2"].ToString());
                    listitem.SubItems.Add(dr["vin"].ToString());
                    listitem.SubItems.Add(dr["datetow"].ToString());
                    listitem.SubItems.Add(dr["notes"].ToString());
                    listitem.SubItems.Add(dr["daterelease"].ToString());
                    listitem.SubItems.Add(dr["ownadd"].ToString());
                    listitem.SubItems.Add(dr["owncit"].ToString());
                    listitem.SubItems.Add(dr["tagn"].ToString());
                    listitem.SubItems.Add(dr["towmiles"].ToString());
                    listitem.SubItems.Add(dr["laborcharge"].ToString());
                    listitem.SubItems.Add(dr["other1charge"].ToString());
                    listitem.SubItems.Add(dr["other2charge"].ToString());
                    listitem.SubItems.Add(dr["wrecknum"].ToString());
                    listitem.SubItems.Add(dr["wreckdriver"].ToString());
                    listitem.SubItems.Add(dr["lotkeys"].ToString());
                    listitem.SubItems.Add(dr["ccrcase"].ToString());
                    listitem.SubItems.Add(dr["towaddress"].ToString());
                    listitem.SubItems.Add(dr["lienholder"].ToString());
                    listitem.SubItems.Add(dr["charge1desc"].ToString());
                    listitem.SubItems.Add(dr["charge2desc"].ToString());
                    listitem.SubItems.Add(dr["tagex"].ToString());
                    listitem.SubItems.Add(dr["winched"].ToString());
                    listitem.SubItems.Add(dr["crashfilm"].ToString());
                    listitem.SubItems.Add(dr["certmail"].ToString());
                    listitem.SubItems.Add(dr["towreason"].ToString());
                    listitem.SubItems.Add(dr["towhold"].ToString());
                    listitem.SubItems.Add(dr["towable"].ToString());
                    listitem.SubItems.Add(dr["iscar"].ToString());
                    listitem.SubItems.Add(dr["isbike"].ToString());
                    listView.Items.Add(listitem);
                    listView.View = View.Details;
                }
            }

            //string selector = string.Format("{0}", comboBox1.GetItemText(comboBox1.SelectedItem));
            string laststring = string.Format("%{0}%", textBox9.Text);
            //MessageBox.Show(selector);
            using (SQLiteConnection vonx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            using (SQLiteCommand ventry = new SQLiteCommand("SELECT * FROM customers WHERE last LIKE @last", vonx))
            {
                //ventry.Parameters.AddWithValue("@tables", selector);
                ventry.Parameters.AddWithValue("@last", laststring);
                //ventry.Parameters.AddWithValue("@table", selector);
                SQLiteDataAdapter myda = new SQLiteDataAdapter(ventry);
                DataTable vt = new DataTable();
                myda.Fill(vt);
                for (int i = 0; i < vt.Rows.Count; i++)
                {
                    DataRow dr = vt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                    listitem.SubItems.Add(dr["first"].ToString());
                    listitem.SubItems.Add(dr["last"].ToString());
                    listitem.SubItems.Add(dr["make"].ToString());
                    listitem.SubItems.Add(dr["model"].ToString());
                    listitem.SubItems.Add(dr["prodyear"].ToString());
                    listitem.SubItems.Add(dr["phone1"].ToString());
                    listitem.SubItems.Add(dr["phone2"].ToString());
                    listitem.SubItems.Add(dr["vin"].ToString());
                    listitem.SubItems.Add(dr["datetow"].ToString());
                    listitem.SubItems.Add(dr["notes"].ToString());
                    listitem.SubItems.Add(dr["daterelease"].ToString());
                    listitem.SubItems.Add(dr["ownadd"].ToString());
                    listitem.SubItems.Add(dr["owncit"].ToString());
                    listitem.SubItems.Add(dr["tagn"].ToString());
                    listitem.SubItems.Add(dr["towmiles"].ToString());
                    listitem.SubItems.Add(dr["laborcharge"].ToString());
                    listitem.SubItems.Add(dr["other1charge"].ToString());
                    listitem.SubItems.Add(dr["other2charge"].ToString());
                    listitem.SubItems.Add(dr["wrecknum"].ToString());
                    listitem.SubItems.Add(dr["wreckdriver"].ToString());
                    listitem.SubItems.Add(dr["lotkeys"].ToString());
                    listitem.SubItems.Add(dr["ccrcase"].ToString());
                    listitem.SubItems.Add(dr["towaddress"].ToString());
                    listitem.SubItems.Add(dr["lienholder"].ToString());
                    listitem.SubItems.Add(dr["charge1desc"].ToString());
                    listitem.SubItems.Add(dr["charge2desc"].ToString());
                    listitem.SubItems.Add(dr["tagex"].ToString());
                    listitem.SubItems.Add(dr["winched"].ToString());
                    listitem.SubItems.Add(dr["crashfilm"].ToString());
                    listitem.SubItems.Add(dr["certmail"].ToString());
                    listitem.SubItems.Add(dr["towreason"].ToString());
                    listitem.SubItems.Add(dr["towhold"].ToString());
                    listitem.SubItems.Add(dr["towable"].ToString());
                    listitem.SubItems.Add(dr["iscar"].ToString());
                    listitem.SubItems.Add(dr["isbike"].ToString());
                    listView.Items.Add(listitem);
                    listView.View = View.Details;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string selector = string.Format("{0}", comboBox1.GetItemText(comboBox1.SelectedItem));
            string vinstring = string.Format("%{0}%", textBox4.Text);
            //MessageBox.Show(selector);
            listView.Items.Clear();
            using (SQLiteConnection vonx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            using (SQLiteCommand ventry = new SQLiteCommand("SELECT * FROM customers WHERE vin LIKE @vin", vonx))
            {
                //ventry.Parameters.AddWithValue("@tables", selector);
                ventry.Parameters.AddWithValue("@vin", vinstring);
                //ventry.Parameters.AddWithValue("@table", selector);
                SQLiteDataAdapter myda = new SQLiteDataAdapter(ventry);
                DataTable vt = new DataTable();
                myda.Fill(vt);
                for (int i = 0; i < vt.Rows.Count; i++)
                {
                    DataRow dr = vt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                    listitem.SubItems.Add(dr["first"].ToString());
                    listitem.SubItems.Add(dr["last"].ToString());
                    listitem.SubItems.Add(dr["make"].ToString());
                    listitem.SubItems.Add(dr["model"].ToString());
                    listitem.SubItems.Add(dr["prodyear"].ToString());
                    listitem.SubItems.Add(dr["phone1"].ToString());
                    listitem.SubItems.Add(dr["phone2"].ToString());
                    listitem.SubItems.Add(dr["vin"].ToString());
                    listitem.SubItems.Add(dr["datetow"].ToString());
                    listitem.SubItems.Add(dr["notes"].ToString());
                    listitem.SubItems.Add(dr["daterelease"].ToString());
                    listitem.SubItems.Add(dr["ownadd"].ToString());
                    listitem.SubItems.Add(dr["owncit"].ToString());
                    listitem.SubItems.Add(dr["tagn"].ToString());
                    listitem.SubItems.Add(dr["towmiles"].ToString());
                    listitem.SubItems.Add(dr["laborcharge"].ToString());
                    listitem.SubItems.Add(dr["other1charge"].ToString());
                    listitem.SubItems.Add(dr["other2charge"].ToString());
                    listitem.SubItems.Add(dr["wrecknum"].ToString());
                    listitem.SubItems.Add(dr["wreckdriver"].ToString());
                    listitem.SubItems.Add(dr["lotkeys"].ToString());
                    listitem.SubItems.Add(dr["ccrcase"].ToString());
                    listitem.SubItems.Add(dr["towaddress"].ToString());
                    listitem.SubItems.Add(dr["lienholder"].ToString());
                    listitem.SubItems.Add(dr["charge1desc"].ToString());
                    listitem.SubItems.Add(dr["charge2desc"].ToString());
                    listitem.SubItems.Add(dr["tagex"].ToString());
                    listitem.SubItems.Add(dr["winched"].ToString());
                    listitem.SubItems.Add(dr["crashfilm"].ToString());
                    listitem.SubItems.Add(dr["certmail"].ToString());
                    listitem.SubItems.Add(dr["towreason"].ToString());
                    listitem.SubItems.Add(dr["towhold"].ToString());
                    listitem.SubItems.Add(dr["towable"].ToString());
                    listitem.SubItems.Add(dr["iscar"].ToString());
                    listitem.SubItems.Add(dr["isbike"].ToString());
                    listView.Items.Add(listitem);
                    listView.View = View.Details;
                }
            }


        }
        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            edid = listView.SelectedItems[0].SubItems[0].Text;
            edfirst = listView.SelectedItems[0].SubItems[1].Text;
            edlast = listView.SelectedItems[0].SubItems[2].Text;
            edmake = listView.SelectedItems[0].SubItems[3].Text;
            edmodel = listView.SelectedItems[0].SubItems[4].Text;
            edyear = listView.SelectedItems[0].SubItems[5].Text;
            edph1 = listView.SelectedItems[0].SubItems[6].Text;
            edph2 = listView.SelectedItems[0].SubItems[7].Text;
            edvin = listView.SelectedItems[0].SubItems[8].Text;
            eddate = listView.SelectedItems[0].SubItems[9].Text;
            ednotes = listView.SelectedItems[0].SubItems[10].Text;
            eddaterelease = listView.SelectedItems[0].SubItems[11].Text;
            edownadd = listView.SelectedItems[0].SubItems[12].Text;
            edowncit = listView.SelectedItems[0].SubItems[13].Text;
            edtagn = listView.SelectedItems[0].SubItems[14].Text;
            edtowmiles = listView.SelectedItems[0].SubItems[15].Text;
            edlaborcharge = listView.SelectedItems[0].SubItems[16].Text;
            edother1charge = listView.SelectedItems[0].SubItems[17].Text;
            edother2charge = listView.SelectedItems[0].SubItems[18].Text;
            edwrecknum = listView.SelectedItems[0].SubItems[19].Text;
            edwreckdriver = listView.SelectedItems[0].SubItems[20].Text;
            edlotkeys = listView.SelectedItems[0].SubItems[21].Text;
            edccrcase = listView.SelectedItems[0].SubItems[22].Text;
            edtowaddress = listView.SelectedItems[0].SubItems[23].Text;
            edlienholder = listView.SelectedItems[0].SubItems[24].Text;
            edcharge1desc = listView.SelectedItems[0].SubItems[25].Text;
            edcharge2desc = listView.SelectedItems[0].SubItems[26].Text;
            edtagex = listView.SelectedItems[0].SubItems[27].Text;
            edwinched = listView.SelectedItems[0].SubItems[28].Text;
            edcrashfilm = listView.SelectedItems[0].SubItems[29].Text;
            edcertmail = listView.SelectedItems[0].SubItems[30].Text;
            edtowreason = listView.SelectedItems[0].SubItems[31].Text;
            edtowhold = listView.SelectedItems[0].SubItems[32].Text;
            edtowable = listView.SelectedItems[0].SubItems[33].Text;
            ediscar = listView.SelectedItems[0].SubItems[34].Text;
            edisbike = listView.SelectedItems[0].SubItems[35].Text;

            //MessageBox.Show(listView.SelectedItems[0].SubItems[0].Text);
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            edid = listView1.SelectedItems[0].SubItems[0].Text;
            edfirst = listView1.SelectedItems[0].SubItems[1].Text;
            edlast = listView1.SelectedItems[0].SubItems[2].Text;
            edmake = listView1.SelectedItems[0].SubItems[3].Text;
            edmodel = listView1.SelectedItems[0].SubItems[4].Text;
            edyear = listView1.SelectedItems[0].SubItems[5].Text;
            edph1 = listView1.SelectedItems[0].SubItems[6].Text;
            edph2 = listView1.SelectedItems[0].SubItems[7].Text;
            edvin = listView1.SelectedItems[0].SubItems[8].Text;
            eddate = listView1.SelectedItems[0].SubItems[9].Text;
            ednotes = listView1.SelectedItems[0].SubItems[10].Text;
            eddaterelease = listView1.SelectedItems[0].SubItems[11].Text;
            edownadd = listView1.SelectedItems[0].SubItems[12].Text;
            edowncit = listView1.SelectedItems[0].SubItems[13].Text;
            edtagn = listView1.SelectedItems[0].SubItems[14].Text;
            edtowmiles = listView1.SelectedItems[0].SubItems[15].Text;
            edlaborcharge = listView1.SelectedItems[0].SubItems[16].Text;
            edother1charge = listView1.SelectedItems[0].SubItems[17].Text;
            edother2charge = listView1.SelectedItems[0].SubItems[18].Text;
            edwrecknum = listView1.SelectedItems[0].SubItems[19].Text;
            edwreckdriver = listView1.SelectedItems[0].SubItems[20].Text;
            edlotkeys = listView1.SelectedItems[0].SubItems[21].Text;
            edccrcase = listView1.SelectedItems[0].SubItems[22].Text;
            edtowaddress = listView1.SelectedItems[0].SubItems[23].Text;
            edlienholder = listView1.SelectedItems[0].SubItems[24].Text;
            edcharge1desc = listView1.SelectedItems[0].SubItems[25].Text;
            edcharge2desc = listView1.SelectedItems[0].SubItems[26].Text;
            edtagex = listView1.SelectedItems[0].SubItems[27].Text;
            edwinched = listView1.SelectedItems[0].SubItems[28].Text;
            edcrashfilm = listView1.SelectedItems[0].SubItems[29].Text;
            edcertmail = listView1.SelectedItems[0].SubItems[30].Text;
            edtowreason = listView1.SelectedItems[0].SubItems[31].Text;
            edtowhold = listView1.SelectedItems[0].SubItems[32].Text;
            edtowable = listView1.SelectedItems[0].SubItems[33].Text;
            ediscar = listView1.SelectedItems[0].SubItems[34].Text;
            edisbike = listView1.SelectedItems[0].SubItems[35].Text;

            //MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text);
            Form2 f2 = new Form2();
            f2.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                edid = listView.SelectedItems[0].SubItems[0].Text;
                edfirst = listView.SelectedItems[0].SubItems[1].Text;
                edlast = listView.SelectedItems[0].SubItems[2].Text;
                edmake = listView.SelectedItems[0].SubItems[3].Text;
                edmodel = listView.SelectedItems[0].SubItems[4].Text;
                edyear = listView.SelectedItems[0].SubItems[5].Text;
                edph1 = listView.SelectedItems[0].SubItems[6].Text;
                edph2 = listView.SelectedItems[0].SubItems[7].Text;
                edvin = listView.SelectedItems[0].SubItems[8].Text;
                eddate = listView.SelectedItems[0].SubItems[9].Text;
                ednotes = listView.SelectedItems[0].SubItems[10].Text;
                eddaterelease = listView.SelectedItems[0].SubItems[11].Text;
                edownadd = listView.SelectedItems[0].SubItems[12].Text;
                edowncit = listView.SelectedItems[0].SubItems[13].Text;
                edtagn = listView.SelectedItems[0].SubItems[14].Text;
                edtowmiles = listView.SelectedItems[0].SubItems[15].Text;
                edlaborcharge = listView.SelectedItems[0].SubItems[16].Text;
                edother1charge = listView.SelectedItems[0].SubItems[17].Text;
                edother2charge = listView.SelectedItems[0].SubItems[18].Text;
                edwrecknum = listView.SelectedItems[0].SubItems[19].Text;
                edwreckdriver = listView.SelectedItems[0].SubItems[20].Text;
                edlotkeys = listView.SelectedItems[0].SubItems[21].Text;
                edccrcase = listView.SelectedItems[0].SubItems[22].Text;
                edtowaddress = listView.SelectedItems[0].SubItems[23].Text;
                edlienholder = listView.SelectedItems[0].SubItems[24].Text;
                edcharge1desc = listView.SelectedItems[0].SubItems[25].Text;
                edcharge2desc = listView.SelectedItems[0].SubItems[26].Text;
                edtagex = listView.SelectedItems[0].SubItems[27].Text;
                edwinched = listView.SelectedItems[0].SubItems[28].Text;
                edcrashfilm = listView.SelectedItems[0].SubItems[29].Text;
                edcertmail = listView.SelectedItems[0].SubItems[30].Text;
                edtowreason = listView.SelectedItems[0].SubItems[31].Text;
                edtowhold = listView.SelectedItems[0].SubItems[32].Text;
                edtowable = listView.SelectedItems[0].SubItems[33].Text;
                ediscar = listView.SelectedItems[0].SubItems[34].Text;
                edisbike = listView.SelectedItems[0].SubItems[35].Text;
                Form2 f2 = new Form2();
                f2.ShowDialog();

                listView.Items.Clear();
                SQLiteConnection conx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                {
                    SQLiteDataAdapter recententry = new SQLiteDataAdapter("Select * from customers order by id desc limit 250", conx);
                    DataTable dt = new DataTable();
                    recententry.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                        listitem.SubItems.Add(dr["first"].ToString());
                        listitem.SubItems.Add(dr["last"].ToString());
                        listitem.SubItems.Add(dr["make"].ToString());
                        listitem.SubItems.Add(dr["model"].ToString());
                        listitem.SubItems.Add(dr["prodyear"].ToString());
                        listitem.SubItems.Add(dr["phone1"].ToString());
                        listitem.SubItems.Add(dr["phone2"].ToString());
                        listitem.SubItems.Add(dr["vin"].ToString());
                        listitem.SubItems.Add(dr["datetow"].ToString());
                        listitem.SubItems.Add(dr["notes"].ToString());
                        listitem.SubItems.Add(dr["daterelease"].ToString());
                        listitem.SubItems.Add(dr["ownadd"].ToString());
                        listitem.SubItems.Add(dr["owncit"].ToString());
                        listitem.SubItems.Add(dr["tagn"].ToString());
                        listitem.SubItems.Add(dr["towmiles"].ToString());
                        listitem.SubItems.Add(dr["laborcharge"].ToString());
                        listitem.SubItems.Add(dr["other1charge"].ToString());
                        listitem.SubItems.Add(dr["other2charge"].ToString());
                        listitem.SubItems.Add(dr["wrecknum"].ToString());
                        listitem.SubItems.Add(dr["wreckdriver"].ToString());
                        listitem.SubItems.Add(dr["lotkeys"].ToString());
                        listitem.SubItems.Add(dr["ccrcase"].ToString());
                        listitem.SubItems.Add(dr["towaddress"].ToString());
                        listitem.SubItems.Add(dr["lienholder"].ToString());
                        listitem.SubItems.Add(dr["charge1desc"].ToString());
                        listitem.SubItems.Add(dr["charge2desc"].ToString());
                        listitem.SubItems.Add(dr["tagex"].ToString());
                        listitem.SubItems.Add(dr["winched"].ToString());
                        listitem.SubItems.Add(dr["crashfilm"].ToString());
                        listitem.SubItems.Add(dr["certmail"].ToString());
                        listitem.SubItems.Add(dr["towreason"].ToString());
                        listitem.SubItems.Add(dr["towhold"].ToString());
                        listitem.SubItems.Add(dr["towable"].ToString());
                        listitem.SubItems.Add(dr["iscar"].ToString());
                        listitem.SubItems.Add(dr["isbike"].ToString());
                        listView.Items.Add(listitem);
                        listView.View = View.Details;
                    }
                }
                
            }
        }

        private void listview_columnclick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            listView1.Sort();
        }

        public static decimal hook2, towmile2, store2, hookup, storage, towmile, bikeday2, winch2, crash2, admin2;

        private void tabcontrol1_selectedindexchanged(object sender, EventArgs e)
        {
            listView.Items.Clear();
            SQLiteConnection conx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            {
                SQLiteDataAdapter recententry = new SQLiteDataAdapter("Select * from customers order by id desc limit 250", conx);
                DataTable dt = new DataTable();
                recententry.Fill(dt);
                for (int i = 0; i<dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                    listitem.SubItems.Add(dr["first"].ToString());
                    listitem.SubItems.Add(dr["last"].ToString());
                    listitem.SubItems.Add(dr["make"].ToString());
                    listitem.SubItems.Add(dr["model"].ToString());
                    listitem.SubItems.Add(dr["prodyear"].ToString());
                    listitem.SubItems.Add(dr["phone1"].ToString());
                    listitem.SubItems.Add(dr["phone2"].ToString());
                    listitem.SubItems.Add(dr["vin"].ToString());
                    listitem.SubItems.Add(dr["datetow"].ToString());
                    listitem.SubItems.Add(dr["notes"].ToString());
                    listitem.SubItems.Add(dr["daterelease"].ToString());
                    listitem.SubItems.Add(dr["ownadd"].ToString());
                    listitem.SubItems.Add(dr["owncit"].ToString());
                    listitem.SubItems.Add(dr["tagn"].ToString());
                    listitem.SubItems.Add(dr["towmiles"].ToString());
                    listitem.SubItems.Add(dr["laborcharge"].ToString());
                    listitem.SubItems.Add(dr["other1charge"].ToString());
                    listitem.SubItems.Add(dr["other2charge"].ToString());
                    listitem.SubItems.Add(dr["wrecknum"].ToString());
                    listitem.SubItems.Add(dr["wreckdriver"].ToString());
                    listitem.SubItems.Add(dr["lotkeys"].ToString());
                    listitem.SubItems.Add(dr["ccrcase"].ToString());
                    listitem.SubItems.Add(dr["towaddress"].ToString());
                    listitem.SubItems.Add(dr["lienholder"].ToString());
                    listitem.SubItems.Add(dr["charge1desc"].ToString());
                    listitem.SubItems.Add(dr["charge2desc"].ToString());
                    listitem.SubItems.Add(dr["tagex"].ToString());
                    listitem.SubItems.Add(dr["winched"].ToString());
                    listitem.SubItems.Add(dr["crashfilm"].ToString());
                    listitem.SubItems.Add(dr["certmail"].ToString());
                    listitem.SubItems.Add(dr["towreason"].ToString());
                    listitem.SubItems.Add(dr["towhold"].ToString());
                    listitem.SubItems.Add(dr["towable"].ToString());
                    listitem.SubItems.Add(dr["iscar"].ToString());
                    listitem.SubItems.Add(dr["isbike"].ToString());




                    listView.Items.Add(listitem);
                    listView.View = View.Details;
                }
            }
            listView1.Items.Clear();
                    SQLiteConnection conx1 = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                {
                    SQLiteDataAdapter recententry = new SQLiteDataAdapter("Select * from customers order by id desc limit 250", conx);
                    DataTable dt = new DataTable();
                    recententry.Fill(dt);
                    for (int i = 0; i<dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                    listitem.SubItems.Add(dr["first"].ToString());
                    listitem.SubItems.Add(dr["last"].ToString());
                    listitem.SubItems.Add(dr["make"].ToString());
                    listitem.SubItems.Add(dr["model"].ToString());
                    listitem.SubItems.Add(dr["prodyear"].ToString());
                    listitem.SubItems.Add(dr["phone1"].ToString());
                    listitem.SubItems.Add(dr["phone2"].ToString());
                    listitem.SubItems.Add(dr["vin"].ToString());
                    listitem.SubItems.Add(dr["datetow"].ToString());
                    listitem.SubItems.Add(dr["notes"].ToString()); listitem.SubItems.Add(dr["daterelease"].ToString());
                    listitem.SubItems.Add(dr["ownadd"].ToString());
                    listitem.SubItems.Add(dr["owncit"].ToString());
                    listitem.SubItems.Add(dr["tagn"].ToString());
                    listitem.SubItems.Add(dr["towmiles"].ToString());
                    listitem.SubItems.Add(dr["laborcharge"].ToString());
                    listitem.SubItems.Add(dr["other1charge"].ToString());
                    listitem.SubItems.Add(dr["other2charge"].ToString());
                    listitem.SubItems.Add(dr["wrecknum"].ToString());
                    listitem.SubItems.Add(dr["wreckdriver"].ToString());
                    listitem.SubItems.Add(dr["lotkeys"].ToString());
                    listitem.SubItems.Add(dr["ccrcase"].ToString());
                    listitem.SubItems.Add(dr["towaddress"].ToString());
                    listitem.SubItems.Add(dr["lienholder"].ToString());
                    listitem.SubItems.Add(dr["charge1desc"].ToString());
                    listitem.SubItems.Add(dr["charge2desc"].ToString());
                    listitem.SubItems.Add(dr["tagex"].ToString());
                    listitem.SubItems.Add(dr["winched"].ToString());
                    listitem.SubItems.Add(dr["crashfilm"].ToString());
                    listitem.SubItems.Add(dr["certmail"].ToString());
                    listitem.SubItems.Add(dr["towreason"].ToString());
                    listitem.SubItems.Add(dr["towhold"].ToString());
                    listitem.SubItems.Add(dr["towable"].ToString());
                    listitem.SubItems.Add(dr["iscar"].ToString());
                    listitem.SubItems.Add(dr["isbike"].ToString());
                    listView1.Items.Add(listitem);
                    listView1.View = View.Details;
                }

            }

            SQLiteConnection conx2 = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            {
                SQLiteCommand getrate1 = new SQLiteCommand("Select hookup from rates", conx2);
                {
                    conx2.Open();
                    decimal hook2 = 1.00m;
                    string gotrate = getrate1.ExecuteScalar().ToString();
                    decimal.TryParse(gotrate, out hook2);
                    numericUpDown3.Value = hook2;
                    conx2.Close();
                }

                SQLiteCommand getrate2 = new SQLiteCommand("Select towmile from rates", conx2);
                {
                    conx2.Open();
                    decimal towmile2 = 1.00m;
                    string gotmile = getrate2.ExecuteScalar().ToString();
                    decimal.TryParse(gotmile, out towmile2);
                    numericUpDown4.Value = towmile2;
                    conx2.Close();
                }

                SQLiteCommand getrate3 = new SQLiteCommand("Select storage from rates", conx2);
                {
                    conx2.Open();
                    decimal store2 = 1.00m;
                    string gotstore = getrate3.ExecuteScalar().ToString();
                    decimal.TryParse(gotstore, out store2);
                    numericUpDown5.Value = store2;
                    conx2.Close();
                }


                SQLiteCommand getrate4 = new SQLiteCommand("Select bikeday from rates", conx2);
                {
                    conx2.Open();
                    decimal bikeday2 = 1.00m;
                    string gotbikeday = getrate4.ExecuteScalar().ToString();
                    decimal.TryParse(gotbikeday, out bikeday2);
                    numericUpDown10.Value = bikeday2;
                    conx2.Close();
                }

                SQLiteCommand getrate5 = new SQLiteCommand("Select winchrate from rates", conx2);
                {
                    conx2.Open();
                    decimal winch2 = 1.00m;
                    string gotwinch = getrate5.ExecuteScalar().ToString();
                    decimal.TryParse(gotwinch, out winch2);
                    numericUpDown13.Value = winch2;
                    conx2.Close();
                }

                SQLiteCommand getrate6 = new SQLiteCommand("Select crashfilmrate from rates", conx2);
                {
                    conx2.Open();
                    decimal crash2 = 1.00m;
                    string gotcrash = getrate6.ExecuteScalar().ToString();
                    decimal.TryParse(gotcrash, out crash2);
                    numericUpDown12.Value = crash2;
                    conx2.Close();
                }

                SQLiteCommand getrate7 = new SQLiteCommand("Select adminrate from rates", conx2);
                {
                    conx2.Open();
                    decimal admin2 = 1.00m;
                    string gotadmin = getrate7.ExecuteScalar().ToString();
                    decimal.TryParse(gotadmin, out admin2);
                    numericUpDown11.Value = admin2;
                    conx2.Close();
                }

            }
        }
    }
}
