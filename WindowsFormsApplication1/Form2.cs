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
using WindowsFormsApplication1;

namespace CustomerSQLite
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = WindowsFormsApplication1.Form1.edfirst;
            textBox2.Text = WindowsFormsApplication1.Form1.edlast;
            textBox3.Text = WindowsFormsApplication1.Form1.edmake;
            textBox4.Text = WindowsFormsApplication1.Form1.edmodel;
            //textBox5.Text = WindowsFormsApplication1.Form1.edyear;
            textBox10.Text = WindowsFormsApplication1.Form1.edph1;
            textBox9.Text = WindowsFormsApplication1.Form1.edph2;
            textBox8.Text = WindowsFormsApplication1.Form1.edvin;
            //textBox7.Text = WindowsFormsApplication1.Form1.eddate;
            textBox5.Text = WindowsFormsApplication1.Form1.ednotes;
            int theyear;
            int.TryParse(Form1.edyear, out theyear);
            numericUpDown1.Value = theyear;
            DateTime thedate;
            DateTime.TryParse(Form1.eddate, out thedate);
            dateTimePicker1.Value = thedate;
            DateTime therelease = System.DateTime.Today;
            if (DateTime.TryParse(Form1.eddaterelease, out therelease)) 
            {
                dateTimePicker2.Value = therelease;
            }
            else
            { }
         
            textBox25.Text = WindowsFormsApplication1.Form1.edownadd;
            textBox24.Text = WindowsFormsApplication1.Form1.edowncit;
            textBox15.Text = WindowsFormsApplication1.Form1.edtagn;
            decimal themiles;
            decimal.TryParse(Form1.edtowmiles, out themiles);
            numericUpDown6.Value = themiles;
            decimal thelabor;
            decimal.TryParse(Form1.edlaborcharge, out thelabor);
            numericUpDown7.Value = thelabor;
            textBox17.Text = Form1.edcharge1desc;
            textBox18.Text = Form1.edcharge2desc;
            decimal thelabor1;
            decimal.TryParse(Form1.edother1charge, out thelabor1);
            numericUpDown8.Value = thelabor1;
            decimal thelabor2;
            decimal.TryParse(Form1.edother2charge, out thelabor2);
            numericUpDown9.Value = thelabor2;
            textBox21.Text = WindowsFormsApplication1.Form1.edwrecknum;
            textBox20.Text = WindowsFormsApplication1.Form1.edwreckdriver;
            textBox19.Text = WindowsFormsApplication1.Form1.edlotkeys;
            textBox14.Text = WindowsFormsApplication1.Form1.edccrcase;
            textBox16.Text = WindowsFormsApplication1.Form1.edtowaddress;
            textBox22.Text = WindowsFormsApplication1.Form1.edlienholder;
            textBox28.Text = WindowsFormsApplication1.Form1.edtagex;
            decimal winchedbox;
            decimal.TryParse(Form1.edwinched, out winchedbox);
            //checkBox1.Checked = winchedbox;
            if (winchedbox == 1)
                checkBox1.Checked=true;
            else checkBox1.Checked = false;
            decimal crashbox;
            decimal.TryParse(Form1.edcrashfilm, out crashbox);
            //checkBox2.Checked = crashbox;
            if (crashbox == 1)
                checkBox2.Checked = true;
            else checkBox2.Checked = false;
            decimal certmailbox;
            decimal.TryParse(Form1.edcertmail, out certmailbox);
            //checkBox3.Checked = certmailbox;
            if (certmailbox == 1)
                checkBox3.Checked = true;
            else checkBox3.Checked = false;
            textBox23.Text = WindowsFormsApplication1.Form1.edtowreason;
            textBox26.Text = WindowsFormsApplication1.Form1.edtowhold;
            textBox27.Text = WindowsFormsApplication1.Form1.edtowable;
            decimal iscarbutton;
            decimal.TryParse(Form1.ediscar, out iscarbutton);
            //radioButton1.Checked = iscarbutton;
            if (iscarbutton == 1)
                radioButton1.Checked = true;
            else radioButton1.Checked = false;
            decimal isbikebutton;
            decimal.TryParse(Form1.edisbike, out isbikebutton);
            //radioButton2.Checked = isbikebutton;
            if (isbikebutton == 1)
                radioButton2.Checked = true;
            else radioButton2.Checked = false;
            



        }
        

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)







        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to make these changes?", "Edit Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                SQLiteConnection modconx = new SQLiteConnection(@"Data Source = c:\towjax\customers.db; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

                SQLiteCommand modentry = new SQLiteCommand("UPDATE customers SET first = @modfirst, last = @modlast, make = @modmake, model = @modmodel, prodyear = @modyear, phone1 = @modph1, phone2 = @modph2, notes = @modnotes, vin = @modvin, datetow = @moddate, daterelease = @moddaterelease, ownadd = @modownadd, owncit = @modowncit, tagn = @modtagn, towmiles = @modtowmiles, laborcharge = @modlaborcharge, other1charge = @modother1charge, other2charge = @modother2charge, wrecknum = @modwrecknum, wreckdriver = @modwreckdriver, lotkeys = @modlotkeys, ccrcase = @modccrcase, towaddress = @modtowaddress, lienholder = @modlienholder, charge1desc = @modcharge1desc, charge2desc = @modcharge2desc, tagex = @modtagex, winched = @modwinched, crashfilm = @modcrashfilm, certmail = @modcertmail, towreason = @modtowreason, towhold = @modtowhold, towable = @modtowable, iscar = @modiscar, isbike = @modisbike WHERE id = @modid", modconx);
                //, last = @modlast, make = @modmake, model = @modmodel, prodyear = @modyear, phone1 = @modph1, phone2 = @modph2, vin = @modvin, datetow = @modtow WHERE id = @modid", modconx);
                modentry.Parameters.AddWithValue("@modfirst", textBox1.Text);
                modentry.Parameters.AddWithValue("@modid", Form1.edid);
                modentry.Parameters.AddWithValue("@modlast", textBox2.Text);
                modentry.Parameters.AddWithValue("@modmake", textBox3.Text);
                modentry.Parameters.AddWithValue("@modmodel", textBox4.Text);
                modentry.Parameters.AddWithValue("@modyear", numericUpDown1.Value);
                modentry.Parameters.AddWithValue("@modph1", textBox10.Text);
                modentry.Parameters.AddWithValue("@modph2", textBox9.Text);
                modentry.Parameters.AddWithValue("@modvin", textBox8.Text);
                modentry.Parameters.AddWithValue("@moddate", dateTimePicker1.Value);
                modentry.Parameters.AddWithValue("@modnotes", textBox5.Text);
                modentry.Parameters.AddWithValue("@moddaterelease", dateTimePicker2.Value);
                modentry.Parameters.AddWithValue("@modownadd", textBox25.Text);
                modentry.Parameters.AddWithValue("@modowncit", textBox24.Text);
                modentry.Parameters.AddWithValue("@modtagn", textBox15.Text);
                modentry.Parameters.AddWithValue("@modtowmiles", numericUpDown6.Value);
                modentry.Parameters.AddWithValue("@modlaborcharge", numericUpDown7.Value);
                modentry.Parameters.AddWithValue("@modother1charge", numericUpDown8.Value);
                modentry.Parameters.AddWithValue("@modother2charge", numericUpDown9.Value);
                modentry.Parameters.AddWithValue("@modwrecknum", textBox21.Text);
                modentry.Parameters.AddWithValue("@modwreckdriver", textBox20.Text);
                modentry.Parameters.AddWithValue("@modlotkeys", textBox19.Text);
                modentry.Parameters.AddWithValue("@modccrcase", textBox14.Text);
                modentry.Parameters.AddWithValue("@modtowaddress", textBox16.Text);
                modentry.Parameters.AddWithValue("@modlienholder", textBox22.Text);
                modentry.Parameters.AddWithValue("@modcharge1desc", textBox17.Text);
                modentry.Parameters.AddWithValue("@modcharge2desc", textBox18.Text);
                // @modtagex, @modwinched, @modcrashfilm, @modcertmail, @modtowreason, @modtowhold, @modtowable, @modiscar, @modisbike
                // modtagex, modwinched, modcrashfilm, modcertmail, modtowreason, modtowhold, modtowable, modiscar, modisbike
                modentry.Parameters.AddWithValue("@modtagex", textBox28.Text);
                modentry.Parameters.AddWithValue("@modwinched", checkBox1.Checked);
                modentry.Parameters.AddWithValue("@modcrashfilm", checkBox2.Checked);
                modentry.Parameters.AddWithValue("@modcertmail", checkBox3.Checked);
                modentry.Parameters.AddWithValue("@modtowreason", textBox23.Text);
                modentry.Parameters.AddWithValue("@modtowhold", textBox26.Text);
                modentry.Parameters.AddWithValue("@modtowable", textBox27.Text);
                modentry.Parameters.AddWithValue("@modiscar", radioButton1.Checked);
                modentry.Parameters.AddWithValue("@modisbike", radioButton2.Checked);




                modconx.Open();
                modentry.ExecuteNonQuery();
                modconx.Close();
                
                this.Close();
                
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }
    }
}
