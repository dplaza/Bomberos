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
    public partial class MasInfoBomberoUsuario : Form
    {
        public MasInfoBomberoUsuario()
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
            IPremioMgr _Premio = new PremioMgr();
            ICargoMgr _Cargo = new CargoMgr();

            //Carga de los distinto DataGrid existentes en la ventana.
            ICargoBomberoMgr _CargoBombero = new CargoBomberoMgr();
            ICursoBomberoMgr _CursoBombero = new CursoBomberoMgr();
            IPremioBomberoMgr _PremioBombero = new PremioBomberoMgr();
            IObservacionBomberoMgr _ObservacionBombero = new ObservacionBomberoMgr();
            IServicioBomberoMgr _Servicio = new ServicioBomberoMgr();
            IFichaMedicaMgr _FichaMedica = new FichaMedicaMgr();
            IReincorporacionBomberoMgr _Reincorporacion = new ReincorporacionBomberoMgr();
            CargoBomberoDTO CargoBombero = new CargoBomberoDTO();
            CursoBomberoDTO CursoBombero = new CursoBomberoDTO();
            PremioBomberoDTO PremioBombero = new PremioBomberoDTO();
            ObservacionBomberoDTO ObservacionBombero = new ObservacionBomberoDTO();
            FichaMedicaDTO FichaMedica = new FichaMedicaDTO();
            ServicioBomberoDTO ServicioBombero = new ServicioBomberoDTO();
            ReincorporacionBomberoDTO ReincorporacionBombero = new ReincorporacionBomberoDTO();
            ReincorporacionBombero.Bombero = ContextoDTO.Instancia().BomberoSelected;
            PremioBombero.Bombero = ContextoDTO.Instancia().BomberoSelected;
            CargoBombero.Bombero = ContextoDTO.Instancia().BomberoSelected;
            CursoBombero.Bombero = ContextoDTO.Instancia().BomberoSelected;
            ObservacionBombero.Bombero = ContextoDTO.Instancia().BomberoSelected;
            FichaMedica.Bombero = ContextoDTO.Instancia().BomberoSelected;
            ServicioBombero.Bombero = ContextoDTO.Instancia().BomberoSelected;

            dataGridPremios.DataSource = _PremioBombero.CargarPremioBombero(PremioBombero).OrderBy(p => p.FechaCalifica).ToList();
            dataGridCursos.DataSource = _CursoBombero.CargarCursoBombero(CursoBombero).OrderBy(p => p.FechaInicio).ToList();
            dataGridCargos.DataSource = _CargoBombero.CargarCargoBombero(CargoBombero).OrderBy(p => p.FechaDesde).ToList();
            dataGridObservacion.DataSource = _ObservacionBombero.CargarObservacionesBombero(ObservacionBombero).OrderBy(p => p.Fecha).ToList();
            dataGridServicio.DataSource = _Servicio.CargarServicioBombero(ServicioBombero).OrderBy(p => p.Año).ToList();
            dataGridReincorporacion.DataSource = _Reincorporacion.CargarReincorporacionBombero(ReincorporacionBombero).OrderBy(p => p.FechaReincorporacion).ToList();

            dataGridCargos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPremios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridObservacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridReincorporacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            FichaMedica = _FichaMedica.CargarFichaMedica(FichaMedica);

            txt_med_antec.Text = FichaMedica.AntecedentesCronicos;
            txt_med_medContra.Text = FichaMedica.MedicamentosNoToma;
            txt_med_medToma.Text = FichaMedica.MedicamentosToma;
            txt_med_operac.Text = FichaMedica.Operaciones;
            txt_med_otras.Text = FichaMedica.OtrasEnfermedades;
            txt_nombre_pariente_1.Text = FichaMedica.NombrePariente1;
            txt_nomnbre_pariente_2.Text = FichaMedica.NombrePariente2;
            txt_parentesco_pariente_1.Text = FichaMedica.ParentescoPariente1;
            txt_parentesco_pariente_2.Text = FichaMedica.ParentescoPariente2;
            txt_telefono_pariente_1.Text = FichaMedica.TelefonoPariente1;
            txt_telefono_pariente_2.Text = FichaMedica.TelefonoPariente2;
            txt_celular_pariente_1.Text = FichaMedica.CelularPariente1;
            txt_celular_pariente_2.Text = FichaMedica.CelularPariente2;
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

        private void dateTimeCalifica_ValueChanged(object sender, EventArgs e)
        {

        }


        private void dateTimeTermino_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            FichaMedica.CelularPariente1 = txt_celular_pariente_1.Text;
            FichaMedica.CelularPariente2 = txt_celular_pariente_2.Text;
            FichaMedica.NombrePariente1 = txt_nombre_pariente_1.Text;
            FichaMedica.NombrePariente2 = txt_nomnbre_pariente_2.Text;
            FichaMedica.ParentescoPariente1 = txt_parentesco_pariente_1.Text;
            FichaMedica.ParentescoPariente2 = txt_parentesco_pariente_2.Text;
            FichaMedica.TelefonoPariente1 = txt_telefono_pariente_1.Text;
            FichaMedica.TelefonoPariente2 = txt_telefono_pariente_2.Text;

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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            IListaMgr _Lista = new ListaMgr();
            ListaDTO Lista = new ListaDTO();

            Lista.Bombero = ContextoDTO.Instancia().BomberoSelected;
            Lista.Año = dateTimeListas.Value.Year;
            dataGridListas.DataSource = _Lista.CargarLista(Lista);

            int sumatotalLlam = 0;
            int sumatotalAbonos = 0;
            int sumaAsistencias = 0;
            int sumaFaltas = 0;
            int sumaLlamadas = 0;
            int sumaGuardiasNoct = 0;
            int sumaOtrosCuerp = 0;
            int sumaOtrasComp = 0;
            int sumaSuspensiones = 0;
            int sumaLicencias = 0;
            int sumaCompCanje = 0;
            foreach (DataGridViewRow row in dataGridListas.Rows)
            {
                sumatotalLlam += (int)row.Cells["TotalLlamadasLista"].Value;
                sumatotalAbonos += (int)row.Cells["TotalAbonosLista"].Value;
                sumaSuspensiones += (int)row.Cells["SuspensionesLista"].Value;
                sumaOtrosCuerp += (int)row.Cells["OtrosCuerpLista"].Value;
                sumaOtrasComp += (int)row.Cells["OtrasCompLista"].Value;
                sumaLlamadas += (int)row.Cells["LlamadasComandanciaLista"].Value;
                sumaLicencias += (int)row.Cells["LicenciasLista"].Value;
                sumaGuardiasNoct += (int)row.Cells["GuardiasNocturnasLista"].Value;
                sumaFaltas += (int)row.Cells["FaltasLista"].Value;
                sumaCompCanje += (int)row.Cells["CanjeLista"].Value;
                sumaAsistencias += (int)row.Cells["AsistenciasLista"].Value;
            }
            lbl_totalLlam.Text = "Total Llamadas " + sumatotalLlam.ToString();
            lbl_asistencias.Text = "Asistencias " + sumaAsistencias.ToString();
            lbl_canje.Text = "Compañias de Canje " + sumaCompCanje.ToString();
            lbl_faltas.Text = "Faltas " + sumaFaltas.ToString();
            lbl_guardias.Text = "Guardias Nocturnas " + sumaGuardiasNoct.ToString();
            lbl_licencias.Text = "Licencias " + sumaLicencias.ToString();
            lbl_llamadas.Text = "Llamadas de Comandancia " + sumaLlamadas.ToString();
            lbl_otrasComp.Text = "Otras Compañias " + sumaOtrasComp.ToString();
            lbl_otrosCuerp.Text = "Otros Cuerpos " + sumaOtrosCuerp.ToString();
            lbl_suspens.Text = "Suspensiones " + sumaSuspensiones.ToString();
            lbl_totalAbonos.Text = "Total Abonos " + sumatotalAbonos.ToString();


        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridListas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridListas.Rows)
                {
                    IListaMgr _Lista = new ListaMgr();
                    ListaDTO ListaTemp = new ListaDTO();
                    ListaTemp = (ListaDTO)row.DataBoundItem;

                    try
                    {
                        _Lista.EditarLista(ListaTemp);
                    }
                    catch (Exception er) { }
                }
            }
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridServicio.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridServicio.Rows)
                {
                    IServicioBomberoMgr _Servicio = new ServicioBomberoMgr();
                    ServicioBomberoDTO ServicioTemp = new ServicioBomberoDTO();
                    ServicioTemp = (ServicioBomberoDTO)row.DataBoundItem;

                    try
                    {
                        _Servicio.EditarServicioBombero(ServicioTemp);
                    }
                    catch (Exception er) { }
                }
            }
        }
    }
}
