using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormLoginEst: Form
    {
        private bool isNuevo = false;
        private bool isEditar = false;

        public FormLoginEst()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicio newForm = new FormInicio();
            newForm.Show();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {



            this.Hide();
            FormPanelEstudiante newForm = new FormPanelEstudiante();
            newForm.Show();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormRegistroEstudiante newForm = new FormRegistroEstudiante();
            newForm.Show();
        }
    }
}
