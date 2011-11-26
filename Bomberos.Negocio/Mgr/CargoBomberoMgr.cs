using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Negocio.Dom;

namespace Bomberos.Negocio.Mgr
{
    public class CargoBomberoMgr : ICargoBomberoMgr
    {
        public bool RegistroCargoBombero(CargoBomberoDTO p_CargoBombero)
        {
            ICargoBomberoDom _CargoBombero = new CargoBomberoDom();
            return _CargoBombero.Insert(p_CargoBombero);
        }

        public bool EditarCargoBombero(CargoBomberoDTO p_CargoBombero)
        {
            ICargoBomberoDom _CargoBombero = new CargoBomberoDom();
            return _CargoBombero.Update(p_CargoBombero);
        }

        public List<CargoBomberoDTO> CargarCargoBombero(CargoBomberoDTO p_CargoBombero)
        {
            ICargoBomberoDom _CargoBombero = new CargoBomberoDom();
            return _CargoBombero.Load(p_CargoBombero);
        }

        public List<CargoBomberoDTO> ListarCargoBomberos()
        {
            ICargoBomberoDom _CargoBombero = new CargoBomberoDom();
            return _CargoBombero.LoadAll();
        }

    }
}