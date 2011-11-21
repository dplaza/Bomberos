using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Dom
{
    public interface IPremioDom
    {
        bool Insert(PremioDTO p_Premio);
        List<PremioDTO> LoadAll();
    }
}
