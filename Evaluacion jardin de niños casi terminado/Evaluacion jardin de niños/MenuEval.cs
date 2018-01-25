using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Evaluacion_jardin_de_niños
{
    public partial class MenuEval : Form
    {
        string nombreAl = "", gradGrup = "";
        int id = 0;
        public MenuEval(string nombreAl, string gradGrup, int id)
        {
            InitializeComponent();
            this.nombreAl = nombreAl;
            this.gradGrup = gradGrup;
            this.id = id;
        }
        public MenuEval()
        {
        }
        public static class Util
        {
            public enum Effect { Roll, Slide, Center, Blend }

            public static void Animate(Control ctl, Effect effect, int msec, int angle)
            {
                int flags = effmap[(int)effect];
                if (ctl.Visible) { flags |= 0x10000; angle += 180; }
                else
                {
                    if (ctl.TopLevelControl == ctl) flags |= 0x20000;
                    else if (effect == Effect.Blend) throw new ArgumentException();
                }
                flags |= dirmap[(angle % 360) / 45];
                bool ok = AnimateWindow(ctl.Handle, msec, flags);
                if (!ok) throw new Exception("Animation failed");
                ctl.Visible = !ctl.Visible;
            }

            private static int[] dirmap = { 1, 5, 4, 6, 2, 10, 8, 9 };
            private static int[] effmap = { 0, 0x40000, 0x10, 0x80000 };

            [DllImport("user32.dll")]
            private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);
        }

        private void evwin_Load(object sender, EventArgs e)
        {
            
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLenycom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelPenMat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLenycom_MouseHover(object sender, EventArgs e)
        {

        }

        private void panelLenycom_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLengYCom_Click(object sender, EventArgs e)
        {

        }

        private void btmPenMat_Click(object sender, EventArgs e)
        {

        }

        private void btnLengYCom_MouseHover(object sender, EventArgs e)
        {
            if (panelSubMen.Visible == false)
            {
                panelExploConMun.Visible = false;
                panelDesFisSal.Visible = false;
                panelDesPerSoc.Visible = false;
                panelExpApreArt.Visible = false;
                panelPenMat.Visible = false;
                panelLenycom.Visible = true;
                Util.Animate(panelSubMen, Util.Effect.Slide, 150, 360);
            }
            else
            {
                Util.Animate(panelSubMen, Util.Effect.Slide, 150, 360);
                panelExploConMun.Visible = false;
                panelDesFisSal.Visible = false;
                panelDesPerSoc.Visible = false;
                panelExpApreArt.Visible = false;
                panelPenMat.Visible = false;
                panelLenycom.Visible = true;
                Util.Animate(panelSubMen, Util.Effect.Slide, 150, 360);
            }
        }

        private void btmPenMat_MouseHover(object sender, EventArgs e)
        {
            if (panelSubMen.Visible == false)
            {
                panelExploConMun.Visible = false;
                panelDesFisSal.Visible = false;
                panelDesPerSoc.Visible = false;
                panelPenMat.Visible = true;
                panelLenycom.Visible = false;
                panelExpApreArt.Visible = false;
                Util.Animate(panelSubMen, Util.Effect.Slide, 150, 360);
            }
            else
            {
                Util.Animate(panelSubMen, Util.Effect.Slide, 150, 360);
                panelExploConMun.Visible = false;
                panelDesFisSal.Visible = false;
                panelDesPerSoc.Visible = false;
                panelPenMat.Visible = true;
                panelLenycom.Visible = false;
                panelExpApreArt.Visible = false;
                Util.Animate(panelSubMen, Util.Effect.Slide, 150, 360);
            }
        }

        private void btnExYConMun_MouseHover(object sender, EventArgs e)
        {
            if (panelSubMen.Visible == false)
            {
                panelExploConMun.Visible = true;
                panelDesFisSal.Visible = false;
                panelDesPerSoc.Visible = false;
                panelPenMat.Visible = false;
                panelLenycom.Visible = false;
                panelExpApreArt.Visible = false;
                Util.Animate(panelSubMen, Util.Effect.Slide, 150, 360);
            }
            else
            {
                Util.Animate(panelSubMen, Util.Effect.Slide, 150, 360);
                panelExploConMun.Visible = true;
                panelDesFisSal.Visible = false;
                panelDesPerSoc.Visible = false;
                panelPenMat.Visible = false;
                panelLenycom.Visible = false;
                panelExpApreArt.Visible = false;
                Util.Animate(panelSubMen, Util.Effect.Slide, 150, 360);
            }
        }

        private void btnDesFisSal_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDesFisSal_MouseHover(object sender, EventArgs e)
        {
            if (panelSubMen.Visible == false)
            {
                panelExploConMun.Visible = false;
                panelDesFisSal.Visible = true;
                panelDesPerSoc.Visible = false;
                panelPenMat.Visible = false;
                panelLenycom.Visible = false;
                panelExpApreArt.Visible = false;
                Util.Animate(panelSubMen, Util.Effect.Slide, 150, 360);
            }
            else
            {
                Util.Animate(panelSubMen, Util.Effect.Slide, 150, 360);
                panelExploConMun.Visible = false;
                panelDesFisSal.Visible = true;
                panelDesPerSoc.Visible = false;
                panelPenMat.Visible = false;
                panelLenycom.Visible = false;
                panelExpApreArt.Visible = false;
                Util.Animate(panelSubMen, Util.Effect.Slide, 150, 360);
            }
        }

        private void btnDesPerSoc_MouseHover(object sender, EventArgs e)
        {
            if (panelSubMen.Visible == false)
            {
                panelExploConMun.Visible = false;
                panelDesFisSal.Visible = false;
                panelDesPerSoc.Visible = true;
                panelPenMat.Visible = false;
                panelLenycom.Visible = false;
                panelExpApreArt.Visible = false;
                Util.Animate(panelSubMen, Util.Effect.Slide, 150, 360);
            }
            else
            {
                Util.Animate(panelSubMen, Util.Effect.Slide, 150, 360);
                panelExploConMun.Visible = false;
                panelDesFisSal.Visible = false;
                panelDesPerSoc.Visible = true;
                panelPenMat.Visible = false;
                panelLenycom.Visible = false;
                panelExpApreArt.Visible = false;
                Util.Animate(panelSubMen, Util.Effect.Slide, 150, 360);
            }
        }

        private void btnExpApArt_Click(object sender, EventArgs e)
        {

        }

        private void btnExpApArt_MouseHover(object sender, EventArgs e)
        {
            if (panelSubMen.Visible == false)
            {
                panelExploConMun.Visible = false;
                panelDesFisSal.Visible = false;
                panelDesPerSoc.Visible = false;
                panelPenMat.Visible = false;
                panelLenycom.Visible = false;
                panelExpApreArt.Visible = true;
                Util.Animate(panelSubMen, Util.Effect.Slide, 150, 360);
            }
            else
            {
                Util.Animate(panelSubMen, Util.Effect.Slide, 150, 360);
                panelExploConMun.Visible = false;
                panelDesFisSal.Visible = false;
                panelDesPerSoc.Visible = false;
                panelPenMat.Visible = false;
                panelLenycom.Visible = false;
                panelExpApreArt.Visible = true;
                Util.Animate(panelSubMen, Util.Effect.Slide, 150, 360);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDesPerSoc_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            EvalPenMat forma = new EvalPenMat(nombreAl,gradGrup, id);
            forma.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            EvaluacionFisySal forma = new EvaluacionFisySal(nombreAl, gradGrup, id);
            forma.Show();
            this.Hide();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlConnection cn = new MySqlConnection("server=127.0.0.1; port=3305; database=JardinBonifacioDiaz; Uid=root; pwd=root;");
            using (cn)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT SubCompetencia, Calificacion FROM LenguajeYcomunicacion WHERE Competencias = @Competencias", cn);
                cmd.Parameters.AddWithValue("@Competencias", "Lenguaje Oral.");
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            foreach (DataColumn column in dt.Columns)
            {
                dataGridView1.Columns.Add("","");
            }
            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row[0], row[1]);
            }
            dataGridView1.Columns[0].Width = 515;
            dataGridView1.Columns[0].HeaderCell.Value = "Competencia";
            dataGridView1.Columns[1].HeaderCell.Value = "Calificación";
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[1];
            dataGridView1.CurrentCell.Selected = true;
            dataGridView1.BeginEdit(true);
        }

        private void MenuEval_FormClosed(object sender, FormClosedEventArgs e)
        {
            Buscar_Alumno forma = new Buscar_Alumno();
            forma.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        void dText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 7 || e.KeyChar >= 10 && e.KeyChar <= 47 || e.KeyChar >= 52 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;

            dText.KeyPress -= new KeyPressEventHandler(dText_KeyPress);
            dText.KeyPress += new KeyPressEventHandler(dText_KeyPress);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }
    }
}
