using SistemaAcademico.BLL;
using SistemaAcademico.DAL;
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
            dataGrid.DataSource = _StudentService.GetContent();
        }

        private void FormStudentPanel_Load(object sender, EventArgs e)
        {
            cmbMat.DataSource = _StudentService.GetSubjects();
            cmbMat.DisplayMember = "Subject";
            cmbMat.ValueMember = "Subject";
        }
    }
}
