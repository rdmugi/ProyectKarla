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
    public partial class EvalPenMat : Form
    {
        string nombreAl = "", gradGrup = "";
        int id = 0;
        int Identifica, Estrategia, Nombrarnum, Usaobjsimbnum, Proceso, Comprendeprob, Explicaprob;
        public EvalPenMat(string nombreAl, string gradGrup, int id)
        {
            InitializeComponent();
            this.nombreAl = nombreAl;
            this.gradGrup = gradGrup;
            this.id = id;
        }

        private void evaluar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(identielemen.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            if (string.IsNullOrEmpty(estrategias.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            if (string.IsNullOrEmpty(nombranum.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            if (string.IsNullOrEmpty(utilizaobjsimbnum.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }

            if (string.IsNullOrEmpty(procesos.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            if (string.IsNullOrEmpty(comprendeprobl.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            if (string.IsNullOrEmpty(explicaprob.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }

            Identifica = Convert.ToInt16(identielemen.Text);
            Estrategia = Convert.ToInt16(estrategias.Text);
            Nombrarnum = Convert.ToInt16(nombranum.Text);
            Usaobjsimbnum = Convert.ToInt16(utilizaobjsimbnum.Text);
            Proceso = Convert.ToInt16(procesos.Text);
            Comprendeprob = Convert.ToInt16(comprendeprobl.Text);
            Explicaprob = Convert.ToInt16(explicaprob.Text);

            MySqlConnection cn;
            try
            {
                cn = new MySqlConnection("server=127.0.0.1; port=3305; database=JardinBonifacioDiaz; Uid=root; pwd=root;");
                evaluapensamientomatematico(Identifica, Estrategia, Nombrarnum, Usaobjsimbnum, Proceso, Comprendeprob, Explicaprob);
                BoletaDePensamientoMatematico pPensamientoMatematico = new BoletaDePensamientoMatematico();
                pPensamientoMatematico.Nombre = lblNomAl.Text.Trim();
                pPensamientoMatematico.GradoyGrupo = lblGradGrup.Text.Trim();
                pPensamientoMatematico.Esperado = lblesperado.Text.Trim();
                pPensamientoMatematico.Desarrollo = lbldesarrollo.Text.Trim();
                pPensamientoMatematico.RequiereApoyo = lblrequiereapoyo.Text.Trim();
                pPensamientoMatematico.Resultado = nivel.Text.Trim();

                int resultado = BoletaDePensamientoMatematicoABC.Agregar(pPensamientoMatematico);

                if (resultado > 0)
                {
                    MessageBox.Show("Alumno Evaluado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo evaluar el alumno", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un error" + ex.Message);
            }
            MenuEval menu = new MenuEval(nombreAl, gradGrup,id);
            menu.Show();
            this.Hide();
        }

        private void identielemen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }

        private void estrategias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }

        private void nombranum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }

        private void utilizaobjsimbnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }

        private void procesos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }

        private void comprendeprobl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }

        private void explicaprob_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }

        private void limpiar()
        {
            identielemen.Text = "";
            estrategias.Text = "";
            nombranum.Text = "";
            utilizaobjsimbnum.Text = "";
            procesos.Text = "";
            comprendeprobl.Text = "";
            explicaprob.Text = "";

        }
        private void evaluapensamientomatematico(int ident, int estra, int nombnum, int utiobj, int proce, int comprende, int explic)
        {
            double prom = 0;
            int Contesperado = 0;
            int Contdesarrollo = 0;
            int Contrapoyo = 0;

            string contespe = "";
            string contdes = "";
            string contrapo = "";

            if (ident == 3)
            {
                Contesperado++;
            }
            else if (ident == 2)
            {
                Contdesarrollo++;
            }
            else if (ident == 1)
            {
                Contrapoyo++;
            }

            if (estra == 3)
            {
                Contesperado++;
            }
            else if (estra == 2)
            {
                Contdesarrollo++;
            }
            else if (estra == 1)
            {
                Contrapoyo++;
            }

            if (nombnum == 3)
            {
                Contesperado++;
            }
            else if (nombnum == 2)
            {
                Contdesarrollo++;
            }
            else if (nombnum == 1)
            {
                Contrapoyo++;
            }

            if (utiobj == 3)
            {
                Contesperado++;
            }
            else if (utiobj == 2)
            {
                Contdesarrollo++;
            }
            else if (utiobj == 1)
            {
                Contrapoyo++;
            }

            if (proce == 3)
            {
                Contesperado++;
            }
            else if (proce == 2)
            {
                Contdesarrollo++;
            }
            else if (proce == 1)
            {
                Contrapoyo++;
            }

            if (comprende == 3)
            {
                Contesperado++;
            }
            else if (comprende == 2)
            {
                Contdesarrollo++;
            }
            else if (comprende == 1)
            {
                Contrapoyo++;
            }

            if (explic == 3)
            {
                Contesperado++;
            }
            else if (explic == 2)
            {
                Contdesarrollo++;
            }
            else if (explic == 1)
            {
                Contrapoyo++;
            }

            prom = ((Convert.ToDouble(ident) + Convert.ToDouble(estra) + Convert.ToDouble(nombnum) + Convert.ToDouble(utiobj) + Convert.ToDouble(proce) + Convert.ToDouble(comprende) + Convert.ToDouble(explic)) / 7);

            if (prom <= 1.6)
            {
                MessageBox.Show("El Niño Requiere Apoyo");
                nivel.Text = "R.A";

            }
            if (prom <= 2.4 && prom >= 1.6)
            {
                MessageBox.Show("El Niño Esta En Desarrollo");
                nivel.Text = "Desarrollo";
            }
            if (prom <= 3 && prom >= 2.5)
            {

                MessageBox.Show("El Niño Esta En Esperado");
                nivel.Text = "Esperado";
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

        private void promedio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void EvalPenMat_Load(object sender, EventArgs e)
        {
            lblNomAl.Text = nombreAl;
            lblGradGrup.Text = gradGrup;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EvalPenMat_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuEval forma = new MenuEval(nombreAl,gradGrup, id);
            forma.Show();
        }

    }
}
