using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.ComunFuncional
{
    public class ServicioReportDTO
    {
        public string p_Nombres { get; set; }
        public string p_Apellidos { get; set; }
        public List<ServiciosReport> ListaServicios { get; set; }

        public ServicioReportDTO()
        {
            ListaServicios = new List<ServiciosReport>();
        }

        public class ServiciosReport
        {
            public string p_Año { get; set; }
            public string p_AñoServicio { get; set; }
            public string p_MesServicio { get; set; }
            public string p_DiaServicio { get; set; }
            public string p_Llamadas { get; set; }
            public string p_Faltas { get; set; }
            public string p_Suspensiones { get; set; }
            public string p_Licencias { get; set; }
            public string p_Asistencia { get; set; }
            public string p_Abonos { get; set; }
            public string p_TotalAsistencia { get; set; }
        }
    }
}
