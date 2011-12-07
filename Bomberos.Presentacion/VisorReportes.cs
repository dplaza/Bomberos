using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bomberos.ComunFuncional.Enumeraciones;
using Bomberos.Comun;
using Microsoft.Reporting.WinForms;
using Bomberos.ComunFuncional.Util;
using Bomberos.ComunFuncional;

namespace Bomberos.Presentacion
{
    public partial class VisorReportes : Form
    {
        public VisorReportes()
        {
            InitializeComponent();
        }

        private void VisorReportes_Load(object sender, EventArgs e)
        {

            this.rptViewer.RefreshReport();
        }

        public void MostrarReporte(EnumReportes p_TipoReporte, Object p_ListaParametros)
        {
            var ListaParametrosReporte = new List<ReportParameter>();

            #region Reporte Ficha Personal
            if (p_TipoReporte == EnumReportes.FichaPersonal)
            {
                rptViewer.LocalReport.ReportPath = Application.StartupPath + @"\Reportes\ReporteFichaPersonal.rdlc";
                rptViewer.LocalReport.EnableExternalImages = true;

                BomberoReportDTO bombero = (BomberoReportDTO)p_ListaParametros;

                foreach (var pi in bombero.GetType().GetProperties())
                {
                    var valor = pi.GetValue(bombero, null) == null ? "" : pi.GetValue(bombero, null).ToString();
                    ReportParameter rp = new ReportParameter(pi.Name, valor);
                    ListaParametrosReporte.Add(rp);
                }

                ReportDataSource ds = new ReportDataSource();
                ds.Name = "ListaReincorporaciones";
                ds.Value = Utilidades.ConvertirListADataTable(bombero.ListaReincorporaciones);

                rptViewer.LocalReport.DataSources.Add(ds);
            }
            #endregion

            #region Reporte Ficha Medica
            if (p_TipoReporte == EnumReportes.FichaMedica)
            {
                rptViewer.LocalReport.ReportPath = Application.StartupPath + @"\Reportes\ReporteFichaMedica.rdlc";

                FichaMedicaReportDTO ficha = (FichaMedicaReportDTO)p_ListaParametros;


                foreach (var pi in ficha.GetType().GetProperties())
                {
                    var valor = pi.GetValue(ficha, null) == null ? "" : pi.GetValue(ficha, null).ToString();

                    if (valor.Equals("False"))
                        valor = "No";
                    if (valor.Equals("True"))
                        valor = "Sí";
                     
                    ReportParameter rp = new ReportParameter(pi.Name, valor);
                    ListaParametrosReporte.Add(rp);
                }

                foreach (var pi in ficha.p_Bombero.GetType().GetProperties())
                {
                    var valor = pi.GetValue(ficha.p_Bombero, null) == null ? "" : pi.GetValue(ficha.p_Bombero, null).ToString();
                    ReportParameter rp = new ReportParameter(pi.Name, valor);
                    ListaParametrosReporte.Add(rp);
                }
            }
            #endregion

            #region Reporte Historial Cargos
            if (p_TipoReporte == EnumReportes.HistorialCargos)
            {
                rptViewer.LocalReport.ReportPath = Application.StartupPath + @"\Reportes\ReporteCargos.rdlc";

                CargoReportDTO CargoReport = (CargoReportDTO)p_ListaParametros;

                foreach (var pi in CargoReport.GetType().GetProperties())
                {
                    var valor = pi.GetValue(CargoReport, null) == null ? "" : pi.GetValue(CargoReport, null).ToString();
                    ReportParameter rp = new ReportParameter(pi.Name, valor);
                    ListaParametrosReporte.Add(rp);
                }

                ReportDataSource ds = new ReportDataSource();
                ds.Name = "ListaCargos";
                ds.Value = Utilidades.ConvertirListADataTable(CargoReport.ListaCargos);

                rptViewer.LocalReport.DataSources.Add(ds);
            }
            #endregion

            #region Reporte Historial Cursos
            if (p_TipoReporte == EnumReportes.HistorialCursos)
            {
                rptViewer.LocalReport.ReportPath = Application.StartupPath + @"\Reportes\ReporteCursos.rdlc";

                CursoReportDTO curso = (CursoReportDTO)p_ListaParametros;

                foreach (var pi in curso.GetType().GetProperties())
                {
                    var valor = pi.GetValue(curso, null) == null ? "" : pi.GetValue(curso, null).ToString();
                    ReportParameter rp = new ReportParameter(pi.Name, valor);
                    ListaParametrosReporte.Add(rp);
                }

                ReportDataSource ds = new ReportDataSource();
                ds.Name = "ListaCursos";
                ds.Value = Utilidades.ConvertirListADataTable(curso.ListaCursos);

                rptViewer.LocalReport.DataSources.Add(ds);
            }
            #endregion

            #region Reporte Historial Premios
            if (p_TipoReporte == EnumReportes.HistorialPremios)
            {
                rptViewer.LocalReport.ReportPath = Application.StartupPath + @"\Reportes\ReportePremios.rdlc";

                PremioReportDTO premio = (PremioReportDTO)p_ListaParametros;

                foreach (var pi in premio.GetType().GetProperties())
                {
                    var valor = pi.GetValue(premio, null) == null ? "" : pi.GetValue(premio, null).ToString();
                    ReportParameter rp = new ReportParameter(pi.Name, valor);
                    ListaParametrosReporte.Add(rp);
                }

                ReportDataSource ds = new ReportDataSource();
                ds.Name = "ListaPremios";
                ds.Value = Utilidades.ConvertirListADataTable(premio.ListaPremios);

                rptViewer.LocalReport.DataSources.Add(ds);
            }
            #endregion

            #region Reporte Lista
            if (p_TipoReporte == EnumReportes.Asistencia)
            {
                rptViewer.LocalReport.ReportPath = Application.StartupPath + @"\Reportes\ReporteAsistencia.rdlc";

                ListaReportDTO lista = (ListaReportDTO)p_ListaParametros;

                foreach (var pi in lista.GetType().GetProperties())
                {
                    var valor = pi.GetValue(lista, null) == null ? "" : pi.GetValue(lista, null).ToString();
                    ReportParameter rp = new ReportParameter(pi.Name, valor);
                    ListaParametrosReporte.Add(rp);
                }

                ReportDataSource ds = new ReportDataSource();
                ds.Name = "ListaAsistencia";
                ds.Value = Utilidades.ConvertirListADataTable(lista.ListaAsistencias);

                rptViewer.LocalReport.DataSources.Add(ds);
            }
            #endregion

            #region Reporte Servicio
            if (p_TipoReporte == EnumReportes.Servicio)
            {
                rptViewer.LocalReport.ReportPath = Application.StartupPath + @"\Reportes\ReporteServicio.rdlc";

                ServicioReportDTO servicio = (ServicioReportDTO)p_ListaParametros;

                foreach (var pi in servicio.GetType().GetProperties())
                {
                    var valor = pi.GetValue(servicio, null) == null ? "" : pi.GetValue(servicio, null).ToString();
                    ReportParameter rp = new ReportParameter(pi.Name, valor);
                    ListaParametrosReporte.Add(rp);
                }

                ReportDataSource ds = new ReportDataSource();
                ds.Name = "ListaServicio";
                ds.Value = Utilidades.ConvertirListADataTable(servicio.ListaServicios);

                rptViewer.LocalReport.DataSources.Add(ds);
            }
            #endregion

            #region Reporte Observaciones
            if (p_TipoReporte == EnumReportes.Observaciones)
            {
                rptViewer.LocalReport.ReportPath = Application.StartupPath + @"\Reportes\ReporteObservaciones.rdlc";

                ObservacionReportDTO obs = (ObservacionReportDTO)p_ListaParametros;

                foreach (var pi in obs.GetType().GetProperties())
                {
                    var valor = pi.GetValue(obs, null) == null ? "" : pi.GetValue(obs, null).ToString();
                    ReportParameter rp = new ReportParameter(pi.Name, valor);
                    ListaParametrosReporte.Add(rp);
                }

                ReportDataSource ds = new ReportDataSource();
                ds.Name = "ListaObservaciones";
                ds.Value = Utilidades.ConvertirListADataTable(obs.ListaObservaciones);

                rptViewer.LocalReport.DataSources.Add(ds);
            }
            #endregion

            rptViewer.LocalReport.SetParameters(ListaParametrosReporte);
            rptViewer.RefreshReport();
            rptViewer.Refresh();

            this.Show();
        }
    }
}
