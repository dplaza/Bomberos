using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.ComunFuncional
{
    public class ListaReportDTO
    {
        public string p_Nombres { get; set; }
        public string p_Apellidos { get; set; }
        public List<ListaReport> ListaAsistencias { get; set; }

        public string p_TotalFaltas { get; set; }
        public string p_TotalSuspensiones { get; set; }
        public string p_TotalLicencias { get; set; }
        public string p_TotalAsistencia { get; set; }
        public string p_TotalLlamadasComandancia { get; set; }
        public string p_TotalGuardiasNocturnas { get; set; }
        public string p_TotalCompañiasCanje { get; set; }
        public string p_TotalOtrasCompañias { get; set; }
        public string p_TotalOtrosCuerpos { get; set; }
        public string p_TotalTotalLlamadas { get; set; }
        public string p_TotalTotalAbonos { get; set; }

        public ListaReportDTO()
        {
            ListaAsistencias = new List<ListaReport>();
        }

        public class ListaReport
        {
            public string p_Faltas { get; set; }
            public string p_Suspensiones { get; set; }
            public string p_Licencias { get; set; }
            public string p_Asistencia { get; set; }
            public string p_LlamadasComandancia { get; set; }
            public string p_GuardiasNocturnas { get; set; }
            public string p_CompañiasCanje { get; set; }
            public string p_OtrasCompañias { get; set; }
            public string p_OtrosCuerpos { get; set; }
            public string p_Año { get; set; }
            public string p_Mes { get; set; }
            public string p_TotalLlamadas { get; set; }
            public string p_TotalAbonos { get; set; }
        }
    }
}
