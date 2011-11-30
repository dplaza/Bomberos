using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Dom
{
    public interface IServicioBomberoDom
    {
        bool Insert(ServicioBomberoDTO p_ServicioBombero);
        List<ServicioBomberoDTO> Load(ServicioBomberoDTO p_ServicioBombero);
        bool Update(ServicioBomberoDTO p_ServicioBombero);
    }
}
