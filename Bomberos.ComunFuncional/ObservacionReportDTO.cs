using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.ComunFuncional
{
    public class ObservacionReportDTO
    {
        public string p_Nombres { get; set; }
        public string p_Apellidos { get; set; }
        public List<ObservacionesReport> ListaObservaciones { get; set; }

        public ObservacionReportDTO()
        {
            ListaObservaciones = new List<ObservacionesReport>();
        }

        public class ObservacionesReport
        {
            public string p_Fecha { get; set; }
            public string p_Observacion { get; set; }
        }
    }
}
