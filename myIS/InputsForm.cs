using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myIS
{
    public partial class InputsForm : Form
    {

        public InputsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Domains fd = new Domains();
            fd.setText(ownertext.Text);
            this.Hide();
            fd.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        public void setLabel(string s)
        {
            ownertext.Text = s;
            ownertext.Visible=false;
           // mailLabel.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            /*  PartnerClass fp = new PartnerClass();
              fp.setTextP(ownertext.Text);
              fp.Show();*/
            MessageBox.Show("did not used");
        }

        private void InputsForm_Load(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            MainForm fm = new MainForm();
            this.Hide();
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchForm fs = new SearchForm();
            fs.setString(ownertext.Text);
            this.Hide();
            fs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("did not used");
        }
    }
}
