using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Negocio.Dom;

namespace Bomberos.Negocio.Mgr
{
    public class ListaMgr : IListaMgr
    {
        public bool RegistroLista(ListaDTO p_Lista)
        {
            IListaDom _Lista = new ListaDom();
            return _Lista.Insert(p_Lista);
        }

        public List<ListaDTO> CargarLista(ListaDTO p_Lista)
        {
            IListaDom _Lista = new ListaDom();
            return _Lista.Load(p_Lista);
        }

        public bool EditarLista(ListaDTO p_Lista) {
            IListaDom _Lista = new ListaDom();
            return _Lista.Update(p_Lista);
        }
    }
}
