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

namespace Bomberos.Presentacion
{
    public partial class RegistroBombero : Form
    {
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

            if (select_tipocuenta.Text.Equals("Administrador"))
                Bombero.isAdmin = true;
            else
                Bombero.isAdmin = false;

            if (_Bombero.RegistroBombero(Bombero))
            {
                MessageBox.Show("Registro exitoso");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar nuevo bombero");
            }

           
        }
    }
}
