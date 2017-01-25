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
    public partial class Record : Form
    {
        controler controler;

        public Record(controler c)
        {
            controler = c;
            InitializeComponent();
            genbox.Items.Add("female");
            genbox.Items.Add("male");
            firBox.Items.Add("054");
            firBox.Items.Add("050");
            firBox.Items.Add("052");
            firBox.Items.Add("053");
            metBox1.Items.Add("single");
            metBox1.Items.Add("married");
            metBox1.Items.Add("divorcee");
            for (int i = 1; i <= 31; i++)
            {
                dayBox1.Items.Add(i);
            }
            for (int j = 1; j <= 12; j++)
            {
                monBox2.Items.Add(j);
            }
            for (int k = 1; k <= 5; k++)
            {
                org.Items.Add(k);
            }
            textBox1.UseSystemPasswordChar = true;
            comboBox2.Items.Add("Higher education");
            comboBox2.Items.Add("Medium Education");
            comboBox2.Items.Add("Low education");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void my_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.DialogResult = DialogResult.Cancel;
            MainForm mf = new MainForm(controler);
            mf.Show();
        }

        private void my_ok_Click(object sender, EventArgs e)
        {
            String t1, t2, t3, t5, t6, t7, t8, t9, t10, t11, t4, t12, t13, t14;
            t8 = (age.Text);
            t1 = fn.Text + "";
            t2 = ln.Text + "";
            t3 = mail.Text + "@" + enderBox2.Text;
            t5 = city.Text + "";
            t6 = stret.Text + "";
            t11 = metBox1.Text + "";
            t7 = firBox.Text + "-" + tel.Text;
            t9 = textBox1.Text + "";
            t10 = genbox.Text + "";
            t4 = dayBox1.Text + "/" + monBox2.Text + "/" + birth.Text;
            t12 = org.Text + "";
            t13 = comboBox2.Text + "";
            t14 = mynote.Text + "";
            bool smook = checkBox1.Checked;
            bool pet = checkBox2.Checked;
            bool pur = perBox4.Checked;
            bool drust = drustBox3.Checked;
            string s = DateTime.Today.Date.ToString();
            string strSql = "INSERT INTO [users] ([email],[fname],[lname],[city],[street],[telephone],[age],[gender],[meterial_status],[password],[birth],smoking,have_pet,organized,educatin,dustellrgy,perfumellergy,notes,date_reg) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
            
            if (t1 == "" || t2 == "" || t5 == "" || t6 == "" || t7 == "" || t9 == "" || tel.Text == "" || firBox.Text == "" || t11 == "" || dayBox1.Text == "" || monBox2.Text == "" || birth.Text == "" || t13 == "" || !(CheckedFunc(t2, t3, t4, t5, t6, t7, t8, t12)))
            {
                MessageBox.Show("missing details fill all details");
                this.Show();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                
                try
                {
                    controler.setNewRecord(this,t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, smook, pet, pur, drust, s, strSql);
                    
                }
                catch
                {
                    MessageBox.Show("user exist choose another");
                    this.Show();
                    mail.Clear();
                    enderBox2.Clear();
                    mail.Focus();
                    this.DialogResult = DialogResult.OK;
                }
                
            }

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void genbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  genbox.Items.Add("female");
            //genbox.Items.Add("male");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool CheckedFunc(string t2, string t3, string t4, string t5, string t6, string t7, string t8, string t12)
        {
            int x = 0;
            if (mail.Text == "" || enderBox2.Text == "")
            {
                MessageBox.Show("you must add mail");
                this.Show();
                mail.Focus();
                this.DialogResult = DialogResult.OK;
                return false;
            }
            if (t7.Length != 11 || !int.TryParse(tel.Text, out x))
            {
                MessageBox.Show("error in telphone number");
                tel.Focus();
                // this.DialogResult = DialogResult.OK;
                return false;
            }
            if (birth.Text.Length != 4 || int.Parse(birth.Text) > 2017 || int.Parse(birth.Text) < 1930 || !int.TryParse(birth.Text, out x))
            {
                MessageBox.Show("error in year of birth");
                birth.Focus();
                return false;
            }
            if (int.Parse(monBox2.Text) == 2 && int.Parse(dayBox1.Text) > 29)
            {
                MessageBox.Show("error date");
                dayBox1.Focus();
                return false;
            }
            if (t8 != "")
            {
                if (!(int.TryParse(t8, out x)) || int.Parse(t8) > 80 || int.Parse(DateTime.Now.Year.ToString()) - int.Parse(birth.Text) > int.Parse(t8) + 1 || int.Parse(DateTime.Now.Year.ToString()) - int.Parse(birth.Text) < int.Parse(t8) - 1 || int.Parse(t8) < 10)
                {
                    MessageBox.Show("error in age");
                    age.Clear();
                    age.Focus();
                    //   this.DialogResult = DialogResult.OK;
                    return false;
                }
            }
            if (t12 != "")
            {
                if (!(int.TryParse(t12, out x)))
                {
                    MessageBox.Show("error in orginaization");
                    age.Clear();
                    age.Focus();
                    return false;
                }
            }
            return true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Record_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
