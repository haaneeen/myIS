﻿using System;
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
    public partial class PartnerClass : Form
    {
        public PartnerClass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
      
        private void PartnerClass_Load(object sender, EventArgs e)
        {

        }
        public void setTextP(string s)
        {
            textBox1.Text = s;
            textBox1.Visible = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
