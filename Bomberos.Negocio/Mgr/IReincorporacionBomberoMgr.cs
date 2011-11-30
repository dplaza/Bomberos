using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Mgr
{
    public interface IReincorporacionBomberoMgr
    {
        bool RegistroReincorporacionBombero(ReincorporacionBomberoDTO p_ReincorporacionBombero);
        bool EditarReincorporacionBombero(ReincorporacionBomberoDTO p_ReincorporacionBombero);
        List<ReincorporacionBomberoDTO> CargarReincorporacionBombero(ReincorporacionBomberoDTO p_ReincorporacionBombero);
    }
}
