namespace Bomberos.Presentacion.Usuario
{
    partial class VerFichaBombero
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
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.select_compania = new System.Windows.Forms.ComboBox();
            this.select_tipocuenta = new System.Windows.Forms.ComboBox();
            this.date_fecha_inscrip = new System.Windows.Forms.DateTimePicker();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_tib = new System.Windows.Forms.TextBox();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.txt_tel_lab = new System.Windows.Forms.TextBox();
            this.txt_tel_part = new System.Windows.Forms.TextBox();
            this.txt_dir_lab = new System.Windows.Forms.TextBox();
            this.txt_dir_part = new System.Windows.Forms.TextBox();
            this.select_estadocivil = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_profesion = new System.Windows.Forms.TextBox();
            this.txt_gruposang = new System.Windows.Forms.TextBox();
            this.date_fecha_nac = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_rut = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.select_estado = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.select_cargo = new System.Windows.Forms.ComboBox();
            this.box_picture = new System.Windows.Forms.PictureBox();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelRut = new System.Windows.Forms.Label();
            this.labelTIB = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_socio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cerrar.Location = new System.Drawing.Point(496, 603);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 153;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // select_compania
            // 
            this.select_compania.Enabled = false;
            this.select_compania.FormattingEnabled = true;
            this.select_compania.Items.AddRange(new object[] {
            "Primera",
            "Segunda"});
            this.select_compania.Location = new System.Drawing.Point(140, 180);
            this.select_compania.Name = "select_compania";
            this.select_compania.Size = new System.Drawing.Size(121, 21);
            this.select_compania.TabIndex = 151;
            // 
            // select_tipocuenta
            // 
            this.select_tipocuenta.Enabled = false;
            this.select_tipocuenta.FormattingEnabled = true;
            this.select_tipocuenta.Items.AddRange(new object[] {
            "Usuario",
            "Administrador"});
            this.select_tipocuenta.Location = new System.Drawing.Point(140, 73);
            this.select_tipocuenta.Name = "select_tipocuenta";
            this.select_tipocuenta.Size = new System.Drawing.Size(121, 21);
            this.select_tipocuenta.TabIndex = 150;
            // 
            // date_fecha_inscrip
            // 
            this.date_fecha_inscrip.Enabled = false;
            this.date_fecha_inscrip.Location = new System.Drawing.Point(140, 100);
            this.date_fecha_inscrip.Name = "date_fecha_inscrip";
            this.date_fecha_inscrip.Size = new System.Drawing.Size(200, 20);
            this.date_fecha_inscrip.TabIndex = 149;
            // 
            // txt_pass
            // 
            this.txt_pass.Enabled = false;
            this.txt_pass.Location = new System.Drawing.Point(140, 206);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(139, 20);
            this.txt_pass.TabIndex = 148;
            // 
            // txt_tib
            // 
            this.txt_tib.Enabled = false;
            this.txt_tib.Location = new System.Drawing.Point(140, 47);
            this.txt_tib.Name = "txt_tib";
            this.txt_tib.Size = new System.Drawing.Size(100, 20);
            this.txt_tib.TabIndex = 147;
            // 
            // txt_celular
            // 
            this.txt_celular.Enabled = false;
            this.txt_celular.Location = new System.Drawing.Point(152, 404);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(114, 20);
            this.txt_celular.TabIndex = 145;
            // 
            // txt_tel_lab
            // 
            this.txt_tel_lab.Enabled = false;
            this.txt_tel_lab.Location = new System.Drawing.Point(152, 377);
            this.txt_tel_lab.Name = "txt_tel_lab";
            this.txt_tel_lab.Size = new System.Drawing.Size(156, 20);
            this.txt_tel_lab.TabIndex = 144;
            // 
            // txt_tel_part
            // 
            this.txt_tel_part.Enabled = false;
            this.txt_tel_part.Location = new System.Drawing.Point(152, 350);
            this.txt_tel_part.Name = "txt_tel_part";
            this.txt_tel_part.Size = new System.Drawing.Size(156, 20);
            this.txt_tel_part.TabIndex = 143;
            // 
            // txt_dir_lab
            // 
            this.txt_dir_lab.Enabled = false;
            this.txt_dir_lab.Location = new System.Drawing.Point(152, 324);
            this.txt_dir_lab.Name = "txt_dir_lab";
            this.txt_dir_lab.Size = new System.Drawing.Size(246, 20);
            this.txt_dir_lab.TabIndex = 142;
            // 
            // txt_dir_part
            // 
            this.txt_dir_part.Enabled = false;
            this.txt_dir_part.Location = new System.Drawing.Point(152, 298);
            this.txt_dir_part.Name = "txt_dir_part";
            this.txt_dir_part.Size = new System.Drawing.Size(246, 20);
            this.txt_dir_part.TabIndex = 141;
            // 
            // select_estadocivil
            // 
            this.select_estadocivil.Enabled = false;
            this.select_estadocivil.FormattingEnabled = true;
            this.select_estadocivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Divorciado",
            "Viudo",
            "Separado"});
            this.select_estadocivil.Location = new System.Drawing.Point(152, 271);
            this.select_estadocivil.Name = "select_estadocivil";
            this.select_estadocivil.Size = new System.Drawing.Size(139, 21);
            this.select_estadocivil.TabIndex = 140;
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(152, 245);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(139, 20);
            this.txt_email.TabIndex = 139;
            // 
            // txt_profesion
            // 
            this.txt_profesion.Enabled = false;
            this.txt_profesion.Location = new System.Drawing.Point(152, 218);
            this.txt_profesion.Name = "txt_profesion";
            this.txt_profesion.Size = new System.Drawing.Size(246, 20);
            this.txt_profesion.TabIndex = 138;
            // 
            // txt_gruposang
            // 
            this.txt_gruposang.Enabled = false;
            this.txt_gruposang.Location = new System.Drawing.Point(152, 192);
            this.txt_gruposang.Name = "txt_gruposang";
            this.txt_gruposang.Size = new System.Drawing.Size(139, 20);
            this.txt_gruposang.TabIndex = 137;
            // 
            // date_fecha_nac
            // 
            this.date_fecha_nac.Enabled = false;
            this.date_fecha_nac.Location = new System.Drawing.Point(152, 165);
            this.date_fecha_nac.Name = "date_fecha_nac";
            this.date_fecha_nac.Size = new System.Drawing.Size(200, 20);
            this.date_fecha_nac.TabIndex = 136;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(38, 274);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 13);
            this.label19.TabIndex = 135;
            this.label19.Text = "Estado Civil";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(38, 221);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 134;
            this.label18.Text = "Profesión";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(38, 250);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 133;
            this.label17.Text = "Email";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 407);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 132;
            this.label16.Text = "Celular";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 207);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 131;
            this.label15.Text = "Password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 130;
            this.label14.Text = "Tipo de cuenta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 129;
            this.label13.Text = "Grupo Sanguíneo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 128;
            this.label12.Text = "Compañia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 127;
            this.label11.Text = "Dirección Laboral";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 126;
            this.label10.Text = "Dirección Particular";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 125;
            this.label9.Text = "Teléfono Laboral";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 124;
            this.label8.Text = "Teléfono Particular";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 123;
            this.label7.Text = "Fecha Inscripción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 122;
            this.label6.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 121;
            this.label5.Text = "TIB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 120;
            this.label4.Text = "RUT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 119;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 118;
            this.label2.Text = "Nombres";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nombres);
            this.groupBox1.Controls.Add(this.txt_apellidos);
            this.groupBox1.Controls.Add(this.txt_rut);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 386);
            this.groupBox1.TabIndex = 146;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_nombres
            // 
            this.txt_nombres.Enabled = false;
            this.txt_nombres.Location = new System.Drawing.Point(140, 26);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(198, 20);
            this.txt_nombres.TabIndex = 2;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Enabled = false;
            this.txt_apellidos.Location = new System.Drawing.Point(140, 52);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(198, 20);
            this.txt_apellidos.TabIndex = 4;
            // 
            // txt_rut
            // 
            this.txt_rut.Enabled = false;
            this.txt_rut.Location = new System.Drawing.Point(140, 78);
            this.txt_rut.Name = "txt_rut";
            this.txt_rut.Size = new System.Drawing.Size(120, 20);
            this.txt_rut.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_socio);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.select_tipocuenta);
            this.groupBox2.Controls.Add(this.date_fecha_inscrip);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txt_tib);
            this.groupBox2.Controls.Add(this.select_estado);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.select_cargo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_pass);
            this.groupBox2.Controls.Add(this.select_compania);
            this.groupBox2.Location = new System.Drawing.Point(12, 454);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 241);
            this.groupBox2.TabIndex = 152;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Bombero";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(26, 132);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 162;
            this.label21.Text = "Cargo";
            // 
            // select_estado
            // 
            this.select_estado.Enabled = false;
            this.select_estado.FormattingEnabled = true;
            this.select_estado.Items.AddRange(new object[] {
            "Activo",
            "Renunciado",
            "Separado",
            "Fallecido"});
            this.select_estado.Location = new System.Drawing.Point(140, 153);
            this.select_estado.Name = "select_estado";
            this.select_estado.Size = new System.Drawing.Size(121, 21);
            this.select_estado.TabIndex = 161;
            this.select_estado.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(26, 156);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 160;
            this.label20.Text = "Estado";
            // 
            // select_cargo
            // 
            this.select_cargo.Enabled = false;
            this.select_cargo.FormattingEnabled = true;
            this.select_cargo.Items.AddRange(new object[] {
            "Superintendente",
            "Vicesuperintendente",
            "Tesorero General",
            "Secretario General",
            "Director Honorario",
            "Comandante",
            "2° Comandante",
            "Inspector Salud",
            "Inspector Capacitación",
            "Inspector Investigación Incendio",
            "Inspector Material Mayor",
            "Ayudantes de comandancia",
            "Director",
            "Secretario",
            "Tesorero",
            "Capitán",
            "Teniente1°",
            "Teniente2°",
            "Teniente3°",
            "Ayudante",
            "Maquinista 1°",
            "Maquinistas",
            "Paramédicos",
            "Bombero",
            "Aspirante"});
            this.select_cargo.Location = new System.Drawing.Point(140, 126);
            this.select_cargo.Name = "select_cargo";
            this.select_cargo.Size = new System.Drawing.Size(160, 21);
            this.select_cargo.TabIndex = 0;
            // 
            // box_picture
            // 
            this.box_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.box_picture.Location = new System.Drawing.Point(453, 69);
            this.box_picture.Name = "box_picture";
            this.box_picture.Size = new System.Drawing.Size(150, 180);
            this.box_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_picture.TabIndex = 154;
            this.box_picture.TabStop = false;
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(450, 257);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(90, 13);
            this.labelnombre.TabIndex = 155;
            this.labelnombre.Text = "Nombre completo";
            // 
            // labelRut
            // 
            this.labelRut.AutoSize = true;
            this.labelRut.Location = new System.Drawing.Point(450, 278);
            this.labelRut.Name = "labelRut";
            this.labelRut.Size = new System.Drawing.Size(30, 13);
            this.labelRut.TabIndex = 156;
            this.labelRut.Text = "RUT";
            this.labelRut.Click += new System.EventHandler(this.label20_Click);
            // 
            // labelTIB
            // 
            this.labelTIB.AutoSize = true;
            this.labelTIB.Location = new System.Drawing.Point(450, 299);
            this.labelTIB.Name = "labelTIB";
            this.labelTIB.Size = new System.Drawing.Size(24, 13);
            this.labelTIB.TabIndex = 157;
            this.labelTIB.Text = "TIB";
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Location = new System.Drawing.Point(450, 320);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(35, 13);
            this.labelCargo.TabIndex = 158;
            this.labelCargo.Text = "Cargo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 159;
            this.label1.Text = "FICHA PERSONAL";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(28, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 163;
            this.label22.Text = "Socio N°";
            // 
            // txt_socio
            // 
            this.txt_socio.Location = new System.Drawing.Point(140, 21);
            this.txt_socio.Name = "txt_socio";
            this.txt_socio.Size = new System.Drawing.Size(139, 20);
            this.txt_socio.TabIndex = 164;
            // 
            // VerFichaBombero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cerrar;
            this.ClientSize = new System.Drawing.Size(634, 707);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.labelTIB);
            this.Controls.Add(this.labelRut);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.box_picture);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.txt_celular);
            this.Controls.Add(this.txt_tel_lab);
            this.Controls.Add(this.txt_tel_part);
            this.Controls.Add(this.txt_dir_lab);
            this.Controls.Add(this.txt_dir_part);
            this.Controls.Add(this.select_estadocivil);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_profesion);
            this.Controls.Add(this.txt_gruposang);
            this.Controls.Add(this.date_fecha_nac);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "VerFichaBombero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.VerFichaBombero_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.ComboBox select_compania;
        private System.Windows.Forms.ComboBox select_tipocuenta;
        private System.Windows.Forms.DateTimePicker date_fecha_inscrip;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_tib;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.TextBox txt_tel_lab;
        private System.Windows.Forms.TextBox txt_tel_part;
        private System.Windows.Forms.TextBox txt_dir_lab;
        private System.Windows.Forms.TextBox txt_dir_part;
        private System.Windows.Forms.ComboBox select_estadocivil;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_profesion;
        private System.Windows.Forms.TextBox txt_gruposang;
        private System.Windows.Forms.DateTimePicker date_fecha_nac;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.TextBox txt_rut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox box_picture;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labelRut;
        private System.Windows.Forms.Label labelTIB;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox select_cargo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox select_estado;
        private System.Windows.Forms.TextBox txt_socio;
        private System.Windows.Forms.Label label22;
    }
}