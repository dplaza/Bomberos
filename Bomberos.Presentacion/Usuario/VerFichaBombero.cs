using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bomberos.Negocio.Mgr;
using Bomberos.ComunFuncional;

namespace Bomberos.Presentacion.Usuario
{
    public partial class VerFichaBombero : Form
    {
        public VerFichaBombero()
        {
            InitializeComponent();
        }

        private void VerFichaBombero_Load(object sender, EventArgs e)
        {
            IBomberoMgr _Bombero = new BomberoMgr();
            ContextoDTO.Instancia().BomberoSelected = _Bombero.CargarBombero(ContextoDTO.Instancia().BomberoSelected);

            txt_nombres.Text = ContextoDTO.Instancia().BomberoSelected.Nombres;
            labelnombre.Text = ContextoDTO.Instancia().BomberoSelected.Nombres + " " + ContextoDTO.Instancia().BomberoSelected.Apellidos;
            labelRut.Text = ContextoDTO.Instancia().BomberoSelected.Rut;
            labelTIB.Text = ContextoDTO.Instancia().BomberoSelected.TIB;
            labelCargo.Text = ContextoDTO.Instancia().BomberoSelected.Cargo;
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

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
