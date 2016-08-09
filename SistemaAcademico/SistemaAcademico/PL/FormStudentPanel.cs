using System;
using System.Windows.Forms;

namespace PL
{
    public partial class FormStudentPanel : Form
    {
        public FormStudentPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin newForm = new FormLogin();
            newForm.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
