using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public interface ICompañiaDAO
    {
        bool Insert(CompañiaDTO p_Compañia);
        CompañiaDTO Load(CompañiaDTO p_Compañia);
        bool Delete(CompañiaDTO p_Compañia);
        bool Update(CompañiaDTO p_Compañia);
        List<CompañiaDTO> LoadAll();
    }

       
}
