using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LinqTest
{
    public partial class Form1 : Form
    {        
        StudentRepository repository = new StudentRepository();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            dataGridView1.DataSource = repository.GetStudents();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        { 
            var loginValues = new tbl_login                                        
            {
                usuario = txtUser.Text,                                     
                contraseña = txtPass.Text                                  
            };

            if (repository.VerifyStudent(loginValues))                                                                                 
                MessageBox.Show("Login credentials are legit");
            else 
                MessageBox.Show("Login credentials are incorrect");            
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {                
                var insertValues = new tbl_login
                {
                    usuario = txtNom.Text,
                    contraseña = txtContra.Text,
                    matricula = txtMat.Text
                };

                repository.InsertStudent(insertValues);
                RefreshDataGrid();
                MessageBox.Show("User info has been successfully saved");                
            }
            catch (Exception ex)
            {                
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void btnID_Click(object sender, EventArgs e)
        {         
           int idValue = int.Parse(txtID.Text);
           dataGridView1.DataSource = repository.GetStudentsById(idValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            




            //int rowindex = dataGridView1.CurrentCell.RowIndex;
            //int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);

            //var updateValues = new tbl_login
            //{
            //    id_login = id,
            //    usuario = txtUpdateUser.Text
            //};

            //repository.Update(updateValues);
            //dataGridView1.DataSource = repository.GetStudents();
        }
    }
}