using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Mgr
{
    public interface ICompañiaMgr
    {
        bool RegistroCompañia(CompañiaDTO p_Compañia);
        bool EditarCompañia(CompañiaDTO p_Compañia);
        CompañiaDTO CargarCompañia(CompañiaDTO p_Compañia);
        List<CompañiaDTO> ListarCompañias();
        bool BorrarCompañia(CompañiaDTO p_Compañia);
    }
}
