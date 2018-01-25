using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
namespace Evaluacion_jardin_de_niños
{
    public partial class Registro_del_alumno : Form
    {
        public Registro_del_alumno()
        {
            InitializeComponent();
           
        }
        private void nombrealumno_KeyPress(object sender, KeyPressEventArgs e)
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
                        appat.Focus();
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
        private void appat_KeyPress(object sender, KeyPressEventArgs e)
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
                        apmat.Focus();
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
        private void apmat_KeyPress(object sender, KeyPressEventArgs e)
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
                        apmat.Focus();
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
        private void btncurp_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
           else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void combogenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void comboedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void combogrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void limpiar()
        {
            curp.Text = "";
            nomalu.Text = "";
            appat.Text = "";
            apmat.Text = "";
            fechanac.Text = "";
            edad.Text = "";
            numtel.Text = "";
            combogenero.Text = null;
            combogradogrupo.Text = null;
            curp.Focus();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void registroalu_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(curp.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            if (string.IsNullOrEmpty(nomalu.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            if (string.IsNullOrEmpty(appat.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            if (string.IsNullOrEmpty(apmat.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            if (string.IsNullOrEmpty(edad.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            else if(numtel.TextLength<10){
                MessageBox.Show("Ingrese un número de 10 digitos.");
                return;
            }
            
            MySqlConnection cn;
            try
            {
                cn = new MySqlConnection("server=127.0.0.1; port=3305; database=JardinBonifacioDiaz; Uid=root; pwd=root;");
                Alumno pAlumno = new Alumno();
                pAlumno.Curp = curp.Text.Trim();
                pAlumno.Nombre = nomalu.Text.Trim();
                pAlumno.ApellidoPaterno = appat.Text.Trim();
                pAlumno.ApellidoMaterno = apmat.Text.Trim();
                pAlumno.Edad = edad.Text.Trim();
                pAlumno.Telefono = numtel.Text.Trim();
                pAlumno.GradoyGrupo = combogradogrupo.Text.Trim();
                pAlumno.Fecha_Nac = fechanac.Text.Trim();
                pAlumno.Sexo = combogenero.Text.Trim();
                pAlumno.Fecha_Ingre = txtfechingreso.Text.Trim();
                pAlumno.Num_Lista = txtnumlist.Text.Trim();
                pAlumno.Nacionalidad = txtnacio.Text.Trim();
                pAlumno.Nombre_Tutor = txtnombtut.Text.Trim();
                pAlumno.Domicilio_Tutor = txtdomtut.Text.Trim();
              

                int resultado = AlumnoABC.Agregar(pAlumno);
                if (resultado > 0)
                {
                    MessageBox.Show("Alumno Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el alumno", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un error" + ex.Message);
            }
        }
        private void edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 50 || e.KeyChar >= 54 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void numtel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }

        private void Registro_del_alumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_Principal forma = new Menu_Principal();
            forma.Show();
        }

        private void Registro_del_alumno_Load(object sender, EventArgs e)
        {

        }

     

      
      
    }
}
        
      
            
    

