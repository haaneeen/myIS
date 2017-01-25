using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myIS.Controler;
using System.Windows.Forms;
using System.Data.OleDb;



namespace myIS.Model
{
    public  class model
    {
        controler c;
        public model(controler controler)
        {
            c = controler;
        }


        public void connect(string s)
        {

        }

        public OleDbConnection getGeneralSearch()
        {

             OleDbConnection temp= new OleDbConnection(getDBprovider());
             return temp;
        }

        public string getDBprovider(){
            string temp= @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data source= db\" + @"partners.mdb";
            return temp;
        }


        public void setRecord(OleDbCommand dbCmd,string t1, string t2, string t3, string t4, string t5, string t6, string t7, string t8, string t9, string t10, string t11, string t12, string t13, string t14, bool smook, bool pet, bool pur, bool drust, string s, string strSql)
        {
            dbCmd.Parameters.AddWithValue("email", t3);
            dbCmd.Parameters.AddWithValue("fname", t1);
            dbCmd.Parameters.AddWithValue("lname", t2);
            dbCmd.Parameters.AddWithValue("city", t5);
            dbCmd.Parameters.AddWithValue("street", t6);
            dbCmd.Parameters.AddWithValue("telephone", t7);
            dbCmd.Parameters.AddWithValue("age", t8);
            dbCmd.Parameters.AddWithValue("gender", t10);
            dbCmd.Parameters.AddWithValue("meterial_status", t11);
            dbCmd.Parameters.AddWithValue("password", t9);
            dbCmd.Parameters.AddWithValue("birth", t4);

            dbCmd.Parameters.AddWithValue("smoking", smook);
            dbCmd.Parameters.AddWithValue("have_pet", pet);
            dbCmd.Parameters.AddWithValue("organized", t12);
            dbCmd.Parameters.AddWithValue("educatin", t13);
            dbCmd.Parameters.AddWithValue("dustellrgy", drust);
            dbCmd.Parameters.AddWithValue("perfumellergy", pur);
            dbCmd.Parameters.AddWithValue("notes", t14);
            dbCmd.Parameters.AddWithValue("reg_date", s);
            dbCmd.ExecuteNonQuery();
        }

        public void deleteProfile(EdittingProfile ed, string m)
        {
            string dbprovider = getDBprovider();
            OleDbConnection conn = new OleDbConnection(dbprovider);
            try
            {
                string query = "delete from [users] where [email]='" + m + "'";
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                DialogResult dialogResult = MessageBox.Show("if you Sure you want to delete this domain prees yes else press no", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successful deleting:)");
                    MainForm mf = new MainForm(c);
                    ed.Hide();
                    mf.Show();
                }
                else
                {
                    ed.Show();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void updateUser(OleDbConnection conn,string strsql)
        {
            conn.Open();
            OleDbCommand command = new OleDbCommand(strsql, conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successful Updating");
        }

        public void updateDomain(string strSql,OleDbConnection conn)
        {
            OleDbCommand command = new OleDbCommand(strSql, conn);
            command.ExecuteNonQuery();
        }
    }
}
