﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo01
{
    public partial class Demo1 : Form
    {
        public Demo1()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = "Xin chao!!!";
        }
    }
}
