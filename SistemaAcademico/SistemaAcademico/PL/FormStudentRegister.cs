using SistemaAcademico.BL;
using SistemaAcademico;
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
        private void FormStudentRegister_Load(object sender, EventArgs e)
        {
            cmbGender.DataSource = _RegistrationService.GetGenders();
            cmbGender.DisplayMember = "Genders";
            cmbGender.ValueMember = "ID";
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Hide();
            var loginForm = new FormLogin();
            loginForm.Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CreateNewAccount();
        }

        private void CreateNewAccount()
        {
            var login = new Login
            {
                Enrollment = txtEnrollment.Text,
                Password = txtPassword.Text,
                AccountTypeID = 1
            };

            var student = new Student
            {
                Enrollment = txtEnrollment.Text,
                Name = txtName.Text,
                Lastname = txtLastname.Text,
                Age = Convert.ToInt32(txtAge.Text),
                Address = txtAddress.Text,
                IdentityCardNum = txtCardId.Text,
                GenderID = Convert.ToInt32(cmbGender.SelectedValue)
            };

            if (_RegistrationService.AccountExist(login))
                MessageBox.Show("Esta matricula ya esta registrada. Por favor, intente una diferente.");

            _RegistrationService.CreateNewAccount(login);
            _RegistrationService.CreateStudentProfile(student);
        }
    }
}
