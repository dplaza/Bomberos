using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.ComunFuncional
{
    public class CursoReportDTO
    {
        public string p_Nombres { get; set; }
        public string p_Apellidos { get; set; }
        public List<CursosReport> ListaCursos { get; set; }

        public CursoReportDTO()
        {
            ListaCursos = new List<CursosReport>();
        }

        public class CursosReport
        {
            public string p_Nombre { get; set; }
            public string p_FechaInicio { get; set; }
            public string p_FechaTermino { get; set; }
            public string p_FechaEntrega { get; set; }
            public string p_LugarCurso { get; set; }
        }
    }
}