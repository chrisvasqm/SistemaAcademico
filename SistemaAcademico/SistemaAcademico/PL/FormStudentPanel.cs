using SistemaAcademico.BLL;
using System;
using System.Windows.Forms;

namespace PL
{
    public partial class FormStudentPanel : Form
    {
        private StudentServices _StudentService = new StudentServices();
        public FormStudentPanel()
        {
            InitializeComponent();
        }   

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new FormLogin();
            loginForm.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void FormStudentPanel_Load(object sender, EventArgs e)
        {
        }

        private void btnBuscarMats_Click(object sender, EventArgs e)
        {
        }
    }
}
