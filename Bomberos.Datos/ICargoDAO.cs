using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public interface ICargoDAO
    {
        bool Insert(CargoDTO p_Cargo);
        CargoDTO Load(CargoDTO p_Cargo);
        bool Delete(CargoDTO p_Cargo);
        bool Update(CargoDTO p_Cargo);
        List<CargoDTO> LoadAll();
    }
}
