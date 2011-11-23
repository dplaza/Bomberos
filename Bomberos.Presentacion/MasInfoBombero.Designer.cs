namespace Bomberos.Presentacion
{
    partial class MasInfoBombero
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
            this.tabBox = new System.Windows.Forms.TabControl();
            this.FichaMedica = new System.Windows.Forms.TabPage();
            this.HistorialCargos = new System.Windows.Forms.TabPage();
            this.HistorialPremios = new System.Windows.Forms.TabPage();
            this.HistorialCursos = new System.Windows.Forms.TabPage();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dataGridResult = new System.Windows.Forms.DataGridView();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.select_cargo = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.ResumenListas = new System.Windows.Forms.TabPage();
            this.Servicio = new System.Windows.Forms.TabPage();
            this.Observaciones = new System.Windows.Forms.TabPage();
            this.box_picture = new System.Windows.Forms.PictureBox();
            this.labelCargo = new System.Windows.Forms.Label();
            this.labelTIB = new System.Windows.Forms.Label();
            this.labelRut = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.tabBox.SuspendLayout();
            this.HistorialCargos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBox
            // 
            this.tabBox.Controls.Add(this.FichaMedica);
            this.tabBox.Controls.Add(this.HistorialCargos);
            this.tabBox.Controls.Add(this.HistorialPremios);
            this.tabBox.Controls.Add(this.HistorialCursos);
            this.tabBox.Controls.Add(this.ResumenListas);
            this.tabBox.Controls.Add(this.Servicio);
            this.tabBox.Controls.Add(this.Observaciones);
            this.tabBox.Location = new System.Drawing.Point(32, 122);
            this.tabBox.Name = "tabBox";
            this.tabBox.SelectedIndex = 0;
            this.tabBox.Size = new System.Drawing.Size(610, 439);
            this.tabBox.TabIndex = 0;
            // 
            // FichaMedica
            // 
            this.FichaMedica.Location = new System.Drawing.Point(4, 22);
            this.FichaMedica.Name = "FichaMedica";
            this.FichaMedica.Size = new System.Drawing.Size(547, 403);
            this.FichaMedica.TabIndex = 0;
            this.FichaMedica.Text = "Ficha Médica";
            this.FichaMedica.UseVisualStyleBackColor = true;
            // 
            // HistorialCargos
            // 
            this.HistorialCargos.Controls.Add(this.btn_agregar);
            this.HistorialCargos.Controls.Add(this.select_cargo);
            this.HistorialCargos.Controls.Add(this.label3);
            this.HistorialCargos.Controls.Add(this.label2);
            this.HistorialCargos.Controls.Add(this.label1);
            this.HistorialCargos.Controls.Add(this.dateTimeHasta);
            this.HistorialCargos.Controls.Add(this.dateTimeDesde);
            this.HistorialCargos.Controls.Add(this.dataGridResult);
            this.HistorialCargos.Location = new System.Drawing.Point(4, 22);
            this.HistorialCargos.Name = "HistorialCargos";
            this.HistorialCargos.Size = new System.Drawing.Size(602, 413);
            this.HistorialCargos.TabIndex = 0;
            this.HistorialCargos.Text = "Historial Cargos";
            this.HistorialCargos.UseVisualStyleBackColor = true;
            this.HistorialCargos.Click += new System.EventHandler(this.HistorialCargos_Click);
            // 
            // HistorialPremios
            // 
            this.HistorialPremios.Location = new System.Drawing.Point(4, 22);
            this.HistorialPremios.Name = "HistorialPremios";
            this.HistorialPremios.Padding = new System.Windows.Forms.Padding(3);
            this.HistorialPremios.Size = new System.Drawing.Size(547, 403);
            this.HistorialPremios.TabIndex = 1;
            this.HistorialPremios.Text = "Historial Premios";
            this.HistorialPremios.UseVisualStyleBackColor = true;
            // 
            // HistorialCursos
            // 
            this.HistorialCursos.Location = new System.Drawing.Point(4, 22);
            this.HistorialCursos.Name = "HistorialCursos";
            this.HistorialCursos.Padding = new System.Windows.Forms.Padding(3);
            this.HistorialCursos.Size = new System.Drawing.Size(547, 403);
            this.HistorialCursos.TabIndex = 2;
            this.HistorialCursos.Text = "Historial Cursos";
            this.HistorialCursos.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(587, 585);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dataGridResult
            // 
            this.dataGridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResult.Location = new System.Drawing.Point(63, 122);
            this.dataGridResult.Name = "dataGridResult";
            this.dataGridResult.Size = new System.Drawing.Size(477, 241);
            this.dataGridResult.TabIndex = 0;
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Location = new System.Drawing.Point(113, 50);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDesde.TabIndex = 1;
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Location = new System.Drawing.Point(113, 76);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimeHasta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cargo";
            // 
            // select_cargo
            // 
            this.select_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_cargo.FormattingEnabled = true;
            this.select_cargo.Location = new System.Drawing.Point(113, 23);
            this.select_cargo.Name = "select_cargo";
            this.select_cargo.Size = new System.Drawing.Size(200, 21);
            this.select_cargo.TabIndex = 6;
            this.select_cargo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(380, 46);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(106, 23);
            this.btn_agregar.TabIndex = 7;
            this.btn_agregar.Text = "Agregar Cargo";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // ResumenListas
            // 
            this.ResumenListas.Location = new System.Drawing.Point(4, 22);
            this.ResumenListas.Name = "ResumenListas";
            this.ResumenListas.Padding = new System.Windows.Forms.Padding(3);
            this.ResumenListas.Size = new System.Drawing.Size(547, 403);
            this.ResumenListas.TabIndex = 3;
            this.ResumenListas.Text = "Resumen Listas";
            this.ResumenListas.UseVisualStyleBackColor = true;
            // 
            // Servicio
            // 
            this.Servicio.Location = new System.Drawing.Point(4, 22);
            this.Servicio.Name = "Servicio";
            this.Servicio.Padding = new System.Windows.Forms.Padding(3);
            this.Servicio.Size = new System.Drawing.Size(547, 403);
            this.Servicio.TabIndex = 4;
            this.Servicio.Text = "Servicio";
            this.Servicio.UseVisualStyleBackColor = true;
            // 
            // Observaciones
            // 
            this.Observaciones.Location = new System.Drawing.Point(4, 22);
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Padding = new System.Windows.Forms.Padding(3);
            this.Observaciones.Size = new System.Drawing.Size(602, 413);
            this.Observaciones.TabIndex = 5;
            this.Observaciones.Text = "Observaciones";
            this.Observaciones.UseVisualStyleBackColor = true;
            // 
            // box_picture
            // 
            this.box_picture.Location = new System.Drawing.Point(83, 14);
            this.box_picture.Name = "box_picture";
            this.box_picture.Size = new System.Drawing.Size(78, 88);
            this.box_picture.TabIndex = 2;
            this.box_picture.TabStop = false;
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Location = new System.Drawing.Point(184, 81);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(35, 13);
            this.labelCargo.TabIndex = 175;
            this.labelCargo.Text = "Cargo";
            // 
            // labelTIB
            // 
            this.labelTIB.AutoSize = true;
            this.labelTIB.Location = new System.Drawing.Point(184, 60);
            this.labelTIB.Name = "labelTIB";
            this.labelTIB.Size = new System.Drawing.Size(24, 13);
            this.labelTIB.TabIndex = 174;
            this.labelTIB.Text = "TIB";
            // 
            // labelRut
            // 
            this.labelRut.AutoSize = true;
            this.labelRut.Location = new System.Drawing.Point(184, 39);
            this.labelRut.Name = "labelRut";
            this.labelRut.Size = new System.Drawing.Size(30, 13);
            this.labelRut.TabIndex = 173;
            this.labelRut.Text = "RUT";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(184, 18);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(90, 13);
            this.labelnombre.TabIndex = 172;
            this.labelnombre.Text = "Nombre completo";
            // 
            // MasInfoBombero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 620);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.labelTIB);
            this.Controls.Add(this.labelRut);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.box_picture);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.tabBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MasInfoBombero";
            this.Load += new System.EventHandler(this.MasInfoBombero_Load);
            this.tabBox.ResumeLayout(false);
            this.HistorialCargos.ResumeLayout(false);
            this.HistorialCargos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabBox;
        private System.Windows.Forms.TabPage FichaMedica;
        private System.Windows.Forms.TabPage HistorialCargos;
        private System.Windows.Forms.TabPage HistorialPremios;
        private System.Windows.Forms.TabPage HistorialCursos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dataGridResult;
        private System.Windows.Forms.ComboBox select_cargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TabPage ResumenListas;
        private System.Windows.Forms.TabPage Servicio;
        private System.Windows.Forms.TabPage Observaciones;
        private System.Windows.Forms.PictureBox box_picture;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.Label labelTIB;
        private System.Windows.Forms.Label labelRut;
        private System.Windows.Forms.Label labelnombre;

    }
}