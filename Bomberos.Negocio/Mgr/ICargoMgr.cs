using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Mgr
{
    public interface ICargoMgr
    {
        bool RegistroCargo(CargoDTO p_Cargo);
        bool EditarCargo(CargoDTO p_Cargo);
        CargoDTO CargarCargo(CargoDTO p_Cargo);
        List<CargoDTO> ListarCargos();
    }
}
