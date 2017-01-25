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
    public partial class AddDomain : Form
    {
        controler controler;
        public AddDomain(controler c)
        {
            controler = c;
            InitializeComponent();

            for (int i = 1; i <= 12; i++)
            {
                monBox2.Items.Add(i);

            }
            for (int j = 1; j <= 31; j++)
            {
                dayBox1.Items.Add(j);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            controler.returnToDomains(this, textBox1.Text);
        }
        public void addOwner(string s)
        {
            textBox1.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t2, t3, t4, t5, t6, t7,t8,t9;
            // t1 = fn.Text;
            t2 = ln.Text;
            t3 = textBox1.Text;
            t4 = dayBox1.Text + "/" + monBox2.Text + "/" + year.Text;
            t5 = textBox3.Text;
            t6 = textBox2.Text ;
            t7 = loc.Text;
            t8 = stret.Text;
            t9 = dCost.Text;
            string s = DateTime.Today.Date.ToString();
            bool flag = false;
            string strSql = "INSERT INTO [domain] ([date],[description],[dname],[OwnerMail],[maxNumOfPartner],[city],[street],[maker_date],[cost]) VALUES (?,?,?,?,?,?,?,?,?)";
            // 
            //   string strSql = "INSERT INTO [domain] ([domain_id],[email],[partnersNum]) VALUES (?,?,?)";
            string dbprovider = controler.m.getDBprovider();

            if (t2 == "" | t3 == "" || dayBox1.Text == "" || monBox2.Text == "" || t6 == ""||t8=="" || int.Parse(year.Text) < 2017 || ToCheck(t2, t3, t4, t5, t6))
            {
                MessageBox.Show("missing details you have to fill all details");
                this.Show();
            }
            else
            {
                OleDbConnection conn = new OleDbConnection(dbprovider);
              try
               {
                    OleDbCommand dbCmd = new OleDbCommand(strSql, conn);
                    dbCmd.Parameters.AddWithValue("date", t4);
                    dbCmd.Parameters.AddWithValue("description", t5);
                    dbCmd.Parameters.AddWithValue("dname", t2);
                    dbCmd.Parameters.AddWithValue("OwnerMail", t3);
                    dbCmd.Parameters.AddWithValue("maxNumOfPartner", t6);
                    dbCmd.Parameters.AddWithValue("city", t7);
                    dbCmd.Parameters.AddWithValue("street", t8);
                    dbCmd.Parameters.AddWithValue("maker_date", s);
                    dbCmd.Parameters.AddWithValue("cost", t9);
                    conn.Open();
                    dbCmd.ExecuteNonQuery();
                   flag = true;
              }
             catch
               {
                 MessageBox.Show("erros");
              }
             finally
                {
                 conn.Close();
                if (flag)
                {
                    SuccessfulDomainAdded fmd = new SuccessfulDomainAdded(controler);
                    fmd.setText(returnKey(t2), t3);
                    this.Hide();
                    fmd.Show();
                }
           }
            }
        }
        private bool ToCheck(string t2, string t3, string t4, string t5, string t6)
        {
            int x = 0;

            if (int.Parse(year.Text) < 2017 || !(int.TryParse(year.Text, out x)) || year.Text == "" || dayBox1.Text == "" || monBox2.Text == "")/////cjeck the dateee 
            {
                year.Clear();
                year.Focus();
                return true;
            }

            if (!(int.TryParse(textBox2.Text, out x)) || textBox2.Text == "")
            {
                textBox2.Clear();
                textBox2.Focus();
                return true;
            }
            if (monBox2.Text == "2" && int.Parse(dayBox1.Text) > 29)
            {
                dayBox1.Focus();
                return true;
            }

            return false;
        }
        private string returnKey(string mName)
        {
            int count = 0;
            string max = "0";
            string dbprovider = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                     @"Data source= db\" + @"partners.mdb";
            string strSql = "SELECT * FROM [domain]" ;
           // string strSql = "SELECT MAX(domain_id) FROM [domain]";
            OleDbConnection conn = new OleDbConnection(dbprovider);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                count++;
                string tmp = reader.GetValue(0).ToString();
                if (int.Parse(tmp)>int.Parse(max))
                {
                    max = tmp;
                }
            }
            string s = count + "";
            MessageBox.Show(s);
            conn.Close();
            return max;
        }
        private void AddDomain_Load(object sender, EventArgs e)
        {

        }
    }
}