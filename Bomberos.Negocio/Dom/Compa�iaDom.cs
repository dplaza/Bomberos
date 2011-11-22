using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Datos;

namespace Bomberos.Negocio.Dom
{
    public class CompañiaDom : ICompañiaDom
    {
        public bool Insert(CompañiaDTO p_Compañia)
        {
            ICompañiaDAO _Compañia = new CompañiaDAO();
            return _Compañia.Insert(p_Compañia);
        }

        public CompañiaDTO Load(CompañiaDTO p_Compañia)
        {
            ICompañiaDAO _Compañia = new CompañiaDAO();
            return _Compañia.Load(p_Compañia);
        }

        public bool Delete(CompañiaDTO p_Compañia)
        {
            ICompañiaDAO _Compañia = new CompañiaDAO();
            return _Compañia.Delete(p_Compañia);
        }

        public bool Update(CompañiaDTO p_Compañia)
        {
            ICompañiaDAO _Compañia = new CompañiaDAO();
            return _Compañia.Update(p_Compañia);
        }

        public List<CompañiaDTO> LoadAll()
        {
            ICompañiaDAO _Compañia = new CompañiaDAO();
            return _Compañia.LoadAll();
        }
    }
}
