namespace Bomberos.Presentacion
{
    partial class RegistroAsistencia
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_especialidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridResult = new System.Windows.Forms.DataGridView();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoLaboral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.txt_nombres);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_apellidos);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_especialidad);
            this.groupBox2.Location = new System.Drawing.Point(8, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 108);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bombero";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Año";
            this.label1.Click += new System.EventHandler(this.Año_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(74, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(88, 17);
            this.listBox1.TabIndex = 12;
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(74, 19);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(152, 20);
            this.txt_nombres.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "TIB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(312, 19);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(138, 20);
            this.txt_apellidos.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Apellidos";
            // 
            // txt_especialidad
            // 
            this.txt_especialidad.Location = new System.Drawing.Point(312, 57);
            this.txt_especialidad.Name = "txt_especialidad";
            this.txt_especialidad.Size = new System.Drawing.Size(138, 20);
            this.txt_especialidad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "LISTA MENSUAL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridResult);
            this.groupBox1.Location = new System.Drawing.Point(11, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 273);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados de búsqueda";
            // 
            // dataGridResult
            // 
            this.dataGridResult.AllowUserToAddRows = false;
            this.dataGridResult.AllowUserToDeleteRows = false;
            this.dataGridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombres,
            this.Apellidos,
            this.Rut,
            this.TIB,
            this.Compania,
            this.Especialidad,
            this.isAdmin,
            this.Profesion,
            this.EstadoCivil,
            this.Email,
            this.Celular,
            this.TelefonoLaboral});
            this.dataGridResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridResult.Location = new System.Drawing.Point(3, 16);
            this.dataGridResult.Name = "dataGridResult";
            this.dataGridResult.ReadOnly = true;
            this.dataGridResult.Size = new System.Drawing.Size(672, 254);
            this.dataGridResult.TabIndex = 0;
            this.dataGridResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridResult_CellContentClick_1);
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Mes";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 60;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Total Llamadas";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 60;
            // 
            // Rut
            // 
            this.Rut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Rut.DataPropertyName = "Rut";
            this.Rut.HeaderText = "Faltas";
            this.Rut.Name = "Rut";
            this.Rut.ReadOnly = true;
            this.Rut.Width = 50;
            // 
            // TIB
            // 
            this.TIB.DataPropertyName = "TIB";
            this.TIB.HeaderText = "Suspensiones";
            this.TIB.Name = "TIB";
            this.TIB.ReadOnly = true;
            this.TIB.Width = 75;
            // 
            // Compania
            // 
            this.Compania.DataPropertyName = "Compañia";
            this.Compania.HeaderText = "Licensias";
            this.Compania.Name = "Compania";
            this.Compania.ReadOnly = true;
            this.Compania.Width = 60;
            // 
            // Especialidad
            // 
            this.Especialidad.DataPropertyName = "Especialidad";
            this.Especialidad.HeaderText = "Asistencia";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            this.Especialidad.Width = 60;
            // 
            // isAdmin
            // 
            this.isAdmin.DataPropertyName = "isAdmin";
            this.isAdmin.HeaderText = "Llamadas Comandancia";
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.ReadOnly = true;
            this.isAdmin.Width = 60;
            // 
            // Profesion
            // 
            this.Profesion.DataPropertyName = "Profesion";
            this.Profesion.HeaderText = "Guardias Nocturnas";
            this.Profesion.Name = "Profesion";
            this.Profesion.ReadOnly = true;
            this.Profesion.Width = 60;
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.DataPropertyName = "EstadoCivil";
            this.EstadoCivil.HeaderText = "Compañias Canje";
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.ReadOnly = true;
            this.EstadoCivil.Width = 60;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Otras Compañias";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 60;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Otros Cuerpos";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 60;
            // 
            // TelefonoLaboral
            // 
            this.TelefonoLaboral.DataPropertyName = "TelefonoLaboral";
            this.TelefonoLaboral.FillWeight = 150F;
            this.TelefonoLaboral.HeaderText = "Total";
            this.TelefonoLaboral.Name = "TelefonoLaboral";
            this.TelefonoLaboral.ReadOnly = true;
            this.TelefonoLaboral.Width = 60;
            // 
            // RegistroAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Name = "RegistroAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistencia Mensual";
            this.Load += new System.EventHandler(this.RegistroAsistencia_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_especialidad;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compania;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoLaboral;

    }
}