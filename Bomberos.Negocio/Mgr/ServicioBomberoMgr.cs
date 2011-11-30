using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Negocio.Dom;

namespace Bomberos.Negocio.Mgr
{
    public class ServicioBomberoMgr : IServicioBomberoMgr
    {
        public bool RegistroServicioBombero(ServicioBomberoDTO p_ServicioBombero)
        {
            IServicioBomberoDom _ServicioBombero = new ServicioBomberoDom();
            return _ServicioBombero.Insert(p_ServicioBombero);
        }

        public bool EditarServicioBombero(ServicioBomberoDTO p_ServicioBombero)
        {
            IServicioBomberoDom _ServicioBombero = new ServicioBomberoDom();
            return _ServicioBombero.Update(p_ServicioBombero);
        }

        public List<ServicioBomberoDTO> CargarServicioBombero(ServicioBomberoDTO p_ServicioBombero)
        {
            IServicioBomberoDom _ServicioBombero = new ServicioBomberoDom();
            return _ServicioBombero.Load(p_ServicioBombero);
        }
    }
}
