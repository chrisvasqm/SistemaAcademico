using System;
using System.Windows.Forms;
using SistemaAcademico.BLL;

namespace PL
{
    public partial class FormTeacherPanel : Form
    {
        private StudentServices _StudentService = new StudentServices();    
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
            var loginForm = new FormLogin();
            loginForm.Show();
        }
        private void btnEvaluar_Click(object sender, EventArgs e)
        {

        }
        private void FormTeacherPanel_Load(object sender, EventArgs e)
        {
                     
        }
    }
}
