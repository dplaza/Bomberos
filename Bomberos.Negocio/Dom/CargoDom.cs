using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Datos;

namespace Bomberos.Negocio.Dom
{
    public class CargoDom : ICargoDom
    {
        public bool Insert(CargoDTO p_Cargo)
        {
            ICargoDAO _Cargo = new CargoDAO();
            return _Cargo.Insert(p_Cargo);
        }

        public bool Delete(CargoDTO p_Cargo)
        {
            ICargoDAO _Cargo = new CargoDAO();
            return _Cargo.Delete(p_Cargo);
        }

        public bool Update(CargoDTO p_Cargo)
        {
            ICargoDAO _Cargo = new CargoDAO();
            return _Cargo.Update(p_Cargo);
        }

        public CargoDTO Load(CargoDTO p_Cargo)
        {
            ICargoDAO _Cargo = new CargoDAO();
            return _Cargo.Load(p_Cargo);
        }

        public List<CargoDTO> LoadAll()
        {
            ICargoDAO _Cargo = new CargoDAO();
            return _Cargo.LoadAll();
        }
    }
}
