using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Dom
{
    public interface ICompañiaDom
    {
        bool Insert(CompañiaDTO p_Compañia);
        CompañiaDTO Load(CompañiaDTO p_Compañia);
        List<CompañiaDTO> LoadAll();
    }
}
