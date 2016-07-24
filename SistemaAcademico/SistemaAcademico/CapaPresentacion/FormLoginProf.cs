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
    public partial class FormLoginProf : Form
    {
        public FormLoginProf()
        {
            InitializeComponent();
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
            FormEvaluacion newForm = new FormEvaluacion();
            newForm.Show();
        }
    }
}
