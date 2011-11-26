using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Negocio.Dom;

namespace Bomberos.Negocio.Mgr
{
    public class PremioBomberoMgr : IPremioBomberoMgr
    {
        public bool RegistroPremioBombero(PremioBomberoDTO p_CargoBombero)
        {
            IPremioBomberoDom _PremioBombero = new PremioBomberoDom();
            return _PremioBombero.Insert(p_CargoBombero);
        }

        public bool EditarPremioBombero(PremioBomberoDTO p_PremioBombero)
        {
            IPremioBomberoDom _PremioBombero = new PremioBomberoDom();
            return _PremioBombero.Update(p_PremioBombero);
        }

        public List<PremioBomberoDTO> CargarPremioBombero(PremioBomberoDTO p_PremioBombero)
        {
            IPremioBomberoDom _PremioBombero = new PremioBomberoDom();
            return _PremioBombero.Load(p_PremioBombero);
        }

        public List<PremioBomberoDTO> ListarPremioBomberos()
        {
            IPremioBomberoDom _PremioBombero = new PremioBomberoDom();
            return _PremioBombero.LoadAll();
        }
    }
}
