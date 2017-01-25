using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using myIS.Controler;

namespace myIS
{
    public partial class DeleteExistDomain : Form
    {
        controler controler;
        private long domainId;
        public DeleteExistDomain(controler c)
        {
            controler = c;
            InitializeComponent();
        }
        public void setText(string s,string name,string id)
        {
            textBox3.Text = s;
            textBox3.Visible = false;
            textBox1.Text = name;
            textBox2.Text = id;
        }
        private void DeleteExistDomain_Load(object sender, EventArgs e)
        {
           
        }
        private void ToDelete()
        {

            domainId = long.Parse(textBox2.Text);
            controler.DeleteDomain(domainId,textBox3.Text,this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToDelete();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controler.returnToInputForm(this, textBox3.Text);
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
