using SistemaAcademico.BLL;
using System;
using System.Windows.Forms;

namespace PL
{
    public partial class FormStudentRegister : Form
    {
        private RegistrationService _RegistrationService = new RegistrationService();

        public FormStudentRegister()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin newForm = new FormLogin();
            newForm.Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }

        private void FormStudentRegister_Load(object sender, EventArgs e)
        {
            cmbGender.DataSource = _RegistrationService.GetGender();
            cmbGender.DisplayMember = "Gender";
            cmbGender.ValueMember = "Gender";
        }
    }
}
