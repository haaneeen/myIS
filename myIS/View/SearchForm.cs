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
    public partial class SearchForm : Form
    {
        controler controler;
        public SearchForm(controler c)
        {
            controler = c;
            InitializeComponent();
            string dbprovider = controler.m.getDBprovider();
            OleDbConnection conn = new OleDbConnection(dbprovider);
            ReturnName(conn);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mdName=d_name.Text ;
            string loc=loca.Text;
            string st=stret.Text;
            string mDate;
            string mDesc;
            string mId ;
            string dbprovider = controler.m.getDBprovider();
            String strSql = "SELECT * FROM [domain] WHERE [dname]= '" + mdName + "'";
            OleDbConnection conn = new OleDbConnection(dbprovider);
            MySearchList sl = new MySearchList(controler);
            if (!CheckClearly(mdName, loc,st))
            { }
            else
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(strSql, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string mcity = reader.GetString(6);
                        string mstreet = reader.GetString(7);
                        if (mcity == loc&&mstreet==st)
                        {
                            mId = reader.GetValue(0).ToString();
                            mDesc = reader.GetString(2);
                            mDate = reader.GetString(1);
                            sl.addToList(mId, mdName, mDesc, mDate);
                        }

                    }
                    conn.Close();
                    this.Hide();
                    if (sl.listCount() == -1)
                    {
                        MessageBox.Show("domain didn't exist search one more time or add it");
                        this.Show();
                        d_name.Focus();
                    }
                    else
                    {
                        MessageBox.Show("you must fill Yes if you want to sent request to the partners in this domain at  (yes/no) column else fill No");
                        sl.setStext(mstring.Text);
                        sl.Show();
                    }
                }
                catch
                {
                  // MessageBox.Show("domain didn't exist search one more time or add it");
                  //  name_do.Clear();
                  //  name_do.Focus();
                  //  location.Clear();
                }
            }
        }
        private bool CheckClearly(string name,string loc,string str)
        {
            if (name == "" && loc ==""&&str=="")
            {
                MessageBox.Show("you must fill domain name and location");
              d_name.Focus();
                return false;
            }
            else if (name == "")
            {
                MessageBox.Show("you mustfill  domain name ");
                d_name.Focus();
                return false;
            } 
            else if (loc == "")
            {
                MessageBox.Show("you must fill City");
                 loca.Focus();
              return false;
            }else if (str == "")
            {
                MessageBox.Show("you must fill street");
                stret.Focus();
                return false;
            }
            return true;
        }
        private void ReturnName(OleDbConnection conn)
        {
            string strSql = "Select * from [domain]";
            conn.Open();
                  OleDbCommand cmd = new OleDbCommand(strSql, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string tmpName = reader.GetString(3);
                if (CheckComboName(tmpName))
                {
                    d_name.Items.Add(tmpName);
                }
                string tmpCity = reader.GetString(6);
                if (CheckComboCity(tmpCity))
                {
                    loca.Items.Add(tmpCity);
                }
                string tmpStreet = reader.GetString(7);
                if (CheckComboStreet(tmpStreet))
                {
                    stret.Items.Add(tmpStreet);
                }
            }
            conn.Close();
        }
        private bool CheckComboName(string s)
        {
            for (int i = 0; i < d_name.Items.Count; i++)
            {
                string value = d_name.GetItemText(d_name.Items[i]);
                if (value == s)
                {
                    return false;
                }
            }
            return true;
        }
        private bool CheckComboCity(string s)
        {
            for (int i = 0; i < loca.Items.Count; i++)
            {
                string value = loca.GetItemText(loca.Items[i]);
                if (value == s)
                {
                    return false;
                }
            }
            return true;
        }
        private bool CheckComboStreet(string s)
        {
            for (int i = 0; i < stret.Items.Count; i++)
            {
                string value = stret.GetItemText(stret.Items[i]);
                if (value == s)
                {
                    return false;
                }
            }
            return true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddDomain fad = new AddDomain(controler);
            fad.addOwner(mstring.Text);
            this.Hide();
            fad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Domains fa = new Domains(controler);
            fa.setText(mstring.Text);
            this.Hide();
            fa.Show();
        }
        private void ReturnTheValue()
        {

        }
        public void setString(string s)
        {
            mstring.Text = s;
            mstring.Visible = false;
        }
        private void SearchForm_Load(object sender, EventArgs e)
        {

        }
    }
}
