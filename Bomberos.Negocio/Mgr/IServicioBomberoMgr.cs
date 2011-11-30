using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Mgr
{
    public interface IServicioBomberoMgr
    {
        bool RegistroServicioBombero(ServicioBomberoDTO p_ServicioBombero);
        bool EditarServicioBombero(ServicioBomberoDTO p_ServicioBombero);
        List<ServicioBomberoDTO> ServicioCursoBombero(ServicioBomberoDTO p_ServicioBombero);
    }
}
