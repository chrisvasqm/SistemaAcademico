
using System;
using System.Windows.Forms;
using SistemaAcademico;
using SistemaAcademico.BL;

namespace PL
{
    public partial class FormLogin : Form
    {
        private AcademicEntities dataBase = new AcademicEntities();
        private LoginServices _loginServices = new LoginServices();
        public FormLogin()
        {
            InitializeComponent();            
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            cmbAccountType.DataSource = _loginServices.GetLoginType();
            cmbAccountType.DisplayMember = "Type";
            cmbAccountType.ValueMember = "ID";
        }        
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            var loginValues = new Login
            {
                Enrollment = txtUsername.Text,
                Password = txtPassword.Text
            };

            var loginResponse = _loginServices.ValidateAccountType(loginValues, (int)cmbAccountType.SelectedValue);

            if (loginResponse == TypeOfAccount.Student)
                ShowStudentForm();

            else if (loginResponse == TypeOfAccount.Teacher)
                ShowTeacherForm();

            else if (loginResponse == TypeOfAccount.Error)
                MessageBox.Show("Matricula y/o contraseña invalida. Por favor, intente de nuevo.");
        }        
        private void ShowStudentForm()
        {
            Hide();
            var StudentForm = new FormStudentPanel(txtUsername.Text);
            StudentForm.Show();
        }       
        private void ShowTeacherForm()
        {
            Hide();
            var TeacherForm = new FormTeacherPanel();
            TeacherForm.Show();
        }
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var StudentRegForm = new FormStudentRegister();
            StudentRegForm.Show();
        }
    }
}