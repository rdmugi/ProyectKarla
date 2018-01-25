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
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;
namespace Evaluacion_jardin_de_niños
{
    public partial class ConsultaAlumnado : Form
    {
        public ConsultaAlumnado()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            MySqlConnection cn;
            try
            {
                
                cn = new MySqlConnection("server=127.0.0.1; port=3305; database=JardinBonifacioDiaz; Uid=root; pwd=root;");

                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Seleccione uno de los filtros.");
                }
                
                if (comboBox1.Text == "General")
                {
                    button1.Enabled = true;
                    MySqlDataAdapter da = new MySqlDataAdapter("Select IdAlumno, Curp, Nombre, Apellido_Paterno, Apellido_Materno, Genero, Edad , Grupo_y_Grado, Fecha_Nacimiento,Telefono from Alumno", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.tablaalumno.DataSource = dt;
                    cn.Clone();
                    
                }
                if (comboBox1.Text == "1A")
                {
                    button1.Enabled = true;
                    tablaalumno.DataSource = AlumnoABC.Buscargrupo(comboBox1.Text);
                }
                if (comboBox1.Text == "2A")
                {
                    button1.Enabled = true;
                    tablaalumno.DataSource = AlumnoABC.Buscargrupo(comboBox1.Text);
                }
                if (comboBox1.Text == "2B")
                {
                    button1.Enabled = true;
                    tablaalumno.DataSource = AlumnoABC.Buscargrupo(comboBox1.Text);
                }
                if (comboBox1.Text == "3A")
                {
                    button1.Enabled = true;
                    tablaalumno.DataSource = AlumnoABC.Buscargrupo(comboBox1.Text);
                }
                if (comboBox1.Text == "3B")
                {
                    button1.Enabled = true;
                    tablaalumno.DataSource = AlumnoABC.Buscargrupo(comboBox1.Text);
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un error" + ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
                       
            if (comboBox1.Text == "General")
            {
                
                
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("TablaAlumnos General.pdf", FileMode.Create));
                
                
                doc.Open();

                PdfPTable tabla = new PdfPTable(tablaalumno.Columns.Count);
                
                for (int j = 0; j < tablaalumno.Columns.Count; j++)
                {
                    tabla.AddCell(new Phrase(tablaalumno.Columns[j].HeaderText));
                }

                tabla.HeaderRows = 1;

                for (int i = 0; i < tablaalumno.Rows.Count; i++)
                {
                    for (int k = 0; k < tablaalumno.Columns.Count; k++)
                    {
                        if (tablaalumno[k, i].Value != null)
                        {
                            tabla.AddCell(new Phrase(tablaalumno[k, i].Value.ToString()));
                        }
                    }
                }

                doc.Add(tabla);
                MessageBox.Show("Se ha creado con éxito el PDF");
                doc.Close();
            }
            if (comboBox1.Text == "1A")
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("TablaAlumnos 1A.pdf", FileMode.Create));
                doc.Open();

                PdfPTable tabla = new PdfPTable(tablaalumno.Columns.Count);
                for (int j = 0; j < tablaalumno.Columns.Count; j++)
                {
                    tabla.AddCell(new Phrase(tablaalumno.Columns[j].HeaderText));
                }

                tabla.HeaderRows = 1;

                for (int i = 0; i < tablaalumno.Rows.Count; i++)
                {
                    for (int k = 0; k < tablaalumno.Columns.Count; k++)
                    {
                        if (tablaalumno[k, i].Value != null)
                        {
                            tabla.AddCell(new Phrase(tablaalumno[k, i].Value.ToString()));
                        }
                    }
                }

                doc.Add(tabla);
                MessageBox.Show("Se ha creado con éxito el PDF");
                doc.Close();
            }
            if (comboBox1.Text == "2A")
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("TablaAlumnos 2A.pdf", FileMode.Create));
                doc.Open();

                PdfPTable tabla = new PdfPTable(tablaalumno.Columns.Count);
                for (int j = 0; j < tablaalumno.Columns.Count; j++)
                {
                    tabla.AddCell(new Phrase(tablaalumno.Columns[j].HeaderText));
                }

                tabla.HeaderRows = 1;

                for (int i = 0; i < tablaalumno.Rows.Count; i++)
                {
                    for (int k = 0; k < tablaalumno.Columns.Count; k++)
                    {
                        if (tablaalumno[k, i].Value != null)
                        {
                            tabla.AddCell(new Phrase(tablaalumno[k, i].Value.ToString()));
                        }
                    }
                }

                doc.Add(tabla);
                MessageBox.Show("Se ha creado con éxito el PDF");
                doc.Close();
            }
            if (comboBox1.Text == "2B")
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("TablaAlumnos 2B.pdf", FileMode.Create));
                doc.Open();

                PdfPTable tabla = new PdfPTable(tablaalumno.Columns.Count);
                for (int j = 0; j < tablaalumno.Columns.Count; j++)
                {
                    tabla.AddCell(new Phrase(tablaalumno.Columns[j].HeaderText));
                }

                tabla.HeaderRows = 1;

                for (int i = 0; i < tablaalumno.Rows.Count; i++)
                {
                    for (int k = 0; k < tablaalumno.Columns.Count; k++)
                    {
                        if (tablaalumno[k, i].Value != null)
                        {
                            tabla.AddCell(new Phrase(tablaalumno[k, i].Value.ToString()));
                        }
                    }
                }

                doc.Add(tabla);
                MessageBox.Show("Se ha creado con éxito el PDF");
                doc.Close();
            }
            if (comboBox1.Text == "3A")
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("TablaAlumnos 3A.pdf", FileMode.Create));
                doc.Open();

                PdfPTable tabla = new PdfPTable(tablaalumno.Columns.Count);
                for (int j = 0; j < tablaalumno.Columns.Count; j++)
                {
                    tabla.AddCell(new Phrase(tablaalumno.Columns[j].HeaderText));
                }

                tabla.HeaderRows = 1;

                for (int i = 0; i < tablaalumno.Rows.Count; i++)
                {
                    for (int k = 0; k < tablaalumno.Columns.Count; k++)
                    {
                        if (tablaalumno[k, i].Value != null)
                        {
                            tabla.AddCell(new Phrase(tablaalumno[k, i].Value.ToString()));
                        }
                    }
                }

                doc.Add(tabla);
                MessageBox.Show("Se ha creado con éxito el PDF");
                doc.Close();
            }
            if (comboBox1.Text == "3B")
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("TablaAlumnos 3B.pdf", FileMode.Create));
                doc.Open();

                PdfPTable tabla = new PdfPTable(tablaalumno.Columns.Count);
                for (int j = 0; j < tablaalumno.Columns.Count; j++)
                {
                    tabla.AddCell(new Phrase(tablaalumno.Columns[j].HeaderText));
                }

                tabla.HeaderRows = 1;

                for (int i = 0; i < tablaalumno.Rows.Count; i++)
                {
                    for (int k = 0; k < tablaalumno.Columns.Count; k++)
                    {
                        if (tablaalumno[k, i].Value != null)
                        {
                            tabla.AddCell(new Phrase(tablaalumno[k, i].Value.ToString()));
                        }
                    }
                }

                doc.Add(tabla);
                MessageBox.Show("Se ha creado con éxito el PDF");
                doc.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultaAlumnado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_Principal forma = new Menu_Principal();
            forma.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Evaluacion_Alumnado evalua = new Evaluacion_Alumnado();
            evalua.Show();
            this.Hide();
        }

    }
}
