using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Mgr
{
    public interface IFichaMedicaMgr
    {
        bool RegistroFichaMedica(FichaMedicaDTO p_FichaMedica);
        bool EditarFichaMedica(FichaMedicaDTO p_FichaMedica);
        FichaMedicaDTO CargarFichaMedica(FichaMedicaDTO p_FichaMedica);
    }
}
