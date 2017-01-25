using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myIS.Controler;

namespace myIS
{
    public partial class PartnersList : Form
    {
        controler controler;
        public PartnersList(string s,controler c)
        {
            controler = c;
            InitializeComponent();
            textBox1.Text = s;
            textBox1.Visible = false;
        }

        private void PartnersList_Load(object sender, EventArgs e)
        {

        }
        public void addToList(string mail, string fname, string lname, string city, string age)
        {
            string[] row = new string[] { mail, fname, lname, city, age};
            dataGridView1.Rows.Add(row);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DomainsUserList fdus = new myIS.DomainsUserList(textBox1.Text,controler);
            this.Hide();
            fdus.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
