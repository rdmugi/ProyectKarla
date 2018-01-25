using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System.IO;
namespace Evaluacion_jardin_de_niños
{
    public partial class Evaluacion_Alumnado : Form
    {
        public Evaluacion_Alumnado()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            MySqlConnection cn;
            try
            {

                cn = new MySqlConnection("server=127.0.0.1; port=3305; database=JardinBonifacioDiaz; Uid=root; pwd=root;");

                if (comboBox1.Text == "" && comboBox2.Text == "")
                {
                    MessageBox.Show("Seleccione un tipo de consulta");
                }

                if (comboBox1.Text == "Desarrollo Fisico y Salud" && comboBox2.Text == "General")
                {

                    MySqlDataAdapter da = new MySqlDataAdapter("Select Nombre,Grupo_y_Grado,Esperado,Desarrollo,Requiere_Apoyo,Resultado from Boletaeducacionfisica", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.tablaboletaalumnos.DataSource = dt;
                    cn.Clone();

                }
                if (comboBox1.Text == "Desarrollo Fisico y Salud" && comboBox2.Text == "1A")
                {
                    
                    MySqlDataAdapter da = new MySqlDataAdapter("Select Nombre,Esperado,Desarrollo,Requiere_Apoyo,Resultado from Boletaeducacionfisica where Grupo_y_Grado = '1A'", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.tablaboletaalumnos.DataSource = dt;
                    cn.Clone();
                }
                if (comboBox1.Text == "Desarrollo Fisico y Salud" && comboBox2.Text == "2A")
                {

                    
                    MySqlDataAdapter da = new MySqlDataAdapter("Select Nombre,Esperado,Desarrollo,Requiere_Apoyo,Resultado from Boletaeducacionfisica where Grupo_y_Grado = '2A'", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.tablaboletaalumnos.DataSource = dt;
                    cn.Clone();
                }
                if (comboBox1.Text == "Desarrollo Fisico y Salud" && comboBox2.Text == "2B")
                {

                    
                    MySqlDataAdapter da = new MySqlDataAdapter("Select Nombre,Esperado,Desarrollo,Requiere_Apoyo,Resultado from Boletaeducacionfisica where Grupo_y_Grado = '2B'", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.tablaboletaalumnos.DataSource = dt;
                    cn.Clone();
                }
                if (comboBox1.Text == "Desarrollo Fisico y Salud" && comboBox2.Text == "3A")
                {

                   
                    MySqlDataAdapter da = new MySqlDataAdapter("Select Nombre,Esperado,Desarrollo,Requiere_Apoyo,Resultado from Boletaeducacionfisica where Grupo_y_Grado = '3A'", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.tablaboletaalumnos.DataSource = dt;
                    cn.Clone();
                }
                if (comboBox1.Text == "Desarrollo Fisico y Salud" && comboBox2.Text == "3B")
                {
                                      
                    MySqlDataAdapter da = new MySqlDataAdapter("Select Nombre,Esperado,Desarrollo,Requiere_Apoyo,Resultado from Boletaeducacionfisica where Grupo_y_Grado = '3B'", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.tablaboletaalumnos.DataSource = dt;
                    cn.Clone();
                }
                if (comboBox1.Text == "Lenguaje y Comunicacion" && comboBox2.Text == "General")
                {

                    MySqlDataAdapter da = new MySqlDataAdapter("Select * from BoletaLenguajeYcomunicacion", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.tablaboletaalumnos.DataSource = dt;
                    cn.Clone();

                }
                if (comboBox1.Text == "Lenguaje y Comunicacion" && comboBox2.Text == "1A")
                {

                    MySqlDataAdapter da = new MySqlDataAdapter("Select Nombre,Esperado,Desarrollo,Requiere_Apoyo,Resultado from BoletaLenguajeYcomunicacion where Grado_y_Grupo = '1A'", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.tablaboletaalumnos.DataSource = dt;
                    cn.Clone();

                }
                if (comboBox1.Text == "Lenguaje y Comunicacion" && comboBox2.Text == "2A")
                {

                    MySqlDataAdapter da = new MySqlDataAdapter("Select Nombre,Esperado,Desarrollo,Requiere_Apoyo,Resultado from BoletaLenguajeYcomunicacion where Grado_y_Grupo = '2A'", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.tablaboletaalumnos.DataSource = dt;
                    cn.Clone();

                }
                if (comboBox1.Text == "Lenguaje y Comunicacion" && comboBox2.Text == "2B")
                {

                    MySqlDataAdapter da = new MySqlDataAdapter("Select Nombre,Esperado,Desarrollo,Requiere_Apoyo,Resultado from BoletaLenguajeYcomunicacion where Grado_y_Grupo = '2B'", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.tablaboletaalumnos.DataSource = dt;
                    cn.Clone();

                }
                if (comboBox1.Text == "Lenguaje y Comunicacion" && comboBox2.Text == "3A")
                {

                    MySqlDataAdapter da = new MySqlDataAdapter("Select Nombre,Esperado,Desarrollo,Requiere_Apoyo,Resultado from BoletaLenguajeYcomunicacion where Grado_y_Grupo = '3A'", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.tablaboletaalumnos.DataSource = dt;
                    cn.Clone();

                }
                if (comboBox1.Text == "Lenguaje y Comunicacion" && comboBox2.Text == "3B")
                {

                    MySqlDataAdapter da = new MySqlDataAdapter("Select Nombre,Esperado,Desarrollo,Requiere_Apoyo,Resultado from BoletaLenguajeYcomunicacion where Grado_y_Grupo = '3B'", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.tablaboletaalumnos.DataSource = dt;
                    cn.Clone();

                }
                if (comboBox1.Text == "Pensamiento Matematico" && comboBox2.Text == "General")
                {

                    MySqlDataAdapter da = new MySqlDataAdapter("Select * from BoletaPensamientoMatematico", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.tablaboletaalumnos.DataSource = dt;
                    cn.Clone();

                }
                if (comboBox1.Text == "Pensamiento Matematico" && comboBox2.Text == "1A")
                {

                    MySqlDataAdapter da = new MySqlDataAdapter("Select Nombre,Esperado,Desarrollo,Requiere_Apoyo,Resultado from BoletaPensamientoMatematico where Grado_y_Grupo = '1A'", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.tablaboletaalumnos.DataSource = dt;
                    cn.Clone();
                }
                if (comboBox1.Text == "Pensamiento Matematico" && comboBox2.Text == "2A")
                {

                    MySqlDataAdapter da = new MySqlDataAdapter("Select Nombre,Esperado,Desarrollo,Requiere_Apoyo,Resultado from BoletaPensamientoMatematico where Grado_y_Grupo = '2A'", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.tablaboletaalumnos.DataSource = dt;
                    cn.Clone();
                }
                if (comboBox1.Text == "Pensamiento Matematico" && comboBox2.Text == "2B")
                {

                    MySqlDataAdapter da = new MySqlDataAdapter("Select Nombre,Esperado,Desarrollo,Requiere_Apoyo,Resultado from BoletaPensamientoMatematico where Grado_y_Grupo = '2B'", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.tablaboletaalumnos.DataSource = dt;
                    cn.Clone();
                }
                if (comboBox1.Text == "Pensamiento Matematico" && comboBox2.Text == "3A")
                {

                    MySqlDataAdapter da = new MySqlDataAdapter("Select Nombre,Esperado,Desarrollo,Requiere_Apoyo,Resultado from BoletaPensamientoMatematico where Grado_y_Grupo = '3A'", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.tablaboletaalumnos.DataSource = dt;
                    cn.Clone();
                }
                if (comboBox1.Text == "Pensamiento Matematico" && comboBox2.Text == "3B")
                {

                    MySqlDataAdapter da = new MySqlDataAdapter("Select Nombre,Esperado,Desarrollo,Requiere_Apoyo,Resultado from BoletaPensamientoMatematico where Grado_y_Grupo = '3B'", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.tablaboletaalumnos.DataSource = dt;
                    cn.Clone();
                }

             }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un error" + ex.Message);
            }

        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Desarrollo Físico y Salud" && comboBox2.Text == "General")
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Tabla Boleta Desarrollo Fisico y Salud General.pdf", FileMode.Create));
                doc.Open();

                PdfPTable tabla = new PdfPTable(tablaboletaalumnos.Columns.Count);

                for (int j = 0; j < tablaboletaalumnos.Columns.Count; j++)
                {
                    tabla.AddCell(new Phrase(tablaboletaalumnos.Columns[j].HeaderText));
                }

                tabla.HeaderRows = 1;

                for (int i = 0; i < tablaboletaalumnos.Rows.Count; i++)
                {
                    for (int k = 0; k < tablaboletaalumnos.Columns.Count; k++)
                    {
                        if (tablaboletaalumnos[k, i].Value != null)
                        {
                            tabla.AddCell(new Phrase(tablaboletaalumnos[k, i].Value.ToString()));
                        }
                    }
                }

                doc.Add(tabla);
                MessageBox.Show("Se a creado con exito el PDF");
                doc.Close();
            }
            if (comboBox1.Text == "Desarrollo Fisico y Salud" && comboBox2.Text == "1A")
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Tabla Boleta Desarrollo Fisico y Salud 1A.pdf", FileMode.Create));
                doc.Open();

                PdfPTable tabla = new PdfPTable(tablaboletaalumnos.Columns.Count);
                for (int j = 0; j < tablaboletaalumnos.Columns.Count; j++)
                {
                    tabla.AddCell(new Phrase(tablaboletaalumnos.Columns[j].HeaderText));
                }

                tabla.HeaderRows = 1;

                for (int i = 0; i < tablaboletaalumnos.Rows.Count; i++)
                {
                    for (int k = 0; k < tablaboletaalumnos.Columns.Count; k++)
                    {
                        if (tablaboletaalumnos[k, i].Value != null)
                        {
                            tabla.AddCell(new Phrase(tablaboletaalumnos[k, i].Value.ToString()));
                        }
                    }
                }

                doc.Add(tabla);
                MessageBox.Show("Se a creado con exito el PDF");
                doc.Close();
            }
            if (comboBox1.Text == "Desarrollo Fisico y Salud" && comboBox2.Text == "2A")
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Tabla Boleta Desarrollo Fisico y Salud 2A.pdf", FileMode.Create));
                doc.Open();

                PdfPTable tabla = new PdfPTable(tablaboletaalumnos.Columns.Count);
                for (int j = 0; j < tablaboletaalumnos.Columns.Count; j++)
                {
                    tabla.AddCell(new Phrase(tablaboletaalumnos.Columns[j].HeaderText));
                }

                tabla.HeaderRows = 1;

                for (int i = 0; i < tablaboletaalumnos.Rows.Count; i++)
                {
                    for (int k = 0; k < tablaboletaalumnos.Columns.Count; k++)
                    {
                        if (tablaboletaalumnos[k, i].Value != null)
                        {
                            tabla.AddCell(new Phrase(tablaboletaalumnos[k, i].Value.ToString()));
                        }
                    }
                }

                doc.Add(tabla);
                MessageBox.Show("Se a creado con exito el PDF");
                doc.Close();
            }
            if (comboBox1.Text == "Desarrollo Fisico y Salud" && comboBox2.Text == "2B")
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Tabla Boleta Desarrollo Fisico y Salud 2B.pdf", FileMode.Create));
                doc.Open();

                PdfPTable tabla = new PdfPTable(tablaboletaalumnos.Columns.Count);
                for (int j = 0; j < tablaboletaalumnos.Columns.Count; j++)
                {
                    tabla.AddCell(new Phrase(tablaboletaalumnos.Columns[j].HeaderText));
                }

                tabla.HeaderRows = 1;

                for (int i = 0; i < tablaboletaalumnos.Rows.Count; i++)
                {
                    for (int k = 0; k < tablaboletaalumnos.Columns.Count; k++)
                    {
                        if (tablaboletaalumnos[k, i].Value != null)
                        {
                            tabla.AddCell(new Phrase(tablaboletaalumnos[k, i].Value.ToString()));
                        }
                    }
                }

                doc.Add(tabla);
                MessageBox.Show("Se a creado con exito el PDF");
                doc.Close();
            }
            if (comboBox1.Text == "Desarrollo Fisico y Salud" && comboBox2.Text == "3A")
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Tabla Desarrollo Fisico y Salud 3A.pdf", FileMode.Create));
                doc.Open();

                PdfPTable tabla = new PdfPTable(tablaboletaalumnos.Columns.Count);
                for (int j = 0; j < tablaboletaalumnos.Columns.Count; j++)
                {
                    tabla.AddCell(new Phrase(tablaboletaalumnos.Columns[j].HeaderText));
                }

                tabla.HeaderRows = 1;

                for (int i = 0; i < tablaboletaalumnos.Rows.Count; i++)
                {
                    for (int k = 0; k < tablaboletaalumnos.Columns.Count; k++)
                    {
                        if (tablaboletaalumnos[k, i].Value != null)
                        {
                            tabla.AddCell(new Phrase(tablaboletaalumnos[k, i].Value.ToString()));
                        }
                    }
                }

                doc.Add(tabla);
                MessageBox.Show("Se a creado con exito el PDF");
                doc.Close();
            }
            if (comboBox1.Text == "Desarrollo Fisico y Salud" && comboBox2.Text == "3B")
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Tabla Desarrollo Fisico y Salud 3B.pdf", FileMode.Create));
                doc.Open();

                PdfPTable tabla = new PdfPTable(tablaboletaalumnos.Columns.Count);
                for (int j = 0; j < tablaboletaalumnos.Columns.Count; j++)
                {
                    tabla.AddCell(new Phrase(tablaboletaalumnos.Columns[j].HeaderText));
                }

                tabla.HeaderRows = 1;

                for (int i = 0; i < tablaboletaalumnos.Rows.Count; i++)
                {
                    for (int k = 0; k < tablaboletaalumnos.Columns.Count; k++)
                    {
                        if (tablaboletaalumnos[k, i].Value != null)
                        {
                            tabla.AddCell(new Phrase(tablaboletaalumnos[k, i].Value.ToString()));
                        }
                    }
                }

                doc.Add(tabla);
                MessageBox.Show("Se a creado con exito el PDF");
                doc.Close();
            }
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Evaluacion_Alumnado_Load(object sender, EventArgs e)
        {

        }

        private void Evaluacion_Alumnado_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConsultaAlumnado forma = new ConsultaAlumnado();
            forma.Show();
        }
    }
}
