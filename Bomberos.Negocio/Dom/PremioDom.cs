using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Dom
{
    public class PremioDom : IPremioDom
    {
        public bool Insert(PremioDTO p_Premio)
        {
            return false;
        }

        public List<PremioDTO> LoadAll()
        {
            List<PremioDTO> retorno = new List<PremioDTO>();

            return retorno;
        }
    }
}
