﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class FormRegistroEstudiante : Form
    {
        public FormRegistroEstudiante()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin newForm = new FormLogin();
            newForm.Show();
        }
    }
}
