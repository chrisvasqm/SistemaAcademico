using System;
using System.Windows.Forms;

namespace PL
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormRegistroEstudiante newForm = new FormRegistroEstudiante();
            newForm.Show();
        }
    }
}
