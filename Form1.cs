﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void planForm_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Form form2 = new loginForm();
            form2.Visible = true;
        }
    }
}
