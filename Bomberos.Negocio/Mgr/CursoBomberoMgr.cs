using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Negocio.Dom;

namespace Bomberos.Negocio.Mgr
{
    public class CursoBomberoMgr : ICursoBomberoMgr
    {
        public bool RegistroCursoBombero(CursoBomberoDTO p_CursoBombero)
        {
            ICursoBomberoDom _CursoBombero = new CursoBomberoDom();
            return _CursoBombero.Insert(p_CursoBombero);
        }

        public bool EditarCursoBombero(CursoBomberoDTO p_CursoBombero)
        {
            ICursoBomberoDom _CursoBombero = new CursoBomberoDom();
            return _CursoBombero.Update(p_CursoBombero);
        }

        public List<CursoBomberoDTO> CargarCursoBombero(CursoBomberoDTO p_CursoBombero)
        {
            ICursoBomberoDom _CursoBombero = new CursoBomberoDom();
            return _CursoBombero.Load(p_CursoBombero);
        }

        public List<CursoBomberoDTO> ListarCursoBomberos()
        {
            ICursoBomberoDom _CursoBombero = new CursoBomberoDom();
            return _CursoBombero.LoadAll();
        }
    }
}
