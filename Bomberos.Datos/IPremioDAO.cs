using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.Comun
{
    public interface IPremioDAO
    {
        bool Insert(PremioDTO p_Premio);
        PremioDTO Load(PremioDTO p_Premio);
        bool Delete(PremioDTO p_Premio);
        bool Update(PremioDTO p_Premio);
        List<PremioDTO> LoadAll();
    }
}
