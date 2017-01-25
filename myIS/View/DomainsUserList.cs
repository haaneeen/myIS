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
    public partial class DomainsUserList : Form
    {
        controler controler;
        string show;
        public DomainsUserList(string s,controler c)
        {
            controler=c;
            InitializeComponent();
            textBox2.Text = s;
            textBox2.Visible = false;
        }
        public void addToList(string mId, string mname, string mDesc, string mDate, string mCity, string mCost)
        {
            string[] row = new string[] { mId, mname, mDate, mDesc, mCity, mCost };
            dataGridView1.Rows.Add(row);
            listb.Items.Add(mId + "-Yes/No");
        }
        public int listCount()
        {
            int i = -1;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                i++;
            }
            return i;
        }
        private void WhatToShow()
        {
            if (listb.Items.Count == -1)
            {
                MessageBox.Show("you have no Domains To see");
                Domains fs = new Domains(controler);
                this.Hide();
                fs.setText(textBox2.Text);
                fs.Show();
            }
            List<string> sl = new List<string>();
            for (int i = 0; i < listb.Items.Count; i++)
            {
                if (listb.GetItemCheckState(i) == CheckState.Checked)
                {
                    sl.Add(listb.Items[i].ToString());
                }
            }
            if (sl.Count == 0)
            {
                MessageBox.Show("you must fill one domain you want to see it");
                this.Show();
            }
            else if (sl.Count > 1)
            {
                MessageBox.Show("you must fill just one domain To Show...!!!");
                this.Show();
            }
            else
            {
                show = sl.ToArray()[0].Split('-')[0];
                if (ToShowFromPartner().Count == 0)
                {
                    MessageBox.Show("this domain have no partners");
                    this.Show();
                    return;
                }
                ToShowFromUsers(ToShowFromPartner());
            }
        }
        private List<string> ToShowFromPartner()
        {
            string dbprovider = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data source= db\" + @"partners.mdb";
            String strSql = "SELECT * FROM [partnerTable] WHERE [domainId]= '" + long.Parse(show) + "'";
            OleDbConnection conn = new OleDbConnection(dbprovider);
            List<string> mls = new List<string>();
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(strSql, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    mls.Add(reader.GetString(1).ToString());
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("there is no partners");
            }
            return mls;
        }
        private void ToShowFromUsers(List<string> myls)
        {
            string fname, lname, city, age;
            string dbprovider = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
               @"Data source= db\" + @"partners.mdb";
            OleDbConnection conn = new OleDbConnection(dbprovider);
            PartnersList pls = new PartnersList(textBox2.Text,controler);
            try
            {
                foreach (string item in myls)
                {
                    String strSql = "SELECT * FROM [users] WHERE [email]= '" + item + "'";
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(strSql, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    fname = reader.GetString(1);
                    lname = reader.GetString(2);
                    city = reader.GetString(3);
                    age = reader.GetValue(6).ToString();
                    pls.addToList(item, fname, lname, city, age);
                    conn.Close();
                }
                this.Hide();
                pls.Show();
            }
            catch
            {
                MessageBox.Show("there is no partners for this domain");
            }
        }
        private void DomainsUsersList_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WhatToShow();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            controler.returnToDomain(this,textBox2.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
