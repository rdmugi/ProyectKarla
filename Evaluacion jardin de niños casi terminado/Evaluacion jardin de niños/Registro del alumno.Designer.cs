namespace Evaluacion_jardin_de_niños
{
    partial class Registro_del_alumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.curp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.apmat = new System.Windows.Forms.TextBox();
            this.combogenero = new System.Windows.Forms.ComboBox();
            this.appat = new System.Windows.Forms.TextBox();
            this.combogradogrupo = new System.Windows.Forms.ComboBox();
            this.nomalu = new System.Windows.Forms.TextBox();
            this.fechanac = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numtel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.registroalu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtfechingreso = new System.Windows.Forms.TextBox();
            this.txtnumlist = new System.Windows.Forms.TextBox();
            this.txtnacio = new System.Windows.Forms.TextBox();
            this.txtnombtut = new System.Windows.Forms.TextBox();
            this.txtdomtut = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // curp
            // 
            this.curp.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.curp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.curp.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.curp.ForeColor = System.Drawing.Color.White;
            this.curp.Location = new System.Drawing.Point(183, 83);
            this.curp.MaxLength = 18;
            this.curp.Name = "curp";
            this.curp.Size = new System.Drawing.Size(413, 26);
            this.curp.TabIndex = 1;
            this.curp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btncurp_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(118, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(118, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Curp:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(366, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "Edad:";
            // 
            // apmat
            // 
            this.apmat.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.apmat.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.apmat.ForeColor = System.Drawing.Color.White;
            this.apmat.Location = new System.Drawing.Point(287, 232);
            this.apmat.MaxLength = 15;
            this.apmat.Name = "apmat";
            this.apmat.Size = new System.Drawing.Size(309, 26);
            this.apmat.TabIndex = 4;
            this.apmat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apmat_KeyPress);
            // 
            // combogenero
            // 
            this.combogenero.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.combogenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combogenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combogenero.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.combogenero.ForeColor = System.Drawing.Color.White;
            this.combogenero.FormattingEnabled = true;
            this.combogenero.Items.AddRange(new object[] {
            "M",
            "F"});
            this.combogenero.Location = new System.Drawing.Point(183, 278);
            this.combogenero.Name = "combogenero";
            this.combogenero.Size = new System.Drawing.Size(163, 29);
            this.combogenero.TabIndex = 5;
            this.combogenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combogenero_KeyPress);
            // 
            // appat
            // 
            this.appat.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.appat.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.appat.ForeColor = System.Drawing.Color.White;
            this.appat.Location = new System.Drawing.Point(288, 181);
            this.appat.MaxLength = 30;
            this.appat.Name = "appat";
            this.appat.Size = new System.Drawing.Size(308, 26);
            this.appat.TabIndex = 3;
            this.appat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.appat_KeyPress);
            // 
            // combogradogrupo
            // 
            this.combogradogrupo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.combogradogrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combogradogrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combogradogrupo.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.combogradogrupo.ForeColor = System.Drawing.Color.White;
            this.combogradogrupo.FormattingEnabled = true;
            this.combogradogrupo.Items.AddRange(new object[] {
            "1A",
            "2A",
            "2B",
            "3A",
            "3B"});
            this.combogradogrupo.Location = new System.Drawing.Point(257, 328);
            this.combogradogrupo.Name = "combogradogrupo";
            this.combogradogrupo.Size = new System.Drawing.Size(89, 29);
            this.combogradogrupo.TabIndex = 7;
            this.combogradogrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combogrupo_KeyPress);
            // 
            // nomalu
            // 
            this.nomalu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nomalu.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.nomalu.ForeColor = System.Drawing.Color.White;
            this.nomalu.Location = new System.Drawing.Point(235, 131);
            this.nomalu.MaxLength = 30;
            this.nomalu.Name = "nomalu";
            this.nomalu.Size = new System.Drawing.Size(361, 26);
            this.nomalu.TabIndex = 2;
            this.nomalu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombrealumno_KeyPress);
            // 
            // fechanac
            // 
            this.fechanac.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.fechanac.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.fechanac.ForeColor = System.Drawing.Color.White;
            this.fechanac.Location = new System.Drawing.Point(501, 331);
            this.fechanac.Mask = "0000/00/00";
            this.fechanac.Name = "fechanac";
            this.fechanac.Size = new System.Drawing.Size(94, 26);
            this.fechanac.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(357, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "Fecha de Nac.:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(118, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 24);
            this.label12.TabIndex = 15;
            this.label12.Text = "Celular de tutor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(118, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Grado y Grupo:";
            // 
            // numtel
            // 
            this.numtel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.numtel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.numtel.ForeColor = System.Drawing.Color.White;
            this.numtel.Location = new System.Drawing.Point(279, 381);
            this.numtel.MaxLength = 10;
            this.numtel.Name = "numtel";
            this.numtel.Size = new System.Drawing.Size(317, 26);
            this.numtel.TabIndex = 9;
            this.numtel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numtel_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(118, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Apellido Materno:";
            // 
            // edad
            // 
            this.edad.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.edad.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.edad.ForeColor = System.Drawing.Color.White;
            this.edad.Location = new System.Drawing.Point(430, 281);
            this.edad.MaxLength = 1;
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(166, 26);
            this.edad.TabIndex = 6;
            this.edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(118, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido Paterno:";
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(162)))));
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Franklin Gothic Book", 14F, System.Drawing.FontStyle.Bold);
            this.Salir.ForeColor = System.Drawing.Color.White;
            this.Salir.Location = new System.Drawing.Point(386, 632);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(228, 39);
            this.Salir.TabIndex = 11;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(118, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre(s):";
            // 
            // registroalu
            // 
            this.registroalu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(162)))));
            this.registroalu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registroalu.Font = new System.Drawing.Font("Franklin Gothic Book", 14F, System.Drawing.FontStyle.Bold);
            this.registroalu.ForeColor = System.Drawing.Color.White;
            this.registroalu.Location = new System.Drawing.Point(122, 632);
            this.registroalu.Name = "registroalu";
            this.registroalu.Size = new System.Drawing.Size(226, 39);
            this.registroalu.TabIndex = 10;
            this.registroalu.Text = "Registrar";
            this.registroalu.UseVisualStyleBackColor = false;
            this.registroalu.Click += new System.EventHandler(this.registroalu_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(124, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "REGISTRO DE ALUMNO PARA EVALUACIÓN FINAL JARDIN DE NIÑOS BONIFACIO DÍAZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha de ingreso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(124, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "N° Lista:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(124, 496);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 24);
            this.label13.TabIndex = 18;
            this.label13.Text = "Nacionalidad:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(124, 534);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 24);
            this.label14.TabIndex = 19;
            this.label14.Text = "Nombre Tutor:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(124, 568);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 24);
            this.label15.TabIndex = 20;
            this.label15.Text = "Domicilio Tutor:";
            // 
            // txtfechingreso
            // 
            this.txtfechingreso.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtfechingreso.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechingreso.ForeColor = System.Drawing.Color.White;
            this.txtfechingreso.Location = new System.Drawing.Point(288, 429);
            this.txtfechingreso.Name = "txtfechingreso";
            this.txtfechingreso.Size = new System.Drawing.Size(307, 26);
            this.txtfechingreso.TabIndex = 22;
            // 
            // txtnumlist
            // 
            this.txtnumlist.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtnumlist.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumlist.ForeColor = System.Drawing.Color.White;
            this.txtnumlist.Location = new System.Drawing.Point(221, 465);
            this.txtnumlist.Name = "txtnumlist";
            this.txtnumlist.Size = new System.Drawing.Size(108, 26);
            this.txtnumlist.TabIndex = 23;
            // 
            // txtnacio
            // 
            this.txtnacio.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtnacio.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnacio.ForeColor = System.Drawing.Color.White;
            this.txtnacio.Location = new System.Drawing.Point(257, 496);
            this.txtnacio.Name = "txtnacio";
            this.txtnacio.Size = new System.Drawing.Size(338, 26);
            this.txtnacio.TabIndex = 24;
            // 
            // txtnombtut
            // 
            this.txtnombtut.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtnombtut.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombtut.ForeColor = System.Drawing.Color.White;
            this.txtnombtut.Location = new System.Drawing.Point(257, 538);
            this.txtnombtut.Name = "txtnombtut";
            this.txtnombtut.Size = new System.Drawing.Size(338, 26);
            this.txtnombtut.TabIndex = 25;
            // 
            // txtdomtut
            // 
            this.txtdomtut.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtdomtut.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdomtut.ForeColor = System.Drawing.Color.White;
            this.txtdomtut.Location = new System.Drawing.Point(279, 570);
            this.txtdomtut.Name = "txtdomtut";
            this.txtdomtut.Size = new System.Drawing.Size(316, 26);
            this.txtdomtut.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(637, 551);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "KHE PEDO";
            // 
            // Registro_del_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(801, 692);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtdomtut);
            this.Controls.Add(this.txtnombtut);
            this.Controls.Add(this.txtnacio);
            this.Controls.Add(this.txtnumlist);
            this.Controls.Add(this.txtfechingreso);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registroalu);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.numtel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.fechanac);
            this.Controls.Add(this.combogradogrupo);
            this.Controls.Add(this.combogenero);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.curp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.apmat);
            this.Controls.Add(this.appat);
            this.Controls.Add(this.nomalu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Registro_del_alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de alumno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registro_del_alumno_FormClosed);
            this.Load += new System.EventHandler(this.Registro_del_alumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox curp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox apmat;
        private System.Windows.Forms.ComboBox combogenero;
        private System.Windows.Forms.TextBox appat;
        private System.Windows.Forms.ComboBox combogradogrupo;
        private System.Windows.Forms.TextBox nomalu;
        private System.Windows.Forms.MaskedTextBox fechanac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox numtel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registroalu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtfechingreso;
        private System.Windows.Forms.TextBox txtnumlist;
        private System.Windows.Forms.TextBox txtnacio;
        private System.Windows.Forms.TextBox txtnombtut;
        private System.Windows.Forms.TextBox txtdomtut;
        private System.Windows.Forms.Label label16;

    }
}