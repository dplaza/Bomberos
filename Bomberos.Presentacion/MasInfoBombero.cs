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
using Bomberos.Comun;

namespace Bomberos.Presentacion
{
    public partial class MasInfoBombero : Form
    {
        public MasInfoBombero()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MasInfoBombero_Load(object sender, EventArgs e)
        {
            this.Text = "Perfil de " + ContextoDTO.Instancia().BomberoSelected.Nombres + " " + ContextoDTO.Instancia().BomberoSelected.Apellidos;

            ICursoMgr _Curso = new CursoMgr();
            select_cursos.DataSource = _Curso.ListarCursos().OrderBy(p => p.Nombre).ToList();
            select_cursos.DisplayMember = "Nombre";
            select_cursos.ValueMember = "Id";

            IPremioMgr _Premio = new PremioMgr();
            select_premios.DataSource = _Premio.ListarPremios().OrderBy(p => p.Nombre).ToList();
            select_premios.DisplayMember = "Nombre";
            select_premios.ValueMember = "Id";

            ICargoMgr _Cargo = new CargoMgr();
            select_cargo.DataSource = _Cargo.ListarCargos().OrderBy(p => p.Nombre).ToList();
            select_cargo.DisplayMember = "Nombre";
            select_cargo.ValueMember = "Id";


            //Carga de los distinto DataGrid existentes en la ventana.
            ICargoBomberoMgr _CargoBombero = new CargoBomberoMgr();
            ICursoBomberoMgr _CursoBombero = new CursoBomberoMgr();
            IPremioBomberoMgr _PremioBombero = new PremioBomberoMgr();
            CargoBomberoDTO CargoBombero = new CargoBomberoDTO();
            CursoBomberoDTO CursoBombero = new CursoBomberoDTO();
            PremioBomberoDTO PremioBombero = new PremioBomberoDTO();
            PremioBombero.Bombero = ContextoDTO.Instancia().BomberoSelected;
            CargoBombero.Bombero = ContextoDTO.Instancia().BomberoSelected;
            CursoBombero.Bombero = ContextoDTO.Instancia().BomberoSelected;

            dataGridPremios.DataSource = _PremioBombero.CargarPremioBombero(PremioBombero).OrderBy(p => p.Premio.Nombre).ToList();
            dataGridCursos.DataSource = _CursoBombero.CargarCursoBombero(CursoBombero).OrderBy(p => p.Curso.Nombre).ToList();
            dataGridCargos.DataSource = _CargoBombero.CargarCargoBombero(CargoBombero).OrderBy(p => p.Cargo.Nombre).ToList();

            labelnombre.Text = ContextoDTO.Instancia().BomberoSelected.Nombres + " " + ContextoDTO.Instancia().BomberoSelected.Apellidos;
            labelRut.Text = ContextoDTO.Instancia().BomberoSelected.Rut;
            labelTIB.Text = ContextoDTO.Instancia().BomberoSelected.TIB;
            labelCargo.Text = ContextoDTO.Instancia().BomberoSelected.Cargo.Nombre;

            try
            {
                box_picture.Image = new Bitmap("C:\\Bomberos\\" + ContextoDTO.Instancia().BomberoSelected.Rut + ".jpg");
            }
            catch (Exception er)
            {
            }
        }

        private void HistorialCargos_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_premio_Click(object sender, EventArgs e)
        {
            IPremioBomberoMgr _PremioBombero = new PremioBomberoMgr();
            PremioBomberoDTO PremioBombero = new PremioBomberoDTO();

            PremioBombero.Premio = (PremioDTO)select_premios.SelectedItem;
            PremioBombero.Bombero = ContextoDTO.Instancia().BomberoSelected;
            PremioBombero.FechaCalifica = dateTimePremioCalifica.Value;
            PremioBombero.FechaEntrega = dateTimePremioEntrega.Value;

            if (_PremioBombero.RegistroPremioBombero(PremioBombero))
            {
                MessageBox.Show("Bombero actualizado");
                dataGridPremios.DataSource = _PremioBombero.CargarPremioBombero(PremioBombero).OrderBy(p => p.Premio.Nombre).ToList();
            }
            else
            {
                MessageBox.Show("Error al actualizar bombero");
            }
        }

        private void dateTimeCalifica_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_curso_Click(object sender, EventArgs e)
        {
            ICursoBomberoMgr _CursoBombero = new CursoBomberoMgr();
            CursoBomberoDTO CursoBombero = new CursoBomberoDTO();

            CursoBombero.FechaEntrega = dateTimeCursoEntrega.Value;
            CursoBombero.FechaFin = dateTimeCursoTermino.Value;
            CursoBombero.FechaInicio = dateTimeCursoInicio.Value;
            CursoBombero.Curso = (CursoDTO)select_cursos.SelectedItem;
            CursoBombero.Bombero = ContextoDTO.Instancia().BomberoSelected;

            if (_CursoBombero.RegistroCursoBombero(CursoBombero))
            {
                MessageBox.Show("Bombero actualizado");
                dataGridCursos.DataSource = _CursoBombero.CargarCursoBombero(CursoBombero).OrderBy(p => p.Curso.Nombre).ToList();
            }
            else
            {
                MessageBox.Show("Error al actualizar bombero");
            }
        }

        private void dateTimeTermino_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
