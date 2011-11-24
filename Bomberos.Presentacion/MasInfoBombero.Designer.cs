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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.select_cargo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.dataGridResult = new System.Windows.Forms.DataGridView();
            this.HistorialPremios = new System.Windows.Forms.TabPage();
            this.HistorialCursos = new System.Windows.Forms.TabPage();
            this.ResumenListas = new System.Windows.Forms.TabPage();
            this.Servicio = new System.Windows.Forms.TabPage();
            this.Observaciones = new System.Windows.Forms.TabPage();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.box_picture = new System.Windows.Forms.PictureBox();
            this.labelCargo = new System.Windows.Forms.Label();
            this.labelTIB = new System.Windows.Forms.Label();
            this.labelRut = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.btn_actual = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_premio = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_observacion = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimeTermino = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEntrega = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_curso = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabBox.SuspendLayout();
            this.HistorialCargos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            this.HistorialPremios.SuspendLayout();
            this.HistorialCursos.SuspendLayout();
            this.Observaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            this.FichaMedica.Size = new System.Drawing.Size(602, 413);
            this.FichaMedica.TabIndex = 0;
            this.FichaMedica.Text = "Ficha Médica";
            this.FichaMedica.UseVisualStyleBackColor = true;
            // 
            // HistorialCargos
            // 
            this.HistorialCargos.Controls.Add(this.btn_actual);
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
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(421, 26);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(106, 23);
            this.btn_agregar.TabIndex = 7;
            this.btn_agregar.Text = "Agregar Cargo";
            this.btn_agregar.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cargo";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde";
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Location = new System.Drawing.Point(113, 76);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimeHasta.TabIndex = 2;
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Location = new System.Drawing.Point(113, 50);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDesde.TabIndex = 1;
            // 
            // dataGridResult
            // 
            this.dataGridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResult.Location = new System.Drawing.Point(23, 120);
            this.dataGridResult.Name = "dataGridResult";
            this.dataGridResult.Size = new System.Drawing.Size(557, 272);
            this.dataGridResult.TabIndex = 0;
            // 
            // HistorialPremios
            // 
            this.HistorialPremios.Controls.Add(this.dataGridView1);
            this.HistorialPremios.Controls.Add(this.btn_premio);
            this.HistorialPremios.Controls.Add(this.textBox1);
            this.HistorialPremios.Controls.Add(this.label6);
            this.HistorialPremios.Controls.Add(this.dateTimePicker2);
            this.HistorialPremios.Controls.Add(this.dateTimePicker1);
            this.HistorialPremios.Controls.Add(this.label5);
            this.HistorialPremios.Controls.Add(this.label4);
            this.HistorialPremios.Location = new System.Drawing.Point(4, 22);
            this.HistorialPremios.Name = "HistorialPremios";
            this.HistorialPremios.Padding = new System.Windows.Forms.Padding(3);
            this.HistorialPremios.Size = new System.Drawing.Size(602, 413);
            this.HistorialPremios.TabIndex = 1;
            this.HistorialPremios.Text = "Historial Premios";
            this.HistorialPremios.UseVisualStyleBackColor = true;
            // 
            // HistorialCursos
            // 
            this.HistorialCursos.Controls.Add(this.dataGridView3);
            this.HistorialCursos.Controls.Add(this.btn_curso);
            this.HistorialCursos.Controls.Add(this.comboBox1);
            this.HistorialCursos.Controls.Add(this.label11);
            this.HistorialCursos.Controls.Add(this.dateTimeEntrega);
            this.HistorialCursos.Controls.Add(this.dateTimeTermino);
            this.HistorialCursos.Controls.Add(this.dateTimeInicio);
            this.HistorialCursos.Controls.Add(this.label10);
            this.HistorialCursos.Controls.Add(this.label9);
            this.HistorialCursos.Controls.Add(this.label8);
            this.HistorialCursos.Location = new System.Drawing.Point(4, 22);
            this.HistorialCursos.Name = "HistorialCursos";
            this.HistorialCursos.Padding = new System.Windows.Forms.Padding(3);
            this.HistorialCursos.Size = new System.Drawing.Size(602, 413);
            this.HistorialCursos.TabIndex = 2;
            this.HistorialCursos.Text = "Historial Cursos";
            this.HistorialCursos.UseVisualStyleBackColor = true;
            // 
            // ResumenListas
            // 
            this.ResumenListas.Location = new System.Drawing.Point(4, 22);
            this.ResumenListas.Name = "ResumenListas";
            this.ResumenListas.Padding = new System.Windows.Forms.Padding(3);
            this.ResumenListas.Size = new System.Drawing.Size(602, 413);
            this.ResumenListas.TabIndex = 3;
            this.ResumenListas.Text = "Resumen Listas";
            this.ResumenListas.UseVisualStyleBackColor = true;
            // 
            // Servicio
            // 
            this.Servicio.Location = new System.Drawing.Point(4, 22);
            this.Servicio.Name = "Servicio";
            this.Servicio.Padding = new System.Windows.Forms.Padding(3);
            this.Servicio.Size = new System.Drawing.Size(602, 413);
            this.Servicio.TabIndex = 4;
            this.Servicio.Text = "Servicio";
            this.Servicio.UseVisualStyleBackColor = true;
            // 
            // Observaciones
            // 
            this.Observaciones.Controls.Add(this.dataGridView2);
            this.Observaciones.Controls.Add(this.txt_observacion);
            this.Observaciones.Controls.Add(this.textBox2);
            this.Observaciones.Controls.Add(this.label7);
            this.Observaciones.Controls.Add(this.dateTimeFecha);
            this.Observaciones.Location = new System.Drawing.Point(4, 22);
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Padding = new System.Windows.Forms.Padding(3);
            this.Observaciones.Size = new System.Drawing.Size(602, 413);
            this.Observaciones.TabIndex = 5;
            this.Observaciones.Text = "Observaciones";
            this.Observaciones.UseVisualStyleBackColor = true;
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
            // btn_actual
            // 
            this.btn_actual.Location = new System.Drawing.Point(319, 75);
            this.btn_actual.Name = "btn_actual";
            this.btn_actual.Size = new System.Drawing.Size(75, 23);
            this.btn_actual.TabIndex = 8;
            this.btn_actual.Text = "Actual";
            this.btn_actual.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha Califica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha Entrega";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(133, 47);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Por concepto de";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 76);
            this.textBox1.TabIndex = 5;
            // 
            // btn_premio
            // 
            this.btn_premio.Location = new System.Drawing.Point(410, 26);
            this.btn_premio.Name = "btn_premio";
            this.btn_premio.Size = new System.Drawing.Size(101, 23);
            this.btn_premio.TabIndex = 6;
            this.btn_premio.Text = "Agregar Premio";
            this.btn_premio.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 225);
            this.dataGridView1.TabIndex = 7;
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.Location = new System.Drawing.Point(123, 14);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFecha.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fecha";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 40);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 83);
            this.textBox2.TabIndex = 2;
            // 
            // txt_observacion
            // 
            this.txt_observacion.AutoSize = true;
            this.txt_observacion.Location = new System.Drawing.Point(39, 43);
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.Size = new System.Drawing.Size(78, 13);
            this.txt_observacion.TabIndex = 3;
            this.txt_observacion.Text = "Observaciones";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(21, 139);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(561, 256);
            this.dataGridView2.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Inicio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Termino";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Entrega";
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Location = new System.Drawing.Point(96, 16);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(200, 20);
            this.dateTimeInicio.TabIndex = 3;
            // 
            // dateTimeTermino
            // 
            this.dateTimeTermino.Location = new System.Drawing.Point(96, 42);
            this.dateTimeTermino.Name = "dateTimeTermino";
            this.dateTimeTermino.Size = new System.Drawing.Size(200, 20);
            this.dateTimeTermino.TabIndex = 4;
            // 
            // dateTimeEntrega
            // 
            this.dateTimeEntrega.Location = new System.Drawing.Point(96, 68);
            this.dateTimeEntrega.Name = "dateTimeEntrega";
            this.dateTimeEntrega.Size = new System.Drawing.Size(200, 20);
            this.dateTimeEntrega.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Curso";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // btn_curso
            // 
            this.btn_curso.Location = new System.Drawing.Point(401, 43);
            this.btn_curso.Name = "btn_curso";
            this.btn_curso.Size = new System.Drawing.Size(98, 23);
            this.btn_curso.TabIndex = 8;
            this.btn_curso.Text = "Agregar Curso";
            this.btn_curso.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(21, 130);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(560, 260);
            this.dataGridView3.TabIndex = 9;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MasInfoBombero_Load);
            this.tabBox.ResumeLayout(false);
            this.HistorialCargos.ResumeLayout(false);
            this.HistorialCargos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).EndInit();
            this.HistorialPremios.ResumeLayout(false);
            this.HistorialPremios.PerformLayout();
            this.HistorialCursos.ResumeLayout(false);
            this.HistorialCursos.PerformLayout();
            this.Observaciones.ResumeLayout(false);
            this.Observaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
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
        private System.Windows.Forms.Button btn_actual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_premio;
        private System.Windows.Forms.Label txt_observacion;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimeFecha;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btn_curso;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimeEntrega;
        private System.Windows.Forms.DateTimePicker dateTimeTermino;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;

    }
}