﻿namespace clinica
{
    partial class frmMenuPrincipalConsultorios
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipalConsultorios));
            pnlPanelPrincipal = new Panel();
            lblIngreso = new Label();
            btnVolver = new Button();
            btnAtencion = new Button();
            btnSalir = new Button();
            btnSalaDeEspera = new Button();
            btnAcreditacion = new Button();
            btnTurnos = new Button();
            btnInscripciones = new Button();
            pnlPanelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPanelPrincipal
            // 
            pnlPanelPrincipal.BackgroundImage = (Image)resources.GetObject("pnlPanelPrincipal.BackgroundImage");
            pnlPanelPrincipal.BackgroundImageLayout = ImageLayout.Stretch;
            pnlPanelPrincipal.BorderStyle = BorderStyle.FixedSingle;
            pnlPanelPrincipal.Controls.Add(lblIngreso);
            pnlPanelPrincipal.Controls.Add(btnVolver);
            pnlPanelPrincipal.Controls.Add(btnAtencion);
            pnlPanelPrincipal.Controls.Add(btnSalir);
            pnlPanelPrincipal.Controls.Add(btnSalaDeEspera);
            pnlPanelPrincipal.Controls.Add(btnAcreditacion);
            pnlPanelPrincipal.Controls.Add(btnTurnos);
            pnlPanelPrincipal.Controls.Add(btnInscripciones);
            pnlPanelPrincipal.Location = new Point(9, 8);
            pnlPanelPrincipal.Margin = new Padding(6);
            pnlPanelPrincipal.Name = "pnlPanelPrincipal";
            pnlPanelPrincipal.Size = new Size(572, 342);
            pnlPanelPrincipal.TabIndex = 8;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngreso.Location = new Point(4, 3);
            lblIngreso.Margin = new Padding(4, 0, 4, 0);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(50, 15);
            lblIngreso.TabIndex = 0;
            lblIngreso.Text = "Usuario:";
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderColor = Color.LightGray;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(497, 309);
            btnVolver.Margin = new Padding(6);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(68, 28);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAtencion
            // 
            btnAtencion.FlatAppearance.BorderColor = Color.LightGray;
            btnAtencion.FlatAppearance.BorderSize = 2;
            btnAtencion.FlatStyle = FlatStyle.Flat;
            btnAtencion.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAtencion.Location = new Point(409, 245);
            btnAtencion.Margin = new Padding(6);
            btnAtencion.Name = "btnAtencion";
            btnAtencion.Size = new Size(110, 30);
            btnAtencion.TabIndex = 10;
            btnAtencion.Text = "Atención";
            btnAtencion.UseVisualStyleBackColor = true;
            btnAtencion.Click += btnAtencion_Click;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderColor = Color.LightGray;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(506, 3);
            btnSalir.Margin = new Padding(6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(60, 28);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnSalaDeEspera
            // 
            btnSalaDeEspera.FlatAppearance.BorderColor = Color.LightGray;
            btnSalaDeEspera.FlatAppearance.BorderSize = 2;
            btnSalaDeEspera.FlatStyle = FlatStyle.Flat;
            btnSalaDeEspera.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalaDeEspera.Location = new Point(226, 290);
            btnSalaDeEspera.Margin = new Padding(6);
            btnSalaDeEspera.Name = "btnSalaDeEspera";
            btnSalaDeEspera.Size = new Size(120, 30);
            btnSalaDeEspera.TabIndex = 9;
            btnSalaDeEspera.Text = "Sala de Espera";
            btnSalaDeEspera.UseVisualStyleBackColor = true;
            btnSalaDeEspera.Click += btnSalaDeEspera_Click;
            // 
            // btnAcreditacion
            // 
            btnAcreditacion.FlatAppearance.BorderColor = Color.LightGray;
            btnAcreditacion.FlatAppearance.BorderSize = 2;
            btnAcreditacion.FlatStyle = FlatStyle.Flat;
            btnAcreditacion.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAcreditacion.Location = new Point(288, 245);
            btnAcreditacion.Margin = new Padding(6);
            btnAcreditacion.Name = "btnAcreditacion";
            btnAcreditacion.Size = new Size(110, 30);
            btnAcreditacion.TabIndex = 8;
            btnAcreditacion.Text = "Acreditación";
            btnAcreditacion.UseVisualStyleBackColor = true;
            btnAcreditacion.Click += btnAcreditacion_Click;
            // 
            // btnTurnos
            // 
            btnTurnos.FlatAppearance.BorderColor = Color.LightGray;
            btnTurnos.FlatAppearance.BorderSize = 2;
            btnTurnos.FlatStyle = FlatStyle.Flat;
            btnTurnos.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTurnos.Location = new Point(55, 245);
            btnTurnos.Margin = new Padding(6);
            btnTurnos.Name = "btnTurnos";
            btnTurnos.Size = new Size(110, 30);
            btnTurnos.TabIndex = 7;
            btnTurnos.Text = "Turnos";
            btnTurnos.UseVisualStyleBackColor = true;
            btnTurnos.Click += btnTurnos_Click;
            // 
            // btnInscripciones
            // 
            btnInscripciones.FlatAppearance.BorderColor = Color.LightGray;
            btnInscripciones.FlatAppearance.BorderSize = 2;
            btnInscripciones.FlatStyle = FlatStyle.Flat;
            btnInscripciones.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnInscripciones.Location = new Point(172, 245);
            btnInscripciones.Margin = new Padding(6);
            btnInscripciones.Name = "btnInscripciones";
            btnInscripciones.Size = new Size(110, 30);
            btnInscripciones.TabIndex = 6;
            btnInscripciones.Text = "Registro";
            btnInscripciones.UseVisualStyleBackColor = true;
            btnInscripciones.Click += btnInscripciones_Click;
            // 
            // frmMenuPrincipalConsultorios
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 359);
            Controls.Add(pnlPanelPrincipal);
            Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "frmMenuPrincipalConsultorios";
            Text = "Menú Principal - Consultorios Externos";
            Load += frmPrincipal_Load;
            pnlPanelPrincipal.ResumeLayout(false);
            pnlPanelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlPanelPrincipal;
        private Button btnVolver;
        private Button btnAtencion;
        private Button btnSalir;
        private Button btnSalaDeEspera;
        private Button btnAcreditacion;
        private Button btnTurnos;
        private Button btnInscripciones;
        private Label lblIngreso;
    }
}
