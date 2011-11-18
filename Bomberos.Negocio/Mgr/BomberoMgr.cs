using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Negocio.Dom;

namespace Bomberos.Negocio.Mgr
{
    public class BomberoMgr : IBomberoMgr
    {
        public bool RegistroBombero(BomberoDTO p_Bombero)
        {
            IBomberoDom _Bombero = new BomberoDom();
            return _Bombero.Insert(p_Bombero);
        }

        public bool EditarBombero(BomberoDTO p_Bombero)
        {
            IBomberoDom _Bombero = new BomberoDom();
            return _Bombero.Update(p_Bombero);
        }

        public BomberoDTO CargarBombero(BomberoDTO p_Bombero)
        {
            IBomberoDom _Bombero = new BomberoDom();
            return _Bombero.Load(p_Bombero);
        }

        public List<BomberoDTO> ListarBomberos()
        {
            IBomberoDom _Bombero = new BomberoDom();
            return _Bombero.ListAll();
        }
    }
}
