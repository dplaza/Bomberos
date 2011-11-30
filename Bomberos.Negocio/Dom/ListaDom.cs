using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Datos;

namespace Bomberos.Negocio.Dom
{
    public class ListaDom : IListaDom
    {
        public bool Insert(ListaDTO p_Lista)
        {
            IListaDAO _Lista = ListaDAO();
            return _Lista.Insert(p_Lista);
        }

        public List<ListaDTO> Load(ListaDTO p_Lista)
        {
            IListaDAO _Lista = ListaDAO();
            return _Lista.Load(p_Lista);
        }

        public bool Update(ListaDTO p_Lista)
        {
            IListaDAO _Lista = ListaDAO();
            return _Lista.Update(p_Lista);
        }
    }
}
