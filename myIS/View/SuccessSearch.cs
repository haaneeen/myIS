using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myIS.Controler;

namespace myIS
{
    public partial class SuccessSearch : Form
    {
        controler controler;
        public SuccessSearch(controler c)
        {
            controler=c;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controler.returnToInputsForm(this, sString.Text);
            
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
