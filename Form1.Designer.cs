namespace PresupuestoHospital
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDepartamento = new Label();
            txtPresupuesto = new TextBox();
            btnRepartir = new Button();
            btnCerrar = new Button();
            lblPorcentaje = new Label();
            lblEmergencia = new Label();
            lblSuministros = new Label();
            lblAdministracion = new Label();
            lblLaboratorio = new Label();
            lblImagenesDiagnosticas = new Label();
            lblResultadoEmergencia = new Label();
            lblResultadoSuministros = new Label();
            lblResultadoAdministracion = new Label();
            lblResultadoLaboratorio = new Label();
            lblResultadoImagenes = new Label();
            lblPresupuestoHospital = new Label();
            lblPresupuestoResultado = new Label();
            lblCirugia = new Label();
            lblResultadoCirugia = new Label();
            lblPresupuesto = new Label();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDepartamento.Location = new Point(70, 82);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(153, 28);
            lblDepartamento.TabIndex = 0;
            lblDepartamento.Text = "Departamento";
            lblDepartamento.Click += lblDepartamento_Click;
            // 
            // txtPresupuesto
            // 
            txtPresupuesto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPresupuesto.Location = new Point(303, 25);
            txtPresupuesto.Margin = new Padding(3, 2, 3, 2);
            txtPresupuesto.Name = "txtPresupuesto";
            txtPresupuesto.Size = new Size(110, 26);
            txtPresupuesto.TabIndex = 1;
            // 
            // btnRepartir
            // 
            btnRepartir.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRepartir.Location = new Point(430, 358);
            btnRepartir.Margin = new Padding(3, 2, 3, 2);
            btnRepartir.Name = "btnRepartir";
            btnRepartir.Size = new Size(82, 27);
            btnRepartir.TabIndex = 2;
            btnRepartir.Text = "Repartir";
            btnRepartir.UseVisualStyleBackColor = true;
            btnRepartir.Click += btnRepartir_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(606, 358);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(82, 27);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPorcentaje.Location = new Point(257, 82);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(124, 28);
            lblPorcentaje.TabIndex = 4;
            lblPorcentaje.Text = "Asignación";
            lblPorcentaje.Click += lblPorcentaje_Click;
            // 
            // lblEmergencia
            // 
            lblEmergencia.AutoSize = true;
            lblEmergencia.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmergencia.Location = new Point(98, 138);
            lblEmergencia.Name = "lblEmergencia";
            lblEmergencia.Size = new Size(96, 21);
            lblEmergencia.TabIndex = 5;
            lblEmergencia.Text = "Emergencia";
            // 
            // lblSuministros
            // 
            lblSuministros.AutoSize = true;
            lblSuministros.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSuministros.Location = new Point(100, 208);
            lblSuministros.Name = "lblSuministros";
            lblSuministros.Size = new Size(98, 21);
            lblSuministros.TabIndex = 6;
            lblSuministros.Text = "Suministros";
            // 
            // lblAdministracion
            // 
            lblAdministracion.AutoSize = true;
            lblAdministracion.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdministracion.Location = new Point(98, 249);
            lblAdministracion.Name = "lblAdministracion";
            lblAdministracion.Size = new Size(123, 21);
            lblAdministracion.TabIndex = 7;
            lblAdministracion.Text = "Administracion";
            // 
            // lblLaboratorio
            // 
            lblLaboratorio.AutoSize = true;
            lblLaboratorio.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblLaboratorio.Location = new Point(100, 288);
            lblLaboratorio.Name = "lblLaboratorio";
            lblLaboratorio.Size = new Size(98, 21);
            lblLaboratorio.TabIndex = 8;
            lblLaboratorio.Text = "Laboratorio";
            // 
            // lblImagenesDiagnosticas
            // 
            lblImagenesDiagnosticas.AutoSize = true;
            lblImagenesDiagnosticas.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblImagenesDiagnosticas.Location = new Point(98, 322);
            lblImagenesDiagnosticas.Name = "lblImagenesDiagnosticas";
            lblImagenesDiagnosticas.Size = new Size(180, 21);
            lblImagenesDiagnosticas.TabIndex = 9;
            lblImagenesDiagnosticas.Text = "Imagenes Diagnosticas";
            // 
            // lblResultadoEmergencia
            // 
            lblResultadoEmergencia.AutoSize = true;
            lblResultadoEmergencia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoEmergencia.ForeColor = Color.ForestGreen;
            lblResultadoEmergencia.Location = new Point(313, 138);
            lblResultadoEmergencia.Name = "lblResultadoEmergencia";
            lblResultadoEmergencia.Size = new Size(38, 19);
            lblResultadoEmergencia.TabIndex = 10;
            lblResultadoEmergencia.Text = "30%";
            // 
            // lblResultadoSuministros
            // 
            lblResultadoSuministros.AutoSize = true;
            lblResultadoSuministros.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoSuministros.ForeColor = Color.ForestGreen;
            lblResultadoSuministros.Location = new Point(313, 208);
            lblResultadoSuministros.Name = "lblResultadoSuministros";
            lblResultadoSuministros.Size = new Size(38, 19);
            lblResultadoSuministros.TabIndex = 11;
            lblResultadoSuministros.Text = "15%";
            // 
            // lblResultadoAdministracion
            // 
            lblResultadoAdministracion.AutoSize = true;
            lblResultadoAdministracion.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoAdministracion.ForeColor = Color.ForestGreen;
            lblResultadoAdministracion.Location = new Point(313, 249);
            lblResultadoAdministracion.Name = "lblResultadoAdministracion";
            lblResultadoAdministracion.Size = new Size(38, 19);
            lblResultadoAdministracion.TabIndex = 12;
            lblResultadoAdministracion.Text = "25%";
            // 
            // lblResultadoLaboratorio
            // 
            lblResultadoLaboratorio.AutoSize = true;
            lblResultadoLaboratorio.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoLaboratorio.ForeColor = Color.ForestGreen;
            lblResultadoLaboratorio.Location = new Point(313, 288);
            lblResultadoLaboratorio.Name = "lblResultadoLaboratorio";
            lblResultadoLaboratorio.Size = new Size(30, 19);
            lblResultadoLaboratorio.TabIndex = 13;
            lblResultadoLaboratorio.Text = "5%";
            // 
            // lblResultadoImagenes
            // 
            lblResultadoImagenes.AutoSize = true;
            lblResultadoImagenes.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoImagenes.ForeColor = Color.ForestGreen;
            lblResultadoImagenes.Location = new Point(313, 322);
            lblResultadoImagenes.Name = "lblResultadoImagenes";
            lblResultadoImagenes.Size = new Size(30, 19);
            lblResultadoImagenes.TabIndex = 14;
            lblResultadoImagenes.Text = "7%";
            // 
            // lblPresupuestoHospital
            // 
            lblPresupuestoHospital.AutoSize = true;
            lblPresupuestoHospital.Font = new Font("Times New Roman", 17.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPresupuestoHospital.Location = new Point(20, 25);
            lblPresupuestoHospital.Name = "lblPresupuestoHospital";
            lblPresupuestoHospital.Size = new Size(250, 26);
            lblPresupuestoHospital.TabIndex = 15;
            lblPresupuestoHospital.Text = "Presupuesto del Hospital";
            lblPresupuestoHospital.Click += lblPresupuestoHospital_Click;
            // 
            // lblPresupuestoResultado
            // 
            lblPresupuestoResultado.AutoSize = true;
            lblPresupuestoResultado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPresupuestoResultado.Location = new Point(507, 57);
            lblPresupuestoResultado.Name = "lblPresupuestoResultado";
            lblPresupuestoResultado.Size = new Size(0, 20);
            lblPresupuestoResultado.TabIndex = 16;
            lblPresupuestoResultado.Click += lblPresupuesto_Click;
            // 
            // lblCirugia
            // 
            lblCirugia.AutoSize = true;
            lblCirugia.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCirugia.Location = new Point(100, 171);
            lblCirugia.Name = "lblCirugia";
            lblCirugia.Size = new Size(63, 21);
            lblCirugia.TabIndex = 17;
            lblCirugia.Text = "Cirugia";
            // 
            // lblResultadoCirugia
            // 
            lblResultadoCirugia.AutoSize = true;
            lblResultadoCirugia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoCirugia.ForeColor = Color.ForestGreen;
            lblResultadoCirugia.Location = new Point(313, 171);
            lblResultadoCirugia.Name = "lblResultadoCirugia";
            lblResultadoCirugia.Size = new Size(38, 19);
            lblResultadoCirugia.TabIndex = 18;
            lblResultadoCirugia.Text = "15%";
            // 
            // lblPresupuesto
            // 
            lblPresupuesto.AutoSize = true;
            lblPresupuesto.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            lblPresupuesto.Location = new Point(468, 25);
            lblPresupuesto.Name = "lblPresupuesto";
            lblPresupuesto.Size = new Size(121, 25);
            lblPresupuesto.TabIndex = 19;
            lblPresupuesto.Text = "Presupuesto";
            lblPresupuesto.Click += lblPresupuesto_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(518, 358);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(82, 27);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 396);
            Controls.Add(btnLimpiar);
            Controls.Add(lblPresupuesto);
            Controls.Add(lblResultadoCirugia);
            Controls.Add(lblCirugia);
            Controls.Add(lblPresupuestoResultado);
            Controls.Add(lblPresupuestoHospital);
            Controls.Add(lblResultadoImagenes);
            Controls.Add(lblResultadoLaboratorio);
            Controls.Add(lblResultadoAdministracion);
            Controls.Add(lblResultadoSuministros);
            Controls.Add(lblResultadoEmergencia);
            Controls.Add(lblImagenesDiagnosticas);
            Controls.Add(lblLaboratorio);
            Controls.Add(lblAdministracion);
            Controls.Add(lblSuministros);
            Controls.Add(lblEmergencia);
            Controls.Add(lblPorcentaje);
            Controls.Add(btnCerrar);
            Controls.Add(btnRepartir);
            Controls.Add(txtPresupuesto);
            Controls.Add(lblDepartamento);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDepartamento;
        private TextBox txtPresupuesto;
        private Button btnRepartir;
        private Button btnCerrar;
        private Label lblPorcentaje;
        private Label lblEmergencia;
        private Label lblSuministros;
        private Label lblAdministracion;
        private Label lblLaboratorio;
        private Label lblImagenesDiagnosticas;
        private Label lblResultadoEmergencia;
        private Label lblResultadoSuministros;
        private Label lblResultadoAdministracion;
        private Label lblResultadoLaboratorio;
        private Label lblResultadoImagenes;
        private Label lblPresupuestoHospital;
        private Label lblPresupuestoResultado;
        private Label lblCirugia;
        private Label lblResultadoCirugia;
        private Label lblPresupuesto;
        private Button btnLimpiar;
    }
}