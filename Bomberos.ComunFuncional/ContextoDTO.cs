using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.ComunFuncional
{
    public class ContextoDTO
    {
        private static ContextoDTO _instancia = null;

        public BomberoDTO BomberoActual { get; set; }

        public static ContextoDTO Instancia()
        {
            if (_instancia == null)
                _instancia = new ContextoDTO();

            return _instancia;
        }

        private ContextoDTO()
        {
            BomberoActual = new BomberoDTO();
        }

    }
}
