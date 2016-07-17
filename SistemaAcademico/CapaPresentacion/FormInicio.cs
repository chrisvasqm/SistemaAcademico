using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoginEst newForm = new FormLoginEst();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoginProf newForm = new FormLoginProf();
            newForm.Show();
        }
    }
}
