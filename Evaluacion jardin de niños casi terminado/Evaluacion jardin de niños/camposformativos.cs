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
    public partial class camposformativos : Form
    {
        string[] rubLengCom = { "Lenguaje Oral.", "Lenguaje Escrito." };
        string[] rubPenMat = { "Número.", "Forma, Espacio y Medida." };
        string[] rubExpConMun = { "Mundo Natural.", "Cultura y Vida Social." };
        string[] rubDesFis = { "Coordinación, Fuerza y Equilibrio.", "Promoción de la Salud." };
        string[] rubDesper = { "Identidad Personal.", "Relaciones Interpersonales." };
        string[] rubExpApAr = { "Expresión y Apreción Musical.", "Expresión Corporal y Apreciación de la Danza.", "Expresión y Apreciación Visual.", "Expresión Dramática y Apreciación Teatral." };
        string[] allRubs = { "Lenguaje Oral.", "Lenguaje Escrito.", "Número.", "Forma, Espacio y Medida.", "Mundo Natural.", "Cultura y Vida Social.", "Coordinación, Fuerza y Equilibrio.", "Promoción de la Salud.", "Identidad Personal.", "Relaciones Interpersonales.", "Expresión y Apreción Musical.", "Expresión Corporal y Apreciación de la Danza.", "Expresión y Apreciación Visual.", "Expresión Dramática y Apreciación Teatral." };
        public camposformativos()
        {
            InitializeComponent();
            
        }

        private void camposformativos_Load(object sender, EventArgs e)
        {
        }

        private void cmbAsig_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCampFor.Items.Clear();
            cmbCampFor.Text = "";
            tbxRub.Clear();
            listBox1.Items.Clear();
            string op = "";
            op = cmbAsig.Text;
            switch (op) {
                case "Lenguaje y Comunicación.":
                    for (int i = 0; i < rubLengCom.Length; i++)
                {
                    cmbCampFor.Items.Add(rubLengCom[i]);
                }
                break;
            
        case "Pensamiento Matemático.":
                for (int i = 0; i < rubPenMat.Length; i++)
                {
                    cmbCampFor.Items.Add(rubPenMat[i]);
                }
            break;
        case "Exploración y Conocimiento del Mundo.":
            for (int i = 0; i < rubExpConMun.Length; i++)
            {
                cmbCampFor.Items.Add(rubExpConMun[i]);
            }
            break;
        case "Desarrollo Físico y Salud.":
            for (int i = 0; i < rubDesFis.Length; i++)
            {
                cmbCampFor.Items.Add(rubDesFis[i]);
            }
            break;
        case "Desarrollo Personal y Social.":
            for (int i = 0; i < rubDesper.Length; i++)
            {
                cmbCampFor.Items.Add(rubDesper[i]);
            }
            break;
        case "Expresion y Apreciación Artístiscas.":
            for (int i = 0; i < rubExpApAr.Length; i++)
            {
                cmbCampFor.Items.Add(rubExpApAr[i]);
            }
            break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(tbxRub.Text);
            tbxRub.Clear();
            tbxRub.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void camposformativos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_Principal forma = new Menu_Principal();
            forma.Show();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string op = cmbAsig.Text;
            try
            {
                int resultado = 0;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    Rubros pRubro = new Rubros();
                    pRubro.competencia = cmbCampFor.Text;
                    pRubro.subCompetencia = listBox1.Items[i].ToString();
                    resultado = RubAC.Agregar(pRubro, op);
                }
                if (resultado > 0)
                {
                    MessageBox.Show("Competencias Guardadas Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudieron guardar las competencias", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un error" + ex.Message);
            }
            cmbAsig.Items.Clear();
            cmbAsig.Text = "";
            cmbCampFor.Items.Clear();
            cmbCampFor.Text = "";
            tbxRub.Clear();
            listBox1.Items.Clear();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        }
    }

