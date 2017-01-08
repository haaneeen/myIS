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

namespace myIS
{
    public partial class MySearchList : Form
    {
        public MySearchList()
        {
            InitializeComponent();

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
                count++;
            }
            if (!flag)
            {
                MessageBox.Show("you [MUST] fill all rows in (Yes/No) column");
            }
            else
            {
                if (i == count)
                {
                    MessageBox.Show("OK if you want You can search another domain ;)");
                    SearchForm fs = new SearchForm();
                    fs.setString(sString.Text);
                    this.Hide();
                    fs.Show();
                }
                else
                {
                    SuccessSearch fsc = new SuccessSearch();
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
            InputsForm fm = new InputsForm();
            fm.setLabel(sString.Text);
            this.Hide();
            fm.Show();
        }
    }
}
