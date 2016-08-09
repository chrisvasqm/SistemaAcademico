
using System;
using System.Windows.Forms;
using SistemaAcademico.BLL;

namespace PL
{
    public partial class FormLogin : Form
    {
        LoginServices _loginServices = new LoginServices();
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
            var loginResponse = _loginServices.ValidateAccountType(txtUsername.Text, txtPassword.Text, (int)cmbAccountType.SelectedValue);

            if (loginResponse == TypeOfAccount.Student)
                ShowStudentForm();
            else if (loginResponse == TypeOfAccount.Teacher)
                ShowTeacherForm();
            else if (loginResponse == TypeOfAccount.Error)
                MessageBox.Show("Wrong username, password or account type");
        }
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var StudentRegForm = new FormStudentRegister();
            StudentRegForm.Show();
        }
        private void ShowStudentForm()
        {
            this.Hide();
            var StudentForm = new FormStudentPanel();
            StudentForm.Show();
        }       
        private void ShowTeacherForm()
        {
            this.Hide();
            var TeacherForm = new FormTeacherPanel();
            TeacherForm.Show();
        }        
    }
}