using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.Comun
{
    public class ReincorporacionBomberoDTO
    {
        public BomberoDTO Bombero { get; set; }
        public DateTime FechaReincorporacion { get; set; }
    }
}
