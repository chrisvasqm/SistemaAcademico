
using SistemaAcademico.BL;
using SistemaAcademico;
using System;
using System.Windows.Forms;

namespace PL
{
    public partial class FormStudentPanel : Form
    {
        private AcademicEntities dataBase = new AcademicEntities();
        private StudentServices _studentService = new StudentServices(); 

        public FormStudentPanel(string matStudent)
        {
            InitializeComponent();
            lblMatricula.Text = matStudent;
        }
        private void FormStudentPanel_Load(object sender, EventArgs e)
        {
            cmbMaterias.DataSource = _studentService.GetAllSubject();
            cmbMaterias.DisplayMember = "Materias";
            cmbMaterias.ValueMember = "ID";

            dgv1.DataSource = _studentService.GetRecordsByMatricula(lblMatricula.Text);
            dgv1.Columns["ID"].Visible = false;
            dgv1.Columns["Student"].Visible = true;
            dgv1.Columns["Materia"].Width = 150;
            dgv2.DataSource = _studentService.GetAllSubject();
            dgv2.Columns["ID"].Visible = false;
            dgv2.Columns["isAproved"].Visible = false;
            dgv2.Columns["Materias"].Width = 150;
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Hide();
            var loginForm = new FormLogin();
            loginForm.Show();
        }             
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = _studentService.GetRecordsByMatricula(lblMatricula.Text);
        }

        private void btnSeleccioanr_Click(object sender, EventArgs e)
        {
            var selectionValues = new StudentRecord
            {
                Student = lblMatricula.Text,
                Materia = cmbMaterias.Text                
            };

            if (_studentService.ValidateDuplicate(selectionValues))
                MessageBox.Show("Materia previamente seleccionada, por favor elija otra.");
            else 
                _studentService.SetStudentSubject(selectionValues);

            _studentService.GetRecordsByMatricula(lblMatricula.Text);
        }
    }
}
