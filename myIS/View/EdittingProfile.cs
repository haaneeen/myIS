using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using myIS.Controler;


namespace myIS
{
    public partial class EdittingProfile : Form
    {
        controler controler;
        public EdittingProfile(controler c)
        {
            controler = c;
            InitializeComponent();
            meter.Items.Add("Single");
            meter.Items.Add("merried");
            meter.Items.Add("devorce");
        }

        private void mynote_TextChanged(object sender, EventArgs e)
        {

        }
        public void setMail(String Mail)
        {
            mail.Text = Mail;
            string dbprovider = controler.m.getDBprovider();
            String strSql = "SELECT * FROM [users] WHERE [email]= '" + Mail + "'";
            OleDbConnection conn = new OleDbConnection(dbprovider);
            MySearchList sl = new MySearchList(controler);

            conn.Open();
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            fn.Text = reader.GetString(1);
            ln.Text = reader.GetString(2);
            city.Text = reader.GetString(3);
            street.Text = reader.GetString(4);
            string t = reader.GetString(5);
            string[] telArray = t.Split('-');
            firBox.Text = telArray[0];
            tel.Text = telArray[1];
            age.Text = reader.GetInt32(6).ToString();
            genbox.Text = reader.GetString(7);
            meter.Text = reader.GetString(8);
            pass.Text = reader.GetString(9);
            string birth = reader.GetString(10);
            string[] birthDate = birth.Split('/');
            dayBox1.Text = birthDate[0];
            monBox2.Text = birthDate[1];
            year.Text = birthDate[2];
            smok.Checked = reader.GetBoolean(reader.GetOrdinal("smoking"));
            havePet.Checked = reader.GetBoolean(12);
            org.Text = reader.GetInt32(13).ToString();
            education.Text = reader.GetString(14);
            dustAllergy.Checked = reader.GetBoolean(reader.GetOrdinal("dustellrgy"));
            perBox4.Checked = reader.GetBoolean(reader.GetOrdinal("perfumellergy"));
            mynote.Text = (reader["notes"].ToString());
            conn.Close();


        }

        private void my_ok_Click(object sender, EventArgs e)
        {
            String t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14;
            t1 = fn.Text + "";
            t2 = ln.Text + "";
            t3 = pass.Text + "";
            t4 = dayBox1.Text + "/" + monBox2.Text + "/" + year.Text;
            t5 = meter.Text + "";
            t6 = (age.Text);
            t7 = genbox.Text + "";
            t8 = city.Text + "";
            t9 = street.Text + "";
            t10 = firBox.Text + "-" + tel.Text;
            t11 = mail.Text + "";
            t12 = org.Text + "";
            t13 = education.Text + "";
            t14 = mynote.Text + "";

            int smook = 0;
            int pet = 0;
            int pur = 0;
            int drust = 0;

            if (smok.Checked)
            {
                smook = 1;
            }

            if (havePet.Checked)
            {
                pet = 1;

            }
            if (dustAllergy.Checked)
            {
                drust = 1;

            }
            if (perBox4.Checked)
            {
                pur = 1;

            }
            
           
            if (t1 == "" || t2 == "" || t3 == "" || dayBox1.Text == "" || monBox2.Text == "" || year.Text == "" || t5 == "" || t6 == "" || t7 == "" || t8 == "" || t9 == "" || tel.Text == "" || firBox.Text == "" || t11 == "" || t12 == "" || t13 == "")
            {
                MessageBox.Show("missing details fill all details");
                this.Show();
            }
            else
            {
                controler.updateUser(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, smook, pet, pur, drust);
                
            }
        }

        private void my_Cancel_Click(object sender, EventArgs e)
        {
            InputsForm fd = new InputsForm(controler);
            this.Hide();
            fd.setLabel(mail.Text);
            fd.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string m=mail.Text;
            controler.profileToDelete(this,m);
        }

        

        private void EdittingProfile_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
