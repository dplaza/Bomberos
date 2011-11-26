using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Datos;

namespace Bomberos.Negocio.Dom
{
    public class CursoBomberoDom : ICursoBomberoDom
    {
        public bool Insert(CursoBomberoDTO p_CursoBombero)
        {
            ICursoBomberoDAO _CursoBombero = new CursoBomberoDAO();
            return _CursoBombero.Insert(p_CursoBombero);
        }

        public bool Delete(CursoBomberoDTO p_CursoBombero)
        {
            ICursoBomberoDAO _CursoBombero = new CursoBomberoDAO();
            return _CursoBombero.Delete(p_CursoBombero);
        }

        public bool Update(CursoBomberoDTO p_CursoBombero)
        {
            ICursoBomberoDAO _CursoBombero = new CursoBomberoDAO();
            return _CursoBombero.Update(p_CursoBombero);
        }

        public List<CursoBomberoDTO> Load(CursoBomberoDTO p_CursoBombero)
        {
            ICursoBomberoDAO _CursoBombero = new CursoBomberoDAO();
            return _CursoBombero.Load(p_CursoBombero);
        }

        public List<CursoBomberoDTO> LoadAll()
        {
            ICursoBomberoDAO _CursoBombero = new CursoBomberoDAO();
            return _CursoBombero.LoadAll();
        }
    }
}
