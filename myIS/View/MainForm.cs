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
using myIS.Controler;

namespace myIS
{
    public partial class MainForm : Form
    {
        public controler controler;
        public MainForm(controler c)
        {
            controler = c;
            InitializeComponent();
        }



        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void My_Label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.Format = DateTimePickerFormat.Time;
            this.dateTimePicker1.Width = 100;
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Record frec = new Record(controler);
            this.Visible = false;
            frec.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectUser fcon = new ConnectUser(controler);
            this.Visible = false;
            DialogResult dr = fcon.ShowDialog();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            controler.GeneralSearch(this);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
