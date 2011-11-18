using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Mgr
{
    public interface ILoginMgr
    {
        bool Autentificacion(BomberoDTO p_Bombero, string tipo);
    }
}
