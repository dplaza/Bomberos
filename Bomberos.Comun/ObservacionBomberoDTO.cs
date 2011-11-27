using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.Comun
{
    public class ObservacionBomberoDTO
    {
        public BomberoDTO Bombero { get; set; }
        public string Observacion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
