using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myIS.Controler;
using myIS.Model;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;


namespace myIS.Controler
{
    public class controler
    {
         public model m;



        public controler() { m = new model(this);}

        public void startApp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FirstForm(this));
        }


        public void connactUser(string mail, string pass)
        {

                
        }



        public void GeneralSearch(MainForm mf)
        {
            SearchGenere fg = new SearchGenere(this);
            string name = "";
            string desc = "";
            string date = "";
            string city = "";
            string street = "";
            string cost = "";
            
            String strSql = "SELECT * FROM [domain] ";
            OleDbConnection conn = m.getGeneralSearch();
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(strSql, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    name = reader.GetString(3);
                    desc = reader.GetString(2);
                    date = reader.GetString(1);
                    city = reader.GetString(6);
                    street = reader.GetString(7);
                    cost = reader.GetValue(9).ToString();
                    fg.addToList(name, desc, date, city, street, cost);
                }
                conn.Close();
                mf.Hide();
                fg.Show();

            }
            catch
            {
                MessageBox.Show("there is no domains");
            }
        }


        public void setNewRecord(Record R,string t1, string t2, string t3, string t4, string t5, string t6, string t7, string t8, string t9, string t10, string t11, string t12, string t13, string t14, bool smook, bool pet, bool pur, bool drust, string s, string strSql)
        {
            string dbprovider = m.getDBprovider();
            OleDbConnection conn = new OleDbConnection(dbprovider);
            OleDbCommand dbCmd = new OleDbCommand(strSql, conn);
            conn.Open();
            m.setRecord(dbCmd,t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, smook, pet, pur, drust, s, strSql);
            
            R.Hide();
            Success_insert fOk = new Success_insert(this);
            fOk.UpdateStatusSuccess(t1, t3);

            fOk.Show();
            conn.Close();
            
        }

        public void profileToDelete(EdittingProfile ed,string mail)
        {
            m.deleteProfile(ed,mail);
            
        }

        public void getDataFromUser(EdittingProfile ed, string Mail)
        {
            string dbprovider = m.getDBprovider();
            String strSql = "SELECT * FROM [users] WHERE [email]= '" + Mail + "'";
            OleDbConnection conn = new OleDbConnection(dbprovider);
            MySearchList sl = new MySearchList(this);

            conn.Open();
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            
        }


        public void updateUser(string t1, string t2, string t3, string t4, string t5, string t6, string t7, string t8, string t9, string t10, string t11, string t12, string t13, string t14, int smook, int pet, int pur, int drust)
        {
            OleDbConnection conn = new OleDbConnection(m.getDBprovider());
            
            string strSql = "UPDATE [users] SET [fname]='" + t1 + "',[lname]='" + t2 + "',[city]='" + t8 + "',[street]='" + t9 + "',[telephone]='" + t10 + "',[age]='" + Int32.Parse(t6) + "',[gender]='" + t7 + "',[meterial_status]='" + t5 + "',[password]='" + t3 + "',[birth]='" + t4 + "',[smoking]='" + smook + "',[have_pet]='" + pet + "',[organized]='" + Int32.Parse(t12) + "',[educatin]='" + t13 + "',[dustellrgy]='" + drust + "',[perfumellergy]='" + pur + "',[notes]='" + t14 + "' WHERE [email]='" + t11 + "'";

            m.updateUser(conn,strSql);
            

        }


        public void updateDomain(Domains D, string s)
        {
            UpdateDomain fud = new UpdateDomain(this,s);
            D.Hide();
            fud.Show();
        }

        public void returnToInputsForm(Domains D,String S){
            InputsForm fi = new InputsForm(this);
            D.Hide();
            fi.setLabel(S);
            fi.Show();
        }

        public void returnToDomains(UpdateDomain ud, string s)
        {
            Domains fd = new Domains(this);
            ud.Hide();
            fd.setText(s);
            fd.Show();
        }

        public void updateUD(UpdateDomain UD, string s)
        {
            InputsForm ff = new InputsForm(this);
            ff.setLabel(s);
            UD.Hide();
            ff.Show();
        }

        public void tryToUpdate(OleDbConnection conn, string t2, string t3, string t4, string t5, string t6, string t7, string t8, long did)
        {
            string strSql = "Update [domain] set [date]='" + t2.ToString() + "', [description]='" + t3.ToString() + "', [maxNumOfPartner]='" + long.Parse(t5) + "', [city]='" + t4.ToString() + "', [street]='" + t6.ToString() + "', [maker_date]='" + t8.ToString() + "', [cost]='" + long.Parse(t7) + "' WHERE domain_id=" + did;
            conn.Open();
            m.updateDomain(strSql,conn);
            
            conn.Close();
        }

        public void addDomain(Domains D, string S)
        {
            AddDomain fad = new AddDomain(this);
            fad.addOwner(S);
            D.Hide();
            fad.Show();
        }

        public void returnToDomains(AddDomain ud, string s)
        {
            Domains fd = new Domains(this);
            ud.Hide();
            fd.setText(s);
            fd.Show();
        }

        public void returnToInputForm(DeleteExistDomain DED, string s)
        {
            InputsForm np = new InputsForm(this);
            np.setLabel(s);
            DED.Hide();
            np.Show();
        }
        public void DeleteDomain(long domainId,string s,DeleteExistDomain DED)
        {
            string dbprovider = m.getDBprovider();
           
            OleDbConnection conn = new OleDbConnection(dbprovider);

            try
            {
                string query = "select * from [domain] where [domain_id]=" + domainId;
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                System.Data.OleDb.OleDbDataAdapter tableAdapter = new System.Data.OleDb.OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                tableAdapter.Fill(dt);
                conn.Close();
                string query_2 = "delete from [domain] where [domain_id]=" + domainId;
                conn.Open();
                OleDbCommand cmd_2 = new OleDbCommand(query_2, conn);
                DialogResult dialogResult = MessageBox.Show("if you Sure you want to delete this domain prees yes else press no", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd_2.ExecuteNonQuery();
                    MessageBox.Show("successful deleting:)");
                    InputsForm fef = new InputsForm(this);
                    fef.setLabel(s);
                    DED.Hide();
                    fef.Show();
                }
                else
                {
                    DED.Show();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("can't delete Or user didn't exist");
            }
        }


        public void returnToDomain(DomainsUserList DUL, string S)
        {
            Domains fd = new Domains(this);
            DUL.Hide();
            fd.setText(S);
            fd.Show();

        }


        public void returnToInputs(MySearchList MSL, string S)
        {
            InputsForm fm = new InputsForm(this);
            fm.setLabel(S);
            MSL.Hide();
            fm.Show();
        }

        public void returnToSearchForm(MySearchList MSL, String S)
        {
            SearchForm fs = new SearchForm(this);
            fs.setString(S);
            MSL.Hide();
            fs.Show();
        }

        public void returnToInputForm(SuccessfulDomainAdded SFDA, string S)
        {
            InputsForm mf = new InputsForm(this);
            mf.setLabel(S);
            SFDA.Hide();
            mf.Show();
        }

        public void returnToInputsForm(SuccessSearch SS,string s){
            InputsForm fi = new InputsForm(this);
            fi.setLabel(s);
            SS.Hide();
            fi.Show();
        }
    }
}
