using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.ComunFuncional
{
    public class CargoReportDTO
    {
        public string p_Nombres { get; set; }
        public string p_Apellidos { get; set; }
        public List<CargosReport> ListaCargos { get; set; }

        public CargoReportDTO()
        {
            ListaCargos = new List<CargosReport>();
        }

        public class CargosReport
        {
            public string p_Nombre { get; set; }
            public string p_FechaDesde { get; set; }
            public string p_FechaHasta { get; set; }
        }
    }
}
