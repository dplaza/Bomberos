using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Dom
{
    public interface IReincorporacionBomberoDom
    {
        bool Insert(ReincorporacionBomberoDTO p_ReincorporacionBombero);
        List<ReincorporacionBomberoDTO> Load(ReincorporacionBomberoDTO p_ReincorporacionBombero);
        bool Update(ReincorporacionBomberoDTO p_ReincorporacionBombero);
    }
}
