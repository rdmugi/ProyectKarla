using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Evaluacion_jardin_de_niños
{
    public partial class Evaluacion_Lenguaje_Comunicacion : Form
    {
        int Utiliza, Lenguaje, Escribe;
        string nombreAl = "", gradGrup = "";
        int id = 0;

        public Evaluacion_Lenguaje_Comunicacion(string nombreAl, string gradGrup, int id)
        {
            InitializeComponent();
            this.nombreAl = nombreAl;
            this.gradGrup = gradGrup;
            this.id = id;
        }
        private void evaluar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(utilizaconocimiento.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            if (string.IsNullOrEmpty(lenguajecomunicacion.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            if (string.IsNullOrEmpty(escribenombre.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }

            Utiliza = Convert.ToInt16(utilizaconocimiento.Text);
            Lenguaje = Convert.ToInt16(lenguajecomunicacion.Text);
            Escribe = Convert.ToInt16(escribenombre.Text);

            MySqlConnection cn;
            try
            {
                cn = new MySqlConnection("server=127.0.0.1; port=3305; database=JardinBonifacioDiaz; Uid=root; pwd=root;");
                evalualenguajeycomunicacion(Utiliza, Lenguaje, Escribe);
                BoletaDeLenguajeComunicacion pAlumno = new BoletaDeLenguajeComunicacion();

                pAlumno.Nombre = lblNomAl.Text.Trim();
                pAlumno.GradoyGrupo = lblGradGrup.Text.Trim();
                pAlumno.Esperado = lblesperado.Text.Trim();
                pAlumno.Desarrollo = lbldesarrollo.Text.Trim();
                pAlumno.RequiereApoyo = lblrequiereapoyo.Text.Trim();
                pAlumno.Resultado = nv.Text.Trim();
                

                int resultado = BoletaDeLenguajeComunicacionABC.Agregar(pAlumno);
                if (resultado > 0)
                {
                    MessageBox.Show("Alumno Evaluado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.limpiar();
                   
                }
                else
                {
                    MessageBox.Show("No se pudo evaluar el alumno", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
                MenuEval menu = new MenuEval(nombreAl, gradGrup, id);
                menu.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un error" + ex.Message);
            }
           

        }
        private void evalualenguajeycomunicacion(int util, int lengcom, int escribe)
        {
            double prom = 0;
            int Contesperado = 0;
            int Contdesarrollo = 0;
            int Contrapoyo = 0;

            string contespe = "";
            string contdes = "";
            string contrapo = "";

            if (util == 3)
            {
                Contesperado++;
            }
            else if (util == 2)
            {
                Contdesarrollo++;
            }
            else if (util == 1)
            {
                Contrapoyo++;
            }

            if (lengcom == 3)
            {
                Contesperado++;
            }
            else if (lengcom == 2)
            {
                Contdesarrollo++;
            }
            else if (lengcom == 1)
            {
                Contrapoyo++;
            }

            if (escribe == 3)
            {
                Contesperado++;
            }
            else if (escribe == 2)
            {
                Contdesarrollo++;
            }
            else if (escribe == 1)
            {
                Contrapoyo++;
            }

             prom = ((Convert.ToDouble(util) + Convert.ToDouble(lengcom) + Convert.ToDouble(escribe)) / 3);

            if (prom <= 1.6)
            {
                MessageBox.Show("El Niño Requiere Apoyo");
                nv.Text = "R.A";

            }
            if (prom <= 2.4 && prom >= 1.6)
            {
                MessageBox.Show("El Niño Esta En Desarrollo");
                nv.Text = "Desarrollo";
            }
            if (prom <= 3 && prom >= 2.5)
            {

                MessageBox.Show("El Niño Esta En Esperado");
                nv.Text = "Esperado";
            }
            contdes = Convert.ToString(Contdesarrollo);
            contespe = Convert.ToString(Contesperado);
            contrapo = Convert.ToString(Contrapoyo);
            promedio.Text = Convert.ToString(prom);
            lbldesarrollo.Text = contdes;
            lblesperado.Text = contespe;
            lblrequiereapoyo.Text = contrapo;
            MessageBox.Show("Obtuvo en esperado " + contespe + " , " + "en desarrollo " + contdes + " y " + contrapo + " en requiere apoyo");


        }
        private void utilizaconocimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void lenguajecomunicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void escribenombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void limpiar()
        {
            utilizaconocimiento.Text = "";
            lenguajecomunicacion.Text = "";
            escribenombre.Text = "";
            promedio.Text = "";
            nv.Text = "";
        }

        private void Evaluacion_Lenguaje_Comunicacion_Load(object sender, EventArgs e)
        {
            lblNomAl.Text = nombreAl;
            lblGradGrup.Text = gradGrup;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Evaluacion_Lenguaje_Comunicacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuEval forma = new MenuEval(nombreAl, gradGrup, id);
            forma.Show();
        }

    }
}
