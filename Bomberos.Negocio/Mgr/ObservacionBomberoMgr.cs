using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Negocio.Dom;

namespace Bomberos.Negocio.Mgr
{
    public class ObservacionBomberoMgr : IObservacionBomberoMgr
    {
        public bool RegistroObservacionBombero(ObservacionBomberoDTO p_ObservacionBombero)
        {
            IObservacionBomberoDom _ObservacionBombero = new ObservacionBomberoDom();
            return _ObservacionBombero.Insert(p_ObservacionBombero);
        }

        public List<ObservacionBomberoDTO> CargarObservacionesBombero(ObservacionBomberoDTO p_ObservacionBombero)
        {
            IObservacionBomberoDom _ObservacionBombero = new ObservacionBomberoDom();
            return _ObservacionBombero.Load(p_ObservacionBombero);
        }
    }
}
