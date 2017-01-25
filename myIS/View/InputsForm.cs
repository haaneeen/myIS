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
    public partial class InputsForm : Form
    {
        controler controler;
        public InputsForm(controler c)
        {
            controler = c;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Domains fd = new Domains(controler);
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
            MainForm fm = new MainForm(controler);
            this.Hide();
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchForm fs = new SearchForm(controler);
            fs.setString(ownertext.Text);
            this.Hide();
            fs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EdittingProfile fmd = new EdittingProfile(controler);
            fmd.setMail(ownertext.Text);
            this.Hide();
            fmd.Show();
        }
    }
}
