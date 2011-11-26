using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.Comun
{
    public class CargoBomberoDTO
    {
        public DateTime FechaDesde { get; set; }
        public BomberoDTO Bombero { get; set; }
        public CargoDTO Cargo { get; set; }
        public string NombreCargo { get; set; }
        public DateTime FechaHasta { get; set; }
    }
}
