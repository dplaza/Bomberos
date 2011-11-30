using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.Comun
{
    public class ServicioBomberoDTO
    {
        public int Año { get; set; }
        public int AñoServicio { get; set; }
        public int MesServicio { get; set; }
        public int DiaServicio { get; set; }
        public BomberoDTO Bombero { get; set; }
        public int Llamadas { get; set; }
        public int Faltas { get; set; }
        public int Suspensiones { get; set; }
        public int Licencias { get; set; }
        public int Asistencia { get; set; }
        public int Abonos { get; set; }
        public int TotalAsistencia { get; set; }
    }
}
