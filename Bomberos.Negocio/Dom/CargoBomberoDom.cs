using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Datos;

namespace Bomberos.Negocio.Dom
{
    public class CargoBomberoDom : ICargoBomberoDom
    {
        public bool Insert(CargoBomberoDTO p_CargoBombero)
        {
            ICargoBomberoDAO _CargoBombero = new CargoBomberoDAO();
            return _CargoBombero.Insert(p_CargoBombero);
        }

        public bool Delete(CargoBomberoDTO p_CargoBombero)
        {
            ICargoBomberoDAO _CargoBombero = new CargoBomberoDAO();
            return _CargoBombero.Delete(p_CargoBombero);
        }

        public bool Update(CargoBomberoDTO p_CargoBombero)
        {
            ICargoBomberoDAO _CargoBombero = new CargoBomberoDAO();
            return _CargoBombero.Update(p_CargoBombero);
        }

        public List<CargoBomberoDTO> Load(CargoBomberoDTO p_CargoBombero)
        {
            ICargoBomberoDAO _CargoBombero = new CargoBomberoDAO();
            return _CargoBombero.Load(p_CargoBombero);
        }

        public List<CargoBomberoDTO> LoadAll()
        {
            ICargoBomberoDAO _CargoBombero = new CargoBomberoDAO();
            return _CargoBombero.LoadAll();
        }
    }
}
