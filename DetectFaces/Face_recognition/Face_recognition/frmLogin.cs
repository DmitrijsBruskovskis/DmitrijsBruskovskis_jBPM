﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Face_recognition
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public bool login = true;

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(login)
            {
                this.Hide();
                frmMain fm = new frmMain();
                fm.Show();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}