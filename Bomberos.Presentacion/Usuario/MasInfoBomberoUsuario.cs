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
using Bomberos.ComunFuncional.Enumeraciones;
using Bomberos.ComunFuncional.Util;
using System.IO;

namespace Bomberos.Presentacion
{
    public partial class MasInfoBomberoUsuario : Form
    {
        private FichaMedicaDTO FichaMedicaBomberoActual { get; set; }
        private BomberoDTO BomberoActual { get; set; }

        public MasInfoBomberoUsuario()
        {
            FichaMedicaBomberoActual = new FichaMedicaDTO();
            BomberoActual = new BomberoDTO();
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void InicializaInfoBombero(BomberoDTO p_Bombero)
        {
            this.BomberoActual = p_Bombero;
            this.Show();
        }

        private void MasInfoBombero_Load(object sender, EventArgs e)
        {
            #region Poblamiento de Comboboxs
            ICargoMgr _Cargo = new CargoMgr();
            select_cargo2.DataSource = _Cargo.ListarCargos().OrderBy(p => p.Nombre).ToList();
            select_cargo2.DisplayMember = "Nombre";
            select_cargo2.ValueMember = "Id";

            ICompañiaMgr _Compañia = new CompañiaMgr();
            select_compania.DataSource = _Compañia.ListarCompañias().OrderBy(p => p.Nombre).ToList();
            select_compania.DisplayMember = "Nombre";
            select_compania.ValueMember = "Id";
            #endregion

            #region Carga de DataGrids
            //Carga de los distinto DataGrid existentes en la ventana.
            ICargoBomberoMgr _CargoBombero = new CargoBomberoMgr();
            ICursoBomberoMgr _CursoBombero = new CursoBomberoMgr();
            IPremioBomberoMgr _PremioBombero = new PremioBomberoMgr();
            IObservacionBomberoMgr _ObservacionBombero = new ObservacionBomberoMgr();
            IFichaMedicaMgr _FichaMedica = new FichaMedicaMgr();
            IReincorporacionBomberoMgr _Reincorporacion = new ReincorporacionBomberoMgr();
            CargoBomberoDTO CargoBombero = new CargoBomberoDTO();
            CursoBomberoDTO CursoBombero = new CursoBomberoDTO();
            PremioBomberoDTO PremioBombero = new PremioBomberoDTO();
            ObservacionBomberoDTO ObservacionBombero = new ObservacionBomberoDTO();
            FichaMedicaDTO FichaMedica = new FichaMedicaDTO();
            ReincorporacionBomberoDTO ReincorporacionBombero = new ReincorporacionBomberoDTO();
            ReincorporacionBombero.Bombero = BomberoActual;
            PremioBombero.Bombero = BomberoActual;
            CargoBombero.Bombero = BomberoActual;
            CursoBombero.Bombero = BomberoActual;
            ObservacionBombero.Bombero = BomberoActual;
            FichaMedica.Bombero = BomberoActual;

            dataGridPremios.DataSource = _PremioBombero.CargarPremioBombero(PremioBombero).OrderBy(p => p.FechaCalifica).ToList();
            dataGridCursos.DataSource = _CursoBombero.CargarCursoBombero(CursoBombero).OrderBy(p => p.FechaInicio).ToList();
            dataGridCargos.DataSource = _CargoBombero.CargarCargoBombero(CargoBombero).OrderBy(p => p.FechaDesde).ToList();
            dataGridObservacion.DataSource = _ObservacionBombero.CargarObservacionesBombero(ObservacionBombero).OrderBy(p => p.Fecha).ToList();
            dataGridReincorporacion.DataSource = _Reincorporacion.CargarReincorporacionBombero(ReincorporacionBombero).OrderBy(p => p.FechaReincorporacion).ToList();

            dataGridCargos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPremios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridObservacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridReincorporacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            #endregion

            #region Ficha Medica
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
            #endregion

            #region Pantalla Principal
            this.Text = "Perfil de " + BomberoActual.Nombres + " " + BomberoActual.Apellidos;

            labelnombre.Text = BomberoActual.Nombres + " " + BomberoActual.Apellidos;
            labelRut.Text = BomberoActual.Rut;
            labelNumRegistro.Text = BomberoActual.NumeroRegistro.ToString();
            labelCargo.Text = BomberoActual.Cargo.Nombre;

            if (!System.IO.File.Exists(BomberoActual.PictureName))
            {
                FileStream fs = new FileStream(BomberoActual.PictureName, FileMode.Create, FileAccess.Write);
                fs.Write(BomberoActual.PictureFile, 0, BomberoActual.PictureSize);
                fs.Close();
            }

            box_picture.BackgroundImage = new Bitmap(BomberoActual.PictureName);
            box_ficha_pict.BackgroundImage = box_picture.BackgroundImage;
            #endregion

            #region Ficha Personal
            txt_nombres.Text = BomberoActual.Nombres;
            txt_apellidos.Text = BomberoActual.Apellidos;
            txt_celular.Text = BomberoActual.Celular;
            txt_dir_lab.Text = BomberoActual.DireccionLaboral;
            txt_dir_part.Text = BomberoActual.DireccionParticular;
            txt_email.Text = BomberoActual.Email;
            txt_gruposang.Text = BomberoActual.GrupoSanguineo;
            txt_pass.Text = BomberoActual.Password;
            txt_profesion.Text = BomberoActual.Profesion;
            txt_rut.Text = BomberoActual.Rut;
            date_fecha_nac.Text = BomberoActual.FechaNacimiento.ToString();
            date_fecha_inscrip.Text = BomberoActual.FechaInscripcion.ToString();
            select_estadocivil.SelectedItem = BomberoActual.EstadoCivil;
            select_compania.SelectedValue = BomberoActual.Compañia.Id;
            select_cargo2.SelectedValue = BomberoActual.Cargo.Id;
            select_estado.SelectedItem = BomberoActual.Estado;
            txt_tel_lab.Text = BomberoActual.TelefonoLaboral;
            txt_tel_part.Text = BomberoActual.TelefonoParticular;
            txt_tib.Text = BomberoActual.TIB;
            txt_socio.Text = BomberoActual.NumeroRegistro.ToString();
            select_nivel_acad.SelectedItem = BomberoActual.NivelAcademico;
            label_tiempo_servicio.Text = (DateTime.Today - BomberoActual.FechaInscripcion).TotalDays.ToString() + " día(s)";

            if (BomberoActual.isAdmin)
                select_tipocuenta.SelectedItem = "Administrador";
            else
                select_tipocuenta.SelectedItem = "Usuario";

            #endregion
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

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

            Lista.Bombero = BomberoActual;
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

        private void btn_imprimir_ficha_medica_Click(object sender, EventArgs e)
        {
            FichaMedicaReportDTO oParametro = new FichaMedicaReportDTO();
            oParametro.p_Bombero = new BomberoReportDTO();
            Utilidades.ReflectarPropiedadesSimilares(FichaMedicaBomberoActual, oParametro);
            Utilidades.ReflectarPropiedadesSimilares(BomberoActual, oParametro.p_Bombero);
            oParametro.p_Bombero.p_Compañia = BomberoActual.Compañia.Nombre;

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
            CargoBombero.Bombero = BomberoActual;

            CargoReportDTO oParametro = new CargoReportDTO();
            oParametro.p_Nombres = BomberoActual.Nombres;
            oParametro.p_Apellidos = BomberoActual.Apellidos;

            foreach (var elem in _CargoBombero.CargarCargoBombero(CargoBombero))
            {
                Bomberos.ComunFuncional.CargoReportDTO.CargosReport CargoElem = new CargoReportDTO.CargosReport();
                CargoElem.p_Nombre = elem.NombreCargo;
                CargoElem.p_FechaDesde = elem.FechaDesde.Date.ToString();
                CargoElem.p_FechaHasta = elem.FechaHasta.Date.ToString();
                oParametro.ListaCargos.Add(CargoElem);
            }

            var form = new VisorReportes();

            form.MostrarReporte(
                EnumReportes.HistorialCargos,
                oParametro
                );
        }

        private void btn_imprimir_asistencia_Click(object sender, EventArgs e)
        {
            ListaReportDTO oParametro = new ListaReportDTO();
            oParametro.p_Nombres = BomberoActual.Nombres;
            oParametro.p_Apellidos = BomberoActual.Apellidos;

            IListaMgr _Lista = new ListaMgr();
            ListaDTO Lista = new ListaDTO();
            Lista.Bombero = BomberoActual;
            Lista.Año = dateTimeListas.Value.Year;

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

            foreach (var elem in _Lista.CargarLista(Lista))
            {
                Bomberos.ComunFuncional.ListaReportDTO.ListaReport ListaElem = new ListaReportDTO.ListaReport();
                Utilidades.ReflectarPropiedadesSimilares(elem, ListaElem);
                oParametro.ListaAsistencias.Add(ListaElem);

                sumatotalLlam += elem.TotalLlamadas;
                sumatotalAbonos += elem.TotalAbonos;
                sumaSuspensiones += elem.Suspensiones;
                sumaOtrosCuerp += elem.OtrosCuerpos;
                sumaOtrasComp += elem.OtrasCompañias;
                sumaLlamadas += elem.LlamadasComandancia;
                sumaLicencias += elem.Licencias;
                sumaGuardiasNoct += elem.GuardiasNocturnas;
                sumaFaltas += elem.Faltas;
                sumaCompCanje += elem.CompañiasCanje;
                sumaAsistencias += elem.Asistencia;
            }

            oParametro.p_TotalAsistencia = sumaAsistencias.ToString();
            oParametro.p_TotalCompañiasCanje = sumaCompCanje.ToString();
            oParametro.p_TotalFaltas = sumaFaltas.ToString();
            oParametro.p_TotalGuardiasNocturnas = sumaGuardiasNoct.ToString();
            oParametro.p_TotalLicencias = sumaLicencias.ToString();
            oParametro.p_TotalLlamadasComandancia = sumaLlamadas.ToString();
            oParametro.p_TotalOtrasCompañias = sumaOtrasComp.ToString();
            oParametro.p_TotalOtrosCuerpos = sumaOtrosCuerp.ToString();
            oParametro.p_TotalSuspensiones = sumaSuspensiones.ToString();
            oParametro.p_TotalTotalAbonos = sumatotalAbonos.ToString();
            oParametro.p_TotalTotalLlamadas = sumatotalLlam.ToString();


            var form = new VisorReportes();

            form.MostrarReporte(
                EnumReportes.Asistencia,
                oParametro
                );
        }

        private void btn_imprimir_cursos_Click(object sender, EventArgs e)
        {
            CursoReportDTO oParametro = new CursoReportDTO();
            oParametro.p_Nombres = BomberoActual.Nombres;
            oParametro.p_Apellidos = BomberoActual.Apellidos;

            ICursoBomberoMgr _Curso = new CursoBomberoMgr();
            CursoBomberoDTO Curso = new CursoBomberoDTO();
            Curso.Bombero = BomberoActual;

            foreach (var elem in _Curso.CargarCursoBombero(Curso))
            {
                Bomberos.ComunFuncional.CursoReportDTO.CursosReport CursoElem = new CursoReportDTO.CursosReport();
                Utilidades.ReflectarPropiedadesSimilares(elem, CursoElem);
                CursoElem.p_Nombre = elem.NombreCurso;
                CursoElem.p_FechaTermino = elem.FechaFin.ToString();
                oParametro.ListaCursos.Add(CursoElem);
            }

            var form = new VisorReportes();

            form.MostrarReporte(
                EnumReportes.HistorialCursos,
                oParametro
                );
        }

        private void btn_imprimir_premios_Click(object sender, EventArgs e)
        {
            PremioReportDTO oParametro = new PremioReportDTO();
            oParametro.p_Nombres = BomberoActual.Nombres;
            oParametro.p_Apellidos = BomberoActual.Apellidos;

            IPremioBomberoMgr _Premio = new PremioBomberoMgr();
            PremioBomberoDTO Premio = new PremioBomberoDTO();
            Premio.Bombero = BomberoActual;

            foreach (var elem in _Premio.CargarPremioBombero(Premio))
            {
                Bomberos.ComunFuncional.PremioReportDTO.PremiosReport PremioElem = new PremioReportDTO.PremiosReport();
                Utilidades.ReflectarPropiedadesSimilares(elem, PremioElem);
                PremioElem.p_Nombre = elem.NombrePremio;
                oParametro.ListaPremios.Add(PremioElem);
            }

            var form = new VisorReportes();

            form.MostrarReporte(
                EnumReportes.HistorialPremios,
                oParametro
                );
        }

        private void btn_imprimir_observaciones_Click(object sender, EventArgs e)
        {
            ObservacionReportDTO oParametro = new ObservacionReportDTO();
            oParametro.p_Nombres = BomberoActual.Nombres;
            oParametro.p_Apellidos = BomberoActual.Apellidos;

            IObservacionBomberoMgr _Obs = new ObservacionBomberoMgr();
            ObservacionBomberoDTO Obs = new ObservacionBomberoDTO();
            Obs.Bombero = BomberoActual;

            foreach (var elem in _Obs.CargarObservacionesBombero(Obs))
            {
                Bomberos.ComunFuncional.ObservacionReportDTO.ObservacionesReport ObsElem = new ObservacionReportDTO.ObservacionesReport();
                Utilidades.ReflectarPropiedadesSimilares(elem, ObsElem);
                oParametro.ListaObservaciones.Add(ObsElem);
            }

            var form = new VisorReportes();

            form.MostrarReporte(
                EnumReportes.Observaciones,
                oParametro
                );
        }

        private void select_tipocuenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            BomberoReportDTO oParametro = new BomberoReportDTO();

            IReincorporacionBomberoMgr _Reincorporacion = new ReincorporacionBomberoMgr();
            ReincorporacionBomberoDTO ReincorporacionBombero = new ReincorporacionBomberoDTO();
            List<ReincorporacionBomberoDTO> ListaR = new List<ReincorporacionBomberoDTO>();
            ReincorporacionBombero.Bombero = BomberoActual;

            Utilidades.ReflectarPropiedadesSimilares(BomberoActual, oParametro);
            oParametro.p_Compañia = BomberoActual.Compañia.Nombre;
            oParametro.p_Cargo = BomberoActual.Cargo.Nombre;
            oParametro.p_Estado = BomberoActual.Estado;
            oParametro.p_EstadoCivil = BomberoActual.EstadoCivil;
            oParametro.p_Foto = Application.StartupPath + @"\" + BomberoActual.PictureName;

            foreach (var elem in _Reincorporacion.CargarReincorporacionBombero(ReincorporacionBombero))
            {
                Bomberos.Comun.BomberoReportDTO.ReincorporacionReport ReinElem = new BomberoReportDTO.ReincorporacionReport();
                ReinElem.p_Fecha = elem.FechaReincorporacion.Date.ToString();
                oParametro.ListaReincorporaciones.Add(ReinElem);
            }

            var form = new VisorReportes();

            form.MostrarReporte(
                EnumReportes.FichaPersonal,
                oParametro
                );
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

        private void FichaPersonal_Click(object sender, EventArgs e)
        {

        }
    }
}
