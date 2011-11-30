using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public interface IReincorporacionBomberoDAO
    {
        bool Insert(ReincorporacionBomberoDTO p_ReincorporacionBombero);
        List<ReincorporacionBomberoDTO> Load(ReincorporacionBomberoDTO p_ReincorporacionBombero);
        bool Update(ReincorporacionBomberoDTO p_ReincorporacionBombero);
    }
}
