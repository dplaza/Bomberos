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

namespace Bomberos.Presentacion.Admin
{
    public partial class FichaBombero : Form
    {
        public FichaBombero()
        {
            InitializeComponent();
        }

        private void FichaBombero_Load(object sender, EventArgs e)
        {
            IBomberoMgr _Bombero = new BomberoMgr();
            ContextoDTO.Instancia().BomberoSelected = _Bombero.CargarBombero(ContextoDTO.Instancia().BomberoSelected);

            labelnombre.Text = ContextoDTO.Instancia().BomberoSelected.Nombres + " " + ContextoDTO.Instancia().BomberoSelected.Apellidos;
            labelRut.Text = ContextoDTO.Instancia().BomberoSelected.Rut;
            labelTIB.Text = ContextoDTO.Instancia().BomberoSelected.TIB;
            labelCargo.Text = ContextoDTO.Instancia().BomberoSelected.Cargo;
            txt_nombres.Text = ContextoDTO.Instancia().BomberoSelected.Nombres;
            txt_apellidos.Text = ContextoDTO.Instancia().BomberoSelected.Apellidos;
            txt_celular.Text = ContextoDTO.Instancia().BomberoSelected.Celular;
            txt_dir_lab.Text = ContextoDTO.Instancia().BomberoSelected.DireccionLaboral;
            txt_dir_part.Text = ContextoDTO.Instancia().BomberoSelected.DireccionParticular;
            txt_email.Text = ContextoDTO.Instancia().BomberoSelected.Email;
            txt_gruposang.Text = ContextoDTO.Instancia().BomberoSelected.GrupoSanguineo;
            txt_pass.Text = ContextoDTO.Instancia().BomberoSelected.Password;
            txt_profesion.Text = ContextoDTO.Instancia().BomberoSelected.Profesion;
            txt_rut.Text = ContextoDTO.Instancia().BomberoSelected.Rut;
            date_fecha_nac.Text = ContextoDTO.Instancia().BomberoSelected.FechaNacimiento.ToString();
            date_fecha_inscrip.Text = ContextoDTO.Instancia().BomberoSelected.FechaInscripcion.ToString();
            select_estadocivil.SelectedText = ContextoDTO.Instancia().BomberoSelected.EstadoCivil;
            select_compania.SelectedText = ContextoDTO.Instancia().BomberoSelected.Compañia;
            select_cargo.SelectedText = ContextoDTO.Instancia().BomberoSelected.Cargo;
            select_estado.SelectedText = ContextoDTO.Instancia().BomberoSelected.Estado;
            txt_tel_lab.Text = ContextoDTO.Instancia().BomberoSelected.TelefonoLaboral;
            txt_tel_part.Text = ContextoDTO.Instancia().BomberoSelected.TelefonoParticular;
            txt_tib.Text = ContextoDTO.Instancia().BomberoSelected.TIB;


            if (ContextoDTO.Instancia().BomberoSelected.isAdmin)
                select_tipocuenta.SelectedText = "Administrador";
            else
                select_tipocuenta.SelectedText = "Usuario";

            this.Text = "Perfil de " + ContextoDTO.Instancia().BomberoSelected.Nombres + " " + ContextoDTO.Instancia().BomberoSelected.Apellidos;
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
            select_tipocuenta.Enabled = true;
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

            if (_Bombero.EditarBombero(Bombero))
            {
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
