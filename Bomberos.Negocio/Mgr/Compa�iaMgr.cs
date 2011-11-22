using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Negocio.Dom;

namespace Bomberos.Negocio.Mgr
{
    public class CompañiaMgr : ICompañiaMgr
    {
        public bool RegistroCompañia(CompañiaDTO p_Compañia)
        {
            ICompañiaDom _Compañia = new CompañiaDom();
            return _Compañia.Insert(p_Compañia);
        }

        public bool EditarCompañia(CompañiaDTO p_Compañia)
        {
            ICompañiaDom _Compañia = new CompañiaDom();
            return _Compañia.Update(p_Compañia);
        }

        public CompañiaDTO CargarCompañia(CompañiaDTO p_Compañia)
        {
            ICompañiaDom _Compañia = new CompañiaDom();
            return _Compañia.Load(p_Compañia);
        }

        public bool BorrarCompañia(CompañiaDTO p_Compañia)
        {
            ICompañiaDom _Compañia = new CompañiaDom();
            return _Compañia.Delete(p_Compañia);
        }

        public List<CompañiaDTO> ListarCompañias()
        {
            ICompañiaDom _Compañia = new CompañiaDom();
            return _Compañia.LoadAll();
        }
    }
}
