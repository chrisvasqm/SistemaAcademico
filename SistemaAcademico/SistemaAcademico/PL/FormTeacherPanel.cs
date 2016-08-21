using System;
using System.Windows.Forms;
using SistemaAcademico;
using SistemaAcademico.DAL;
using SistemaAcademico.BL;

namespace PL
{
    public partial class FormTeacherPanel : Form
    {
        private AcademicEntities dbContext = new AcademicEntities();
        private TeacherServices _teacherService = new TeacherServices();
        private SubjectsRepository _subjectsRepository = new SubjectsRepository();
        public FormTeacherPanel()
        {
            InitializeComponent();
        }
        private void FormTeacherPanel_Load(object sender, EventArgs e)
        {
            cmbMaterias.DataSource      = _subjectsRepository.GetAllSubjects();
            cmbMaterias.DisplayMember   = "Materias";
            cmbMaterias.ValueMember     = "ID";

            dgv1.DataSource                 = _teacherService.GetAllStudentsRecords();
            dgv1.Columns["ID"].Visible      = false;
            dgv1.Columns["Materia"].Width   = 150;
        }
        private void btnGuardar(object sender, EventArgs e)
        {
            var cmbValue = cmbMaterias.Text;

            dgv1.DataSource = _teacherService.GetRecordsBySubject(cmbValue);
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Hide();
            var loginForm = new FormLogin();
            loginForm.Show();
        }
        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            var IdValue = _teacherService.GetRecordId(txtMatricula.Text, cmbMaterias.Text);
            //TODO: HACER UN METODO QUE MEDIANTE LA MATRICULA Y LA MATERIA TRAIGA EL ID Y ESE ID SE LO ASIGNE AL OBJETO DE ABAJO
            var evaluationValues = new StudentRecord
            {
                ID = IdValue,
                P1 = Convert.ToInt32(txtPrimerParcial.Text),
                P2 = Convert.ToInt32(txtSegundoParcial.Text),
                P3 = Convert.ToInt32(txtTercerParcial.Text),
                Practica = Convert.ToInt32(txtPractica.Text),
                Asistencia = Convert.ToInt32(txtAsistencia.Text)                
            };

            if (_teacherService.isNotOverOrUnderLimit(evaluationValues))
            {
                _teacherService.EvaluateStudentsByEnrollment(evaluationValues);
            }
            else
            {
                MessageBox.Show(@"Los valores a ingresar deben ser mayores que cero y no superar los siguientes valores: 
Parciales: 20
Practica: 30
Asistencia: 10");
            }
        }




















        private void txtPrimerParcial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtSegundoParcial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtTercerParcial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtPractica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtAsistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
    }
}
