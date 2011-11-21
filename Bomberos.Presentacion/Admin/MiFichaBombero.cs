using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bomberos.ComunFuncional;
using Bomberos.Negocio.Mgr;
using Bomberos.Comun;

namespace Bomberos.Presentacion
{
    public partial class MiFichaBombero : Form
    {
        public MiFichaBombero()
        {
            InitializeComponent();
        }

        private void FichaBombero_Load(object sender, EventArgs e)
        {
            ICargoMgr _Cargo = new CargoMgr();
            ICompañiaMgr _Compañia = new CompañiaMgr();

            select_cargo.DataSource = _Cargo.ListarCargos().OrderBy(p => p.Nombre).ToList();
            select_cargo.DisplayMember = "Nombre";
            select_cargo.ValueMember = "Id";

            select_compania.DataSource = _Compañia.ListarCompañias().OrderBy(p => p.Nombre).ToList();
            select_compania.DisplayMember = "Nombre";
            select_compania.ValueMember = "Id";

            labelnombre.Text = ContextoDTO.Instancia().BomberoActual.Nombres + " " + ContextoDTO.Instancia().BomberoSelected.Apellidos;
            labelRut.Text = ContextoDTO.Instancia().BomberoActual.Rut;
            labelTIB.Text = ContextoDTO.Instancia().BomberoActual.TIB;
            labelCargo.Text = ContextoDTO.Instancia().BomberoActual.Cargo;
            txt_nombres.Text = ContextoDTO.Instancia().BomberoActual.Nombres;
            txt_apellidos.Text = ContextoDTO.Instancia().BomberoActual.Apellidos;
            txt_celular.Text = ContextoDTO.Instancia().BomberoActual.Celular;
            txt_dir_lab.Text = ContextoDTO.Instancia().BomberoActual.DireccionLaboral;
            txt_dir_part.Text = ContextoDTO.Instancia().BomberoActual.DireccionParticular;
            txt_email.Text = ContextoDTO.Instancia().BomberoActual.Email;
            txt_gruposang.Text = ContextoDTO.Instancia().BomberoActual.GrupoSanguineo;
            txt_pass.Text = ContextoDTO.Instancia().BomberoActual.Password;
            txt_profesion.Text = ContextoDTO.Instancia().BomberoActual.Profesion;
            txt_rut.Text = ContextoDTO.Instancia().BomberoActual.Rut;
            date_fecha_nac.Text = ContextoDTO.Instancia().BomberoActual.FechaNacimiento.ToString();
            date_fecha_inscrip.Text = ContextoDTO.Instancia().BomberoActual.FechaInscripcion.ToString();
            select_estadocivil.SelectedText = ContextoDTO.Instancia().BomberoActual.EstadoCivil;
            select_compania.SelectedText = ContextoDTO.Instancia().BomberoActual.Compañia;
            select_cargo.SelectedText = ContextoDTO.Instancia().BomberoActual.Cargo;
            select_estado.SelectedText = ContextoDTO.Instancia().BomberoActual.Estado;
            txt_tel_lab.Text = ContextoDTO.Instancia().BomberoActual.TelefonoLaboral;
            txt_tel_part.Text = ContextoDTO.Instancia().BomberoActual.TelefonoParticular;
            txt_tib.Text = ContextoDTO.Instancia().BomberoActual.TIB;


            if (ContextoDTO.Instancia().BomberoActual.isAdmin)
                select_tipocuenta.SelectedText = "Administrador";
            else
                select_tipocuenta.SelectedText = "Usuario";

            try
            {
                box_picture.Image = new Bitmap("C:\\Bomberos\\" + ContextoDTO.Instancia().BomberoActual.Rut + ".jpg");
            }
            catch (Exception er)
            {
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            txt_nombres.Enabled = true;
            txt_apellidos.Enabled = true;
            txt_celular.Enabled = true;
            txt_dir_lab.Enabled = true;
            txt_dir_part.Enabled = true;
            txt_email.Enabled = true;
            txt_gruposang.Enabled = true;
            txt_pass.Enabled = true;
            txt_profesion.Enabled = true;
            date_fecha_nac.Enabled = true;
            select_compania.Enabled = true;
            txt_tel_lab.Enabled = true;
            txt_tel_part.Enabled = true;
            select_estadocivil.Enabled = true;
            btn_imagen.Enabled = true;
            select_cargo.Enabled = true;
            select_estado.Enabled = true;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
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
            Bombero.Compañia = select_compania.Text;
            Bombero.TelefonoLaboral = txt_tel_lab.Text;
            Bombero.TelefonoParticular = txt_tel_part.Text;
            Bombero.TIB = txt_tib.Text;
            Bombero.Password = txt_pass.Text;
            Bombero.Cargo = select_cargo.Text;
            Bombero.Estado = select_estado.Text;

            if (select_tipocuenta.Text.Equals("Administrador"))
                Bombero.isAdmin = true;
            else
                Bombero.isAdmin = false;

            if (box_picture.Image != null)
            {
                try
                {
                    if (!System.IO.Directory.Exists(@"C:\Bomberos\"))
                        System.IO.Directory.CreateDirectory(@"C:\Bomberos\");

                    System.IO.File.Delete("C:\\Bomberos\\" + Bombero.Rut + ".jpg");
                    box_picture.Image.Save("C:\\Bomberos\\" + Bombero.Rut + ".jpg");
                }
                finally
                {
                    box_picture.Dispose();
                }
            }


            if (_Bombero.EditarBombero(Bombero))
            {
                ContextoDTO.Instancia().BomberoActual = Bombero;
                MessageBox.Show("Bombero actualizado");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar bombero");
            }
        }

        private void btn_imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Seleccione imagen";
            if (file.ShowDialog() == DialogResult.OK)
            {
                box_picture.Image = new Bitmap(file.OpenFile());
            }
        }
    }
}
