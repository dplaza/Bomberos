using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Dom
{
    public interface ICargoBomberoDom
    {
        bool Insert(CargoBomberoDTO p_CargoBombero);
        CargoBomberoDTO Load(CargoBomberoDTO p_CargoBombero);
        bool Delete(CargoBomberoDTO p_CargoBombero);
        bool Update(CargoBomberoDTO p_CargoBombero);
        List<CargoBomberoDTO> LoadAll();
    }
}
