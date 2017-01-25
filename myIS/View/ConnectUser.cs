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
using myIS.Data_Access;
using myIS.Controler;

namespace myIS
{
    public partial class ConnectUser : Form
    {
        public controler controler;
        public ConnectUser(controler c)
        {
            controler = c;
            InitializeComponent();
            password.UseSystemPasswordChar = true;
            password.Text = "123";
            maskedTextBox1.Text = "gmail.com";
            id.Text = "hanen1711";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mail = (id.Text)+"@"+ maskedTextBox1.Text;
            string pass = password.Text;

            string dbprovider = controler.m.getDBprovider();
            String strSql = "SELECT * FROM users WHERE email= '" + mail + "'";
            OleDbConnection conn = new OleDbConnection(dbprovider);
            if (id.Text == "" || maskedTextBox1.Text == "")
            {
                MessageBox.Show("you must add your mail");
                id.Clear();
                maskedTextBox1.Clear();
                id.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(strSql, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    string passw = reader.GetString(9);
                    if (passw != pass)
                    {
                        MessageBox.Show("wrong password");
                        password.Clear();
                        password.Focus();
                    }
                    else
                    {
                        InputsForm fi = new InputsForm(controler);
                        this.Hide();
                        fi.Show();
                        fi.setLabel(mail);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("user didn't exist or wrong mail try again");
                    id.Clear();
                    maskedTextBox1.Clear();
                    id.Focus();
                    password.Clear();
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm(controler);
            this.Hide();
            mf.Show();
        }

        private void ConnectUser_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
