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
namespace myIS
{
    public partial class Add_Domain : Form
    {
        public Add_Domain()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {

            String t1, t2, t3, t5, t6,t4 ;
            t4 = id.Text;
            t1 = desc.Text;
            t2 = num.Text;
            t3 = max.Text;
            t5 = date.Text;
            t6 = name.Text;
           
            string strSql = "INSERT INTO domain (domaim_id,description,partnersNum,maxNumOfPartners,date,name) VALUES (?,?,?,?,?,?)";
            string dbprovider = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                     @"Data source= C:\Users\USER\Documents\Visual Studio 2015\Projects\myIS\myIS\db\" + @"partners.mdb";

            OleDbConnection conn = new OleDbConnection(dbprovider);
            try
            {
                OleDbCommand dbCmd = new OleDbCommand(strSql, conn);

                dbCmd.Parameters.AddWithValue("domaim_id", t4);
                dbCmd.Parameters.AddWithValue("description", t1);
                dbCmd.Parameters.AddWithValue("partnersNum", t2);
                dbCmd.Parameters.AddWithValue("maxNumOfPartners", t3);
                dbCmd.Parameters.AddWithValue("date", t5);
                dbCmd.Parameters.AddWithValue("name", t6);
                conn.Open();
                dbCmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("domain exist choose another");
                id.Clear();
                id.Focus();
            }
            finally
            {
                conn.Close();
            }

            MessageBox.Show("Domain Data saved successfuly...!");
            InputsForm fi = new InputsForm();
            fi.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
