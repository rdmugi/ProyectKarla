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
    public partial class EvaluacionFisySal : Form
    {
        int Partecuerpo, Cangrejo, Reptar, Salticar, Saltarunpie, Saltardospies, Lanzarcachar, Botar, Equilibrio, Adelante, Atras, Derecha, Izquierda, Lejos, Cerca, Arribade, Abajode, Ritmo, Coordinafuervelequi;
        string nombreAl="", gradGrup="";
        int id=0;
        public EvaluacionFisySal(string nombreAl, string gradGrup, int id)
        {
            InitializeComponent();
            this.nombreAl = nombreAl;
            this.gradGrup = gradGrup;
            this.id = id;
        }
     
        private void pcuerpo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void cangrejo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void reptar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void salticar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void sltarunpie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void saltar2pies_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void lanzarcachar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void botar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void equilibrio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void adelante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void atras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void derecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void izquierda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void lejos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void cerca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void arribade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void abajode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void ritmo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void cordinamtv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
        private void evaluaralumno_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pcuerpo.Text))
            {
               MessageBox.Show("Debe completar la informacion");
               return;
            }
            if (string.IsNullOrEmpty(cangrejo.Text))
            {
               MessageBox.Show("Debe completar la informacion");
               return;
            }
            if (string.IsNullOrEmpty(reptar.Text))
            {
               MessageBox.Show("Debe completar la informacion");
               return;
            }
            if (string.IsNullOrEmpty(salticar.Text))
            {
               MessageBox.Show("Debe completar la informacion");
               return;
            }
            if (string.IsNullOrEmpty(sltarunpie.Text))
            {
               MessageBox.Show("Debe completar la informacion");
               return;
            }
            if (string.IsNullOrEmpty(saltar2pies.Text))
            {
               MessageBox.Show("Debe completar la informacion");
               return;
            }
            if (string.IsNullOrEmpty(lanzarcachar.Text))
            {
               MessageBox.Show("Debe completar la informacion");
               return;
            }
            if (string.IsNullOrEmpty(botar.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            if (string.IsNullOrEmpty(equilibrio.Text))
            {
               MessageBox.Show("Debe completar la informacion");
               return;
            }
            if (string.IsNullOrEmpty(adelante.Text))
            {
               MessageBox.Show("Debe completar la informacion");
               return;
            }
            if (string.IsNullOrEmpty(atras.Text))
            {
               MessageBox.Show("Debe completar la informacion");
               return;
            }
            if (string.IsNullOrEmpty(derecha.Text))
            {
               MessageBox.Show("Debe completar la informacion");
               return;
            }
            if (string.IsNullOrEmpty(izquierda.Text))
            {
               MessageBox.Show("Debe completar la informacion");
               return;
            }
            if (string.IsNullOrEmpty(lejos.Text))
            {
               MessageBox.Show("Debe completar la informacion");
               return;
            }
            if (string.IsNullOrEmpty(cerca.Text))
            {
               MessageBox.Show("Debe completar la informacion");
               return;
            }
            if (string.IsNullOrEmpty(arribade.Text))
            {
               MessageBox.Show("Debe completar la informacion");
               return;
            }
            if (string.IsNullOrEmpty(abajode.Text))
            {
               MessageBox.Show("Debe completar la informacion");
               return;
            }
            if (string.IsNullOrEmpty(ritmo.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            if (string.IsNullOrEmpty(cordinamtv.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }

            Partecuerpo = Convert.ToInt16(pcuerpo.Text);
            Cangrejo = Convert.ToInt16(cangrejo.Text);
            Reptar = Convert.ToInt16(reptar.Text);
            Salticar = Convert.ToInt16(salticar.Text);
            Saltarunpie = Convert.ToInt16(sltarunpie.Text);
            Saltardospies = Convert.ToInt16(saltar2pies.Text);
            Lanzarcachar = Convert.ToInt16(lanzarcachar.Text);
            Botar = Convert.ToInt16(botar.Text);
            Equilibrio = Convert.ToInt16(equilibrio.Text);
            Adelante = Convert.ToInt16(adelante.Text);
            Atras = Convert.ToInt16(atras.Text);
            Derecha = Convert.ToInt16(derecha.Text);
            Izquierda = Convert.ToInt16(izquierda.Text);
            Lejos = Convert.ToInt16(lejos.Text);
            Cerca = Convert.ToInt16(cerca.Text);
            Arribade = Convert.ToInt16(arribade.Text);
            Abajode = Convert.ToInt16(abajode.Text);
            Ritmo = Convert.ToInt16(ritmo.Text);
            Coordinafuervelequi = Convert.ToInt16(cordinamtv.Text);

            MySqlConnection cn;
            try
            {
                cn = new MySqlConnection("server=127.0.0.1; port=3305; database=JardinBonifacioDiaz; Uid=root; pwd=root;");
                evaluadesarrollofisico(Partecuerpo, Cangrejo, Reptar, Salticar, Saltarunpie, Saltardospies, Lanzarcachar, Botar, Equilibrio, Adelante, Atras, Derecha, Izquierda, Lejos, Cerca, Arribade, Abajode, Ritmo, Coordinafuervelequi);
                BoletaDeEducacionFisica pAlumno = new BoletaDeEducacionFisica();

                pAlumno.Nombre = lblNomAl.Text.Trim();
                pAlumno.GradoyGrupo = lblGradGrup.Text.Trim();
                pAlumno.Esperado = lblesperado.Text.Trim();
                pAlumno.Desarrollo = lbldesarrollo.Text.Trim();
                pAlumno.RequiereApoyo = lblrequiereapoyo.Text.Trim();
                pAlumno.Resultado = nivel.Text.Trim();
           

                int resultado = BoletaDeEducacionFisicaABC.Agregar(pAlumno);
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

            MenuEval menu = new MenuEval(nombreAl, gradGrup, id);
            menu.Show();
            this.Hide();
       }
        private void evaluadesarrollofisico (int pcuerpo, int cang, int rept, int salti, int saltunpie, int saltdospies, int lanzar, int bot, int equi, int adel, int atr, int der, int izq, int lej, int cer, int arrde, int abajde, int rit, int coord)
        {           
            double prom=0;
            int Contesperado = 0;
            int Contdesarrollo = 0;
            int Contrapoyo = 0;

            string contespe = "";
            string contdes = "";
            string contrapo = "";

            if (pcuerpo == 3)
            {
                Contesperado++;
            }
            else if (pcuerpo == 2)
            {
                Contdesarrollo++;
            }
            else if (pcuerpo == 1)
            {
                Contrapoyo++;
            }

            if (cang == 3)
            {
                Contesperado++;
            }
            else if (cang == 2)
            {
                Contdesarrollo++;
            }
            else if (cang == 1)
            {
                Contrapoyo++;
            }

            if (rept == 3)
            {
                Contesperado++;
            }
            else if (rept == 2)
            {
                Contdesarrollo++;
            }
            else if (rept == 1)
            {
                Contrapoyo++;
            }

            if (salti == 3)
            {
                Contesperado++;
            }
            else if (salti == 2)
            {
                Contdesarrollo++;
            }
            else if (salti == 1)
            {
                Contrapoyo++;
            }

            if (saltunpie == 3)
            {
                Contesperado++;
            }
            else if (saltunpie == 2)
            {
                Contdesarrollo++;
            }
            else if (saltunpie == 1)
            {
                Contrapoyo++;
            }

            if (saltdospies == 3)
            {
                Contesperado++;
            }
            else if (saltdospies == 2)
            {
                Contdesarrollo++;
            }
            else if (saltdospies == 1)
            {
                Contrapoyo++;
            }

            if (lanzar == 3)
            {
                Contesperado++;
            }
            else if (lanzar == 2)
            {
                Contdesarrollo++;
            }
            else if (lanzar == 1)
            {
                Contrapoyo++;
            }

            if (bot == 3)
            {
                Contesperado++;
            }
            else if (bot == 2)
            {
                Contdesarrollo++;
            }
            else if (bot == 1)
            {
                Contrapoyo++;
            }

            if (equi == 3)
            {
                Contesperado++;
            }
            else if (equi == 2)
            {
                Contdesarrollo++;
            }
            else if (equi == 1)
            {
                Contrapoyo++;
            }

            if (adel == 3)
            {
                Contesperado++;
            }
            else if (adel == 2)
            {
                Contdesarrollo++;
            }
            else if (adel == 1)
            {
                Contrapoyo++;
            }

            if (atr == 3)
            {
                Contesperado++;
            }
            else if (atr == 2)
            {
                Contdesarrollo++;
            }
            else if (atr == 1)
            {
                Contrapoyo++;
            }

            if (der == 3)
            {
                Contesperado++;
            }
            else if (der == 2)
            {
                Contdesarrollo++;
            }
            else if (der == 1)
            {
                Contrapoyo++;
            }

            if (izq == 3)
            {
                Contesperado++;
            }
            else if (izq == 2)
            {
                Contdesarrollo++;
            }
            else if (izq == 1)
            {
                Contrapoyo++;
            }

            if (lej == 3)
            {
                Contesperado++;
            }
            else if (lej == 2)
            {
                Contdesarrollo++;
            }
            else if (lej == 1)
            {
                Contrapoyo++;
            }

            if (cer == 3)
            {
                Contesperado++;
            }
            else if (cer == 2)
            {
                Contdesarrollo++;
            }
            else if (cer == 1)
            {
                Contrapoyo++;
            }

            if (arrde == 3)
            {
                Contesperado++;
            }
            else if (arrde == 2)
            {
                Contdesarrollo++;
            }
            else if (arrde == 1)
            {
                Contrapoyo++;
            }

            if (abajde == 3)
            {
                Contesperado++;
            }
            else if (abajde == 2)
            {
                Contdesarrollo++;
            }
            else if (abajde == 1)
            {
                Contrapoyo++;
            }

            if (rit == 3)
            {
                Contesperado++;
            }
            else if (rit == 2)
            {
                Contdesarrollo++;
            }
            else if (rit == 1)
            {
                Contrapoyo++;
            }

            if (coord == 3)
            {
                Contesperado++;
            }
            else if (coord == 2)
            {
                Contdesarrollo++;
            }
            else if (coord == 1)
            {
                Contrapoyo++;
            }

            prom = ((Convert.ToDouble(pcuerpo) + Convert.ToDouble(cang) + Convert.ToDouble(rept) + Convert.ToDouble(salti) + Convert.ToDouble(saltunpie) + Convert.ToDouble(saltdospies) + Convert.ToDouble(lanzar) + Convert.ToDouble(bot) + Convert.ToDouble(equi) + Convert.ToDouble(adel) + Convert.ToDouble(atr) + Convert.ToDouble(der) + Convert.ToDouble(izq) + Convert.ToDouble(lej) + Convert.ToDouble(cer) + Convert.ToDouble(arrde) + Convert.ToDouble(abajde) + Convert.ToDouble(rit) + Convert.ToDouble(coord)) / 19);
           
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
        private void limpiar()
        {
            pcuerpo.Text = "";
            cangrejo.Text = "";
            reptar.Text = "";
            salticar.Text = "";
            sltarunpie.Text = "";
            saltar2pies.Text = "";
            lanzarcachar.Text = "";
            botar.Text = "";
            equilibrio.Text = "";
            adelante.Text = "";
            atras.Text = "";
            derecha.Text = "";
            izquierda.Text = "";
            lejos.Text = "";
            cerca.Text = "";
            arribade.Text = "";
            abajode.Text = "";
            ritmo.Text = "";
            cordinamtv.Text = "";
            promedio.Text = "";
            nivel.Text = "";
            
        }
        private void EvaluacionFisySal_Load(object sender, EventArgs e)
        {
            lblNomAl.Text = nombreAl;
            lblGradGrup.Text = gradGrup;
        }

        

    }
}
