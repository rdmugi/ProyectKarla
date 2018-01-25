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
    public partial class Menu_Principal : Form
    {
        
        public Menu_Principal()
        {
            InitializeComponent();
        }
        public void RegresarAPrincipal()
        {
            this.Visible = true;
        }

        private void btnregal_Click(object sender, EventArgs e)
        {
            Registro_del_alumno forma= new Registro_del_alumno();
            forma.Show();
            this.Hide();
        }
   
        private void btnbusal_Click(object sender, EventArgs e)
        {
            Buscar_Alumno forma = new Buscar_Alumno();
            forma.Show();
            this.Hide();
        }

        private void consulta_Click(object sender, EventArgs e)
        {
            ConsultaAlumnado forma = new ConsultaAlumnado();
            forma.Show();
            this.Hide();
         
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login forma = new Login();
            forma.Show();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnAgrRub_Click(object sender, EventArgs e)
        {
            camposformativos forma = new camposformativos();
            forma.Show();
            this.Hide();
        }
    }
}
