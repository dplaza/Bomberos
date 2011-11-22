using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Negocio.Dom;

namespace Bomberos.Negocio.Mgr
{
    public class CargoMgr : ICargoMgr
    {
        public bool RegistroCargo(CargoDTO p_Cargo)
        {
            ICargoDom _Cargo = new CargoDom();
            return _Cargo.Insert(p_Cargo);
        }

        public bool EditarCargo(CargoDTO p_Cargo)
        {
            ICargoDom _Cargo = new CargoDom();
            return _Cargo.Update(p_Cargo);
        }

        public CargoDTO CargarCargo(CargoDTO p_Cargo)
        {
            ICargoDom _Cargo = new CargoDom();
            return _Cargo.Load(p_Cargo);
        }

        public bool BorrarCargo(CargoDTO p_Cargo)
        {
            ICargoDom _Cargo = new CargoDom();
            return _Cargo.Delete(p_Cargo);
        }

        public List<CargoDTO> ListarCargos()
        {
            ICargoDom _Cargo = new CargoDom();
            return _Cargo.LoadAll();
        }
    }
}
