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
            IObservacionBomberoMgr _ObservacionBombero = new ObservacionBomberoMgr();
            IFichaMedicaMgr _FichaMedica = new FichaMedicaMgr();
            CargoBomberoDTO CargoBombero = new CargoBomberoDTO();
            CursoBomberoDTO CursoBombero = new CursoBomberoDTO();
            PremioBomberoDTO PremioBombero = new PremioBomberoDTO();
            ObservacionBomberoDTO ObservacionBombero = new ObservacionBomberoDTO();
            FichaMedicaDTO FichaMedica = new FichaMedicaDTO();
            PremioBombero.Bombero = ContextoDTO.Instancia().BomberoSelected;
            CargoBombero.Bombero = ContextoDTO.Instancia().BomberoSelected;
            CursoBombero.Bombero = ContextoDTO.Instancia().BomberoSelected;
            ObservacionBombero.Bombero = ContextoDTO.Instancia().BomberoSelected;
            FichaMedica.Bombero = ContextoDTO.Instancia().BomberoSelected;

            dataGridPremios.DataSource = _PremioBombero.CargarPremioBombero(PremioBombero).OrderBy(p => p.FechaCalifica).ToList();
            dataGridCursos.DataSource = _CursoBombero.CargarCursoBombero(CursoBombero).OrderBy(p => p.FechaInicio).ToList();
            dataGridCargos.DataSource = _CargoBombero.CargarCargoBombero(CargoBombero).OrderBy(p => p.FechaDesde).ToList();
            dataGridObservacion.DataSource = _ObservacionBombero.CargarObservacionesBombero(ObservacionBombero).OrderBy(p => p.Fecha).ToList();

            dataGridCargos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPremios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridObservacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            FichaMedica = _FichaMedica.CargarFichaMedica(FichaMedica);

            txt_med_antec.Text = FichaMedica.AntecedentesCronicos;
            txt_med_medContra.Text = FichaMedica.MedicamentosNoToma;
            txt_med_medToma.Text = FichaMedica.MedicamentosToma;
            txt_med_operac.Text = FichaMedica.Operaciones;
            txt_med_otras.Text = FichaMedica.OtrasEnfermedades;
            select_asma.SelectedItem = "No";
            select_diab.SelectedItem = "No";
            select_epilep.SelectedItem = "No";
            select_hipert.SelectedItem = "No";
            select_tifus.SelectedItem = "No";
            select_hepat.SelectedItem = "No";

            if (FichaMedica.Asma)
                select_asma.SelectedItem = "Sí";
            if (FichaMedica.Diabetes)
                select_diab.SelectedItem = "Sí";
            if (FichaMedica.Epilepsia)
                select_epilep.SelectedItem = "Sí";
            if (FichaMedica.Hepatitis)
                select_hepat.SelectedItem = "Sí";
            if (FichaMedica.HipertensionArterial)
                select_hipert.SelectedItem = "Sí";
            if (FichaMedica.Tifus)
                select_tifus.SelectedItem = "Sí";

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
                dataGridPremios.DataSource = _PremioBombero.CargarPremioBombero(PremioBombero).OrderBy(p => p.FechaCalifica).ToList();
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
                dataGridCursos.DataSource = _CursoBombero.CargarCursoBombero(CursoBombero).OrderBy(p => p.FechaInicio).ToList();
            }
            else
            {
                MessageBox.Show("Error al actualizar bombero");
            }
        }

        private void dateTimeTermino_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_actual_Click(object sender, EventArgs e)
        {
            dateTimeCargoHasta.Enabled = false;
        }

        private void dateTimeDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_cargo_Click(object sender, EventArgs e)
        {
            ICargoBomberoMgr _CargoBombero = new CargoBomberoMgr();
            CargoBomberoDTO CargoBombero = new CargoBomberoDTO();

            CargoBombero.FechaDesde = dateTimeCargoDesde.Value;
            CargoBombero.FechaHasta = dateTimeCargoHasta.Value;
            CargoBombero.Bombero = ContextoDTO.Instancia().BomberoSelected;
            CargoBombero.Cargo = (CargoDTO)select_cargo.SelectedItem;

            if (_CargoBombero.RegistroCargoBombero(CargoBombero))
            {
                MessageBox.Show("Bombero actualizado");
                dataGridCargos.DataSource = _CargoBombero.CargarCargoBombero(CargoBombero).OrderBy(p => p.FechaDesde).ToList();
            }
            else
            {
                MessageBox.Show("Error al actualizar bombero");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_observacion_Click(object sender, EventArgs e)
        {
            IObservacionBomberoMgr _ObservacionBombero = new ObservacionBomberoMgr();
            ObservacionBomberoDTO ObservacionBombero = new ObservacionBomberoDTO();

            ObservacionBombero.Bombero = ContextoDTO.Instancia().BomberoSelected;
            ObservacionBombero.Fecha = dateTimeObservacionFecha.Value;
            ObservacionBombero.Observacion = txtobservacion.Text;

            if (_ObservacionBombero.RegistroObservacionBombero(ObservacionBombero))
            {
                MessageBox.Show("Bombero actualizado");
                dataGridObservacion.DataSource = _ObservacionBombero.CargarObservacionesBombero(ObservacionBombero).OrderBy(p => p.Fecha).ToList();
            }
            else
            {
                MessageBox.Show("Error al actualizar bombero");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_borrar_cargo_Click(object sender, EventArgs e)
        {
            ICargoBomberoMgr _CargoBombero = new CargoBomberoMgr();
            CargoBomberoDTO CargoBombero = new CargoBomberoDTO();

            if (dataGridCargos.SelectedRows.Count > 0)
            {
                CargoBombero = (CargoBomberoDTO)dataGridCargos.SelectedRows[0].DataBoundItem;

                if (!_CargoBombero.BorrarCargoBombero(CargoBombero))
                {
                    MessageBox.Show("Falla al borrar cargo");
                }
                else
                {
                    dataGridCargos.DataSource = _CargoBombero.CargarCargoBombero(CargoBombero).OrderBy(p => p.FechaDesde).ToList();
                }
            }
        }

        private void btn_borrar_premio_Click(object sender, EventArgs e)
        {
            IPremioBomberoMgr _PremioBombero = new PremioBomberoMgr();
            PremioBomberoDTO PremioBombero = new PremioBomberoDTO();

            if (dataGridPremios.SelectedRows.Count > 0)
            {
                PremioBombero = (PremioBomberoDTO)dataGridPremios.SelectedRows[0].DataBoundItem;

                if (!_PremioBombero.BorrarPremioBombero(PremioBombero))
                {
                    MessageBox.Show("Falla al borrar premio");
                }
                else
                {
                    dataGridPremios.DataSource = _PremioBombero.CargarPremioBombero(PremioBombero).OrderBy(p => p.FechaCalifica).ToList();
                }
            }
        }

        private void btn_borrar_curso_Click(object sender, EventArgs e)
        {
            ICursoBomberoMgr _CursoBombero = new CursoBomberoMgr();
            CursoBomberoDTO CursoBombero = new CursoBomberoDTO();

            if (dataGridCursos.SelectedRows.Count > 0)
            {
                CursoBombero = (CursoBomberoDTO)dataGridCursos.SelectedRows[0].DataBoundItem;

                if (!_CursoBombero.BorrarCursoBombero(CursoBombero))
                {
                    MessageBox.Show("Falla al borrar curso");
                }
                else
                {
                    dataGridCursos.DataSource = _CursoBombero.CargarCursoBombero(CursoBombero).OrderBy(p => p.FechaInicio).ToList();
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Parientes();
            //form.Parent = this.Parent.Parent.Parent;
            form.Show();
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_enviar_cambios_Click(object sender, EventArgs e)
        {
            IFichaMedicaMgr _FichaMedica = new FichaMedicaMgr();
            FichaMedicaDTO FichaMedica = new FichaMedicaDTO();

            FichaMedica.Bombero = ContextoDTO.Instancia().BomberoSelected;
            FichaMedica.AntecedentesCronicos = txt_med_antec.Text;
            FichaMedica.MedicamentosNoToma = txt_med_medContra.Text;
            FichaMedica.MedicamentosToma = txt_med_medToma.Text;
            FichaMedica.Operaciones = txt_med_operac.Text;
            FichaMedica.OtrasEnfermedades = txt_med_otras.Text;
            FichaMedica.Asma = false;
            FichaMedica.Diabetes = false;
            FichaMedica.Epilepsia = false;
            FichaMedica.Hepatitis = false;
            FichaMedica.HipertensionArterial = false;
            FichaMedica.Tifus = false;

            if (select_asma.Text.Equals("Sí"))
                FichaMedica.Asma = true;
            if (select_diab.Text.Equals("Sí"))
                FichaMedica.Diabetes = true;
            if (select_epilep.Text.Equals("Sí"))
                FichaMedica.Epilepsia = true;
            if (select_hepat.Text.Equals("Sí"))
                FichaMedica.Hepatitis = true;
            if (select_hipert.Text.Equals("Sí"))
                FichaMedica.HipertensionArterial = true;
            if (select_tifus.Text.Equals("Sí"))
                FichaMedica.Tifus = true;

            if (_FichaMedica.EditarFichaMedica(FichaMedica))
            {
                MessageBox.Show("Ficha medica actualizada exitosamente");

                txt_med_antec.Text = FichaMedica.AntecedentesCronicos;
                txt_med_medContra.Text = FichaMedica.MedicamentosNoToma;
                txt_med_medToma.Text = FichaMedica.MedicamentosToma;
                txt_med_operac.Text = FichaMedica.Operaciones;
                txt_med_otras.Text = FichaMedica.OtrasEnfermedades;
                select_asma.SelectedItem = "No";
                select_diab.SelectedItem = "No";
                select_epilep.SelectedItem = "No";
                select_hipert.SelectedItem = "No";
                select_tifus.SelectedItem = "No";
                select_hepat.SelectedItem = "No";

                if (FichaMedica.Asma)
                    select_asma.SelectedItem = "Sí";
                if (FichaMedica.Diabetes)
                    select_diab.SelectedItem = "Sí";
                if (FichaMedica.Epilepsia)
                    select_epilep.SelectedItem = "Sí";
                if (FichaMedica.Hepatitis)
                    select_hepat.SelectedItem = "Sí";
                if (FichaMedica.HipertensionArterial)
                    select_hipert.SelectedItem = "Sí";
                if (FichaMedica.Tifus)
                    select_tifus.SelectedItem = "Sí";
            }
            else
            {
                MessageBox.Show("Error al actualizar ficha medica");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            IListaMgr _Lista = new ListaMgr();
            ListaDTO Lista = new ListaDTO();

            Lista.Bombero = ContextoDTO.Instancia().BomberoSelected;
            dataGridListas.DataSource = _Lista.CargarLista(Lista).FindAll(p => p.Año.Equals(dateTimeListas.Value.ToString()));
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void ResumenListas_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_faltas_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void Servicio_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiaTpoServ_TextChanged(object sender, EventArgs e)
        {

        }

        private void AbonosServ_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
