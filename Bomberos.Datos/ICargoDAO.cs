using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public class ICargoDAO
    {
        bool Insert(CargoDTO p_Cargo);
        CargoDTO Load(CargoDTO p_Cargo);
        List<CargoDTO> LoadAll();
    }
}
