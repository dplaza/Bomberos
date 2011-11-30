using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Mgr
{
    public interface IListaMgr
    {
        bool RegistroLista(ListaDTO p_Lista);
        List<ListaDTO> CargarLista(ListaDTO p_Lista);
        bool EditarLista(ListaDTO p_Lista);
    }
}
