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
    public partial class UpdateDomain : Form
    {
        controler controler;
        public UpdateDomain(controler c,string s)
        {
            InitializeComponent();
            textBox1.Text = s;
            controler = new controler();
            setComboText(SearchDomainName());
        }

        private void setComboText(List<string> name)
        {
            if (name.Count == 0)
            {
                MessageBox.Show("you didn't have any domain");
                Domains fd = new Domains(controler);
                fd.setText(textBox1.Text);
                this.Hide();
                fd.Show();
            }
            else
            {
                foreach (var item in name)
                {
                    comboDName.Items.Add(item);
                }
            }
        }
        private List<string> SearchDomainName()
        {
            string mail = textBox1.Text;
            List<string> name = new List<string>();
            string query = "select * from [domain] where[OwnerMail]= '" + mail + "'";
            string dbprovider = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                    @"Data source= db\" + @"partners.mdb";
            OleDbConnection conn = new OleDbConnection(dbprovider);
            try
            {
                conn.Open();
                OleDbCommand dbCmd = new OleDbCommand(query, conn);
                OleDbDataReader reader = dbCmd.ExecuteReader();
                while (reader.Read())
                {
                    name.Add(reader.GetString(3));
                }
                if (name.Count < 1)
                {
                    MessageBox.Show("you didn't have domains");
                }
            }
            catch
            {
                MessageBox.Show("there is some errors");
            }
            conn.Close();
            return name;
        }
        private List<string> SearchTheId()
        {
            string name = comboDName.Text;
            List<string> domainId = new List<string>();
            string query = "select * from [domain] where[dname]= '" + name + "'";
            string dbprovider = controler.m.getDBprovider();
            OleDbConnection conn = new OleDbConnection(dbprovider);
            if (name != "")
            {
                try
                {
                    conn.Open();
                    OleDbCommand dbCmd = new OleDbCommand(query, conn);
                    OleDbDataReader reader = dbCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        domainId.Add(reader.GetValue(0) + "");
                    }
                    if (domainId.Count < 1)
                    {
                        MessageBox.Show("you didn't have domains");
                    }
                }
                catch
                {
                    MessageBox.Show("there is some errors");
                }
                conn.Close();
            }

            return domainId;
        }
        private void FillComboId(List<string> domainId)
        {
            foreach (string item in domainId)
            {
                comboId.Items.Add(item);
            }
        }
        private void UpdateDomain_Load(object sender, EventArgs e)
        {

        }
        private void ToUpdate()
        {
            string t2, t3, t4, t5, t6, t7, t8;
            long did = long.Parse(comboId.Text);
            t2 = year.Text;
            t3 = textBox3.Text;
            t4 = loc.Text;
            t5 = partnerOfDoman.Text;
            t6 = stret.Text;
            t7 = dCost.Text;
            if (t7 == "--")
            {
                t7 = "0";
            }
            else
            {
                t7 = dCost.Text;
            }
            t8 = DateTime.Today.Date.ToString();
            string dbprovider = controler.m.getDBprovider();
            OleDbConnection conn = new OleDbConnection(dbprovider);
            try
            {
                controler.tryToUpdate(conn, t2, t3, t4, t5, t6, t7, t8, did);
               
                MessageBox.Show("Successful Updating");
            }
            catch
            {
                MessageBox.Show("There is some errors check again");
                this.Show();
            }


        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboDName.Text == "")
            {
                MessageBox.Show("you must fill the domain you want to update");
                this.Show();
                comboDName.Focus();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("are you Sure>? press yes else press no", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("you must fill the id of the domain you want to update");
                    comboId.Focus();
                    FillComboId( SearchTheId());
                    this.Show();
                }
                else
                {
                    this.Hide();
                    Domains df = new Domains(controler);
                    df.setText(textBox1.Text);
                    df.Show();
                }
            }
        }
        private void SearchAllItems()
        {
            string dbprovider = controler.m.getDBprovider();
            string name = comboDName.Text;
            string strSql = "select * from [domain] where[dname]= '" + name + "'";
            OleDbConnection conn = new OleDbConnection(dbprovider);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                if (reader.GetValue(0).ToString() == (comboId.Text)&&reader.GetString(4).ToString()==textBox1.Text)
                {
                    i++;
                    year.Text = reader.GetString(1);
                    textBox3.Text = reader.GetString(2);
                    loc.Text = reader.GetString(6);
                    stret.Text = reader.GetString(7);
                    if (reader.GetValue(9) + "" == "")
                    {
                        dCost.Text ="--";
                    }
                    else
                    {
                        dCost.Text = reader.GetValue(9) + "";
                    }
                    partnerOfDoman.Text = reader.GetValue(5) + "";
                    break;
                }
                else
                {
                    continue;
                }
            }
            conn.Close();
        }
        private void comboId_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            SearchAllItems();
            this.comboId.FormattingEnabled = true;
        }

        private void year_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            controler.returnToDomains(this, textBox1.Text);
            
        }
        private void ToDelete()
        {

        }
        private void update_Click(object sender, EventArgs e)
        {
            ToUpdate();
            controler.updateUD(this, textBox1.Text);
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeleteExistDomain fs = new DeleteExistDomain(controler);
            fs.setText(textBox1.Text, comboDName.Text, comboId.Text);
            this.Hide();
            fs.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
