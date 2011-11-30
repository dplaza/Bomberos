using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.Datos
{
    public interface IListaDAO
    {
        bool Insert(ListaDTO p_Lista);
        List<ListaDTO> Load(ListaDTO p_Lista);
        bool Update(ListaDTO p_Lista);
    }
}
