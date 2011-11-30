using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Negocio.Dom;

namespace Bomberos.Negocio.Mgr
{
    public class ReincorporacionBomberoMgr : IReincorporacionBomberoMgr
    {
        public bool RegistroReincorporacionBombero(ReincorporacionBomberoDTO p_ReincorporacionBombero)
        {
            IReincorporacionBomberoDom _ReincorporacionBombero = new ReincorporacionBomberoDom();
            return _ReincorporacionBombero.Insert(p_ReincorporacionBombero);
        }

        public bool EditarReincorporacionBombero(ReincorporacionBomberoDTO p_ReincorporacionBombero)
        {
            IReincorporacionBomberoDom _ReincorporacionBombero = new ReincorporacionBomberoDom();
            return _ReincorporacionBombero.Update(p_ReincorporacionBombero);
        }

        public List<ReincorporacionBomberoDTO> CargarReincorporacionBombero(ReincorporacionBomberoDTO p_ReincorporacionBombero)
        {
            IReincorporacionBomberoDom _ReincorporacionBombero = new ReincorporacionBomberoDom();
            return _ReincorporacionBombero.Load(p_ReincorporacionBombero);
        }
    }
}
