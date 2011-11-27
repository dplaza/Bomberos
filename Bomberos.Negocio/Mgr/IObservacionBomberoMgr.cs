using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Mgr
{
    public interface IObservacionBomberoMgr
    {
        bool RegistroObservacionBombero(ObservacionBomberoDTO p_ObservacionBombero);
        List<ObservacionBomberoDTO> CargarObservacionesBombero(ObservacionBomberoDTO p_ObservacionBombero);
    }
}
