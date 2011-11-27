using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Datos;

namespace Bomberos.Negocio.Dom
{
    public class ObservacionBomberoDom : IObservacionBomberoDom
    {
        public bool Insert(ObservacionBomberoDTO p_ObservacionBombero)
        {
            IObservacionBomberoDAO _ObservacionBombero = new ObservacionBomberoDAO();
            return _ObservacionBombero.Insert(p_ObservacionBombero);
        }

        public List<ObservacionBomberoDTO> Load(ObservacionBomberoDTO p_ObservacionBombero)
        {
            IObservacionBomberoDAO _ObservacionBombero = new ObservacionBomberoDAO();
            return _ObservacionBombero.Load(p_ObservacionBombero);
        }
    }
}
