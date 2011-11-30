﻿namespace Bomberos.Presentacion.Admin
{
    partial class FichaBombero
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FichaBombero));
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
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
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_rut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.labelTIB = new System.Windows.Forms.Label();
            this.labelRut = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.btn_imagen = new System.Windows.Forms.Button();
            this.box_picture = new System.Windows.Forms.PictureBox();
            this.select_tipocuenta = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.date_fecha_inscrip = new System.Windows.Forms.DateTimePicker();
            this.txt_tib = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_socio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.select_estado = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.select_cargo = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.select_compania = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_picture)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(510, 550);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 117;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(503, 494);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(88, 23);
            this.btn_editar.TabIndex = 116;
            this.btn_editar.Text = "Modificar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Location = new System.Drawing.Point(510, 579);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 115;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_celular
            // 
            this.txt_celular.Enabled = false;
            this.txt_celular.Location = new System.Drawing.Point(161, 392);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(114, 20);
            this.txt_celular.TabIndex = 107;
            // 
            // txt_tel_lab
            // 
            this.txt_tel_lab.Enabled = false;
            this.txt_tel_lab.Location = new System.Drawing.Point(161, 365);
            this.txt_tel_lab.Name = "txt_tel_lab";
            this.txt_tel_lab.Size = new System.Drawing.Size(156, 20);
            this.txt_tel_lab.TabIndex = 106;
            // 
            // txt_tel_part
            // 
            this.txt_tel_part.Enabled = false;
            this.txt_tel_part.Location = new System.Drawing.Point(161, 338);
            this.txt_tel_part.Name = "txt_tel_part";
            this.txt_tel_part.Size = new System.Drawing.Size(156, 20);
            this.txt_tel_part.TabIndex = 105;
            // 
            // txt_dir_lab
            // 
            this.txt_dir_lab.Enabled = false;
            this.txt_dir_lab.Location = new System.Drawing.Point(161, 312);
            this.txt_dir_lab.Name = "txt_dir_lab";
            this.txt_dir_lab.Size = new System.Drawing.Size(246, 20);
            this.txt_dir_lab.TabIndex = 104;
            // 
            // txt_dir_part
            // 
            this.txt_dir_part.Enabled = false;
            this.txt_dir_part.Location = new System.Drawing.Point(161, 286);
            this.txt_dir_part.Name = "txt_dir_part";
            this.txt_dir_part.Size = new System.Drawing.Size(246, 20);
            this.txt_dir_part.TabIndex = 103;
            // 
            // select_estadocivil
            // 
            this.select_estadocivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_estadocivil.Enabled = false;
            this.select_estadocivil.FormattingEnabled = true;
            this.select_estadocivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Divorciado",
            "Viudo",
            "Separado"});
            this.select_estadocivil.Location = new System.Drawing.Point(161, 259);
            this.select_estadocivil.Name = "select_estadocivil";
            this.select_estadocivil.Size = new System.Drawing.Size(139, 21);
            this.select_estadocivil.TabIndex = 102;
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(161, 233);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(139, 20);
            this.txt_email.TabIndex = 101;
            // 
            // txt_profesion
            // 
            this.txt_profesion.Enabled = false;
            this.txt_profesion.Location = new System.Drawing.Point(161, 206);
            this.txt_profesion.Name = "txt_profesion";
            this.txt_profesion.Size = new System.Drawing.Size(246, 20);
            this.txt_profesion.TabIndex = 100;
            // 
            // txt_gruposang
            // 
            this.txt_gruposang.Enabled = false;
            this.txt_gruposang.Location = new System.Drawing.Point(161, 180);
            this.txt_gruposang.Name = "txt_gruposang";
            this.txt_gruposang.Size = new System.Drawing.Size(139, 20);
            this.txt_gruposang.TabIndex = 99;
            // 
            // date_fecha_nac
            // 
            this.date_fecha_nac.Enabled = false;
            this.date_fecha_nac.Location = new System.Drawing.Point(161, 153);
            this.date_fecha_nac.Name = "date_fecha_nac";
            this.date_fecha_nac.Size = new System.Drawing.Size(200, 20);
            this.date_fecha_nac.TabIndex = 98;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(47, 262);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 13);
            this.label19.TabIndex = 97;
            this.label19.Text = "Estado Civil";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(47, 209);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 96;
            this.label18.Text = "Profesión";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(47, 238);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 95;
            this.label17.Text = "Email";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(47, 395);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 94;
            this.label16.Text = "Celular";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 91;
            this.label13.Text = "Grupo Sanguíneo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 89;
            this.label11.Text = "Dirección Laboral";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 88;
            this.label10.Text = "Dirección Particular";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 87;
            this.label9.Text = "Teléfono Laboral";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 86;
            this.label8.Text = "Teléfono Particular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "Fecha Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "RUT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Nombres";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nombres);
            this.groupBox1.Controls.Add(this.txt_apellidos);
            this.groupBox1.Controls.Add(this.txt_rut);
            this.groupBox1.Location = new System.Drawing.Point(21, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 375);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 118;
            this.label1.Text = "FICHA BOMBERO";
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Location = new System.Drawing.Point(471, 353);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(35, 13);
            this.labelCargo.TabIndex = 171;
            this.labelCargo.Text = "Cargo";
            // 
            // labelTIB
            // 
            this.labelTIB.AutoSize = true;
            this.labelTIB.Location = new System.Drawing.Point(471, 332);
            this.labelTIB.Name = "labelTIB";
            this.labelTIB.Size = new System.Drawing.Size(24, 13);
            this.labelTIB.TabIndex = 170;
            this.labelTIB.Text = "TIB";
            // 
            // labelRut
            // 
            this.labelRut.AutoSize = true;
            this.labelRut.Location = new System.Drawing.Point(471, 311);
            this.labelRut.Name = "labelRut";
            this.labelRut.Size = new System.Drawing.Size(30, 13);
            this.labelRut.TabIndex = 169;
            this.labelRut.Text = "RUT";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(471, 290);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(90, 13);
            this.labelnombre.TabIndex = 168;
            this.labelnombre.Text = "Nombre completo";
            // 
            // btn_imagen
            // 
            this.btn_imagen.Enabled = false;
            this.btn_imagen.Location = new System.Drawing.Point(490, 250);
            this.btn_imagen.Name = "btn_imagen";
            this.btn_imagen.Size = new System.Drawing.Size(114, 23);
            this.btn_imagen.TabIndex = 167;
            this.btn_imagen.Text = "Seleccionar Imagen";
            this.btn_imagen.UseVisualStyleBackColor = true;
            this.btn_imagen.Click += new System.EventHandler(this.btn_imagen_Click);
            // 
            // box_picture
            // 
            this.box_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.box_picture.Location = new System.Drawing.Point(474, 60);
            this.box_picture.Name = "box_picture";
            this.box_picture.Size = new System.Drawing.Size(150, 180);
            this.box_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_picture.TabIndex = 166;
            this.box_picture.TabStop = false;
            // 
            // select_tipocuenta
            // 
            this.select_tipocuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_tipocuenta.Enabled = false;
            this.select_tipocuenta.FormattingEnabled = true;
            this.select_tipocuenta.Items.AddRange(new object[] {
            "Usuario",
            "Administrador"});
            this.select_tipocuenta.Location = new System.Drawing.Point(140, 77);
            this.select_tipocuenta.Name = "select_tipocuenta";
            this.select_tipocuenta.Size = new System.Drawing.Size(121, 21);
            this.select_tipocuenta.TabIndex = 177;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(26, 54);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 13);
            this.label20.TabIndex = 172;
            this.label20.Text = "TIB";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(26, 114);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 13);
            this.label21.TabIndex = 173;
            this.label21.Text = "Fecha Inscripción";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(26, 80);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 13);
            this.label23.TabIndex = 174;
            this.label23.Text = "Tipo de cuenta";
            // 
            // date_fecha_inscrip
            // 
            this.date_fecha_inscrip.Enabled = false;
            this.date_fecha_inscrip.Location = new System.Drawing.Point(140, 112);
            this.date_fecha_inscrip.Name = "date_fecha_inscrip";
            this.date_fecha_inscrip.Size = new System.Drawing.Size(200, 20);
            this.date_fecha_inscrip.TabIndex = 176;
            // 
            // txt_tib
            // 
            this.txt_tib.Enabled = false;
            this.txt_tib.Location = new System.Drawing.Point(140, 51);
            this.txt_tib.Name = "txt_tib";
            this.txt_tib.Size = new System.Drawing.Size(100, 20);
            this.txt_tib.TabIndex = 175;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_socio);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.select_tipocuenta);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.select_estado);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.txt_tib);
            this.groupBox3.Controls.Add(this.select_cargo);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.date_fecha_inscrip);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.txt_pass);
            this.groupBox3.Controls.Add(this.select_compania);
            this.groupBox3.Location = new System.Drawing.Point(21, 430);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 265);
            this.groupBox3.TabIndex = 178;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Bombero";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txt_socio
            // 
            this.txt_socio.Enabled = false;
            this.txt_socio.Location = new System.Drawing.Point(140, 20);
            this.txt_socio.Name = "txt_socio";
            this.txt_socio.Size = new System.Drawing.Size(139, 20);
            this.txt_socio.TabIndex = 179;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 178;
            this.label5.Text = "Socio N°";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(26, 143);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 162;
            this.label22.Text = "Cargo";
            // 
            // select_estado
            // 
            this.select_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_estado.Enabled = false;
            this.select_estado.FormattingEnabled = true;
            this.select_estado.Items.AddRange(new object[] {
            "Activo",
            "Renunciado",
            "Separado",
            "Fallecido"});
            this.select_estado.Location = new System.Drawing.Point(140, 174);
            this.select_estado.Name = "select_estado";
            this.select_estado.Size = new System.Drawing.Size(121, 21);
            this.select_estado.TabIndex = 161;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(26, 177);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 13);
            this.label24.TabIndex = 160;
            this.label24.Text = "Estado";
            // 
            // select_cargo
            // 
            this.select_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_cargo.Enabled = false;
            this.select_cargo.FormattingEnabled = true;
            this.select_cargo.Location = new System.Drawing.Point(140, 140);
            this.select_cargo.Name = "select_cargo";
            this.select_cargo.Size = new System.Drawing.Size(160, 21);
            this.select_cargo.TabIndex = 0;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(26, 204);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 13);
            this.label25.TabIndex = 128;
            this.label25.Text = "Compañia";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(26, 231);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 13);
            this.label26.TabIndex = 131;
            this.label26.Text = "Password";
            // 
            // txt_pass
            // 
            this.txt_pass.Enabled = false;
            this.txt_pass.Location = new System.Drawing.Point(140, 228);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(139, 20);
            this.txt_pass.TabIndex = 148;
            // 
            // select_compania
            // 
            this.select_compania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_compania.Enabled = false;
            this.select_compania.FormattingEnabled = true;
            this.select_compania.Location = new System.Drawing.Point(140, 201);
            this.select_compania.Name = "select_compania";
            this.select_compania.Size = new System.Drawing.Size(121, 21);
            this.select_compania.TabIndex = 151;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 179;
            this.button1.Text = "Más Información";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(510, 416);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_imprimir.TabIndex = 180;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // FichaBombero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(668, 707);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.labelTIB);
            this.Controls.Add(this.labelRut);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.btn_imagen);
            this.Controls.Add(this.box_picture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_cancelar);
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
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FichaBombero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FichaBombero_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_picture)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_cancelar;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.TextBox txt_rut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.Label labelTIB;
        private System.Windows.Forms.Label labelRut;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Button btn_imagen;
        private System.Windows.Forms.PictureBox box_picture;
        private System.Windows.Forms.ComboBox select_tipocuenta;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker date_fecha_inscrip;
        private System.Windows.Forms.TextBox txt_tib;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox select_estado;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox select_cargo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.ComboBox select_compania;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_socio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_imprimir;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}