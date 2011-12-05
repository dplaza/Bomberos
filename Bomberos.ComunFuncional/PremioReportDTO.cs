using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.ComunFuncional
{
    public class PremioReportDTO
    {
        public string p_Nombres { get; set; }
        public string p_Apellidos { get; set; }
        public List<PremiosReport> ListaPremios { get; set; }

        public PremioReportDTO()
        {
            ListaPremios = new List<PremiosReport>();
        }

        public class PremiosReport
        {
            public string p_Nombre { get; set; }
            public string p_FechaCalifica { get; set; }
            public string p_FechaEntrega { get; set; }
        }
    }
}
