using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public interface IBomberoDAO
    {
        bool Insert(BomberoDTO p_Bombero);
        BomberoDTO Load(BomberoDTO p_Bombero);
        bool Delete(BomberoDTO p_Bombero);
        bool Update(BomberoDTO p_Bombero);
        List<BomberoDTO> LoadAll();
    }
}
