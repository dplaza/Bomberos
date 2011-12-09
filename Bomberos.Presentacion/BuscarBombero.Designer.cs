namespace Bomberos.Presentacion
{
    partial class BuscarBombero
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_rut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_tib = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridResult = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.select_cargo = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_perfil = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoLaboral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoParticular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionLaboral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionParticular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupoSanguineo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PictureFile = new System.Windows.Forms.DataGridViewImageColumn();
            this.PictureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PictureSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÚSQUEDA BOMBERO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(81, 19);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(160, 20);
            this.txt_nombres.TabIndex = 2;
            // 
            // txt_rut
            // 
            this.txt_rut.Location = new System.Drawing.Point(81, 71);
            this.txt_rut.Name = "txt_rut";
            this.txt_rut.Size = new System.Drawing.Size(160, 20);
            this.txt_rut.TabIndex = 3;
            this.txt_rut.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RUT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Apellidos";
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(362, 18);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(138, 20);
            this.txt_apellidos.TabIndex = 8;
            // 
            // txt_tib
            // 
            this.txt_tib.Location = new System.Drawing.Point(362, 49);
            this.txt_tib.Name = "txt_tib";
            this.txt_tib.Size = new System.Drawing.Size(138, 20);
            this.txt_tib.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "TIB";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridResult);
            this.groupBox1.Location = new System.Drawing.Point(11, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 273);
            this.groupBox1.TabIndex = 13;
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
            this.NumeroRegistro,
            this.Compania,
            this.Cargo,
            this.Estado,
            this.isAdmin,
            this.Profesion,
            this.EstadoCivil,
            this.Email,
            this.Celular,
            this.TelefonoLaboral,
            this.TelefonoParticular,
            this.DireccionLaboral,
            this.DireccionParticular,
            this.GrupoSanguineo,
            this.FechaNacimiento,
            this.FechaInscripcion,
            this.Password,
            this.PictureFile,
            this.PictureName,
            this.PictureSize});
            this.dataGridResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridResult.Location = new System.Drawing.Point(3, 16);
            this.dataGridResult.Name = "dataGridResult";
            this.dataGridResult.ReadOnly = true;
            this.dataGridResult.Size = new System.Drawing.Size(672, 254);
            this.dataGridResult.TabIndex = 0;
            this.dataGridResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridResult_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.select_cargo);
            this.groupBox2.Controls.Add(this.btn_buscar);
            this.groupBox2.Controls.Add(this.txt_nombres);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_tib);
            this.groupBox2.Controls.Add(this.txt_rut);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_apellidos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 108);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros de búsqueda";
            // 
            // select_cargo
            // 
            this.select_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_cargo.FormattingEnabled = true;
            this.select_cargo.Location = new System.Drawing.Point(81, 45);
            this.select_cargo.Name = "select_cargo";
            this.select_cargo.Size = new System.Drawing.Size(160, 21);
            this.select_cargo.TabIndex = 12;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(544, 46);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(101, 23);
            this.btn_buscar.TabIndex = 0;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_perfil
            // 
            this.btn_perfil.Location = new System.Drawing.Point(527, 426);
            this.btn_perfil.Name = "btn_perfil";
            this.btn_perfil.Size = new System.Drawing.Size(75, 23);
            this.btn_perfil.TabIndex = 15;
            this.btn_perfil.Text = "Ver Perfil";
            this.btn_perfil.UseVisualStyleBackColor = true;
            this.btn_perfil.Click += new System.EventHandler(this.btn_perfil_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Location = new System.Drawing.Point(608, 426);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 150;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 150;
            // 
            // Rut
            // 
            this.Rut.DataPropertyName = "Rut";
            this.Rut.HeaderText = "RUT";
            this.Rut.Name = "Rut";
            this.Rut.ReadOnly = true;
            // 
            // TIB
            // 
            this.TIB.DataPropertyName = "TIB";
            this.TIB.HeaderText = "TIB";
            this.TIB.Name = "TIB";
            this.TIB.ReadOnly = true;
            // 
            // NumeroRegistro
            // 
            this.NumeroRegistro.DataPropertyName = "NumeroRegistro";
            this.NumeroRegistro.HeaderText = "N° Registro";
            this.NumeroRegistro.Name = "NumeroRegistro";
            this.NumeroRegistro.ReadOnly = true;
            // 
            // Compania
            // 
            this.Compania.DataPropertyName = "Compañia";
            this.Compania.HeaderText = "Compañia";
            this.Compania.Name = "Compania";
            this.Compania.ReadOnly = true;
            this.Compania.Visible = false;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "Cargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Visible = false;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // isAdmin
            // 
            this.isAdmin.DataPropertyName = "isAdmin";
            this.isAdmin.HeaderText = "isAdmin";
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.ReadOnly = true;
            this.isAdmin.Visible = false;
            // 
            // Profesion
            // 
            this.Profesion.DataPropertyName = "Profesion";
            this.Profesion.HeaderText = "Profesion";
            this.Profesion.Name = "Profesion";
            this.Profesion.ReadOnly = true;
            this.Profesion.Visible = false;
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.DataPropertyName = "EstadoCivil";
            this.EstadoCivil.HeaderText = "EstadoCivil";
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.ReadOnly = true;
            this.EstadoCivil.Visible = false;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Visible = false;
            // 
            // TelefonoLaboral
            // 
            this.TelefonoLaboral.DataPropertyName = "TelefonoLaboral";
            this.TelefonoLaboral.HeaderText = "TelefonoLaboral";
            this.TelefonoLaboral.Name = "TelefonoLaboral";
            this.TelefonoLaboral.ReadOnly = true;
            this.TelefonoLaboral.Visible = false;
            // 
            // TelefonoParticular
            // 
            this.TelefonoParticular.DataPropertyName = "TelefonoParticular";
            this.TelefonoParticular.HeaderText = "TelefonoParticular";
            this.TelefonoParticular.Name = "TelefonoParticular";
            this.TelefonoParticular.ReadOnly = true;
            this.TelefonoParticular.Visible = false;
            // 
            // DireccionLaboral
            // 
            this.DireccionLaboral.DataPropertyName = "DireccionLaboral";
            this.DireccionLaboral.HeaderText = "DireccionLaboral";
            this.DireccionLaboral.Name = "DireccionLaboral";
            this.DireccionLaboral.ReadOnly = true;
            this.DireccionLaboral.Visible = false;
            // 
            // DireccionParticular
            // 
            this.DireccionParticular.DataPropertyName = "DireccionParticular";
            this.DireccionParticular.HeaderText = "DireccionParticular";
            this.DireccionParticular.Name = "DireccionParticular";
            this.DireccionParticular.ReadOnly = true;
            this.DireccionParticular.Visible = false;
            // 
            // GrupoSanguineo
            // 
            this.GrupoSanguineo.DataPropertyName = "GrupoSanguineo";
            this.GrupoSanguineo.HeaderText = "GrupoSanguineo";
            this.GrupoSanguineo.Name = "GrupoSanguineo";
            this.GrupoSanguineo.ReadOnly = true;
            this.GrupoSanguineo.Visible = false;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "FechaNacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Visible = false;
            // 
            // FechaInscripcion
            // 
            this.FechaInscripcion.DataPropertyName = "FechaInscripcion";
            this.FechaInscripcion.HeaderText = "FechaInscripcion";
            this.FechaInscripcion.Name = "FechaInscripcion";
            this.FechaInscripcion.ReadOnly = true;
            this.FechaInscripcion.Visible = false;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // PictureFile
            // 
            this.PictureFile.DataPropertyName = "PictureFile";
            this.PictureFile.HeaderText = "PictureFile";
            this.PictureFile.Name = "PictureFile";
            this.PictureFile.ReadOnly = true;
            this.PictureFile.Visible = false;
            // 
            // PictureName
            // 
            this.PictureName.DataPropertyName = "PictureName";
            this.PictureName.HeaderText = "PictureName";
            this.PictureName.Name = "PictureName";
            this.PictureName.ReadOnly = true;
            this.PictureName.Visible = false;
            // 
            // PictureSize
            // 
            this.PictureSize.DataPropertyName = "PictureSize";
            this.PictureSize.HeaderText = "PictureSize";
            this.PictureSize.Name = "PictureSize";
            this.PictureSize.ReadOnly = true;
            this.PictureSize.Visible = false;
            // 
            // BuscarBombero
            // 
            this.AcceptButton = this.btn_buscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(701, 469);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_perfil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BuscarBombero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Bombero";
            this.Load += new System.EventHandler(this.BuscarBombero_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_rut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.TextBox txt_tib;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dataGridResult;
        private System.Windows.Forms.Button btn_perfil;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ComboBox select_cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compania;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoLaboral;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoParticular;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionLaboral;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionParticular;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupoSanguineo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewImageColumn PictureFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn PictureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PictureSize;
    }
}