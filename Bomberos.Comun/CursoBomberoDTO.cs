using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.Comun
{
    public class CursoBomberoDTO
    {
        public DateTime FechaInicio { get; set; }
        public BomberoDTO Bombero { get; set; }
        public CursoDTO Curso { get; set; }
        public string NombreCurso { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string LugarCurso { get; set; }
    }

}
