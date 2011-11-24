using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.Comun
{
    public class PremioBomberoDTO
    {
        public DateTime FechaCalifica { get; set; }
        public BomberoDTO Bombero { get; set; }
        public PremioDTO Premio { get; set; }
        public DateTime FechaEntrega { get; set; }
    }
}
