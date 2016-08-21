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
            var cmbValue = new StudentRecord
            {
                Materia = cmbMaterias.Text
            };

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
