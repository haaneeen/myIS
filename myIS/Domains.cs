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
    public partial class Domains : Form
    {
        public Domains()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InputsForm fi = new InputsForm();
            this.Hide();
            fi.setLabel(textBox1.Text);
            fi.Show();
            
        }
        public void setText(string s)
        {
            textBox1.Text = s;
            textBox1.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddDomain fad = new AddDomain();
            fad.addOwner(textBox1.Text);
           this.Hide();
            fad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("have not used");
        }

        private void Domains_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("did not use");
        }
    }
}
