using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Negocio.Dom;

namespace Bomberos.Negocio.Mgr
{
    public class PremioMgr : IPremioMgr
    {
        public bool RegistroPremio(PremioDTO p_Premio)
        {
            IPremioDom _Premio = new PremioDom();
            return _Premio.Insert(p_Premio);
        }

        public bool EditarPremio(PremioDTO p_Premio)
        {
            IPremioDom _Premio = new PremioDom();
            return _Premio.Update(p_Premio);
        }

        public PremioDTO CargarPremio(PremioDTO p_Premio)
        {
            IPremioDom _Premio = new PremioDom();
            return _Premio.Load(p_Premio);
        }

        public bool BorrarPremio(PremioDTO p_Premio)
        {
            IPremioDom _Premio = new PremioDom();
            return _Premio.Delete(p_Premio);
        }

        public List<PremioDTO> ListarPremios()
        {
            IPremioDom _Premio = new PremioDom();
            return _Premio.LoadAll();
        }
    }
}
