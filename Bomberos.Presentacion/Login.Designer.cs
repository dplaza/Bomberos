namespace Bomberos
{
    partial class login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ingresar_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_user_login = new System.Windows.Forms.TextBox();
            this.txt_pass_login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combobox_tipo_login = new System.Windows.Forms.ComboBox();
            this.btn_salir_login = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ingresar_login
            // 
            this.btn_ingresar_login.Location = new System.Drawing.Point(109, 148);
            this.btn_ingresar_login.Name = "btn_ingresar_login";
            this.btn_ingresar_login.Size = new System.Drawing.Size(75, 23);
            this.btn_ingresar_login.TabIndex = 4;
            this.btn_ingresar_login.Text = "Ingresar";
            this.btn_ingresar_login.UseVisualStyleBackColor = true;
            this.btn_ingresar_login.Click += new System.EventHandler(this.btn_ingresar_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // txt_user_login
            // 
            this.txt_user_login.Location = new System.Drawing.Point(107, 82);
            this.txt_user_login.Name = "txt_user_login";
            this.txt_user_login.Size = new System.Drawing.Size(141, 20);
            this.txt_user_login.TabIndex = 2;
            // 
            // txt_pass_login
            // 
            this.txt_pass_login.Location = new System.Drawing.Point(107, 110);
            this.txt_pass_login.Name = "txt_pass_login";
            this.txt_pass_login.PasswordChar = '*';
            this.txt_pass_login.Size = new System.Drawing.Size(141, 20);
            this.txt_pass_login.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo:";
            // 
            // combobox_tipo_login
            // 
            this.combobox_tipo_login.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_tipo_login.FormattingEnabled = true;
            this.combobox_tipo_login.Items.AddRange(new object[] {
            "Usuario",
            "Administrador"});
            this.combobox_tipo_login.Location = new System.Drawing.Point(107, 53);
            this.combobox_tipo_login.Name = "combobox_tipo_login";
            this.combobox_tipo_login.Size = new System.Drawing.Size(141, 21);
            this.combobox_tipo_login.TabIndex = 1;
            // 
            // btn_salir_login
            // 
            this.btn_salir_login.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_salir_login.Location = new System.Drawing.Point(190, 148);
            this.btn_salir_login.Name = "btn_salir_login";
            this.btn_salir_login.Size = new System.Drawing.Size(75, 23);
            this.btn_salir_login.TabIndex = 5;
            this.btn_salir_login.Text = "Salir";
            this.btn_salir_login.UseVisualStyleBackColor = true;
            this.btn_salir_login.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "LOGIN COMPAÑIA BOMBEROS";
            // 
            // login
            // 
            this.AcceptButton = this.btn_ingresar_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_salir_login;
            this.ClientSize = new System.Drawing.Size(285, 192);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_salir_login);
            this.Controls.Add(this.combobox_tipo_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pass_login);
            this.Controls.Add(this.txt_user_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ingresar_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compañia Bomberos - Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ingresar_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_user_login;
        private System.Windows.Forms.TextBox txt_pass_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combobox_tipo_login;
        private System.Windows.Forms.Button btn_salir_login;
        private System.Windows.Forms.Label label4;
    }
}

