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
    public partial class AddPartner : Form
    {
        controler controler;
        public AddPartner(controler c)
        {
            controler=c;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         /*   string dbprovider = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                    @"Data source= db\" + @"partners.mdb";*/

        }

        private void AddPartner_Load(object sender, EventArgs e)
        {

        }
    }
}
