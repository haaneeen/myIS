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
using myIS.Data_Access;
using myIS.Controler;

namespace myIS
{
    public partial class Domains : Form
    {
        controler controler;
        public Domains(controler c)
        {
            controler = c;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            controler.returnToInputsForm(this, textBox1.Text);
            

        }
        public void setText(string s)
        {
            textBox1.Text = s;
            textBox1.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            controler.addDomain(this, textBox1.Text);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controler.updateDomain(this, textBox1.Text);
            
        }

        private void Domains_Load(object sender, EventArgs e)
        {

        }
        private void ToShowDomain()
        {
            DomainsUserList du = new DomainsUserList(textBox1.Text,controler);
            string mdName = textBox1.Text;
            string mDate;
            string mname;
            string mDesc;
            string mId;
            string mCity;
            string mCost;
            string dbprovider = controler.m.getDBprovider();
            String strSql = "SELECT * FROM [domain] WHERE [OwnerMail]= '" + mdName + "'";
            OleDbConnection conn = new OleDbConnection(dbprovider);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(strSql, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    mId = reader.GetValue(0).ToString();
                    mDate = reader.GetString(1);
                    mDesc = reader.GetString(2);
                    mname = reader.GetString(3);
                    mCity = reader.GetString(6);
                    mCost = reader.GetValue(9).ToString();
                    du.addToList(mId, mname, mDesc, mDate, mCity, mCost);
                }
                conn.Close();
                if (du.listCount() == -1)
                {
                    MessageBox.Show("don't have domains if you want you can add new");
                    this.Show();
                    AddDomain fd = new AddDomain(controler);
                    fd.addOwner(textBox1.Text);
                    this.Hide();
                    fd.Show();
                }
                else
                {
                    this.Hide();
                    du.Show();
                }
            }
            catch
            {
                MessageBox.Show("there is no domains");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToShowDomain();
        }
    }
}
