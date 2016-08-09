using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PL
{
    public partial class FormTeacherPanel : Form
    {
        public FormTeacherPanel()
        {
            InitializeComponent();
        }

        private void btnGuardar(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin newForm = new FormLogin();
            newForm.Show();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {

        }
    }
}
