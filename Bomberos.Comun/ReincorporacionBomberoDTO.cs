﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.Comun
{
    public class ReincorporacionBomberoDTO
    {
        public BomberoDTO Bombero { get; set; }
        public DateTime FechaSuspension { get; set; }
        public DateTime FechaReincorporacion { get; set; }
        public string Sancion { get; set; }
        public string Observacion_Med { get; set; }
    }
}
