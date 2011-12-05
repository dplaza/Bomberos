﻿using System;
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
using Bomberos.ComunFuncional.Enumeraciones;
using Bomberos.ComunFuncional.Util;

namespace Bomberos.Presentacion
{
    public partial class MasInfoBombero : Form
    {
        public FichaMedicaDTO FichaMedicaBomberoActual { get; set; }

        public MasInfoBombero()
        {
            FichaMedicaBomberoActual = new FichaMedicaDTO();
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
            FichaMedicaBomberoActual = FichaMedica;

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
                MessageBox.Show("Observacion agregada");
                dataGridObservacion.DataSource = _ObservacionBombero.CargarObservacionesBombero(ObservacionBombero).OrderBy(p => p.Fecha).ToList();
            }
            else
            {
                MessageBox.Show("Error al agregar observacion de bombero");
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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            IListaMgr _Lista = new ListaMgr();
            ListaDTO Lista = new ListaDTO();

            Lista.Año = ListaAño.Value.Year;
            Lista.Mes = ListaMes.Value.Month;
            Lista.Asistencia = int.Parse(txt_asistencias.Text);
            Lista.Bombero = ContextoDTO.Instancia().BomberoSelected;
            Lista.CompañiasCanje = int.Parse(txt_canje.Text);
            Lista.Faltas = int.Parse(txt_faltas.Text);
            Lista.GuardiasNocturnas = int.Parse(txt_guardias.Text);
            Lista.Licencias = int.Parse(txt_licencias.Text);
            Lista.LlamadasComandancia = int.Parse(txt_llamadas.Text);
            Lista.OtrasCompañias = int.Parse(txt_otras_comp.Text);
            Lista.OtrosCuerpos = int.Parse(txt_otros_cuerp.Text);
            Lista.Suspensiones = int.Parse(txt_suspens.Text);

            if (_Lista.RegistroLista(Lista))
            {
                MessageBox.Show("Asistencia agregada con exito");
                //dataGridListas.DataSource = _Lista.CargarLista(Lista).OrderBy(p => p.Mes);
            }
            else
            {
                MessageBox.Show("Error al guardar asistencia");
            }
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

        private void btn_agregar_serv_Click(object sender, EventArgs e)
        {
            IServicioBomberoMgr _Servicio = new ServicioBomberoMgr();
            ServicioBomberoDTO Servicio = new ServicioBomberoDTO();

            Servicio.Abonos = int.Parse(txt_abonos_serv.Text);
            Servicio.Año = ServicioAño.Value.Year;
            Servicio.AñoServicio = int.Parse(txt_año_serv.Text);
            Servicio.Bombero = ContextoDTO.Instancia().BomberoSelected;
            Servicio.DiaServicio = int.Parse(txt_dia_serv.Text);
            Servicio.Faltas = int.Parse(txt_faltas_serv.Text);
            Servicio.Licencias = int.Parse(txt_licencias_serv.Text);
            Servicio.Llamadas = int.Parse(txt_llamadas_serv.Text);
            Servicio.MesServicio = int.Parse(txt_mes_serv.Text);
            Servicio.Suspensiones = int.Parse(txt_suspensiones_serv.Text);
            Servicio.Asistencia = int.Parse(txt_asistencias_serv.Text);

            if (_Servicio.RegistroServicioBombero(Servicio))
            {
                MessageBox.Show("Servicio agregado con exito");
                dataGridServicio.DataSource = _Servicio.CargarServicioBombero(Servicio);
            }
            else
            {
                MessageBox.Show("Error al guardar exito");
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

        private void btn_agregar_reincorporacion_Click(object sender, EventArgs e)
        {
            IReincorporacionBomberoMgr _Reincorporacion = new ReincorporacionBomberoMgr();
            ReincorporacionBomberoDTO Reincorporacion = new ReincorporacionBomberoDTO();

            Reincorporacion.Bombero = ContextoDTO.Instancia().BomberoSelected;
            Reincorporacion.FechaReincorporacion = dateTimeReincorporacion.Value;

            if (_Reincorporacion.RegistroReincorporacionBombero(Reincorporacion))
            {
                MessageBox.Show("Reincorporacion de Bombero agregada");
                dataGridReincorporacion.DataSource = _Reincorporacion.CargarReincorporacionBombero(Reincorporacion).OrderBy(p => p.FechaReincorporacion).ToList();
            }
            else
            {
                MessageBox.Show("Error al agregar reincorporacion de bombero");
            }
        }

        private void btn_imprimir_ficha_medica_Click(object sender, EventArgs e)
        {
            FichaMedicaReportDTO oParametro = new FichaMedicaReportDTO();
            oParametro.p_Bombero = new BomberoReportDTO();
            Utilidades.ReflectarPropiedadesSimilares(FichaMedicaBomberoActual, oParametro);
            Utilidades.ReflectarPropiedadesSimilares(ContextoDTO.Instancia().BomberoSelected, oParametro.p_Bombero);
            oParametro.p_Bombero.p_Compañia = ContextoDTO.Instancia().BomberoSelected.Compañia.Nombre;

            var form = new VisorReportes();

            form.MostrarReporte(
                EnumReportes.FichaMedica,
                oParametro
            );
        }

        private void btn_imprimir_cargos_Click(object sender, EventArgs e)
        {
            ICargoBomberoMgr _CargoBombero = new CargoBomberoMgr();
            CargoBomberoDTO CargoBombero = new CargoBomberoDTO();
            CargoBombero.Bombero = ContextoDTO.Instancia().BomberoSelected;

            CargoReportDTO oParametro = new CargoReportDTO();
            oParametro.p_Nombres = ContextoDTO.Instancia().BomberoSelected.Nombres;
            oParametro.p_Apellidos = ContextoDTO.Instancia().BomberoSelected.Apellidos;

            foreach (var elem in _CargoBombero.CargarCargoBombero(CargoBombero))
            {
                Bomberos.ComunFuncional.CargoReportDTO.CargosReport CargoElem = new CargoReportDTO.CargosReport();
                CargoElem.p_Nombre = elem.NombreCargo;
                CargoElem.p_FechaDesde = elem.FechaDesde.ToString();
                CargoElem.p_FechaHasta = elem.FechaHasta.ToString();
                oParametro.ListaCargos.Add(CargoElem);
            }

            var form = new VisorReportes();

            form.MostrarReporte(
                EnumReportes.HistorialCargos,
                oParametro
                );
        }
    }
}