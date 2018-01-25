using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Evaluacion_jardin_de_niños
{
    public partial class Login : Form
    {
        MySqlConnection cn = new MySqlConnection("server=127.0.0.1; port=3305; database=JardinBonifacioDiaz; Uid=root; pwd=root;");
        MySqlCommand cmd = new MySqlCommand();
        int i;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
            txtusuario.Focus();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            i = 0;
            cn.Open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Login where Usuario ='" + txtusuario.Text + "' and Contraseña ='" + txtpassword.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (txtpassword.Text != "" && txtusuario.Text != "")
            {
                if (i == 0)
                {
                    MessageBox.Show("Ha ingresado un usuario o contraseña invalido");
                    txtpassword.Clear();
                    txtusuario.Clear();
                    txtusuario.Focus();
                }
                else
                {
                    MessageBox.Show("Bienvenido");
                    Menu_Principal forma = new Menu_Principal();
                    forma.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Rellene ambos campos.");
                txtpassword.Clear();
                txtusuario.Clear();
                txtusuario.Focus();
            }
            cn.Close();
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            txtusuario.Focus();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
