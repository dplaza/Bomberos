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
            }

            if (p_TipoReporte == EnumReportes.FichaMedica)
            {
                rptViewer.LocalReport.ReportPath = Application.StartupPath + @"\Reportes\ReporteFichaMedica.rdlc";

                FichaMedicaReportDTO ficha = (FichaMedicaReportDTO)p_ListaParametros;

                foreach (var pi in ficha.GetType().GetProperties())
                {
                    var valor = pi.GetValue(ficha, null) == null ? "" : pi.GetValue(ficha, null).ToString();
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

            if (p_TipoReporte == EnumReportes.HistorialCargos) { }
            if (p_TipoReporte == EnumReportes.HistorialCursos) { }
            if (p_TipoReporte == EnumReportes.HistorialPremios) { }
            if (p_TipoReporte == EnumReportes.Asistencia) { }
            if (p_TipoReporte == EnumReportes.Reincorporaciones) { }
            if (p_TipoReporte == EnumReportes.Servicio) { }

            rptViewer.LocalReport.SetParameters(ListaParametrosReporte);
            rptViewer.RefreshReport();
            rptViewer.Refresh();

            this.Show();
        }
    }
}
