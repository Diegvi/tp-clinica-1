﻿namespace clinica
{
    partial class frmTurnosConsultorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurnosConsultorios));
            pnlTurnos = new Panel();
            cbxProfesionales = new ComboBox();
            cbxPacientes = new ComboBox();
            lblProfesional = new Label();
            cbxEspecialidad = new ComboBox();
            btnVolver = new Button();
            label5 = new Label();
            lblTituloT = new Label();
            pnlTituloT = new Panel();
            btnAsignar = new Button();
            btnCancelar = new Button();
            btnRegistrarPaciente = new Button();
            label3 = new Label();
            grbMostrarTurnos = new GroupBox();
            rbtOcupados = new RadioButton();
            rbtDisponibles = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            lbxAgendaTurnos = new ListBox();
            lblFechaHasta = new Label();
            lblFechaDesde = new Label();
            dtpFechaHasta = new DateTimePicker();
            dtpFechaDesde = new DateTimePicker();
            lblEspecialidad = new Label();
            cbxHoraHasta = new ComboBox();
            cbxHoraDesde = new ComboBox();
            btnSalir = new Button();
            pnlTurnos.SuspendLayout();
            grbMostrarTurnos.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTurnos
            // 
            pnlTurnos.BackgroundImage = (Image)resources.GetObject("pnlTurnos.BackgroundImage");
            pnlTurnos.BorderStyle = BorderStyle.FixedSingle;
            pnlTurnos.Controls.Add(cbxProfesionales);
            pnlTurnos.Controls.Add(cbxPacientes);
            pnlTurnos.Controls.Add(lblProfesional);
            pnlTurnos.Controls.Add(cbxEspecialidad);
            pnlTurnos.Controls.Add(btnVolver);
            pnlTurnos.Controls.Add(label5);
            pnlTurnos.Controls.Add(lblTituloT);
            pnlTurnos.Controls.Add(pnlTituloT);
            pnlTurnos.Controls.Add(btnAsignar);
            pnlTurnos.Controls.Add(btnCancelar);
            pnlTurnos.Controls.Add(btnRegistrarPaciente);
            pnlTurnos.Controls.Add(label3);
            pnlTurnos.Controls.Add(grbMostrarTurnos);
            pnlTurnos.Controls.Add(label2);
            pnlTurnos.Controls.Add(label1);
            pnlTurnos.Controls.Add(lbxAgendaTurnos);
            pnlTurnos.Controls.Add(lblFechaHasta);
            pnlTurnos.Controls.Add(lblFechaDesde);
            pnlTurnos.Controls.Add(dtpFechaHasta);
            pnlTurnos.Controls.Add(dtpFechaDesde);
            pnlTurnos.Controls.Add(lblEspecialidad);
            pnlTurnos.Controls.Add(cbxHoraHasta);
            pnlTurnos.Controls.Add(cbxHoraDesde);
            pnlTurnos.Controls.Add(btnSalir);
            pnlTurnos.Location = new Point(36, 38);
            pnlTurnos.Name = "pnlTurnos";
            pnlTurnos.Size = new Size(1414, 839);
            pnlTurnos.TabIndex = 38;
           
            // 
            // cbxProfesionales
            // 
            cbxProfesionales.FormattingEnabled = true;
            cbxProfesionales.Location = new Point(528, 122);
            cbxProfesionales.Name = "cbxProfesionales";
            cbxProfesionales.Size = new Size(288, 40);
            cbxProfesionales.TabIndex = 85;
            // 
            // cbxPacientes
            // 
            cbxPacientes.FormattingEnabled = true;
            cbxPacientes.Location = new Point(216, 576);
            cbxPacientes.Name = "cbxPacientes";
            cbxPacientes.Size = new Size(327, 40);
            cbxPacientes.TabIndex = 84;
           
            // 
            // lblProfesional
            // 
            lblProfesional.AutoSize = true;
            lblProfesional.BackColor = Color.Transparent;
            lblProfesional.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            lblProfesional.Location = new Point(528, 86);
            lblProfesional.Name = "lblProfesional";
            lblProfesional.Size = new Size(130, 32);
            lblProfesional.TabIndex = 38;
            lblProfesional.Text = "Profesional";
            // 
            // cbxEspecialidad
            // 
            cbxEspecialidad.FormattingEnabled = true;
            cbxEspecialidad.Location = new Point(223, 122);
            cbxEspecialidad.Name = "cbxEspecialidad";
            cbxEspecialidad.Size = new Size(288, 40);
            cbxEspecialidad.TabIndex = 37;
            cbxEspecialidad.SelectedIndexChanged += cbxEspecialidad_SelectedIndexChanged;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ActiveCaption;
            btnVolver.FlatAppearance.BorderColor = Color.LightGray;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnVolver.Location = new Point(1121, 714);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(247, 59);
            btnVolver.TabIndex = 36;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label5.Location = new Point(835, 86);
            label5.Name = "label5";
            label5.Size = new Size(193, 32);
            label5.TabIndex = 34;
            label5.Text = "Listado de turnos";
            // 
            // lblTituloT
            // 
            lblTituloT.AutoSize = true;
            lblTituloT.BackColor = Color.Transparent;
            lblTituloT.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTituloT.Location = new Point(231, 2);
            lblTituloT.Name = "lblTituloT";
            lblTituloT.Size = new Size(501, 46);
            lblTituloT.TabIndex = 33;
            lblTituloT.Text = "Gestión de turnos Consultorios";
            // 
            // pnlTituloT
            // 
            pnlTituloT.BorderStyle = BorderStyle.FixedSingle;
            pnlTituloT.ForeColor = SystemColors.ActiveBorder;
            pnlTituloT.Location = new Point(223, 51);
            pnlTituloT.Name = "pnlTituloT";
            pnlTituloT.Size = new Size(927, 15);
            pnlTituloT.TabIndex = 29;
            // 
            // btnAsignar
            // 
            btnAsignar.BackColor = SystemColors.ActiveCaption;
            btnAsignar.FlatAppearance.BorderColor = Color.LightGray;
            btnAsignar.FlatStyle = FlatStyle.Flat;
            btnAsignar.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnAsignar.Location = new Point(416, 714);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(247, 59);
            btnAsignar.TabIndex = 32;
            btnAsignar.Text = "Asignar turno";
            btnAsignar.UseVisualStyleBackColor = false;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaption;
            btnCancelar.FlatAppearance.BorderColor = Color.LightGray;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnCancelar.Location = new Point(770, 714);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(247, 59);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar turno";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrarPaciente
            // 
            btnRegistrarPaciente.BackColor = SystemColors.ActiveCaption;
            btnRegistrarPaciente.FlatAppearance.BorderColor = Color.LightGray;
            btnRegistrarPaciente.FlatStyle = FlatStyle.Flat;
            btnRegistrarPaciente.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnRegistrarPaciente.Location = new Point(47, 714);
            btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            btnRegistrarPaciente.Size = new Size(247, 59);
            btnRegistrarPaciente.TabIndex = 30;
            btnRegistrarPaciente.Text = "Registrar nuevo Paciente";
            btnRegistrarPaciente.UseVisualStyleBackColor = false;
            btnRegistrarPaciente.Click += btnRegistrarPaciente_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label3.Location = new Point(211, 525);
            label3.Name = "label3";
            label3.Size = new Size(427, 32);
            label3.TabIndex = 29;
            label3.Text = "Seleccionar paciente para asignar turno";
            // 
            // grbMostrarTurnos
            // 
            grbMostrarTurnos.BackColor = Color.Transparent;
            grbMostrarTurnos.Controls.Add(rbtOcupados);
            grbMostrarTurnos.Controls.Add(rbtDisponibles);
            grbMostrarTurnos.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            grbMostrarTurnos.Location = new Point(211, 390);
            grbMostrarTurnos.Name = "grbMostrarTurnos";
            grbMostrarTurnos.Size = new Size(400, 78);
            grbMostrarTurnos.TabIndex = 26;
            grbMostrarTurnos.TabStop = false;
            grbMostrarTurnos.Text = "Mostrar turnos:";
            // 
            // rbtOcupados
            // 
            rbtOcupados.AutoSize = true;
            rbtOcupados.Location = new Point(229, 29);
            rbtOcupados.Name = "rbtOcupados";
            rbtOcupados.Size = new Size(148, 36);
            rbtOcupados.TabIndex = 1;
            rbtOcupados.Text = "Ocupados";
            rbtOcupados.UseVisualStyleBackColor = true;
            // 
            // rbtDisponibles
            // 
            rbtDisponibles.AutoSize = true;
            rbtDisponibles.Checked = true;
            rbtDisponibles.Location = new Point(24, 29);
            rbtDisponibles.Name = "rbtDisponibles";
            rbtDisponibles.Size = new Size(163, 36);
            rbtDisponibles.TabIndex = 0;
            rbtDisponibles.TabStop = true;
            rbtDisponibles.Text = "Disponibles";
            rbtDisponibles.UseVisualStyleBackColor = true;
            rbtDisponibles.CheckedChanged += rbtDisponibles_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label2.Location = new Point(416, 296);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 13;
            label2.Text = "Hora hasta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            label1.Location = new Point(218, 296);
            label1.Name = "label1";
            label1.Size = new Size(131, 32);
            label1.TabIndex = 12;
            label1.Text = "Hora desde";
            // 
            // lbxAgendaTurnos
            // 
            lbxAgendaTurnos.FormattingEnabled = true;
            lbxAgendaTurnos.Location = new Point(835, 122);
            lbxAgendaTurnos.Name = "lbxAgendaTurnos";
            lbxAgendaTurnos.Size = new Size(566, 484);
            lbxAgendaTurnos.TabIndex = 11;
            lbxAgendaTurnos.SelectedIndexChanged += lbxTurnos_SelectedIndexChanged;
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.BackColor = Color.Transparent;
            lblFechaHasta.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            lblFechaHasta.Location = new Point(556, 198);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(142, 32);
            lblFechaHasta.TabIndex = 10;
            lblFechaHasta.Text = "Fecha Hasta";
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.BackColor = Color.Transparent;
            lblFechaDesde.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            lblFechaDesde.Location = new Point(218, 198);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(144, 32);
            lblFechaDesde.TabIndex = 9;
            lblFechaDesde.Text = "Fecha Desde";
            lblFechaDesde.Click += lblFechaDesde_Click;
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.Location = new Point(528, 234);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(285, 39);
            dtpFechaHasta.TabIndex = 8;
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.Location = new Point(218, 234);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(285, 39);
            dtpFechaDesde.TabIndex = 7;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.BackColor = Color.Transparent;
            lblEspecialidad.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic);
            lblEspecialidad.Location = new Point(223, 85);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(143, 32);
            lblEspecialidad.TabIndex = 6;
            lblEspecialidad.Text = "Especialidad";
            // 
            // cbxHoraHasta
            // 
            cbxHoraHasta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxHoraHasta.FormattingEnabled = true;
            cbxHoraHasta.Items.AddRange(new object[] { "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "23:59" });
            cbxHoraHasta.Location = new Point(416, 333);
            cbxHoraHasta.Name = "cbxHoraHasta";
            cbxHoraHasta.Size = new Size(128, 40);
            cbxHoraHasta.TabIndex = 4;
            // 
            // cbxHoraDesde
            // 
            cbxHoraDesde.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxHoraDesde.FormattingEnabled = true;
            cbxHoraDesde.Items.AddRange(new object[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            cbxHoraDesde.Location = new Point(218, 333);
            cbxHoraDesde.Name = "cbxHoraDesde";
            cbxHoraDesde.Size = new Size(131, 40);
            cbxHoraDesde.TabIndex = 3;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveBorder;
            btnSalir.FlatAppearance.BorderColor = Color.LightGray;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic);
            btnSalir.Location = new Point(1157, 8);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(247, 59);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmTurnosConsultorios
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 880);
            Controls.Add(pnlTurnos);
            Name = "frmTurnosConsultorios";
            Text = "frmTurnosConsultorios";
            Load += frmTurnosConsultorios_Load;
            pnlTurnos.ResumeLayout(false);
            pnlTurnos.PerformLayout();
            grbMostrarTurnos.ResumeLayout(false);
            grbMostrarTurnos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTurnos;
        private Button btnVolver;
        private Label label5;
        private Label lblTituloT;
        private Panel pnlTituloT;
        private Button btnAsignar;
        private Button btnCancelar;
        private Button btnRegistrarPaciente;
        private Label label3;
        private GroupBox grbMostrarTurnos;
        private RadioButton rbtOcupados;
        private RadioButton rbtDisponibles;
        private Label label2;
        private Label label1;
        private ListBox lbxAgendaTurnos;
        private Label lblFechaHasta;
        private Label lblFechaDesde;
        private DateTimePicker dtpFechaHasta;
        private DateTimePicker dtpFechaDesde;
        private Label lblEspecialidad;
        private ComboBox cbxHoraHasta;
        private ComboBox cbxHoraDesde;
        private Button btnSalir;
        private ComboBox cbxEspecialidad;
        private Label lblProfesional;
        private ComboBox cbxPacientes;
        private ComboBox cbxProfesionales;
    }
}