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
    public partial class FirstForm : Form
    {
        public controler controler;
        public FirstForm(controler c)
        {
            controler = c;
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm(controler);
            this.Hide();
            mf.Show();
        }
    }
}
