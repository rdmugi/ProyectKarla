using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Evaluacion_jardin_de_niños
{
    public partial class Buscar_Alumno : Form
    {
        public Buscar_Alumno()
        {
            InitializeComponent();
            evalua.Enabled = false;
        }
        
        public Alumno AlumnoSeleccionado 
        { 
            get; 
            set; 
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombre.Text) && string.IsNullOrEmpty(apellidop.Text))
            {

                MessageBox.Show("Ingrese nombre o apellido del alumno");

                return;

            }
            else
            {
                dataGridView1.DataSource = AlumnoABC.Buscar(nombre.Text, apellidop.Text);
                evalua.Enabled = true;
            }

            
        }
        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

            }
            else
                if (e.KeyChar == '\b')
                {

                }
                else
                {
                    if (e.KeyChar == 13)
                    {
                        nombre.Focus();
                    }
                    else
                    {
                        if (e.KeyChar == ' ')
                        {

                        }
                        else
                            e.Handled = true;
                    }

              }
        }
        private void apellidop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

            }
            else
                if (e.KeyChar == '\b')
                {

                }
                else
                {
                    if (e.KeyChar == 13)
                    {
                        apellidop.Focus();
                    }
                    else
                    {
                        if (e.KeyChar == ' ')
                        {

                        }
                        else
                            e.Handled = true;
                    }

                }
        }
        private void evalua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                AlumnoSeleccionado = AlumnoABC.ObtenerAlumno(id);
                string nombreAl, gradGrup;
                nombreAl = AlumnoSeleccionado.Nombre + " " + AlumnoSeleccionado.ApellidoPaterno + " " + AlumnoSeleccionado.ApellidoMaterno;
                gradGrup = AlumnoSeleccionado.GradoyGrupo;
                MenuEval forma = new MenuEval(nombreAl, gradGrup, id);
                forma.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Seleccione un alumno para evaluar");
            }

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

 
        private void Buscar_Alumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_Principal menu = new Menu_Principal();
            menu.Show();
        }

        private void Buscar_Alumno_Load(object sender, EventArgs e)
        {
           
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
