using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormLoginEst: Form
    {
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
