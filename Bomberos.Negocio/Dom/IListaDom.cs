using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Dom
{
    public interface IListaDom
    {
        bool Insert(ListaDTO p_Lista);
        List<ListaDTO> Load(ListaDTO p_Lista);
        bool Update(ListaDTO p_Lista);
    }
}
