namespace Bomberos.Presentacion
{
    partial class Compañia
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
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_imagen = new System.Windows.Forms.Button();
            this.box_picture = new System.Windows.Forms.PictureBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridResult = new System.Windows.Forms.DataGridView();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idCompañia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompañia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PictureFileCoim = new System.Windows.Forms.DataGridViewImageColumn();
            this.PictureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PictureSizeComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_picture)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_nombres);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(191, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 95);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Info Compañia";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(139, 38);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(272, 20);
            this.txt_nombres.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Compañia";
            // 
            // btn_imagen
            // 
            this.btn_imagen.Location = new System.Drawing.Point(30, 148);
            this.btn_imagen.Name = "btn_imagen";
            this.btn_imagen.Size = new System.Drawing.Size(139, 23);
            this.btn_imagen.TabIndex = 45;
            this.btn_imagen.Text = "Seleccionar Insignia";
            this.btn_imagen.UseVisualStyleBackColor = true;
            this.btn_imagen.Click += new System.EventHandler(this.btn_imagen_Click);
            // 
            // box_picture
            // 
            this.box_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.box_picture.InitialImage = null;
            this.box_picture.Location = new System.Drawing.Point(49, 21);
            this.box_picture.Name = "box_picture";
            this.box_picture.Size = new System.Drawing.Size(100, 108);
            this.box_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box_picture.TabIndex = 44;
            this.box_picture.TabStop = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(464, 153);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(155, 23);
            this.btn_agregar.TabIndex = 14;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridResult);
            this.groupBox1.Location = new System.Drawing.Point(11, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 235);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compañias";
            // 
            // dataGridResult
            // 
            this.dataGridResult.AllowUserToAddRows = false;
            this.dataGridResult.AllowUserToDeleteRows = false;
            this.dataGridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompañia,
            this.NombreCompañia,
            this.PictureFileCoim,
            this.PictureName,
            this.PictureSizeComp});
            this.dataGridResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridResult.Location = new System.Drawing.Point(3, 16);
            this.dataGridResult.Name = "dataGridResult";
            this.dataGridResult.ReadOnly = true;
            this.dataGridResult.Size = new System.Drawing.Size(672, 216);
            this.dataGridResult.TabIndex = 0;
            this.dataGridResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridResult_CellContentClick);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(527, 426);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar.TabIndex = 22;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Location = new System.Drawing.Point(608, 426);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 23;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "COMPAÑIAS";
            // 
            // idCompañia
            // 
            this.idCompañia.DataPropertyName = "Id";
            this.idCompañia.DividerWidth = 1;
            this.idCompañia.HeaderText = "ID Compañia";
            this.idCompañia.Name = "idCompañia";
            this.idCompañia.ReadOnly = true;
            this.idCompañia.Visible = false;
            this.idCompañia.Width = 70;
            // 
            // NombreCompañia
            // 
            this.NombreCompañia.DataPropertyName = "Nombre";
            this.NombreCompañia.DividerWidth = 1;
            this.NombreCompañia.HeaderText = "Nombre";
            this.NombreCompañia.Name = "NombreCompañia";
            this.NombreCompañia.ReadOnly = true;
            this.NombreCompañia.Width = 400;
            // 
            // PictureFileCoim
            // 
            this.PictureFileCoim.DataPropertyName = "PictureFileComp";
            this.PictureFileCoim.HeaderText = "Insignia";
            this.PictureFileCoim.Name = "PictureFileCoim";
            this.PictureFileCoim.ReadOnly = true;
            this.PictureFileCoim.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PictureFileCoim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PictureFileCoim.Visible = false;
            this.PictureFileCoim.Width = 200;
            // 
            // PictureName
            // 
            this.PictureName.DataPropertyName = "PictureNameComp";
            this.PictureName.HeaderText = "PictureNameComp";
            this.PictureName.Name = "PictureName";
            this.PictureName.ReadOnly = true;
            this.PictureName.Visible = false;
            // 
            // PictureSizeComp
            // 
            this.PictureSizeComp.DataPropertyName = "PictureSizeComp";
            this.PictureSizeComp.HeaderText = "PictureSizeComp";
            this.PictureSizeComp.Name = "PictureSizeComp";
            this.PictureSizeComp.ReadOnly = true;
            this.PictureSizeComp.Visible = false;
            // 
            // Compañia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 464);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_imagen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_picture);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Compañia";
            this.Text = "Compañia";
            this.Load += new System.EventHandler(this.Compañia_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_picture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridResult;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox box_picture;
        private System.Windows.Forms.Button btn_imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompañia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompañia;
        private System.Windows.Forms.DataGridViewImageColumn PictureFileCoim;
        private System.Windows.Forms.DataGridViewTextBoxColumn PictureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PictureSizeComp;
    }
}