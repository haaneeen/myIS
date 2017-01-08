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
    public partial class SuccessfulDomainAdded : Form
    {
        public SuccessfulDomainAdded()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void setText(string mod,string owner)
        {
            moda.Text = mod;
            own.Text= owner;
           own.Visible = false;
        }
        private void SuccessfulDomainAdded_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputsForm mf = new InputsForm();
            mf.setLabel(own.Text);
            this.Hide();
            mf.Show();
        }
    }
}
