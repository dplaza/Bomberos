using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Dom
{
    public interface ICargoDom
    {
        bool Insert(CargoDTO p_Cargo);
        CargoDTO Load(CargoDTO p_Cargo);
        List<CargoDTO> LoadAll();
    }
}
