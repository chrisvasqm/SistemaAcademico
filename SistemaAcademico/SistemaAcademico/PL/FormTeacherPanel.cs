using SistemaAcademico.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PL
{
    public partial class FormTeacherPanel : Form
    {
        private PensumRepository _PensumRepository = new PensumRepository();

    
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
            FormLogin newForm = new FormLogin();
            newForm.Show();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {

        }

        private void FormTeacherPanel_Load(object sender, EventArgs e)
        {
            cmbMateria.DataSource = _PensumRepository.GetPensumSubjects();
            cmbMateria.DisplayMember = "Subject";
            cmbMateria.ValueMember = "Subject";
        }
    }
}
