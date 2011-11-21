using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Mgr
{
    public interface IPremioMgr
    {
        bool RegistroPremio(PremioDTO p_Premio);
        List<PremioDTO> ListarPremios();
    }
}
