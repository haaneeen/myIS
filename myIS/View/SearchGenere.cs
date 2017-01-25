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
    public partial class SearchGenere : Form
    {
        controler controler;
        public SearchGenere(controler c)
        {
            controler = c;
            InitializeComponent();
        }

        private void SearchGenere_Load(object sender, EventArgs e)
        {

        }
        public void addToList(string name, string desc, string date, string city,string street,string cost)
        {
            string[] row = new string[] { name,desc,date,city,street,cost};
            dataGridView1.Rows.Add(row);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mf = new myIS.MainForm(controler);
            this.Hide();
            DialogResult dialogResult = MessageBox.Show("if you want to record press yes else press No to exit", "recoed/exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Record fr = new Record(controler);
                this.Hide();
                fr.Show();            
            }
            else
            {
                Application.Exit();
            }
        //    mf.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
