using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.Comun
{
    public class ListaDTO
    {
        public BomberoDTO Bombero { get; set; }
        public int Faltas { get; set; }
        public int Suspensiones { get; set; }
        public int Licencias { get; set; }
        public int Asistencia { get; set; }
        public int LlamadasComandancia { get; set; }
        public int GuardiasNocturnas { get; set; }
        public int CompañiasCanje { get; set; }
        public int OtrasCompañias { get; set; }
        public int OtrosCuerpos { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
    }
}
