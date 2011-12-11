using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bomberos.ComunFuncional;
using Bomberos.Comun;
using Bomberos.Negocio.Mgr;
using System.IO;

namespace Bomberos.Presentacion
{
    public partial class RegistroBombero : Form
    {
        private string location { get; set; }
        private string fileName { get; set; }

        public RegistroBombero()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void RegistroBombero_Load(object sender, EventArgs e)
        {
            ICargoMgr _Cargo = new CargoMgr();
            ICompañiaMgr _Compañia = new CompañiaMgr();

            select_cargo.DataSource = _Cargo.ListarCargos().OrderBy(p => p.Nombre).ToList();
            select_cargo.DisplayMember = "Nombre";
            select_cargo.ValueMember = "Id";

            select_compania.DataSource = _Compañia.ListarCompañias().OrderBy(p => p.Nombre).ToList();
            select_compania.DisplayMember = "Nombre";
            select_compania.ValueMember = "Id";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (txt_nombres.Text != "" && txt_apellidos.Text != "" && select_tipocuenta.Text != "" && select_estadocivil.Text != "" && txt_rut.Text != "" && txt_pass.Text != "" && select_estado.Text != "")
            {
                IBomberoMgr _Bombero = new BomberoMgr();
                BomberoDTO Bombero = new BomberoDTO();

                Bombero.Nombres = txt_nombres.Text;
                Bombero.Apellidos = txt_apellidos.Text;
                Bombero.Celular = txt_celular.Text;
                Bombero.DireccionLaboral = txt_dir_lab.Text;
                Bombero.DireccionParticular = txt_dir_part.Text;
                Bombero.EstadoCivil = select_estadocivil.Text;
                Bombero.FechaInscripcion = date_fecha_inscrip.Value;
                Bombero.FechaNacimiento = date_fecha_nac.Value;
                Bombero.GrupoSanguineo = txt_gruposang.Text;
                Bombero.Profesion = txt_profesion.Text;
                Bombero.Rut = txt_rut.Text;
                Bombero.Compañia = (CompañiaDTO)select_compania.SelectedItem;
                Bombero.TelefonoLaboral = txt_tel_lab.Text;
                Bombero.TelefonoParticular = txt_tel_part.Text;
                Bombero.TIB = txt_tib.Text;
                Bombero.Password = txt_pass.Text;
                Bombero.Cargo = (CargoDTO)select_cargo.SelectedItem;
                Bombero.Estado = select_estado.Text;
                Bombero.Email = txt_email.Text;
                Bombero.NivelAcademico = select_nivel_acad.Text;

                #region Fotografia Bombero
                try
                {
                    FileStream fs = new FileStream(location, FileMode.Open, FileAccess.Read);

                    Bombero.PictureSize = (int)fs.Length;
                    Bombero.PictureFile = new byte[Bombero.PictureSize];
                    fs.Read(Bombero.PictureFile, 0, (int)Bombero.PictureSize);
                    Bombero.PictureName = fileName;
                    fs.Close();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Debe elegir una fotografía.");
                    return;
                }
                #endregion

                if (txt_socio.Text != "")
                    Bombero.NumeroRegistro = int.Parse(txt_socio.Text);

                if (select_tipocuenta.Text.Equals("Administrador"))
                    Bombero.isAdmin = true;
                else
                    Bombero.isAdmin = false;

                if (_Bombero.RegistroBombero(Bombero))
                {
                    MessageBox.Show("Registro exitoso");

                    IFichaMedicaMgr _FichaMedica = new FichaMedicaMgr();
                    FichaMedicaDTO FichaMedica = new FichaMedicaDTO();
                    FichaMedica.Bombero = Bombero;
                    _FichaMedica.RegistroFichaMedica(FichaMedica);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar nuevo bombero");
                }
            }
            else
            {
                MessageBox.Show("Falta rellenar datos");
            }
        }

        private void btn_imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPic = new OpenFileDialog();
            openPic.Title = "Seleccione imagen";
            if (openPic.ShowDialog() == DialogResult.OK)
            {
                box_picture.BackgroundImage = new Bitmap(openPic.FileName);
                location = openPic.FileName;
                fileName = openPic.SafeFileName;
            }
        }

        private void select_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
