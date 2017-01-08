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
    public partial class SuccessSearch : Form
    {
        public SuccessSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputsForm fi = new InputsForm();
            fi.setLabel(sString.Text);
            this.Hide();
            fi.Show();
        }
        public void setString(string s)
        {
            sString.Text = s;
            sString.Visible = false;
        }
        private void SuccessSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
