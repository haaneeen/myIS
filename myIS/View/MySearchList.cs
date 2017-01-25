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
    public partial class MySearchList : Form
    {
        controler controler;
        List<string> domainList;
        List<string> PrtnerUser;
        public MySearchList(controler c)
        {
            controler = c;
            InitializeComponent();
            domainList = new List<string>();
            PrtnerUser = new List<string>();

        }

        private void SearchList_Load(object sender, EventArgs e)
        {

        }
        public void setStext(string s)
        {
            sString.Text = s;
            sString.Visible = false;
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
        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void addToList(string id,string name,string desc, string date)
        {
            string[] row = new string[] { id, name, desc,date,"-"};
            dataGridView1.Rows.Add(row);
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void searchUsers()
        {
            string dbprovider = controler.m.getDBprovider();
            OleDbConnection conn = new OleDbConnection(dbprovider);
            foreach (string item in domainList)
            {
                string strSql = "SELECT * FROM partnerTable WHERE domainId=" + long.Parse(item) ;
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(strSql, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (!PrtnerUser.Contains(reader.GetString(1).ToString()))
                        {
                            PrtnerUser.Add(reader.GetString(1).ToString());
                        }
                        else
                        {
                            continue;
                        }

                    }
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("there is no partner");
                }
             /*   conn.Open();
            /*    string strSq2 = "select * from [domain] where [domain_id] = " + long.Parse(item);
                OleDbCommand cmd2 = new OleDbCommand(strSq2, conn);
                OleDbDataReader reader2 = cmd2.ExecuteReader();
                if (!PrtnerUser.Contains(reader2.GetString(4).ToString()))
                {
                    PrtnerUser.Add(reader2.GetString(4).ToString());
                }
                conn.Close();*/
            }
            
            
        }
        private void sendAmess()
        {
            string msender = sString.Text;
            string mtype = "Join request ";
            string theMessage = " hello i want to be one of our group i will be happy to join to youre group ";
            string mdate = DateTime.Today.Date.ToString();
            string dbprovider = controler.m.getDBprovider();
            OleDbConnection conn = new OleDbConnection(dbprovider);
            foreach (var item in PrtnerUser)
            {
                string strSql = "INSERT INTO [mails] ([getter],[sender],[type],[mail_text],[date]) VALUES (?,?,?,?,?)";
               
               try
                {
                    OleDbCommand dbCmd = new OleDbCommand(strSql, conn);
                    dbCmd.Parameters.AddWithValue("getter", item.ToString());
                    dbCmd.Parameters.AddWithValue("sender", msender);
                    dbCmd.Parameters.AddWithValue("type", mtype);
                    dbCmd.Parameters.AddWithValue("mail_text", theMessage);
                    dbCmd.Parameters.AddWithValue("date", mdate);
                    conn.Open();
                    dbCmd.ExecuteNonQuery();
                    conn.Close();
                }
              catch {
                   MessageBox.Show("there is no partners");
                }

            }
        }
        private void send_Click(object sender, EventArgs e)
        {
            
            int i = 0;
            int count = 0;
            bool flag = true;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value.ToString() == "-")
                {
                    flag = false;
                }
                if (row.Cells[4].Value.ToString().ToLower() == "no")
                {
                    i++;
                }
                else if(row.Cells[4].Value.ToString().ToLower() == "yes")
                {
                    domainList.Add(row.Cells[0].Value.ToString());
                }
                count++;
            }
            if (!flag)
            {
                MessageBox.Show("you [MUST] fill all rows in (Yes/No) coloumn");
            }
            else
            {
                if (i == count)
                {
                    MessageBox.Show("OK if you want You can search another domain ;)");
                    controler.returnToSearchForm(this, sString.Text);
                    
                }
                else
                {
                    searchUsers();
                    sendAmess();
                    SuccessSearch fsc = new SuccessSearch(controler);
                    this.Hide();
                    fsc.setString(sString.Text);
                    fsc.Show();
                }
            }
        }
        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controler.returnToInputs(this, sString.Text);
            
        }
    }
}
