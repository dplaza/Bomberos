using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Datos;

namespace Bomberos.Negocio.Dom
{
    public class PremioDom : IPremioDom
    {
        public bool Insert(PremioDTO p_Premio)
        {
            IPremioDAO _Premio = new PremioDAO();
            return _Premio.Insert(p_Premio);
        }

        public bool Delete(PremioDTO p_Premio)
        {
            IPremioDAO _Premio = new PremioDAO();
            return _Premio.Delete(p_Premio);
        }

        public bool Update(PremioDTO p_Premio)
        {
            IPremioDAO _Premio = new PremioDAO();
            return _Premio.Update(p_Premio);
        }

        public PremioDTO Load(PremioDTO p_Premio)
        {
            IPremioDAO _Premio = new PremioDAO();
            return _Premio.Load(p_Premio);
        }

        public List<PremioDTO> LoadAll()
        {
            IPremioDAO _Premio = new PremioDAO();
            return _Premio.LoadAll();
        }
    }
}
