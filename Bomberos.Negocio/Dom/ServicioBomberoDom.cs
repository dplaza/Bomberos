using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Datos;

namespace Bomberos.Negocio.Dom
{
    public class ServicioBomberoDom : IServicioBomberoDom
    {
        public bool Insert(ServicioBomberoDTO p_ServicioBombero)
        {
            IServicioBomberoDAO _ServicioBombero = new ServicioBomberoDAO();
            return _ServicioBombero.Insert(p_ServicioBombero);
        }

        public bool Update(ServicioBomberoDTO p_ServicioBombero)
        {
            IServicioBomberoDAO _ServicioBombero = new ServicioBomberoDAO();
            return _ServicioBombero.Update(p_ServicioBombero);
        }

        public List<ServicioBomberoDTO> Load(ServicioBomberoDTO p_ServicioBombero)
        {
            IServicioBomberoDAO _ServicioBombero = new ServicioBomberoDAO();
            return _ServicioBombero.Load(p_ServicioBombero);
        }
    }
}
