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
    public partial class Success_insert : Form
    {
        controler controler;
        public Success_insert(controler c)
        {
            controler = c;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm fm = new MainForm(controler);
            fm.Show();
            this.Hide();
        }

        private void User_Click(object sender, EventArgs e)
        {

        }
        public void UpdateStatusSuccess(string name,string mail)
        {
            username.Text  = name;
            themail.Text = mail;
        }

        private void Success_insert_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
