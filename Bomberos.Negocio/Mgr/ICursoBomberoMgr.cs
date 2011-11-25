using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Mgr
{
    public interface ICursoBomberoMgr
    {
        bool RegistroCursoBombero(CursoBomberoDTO p_CursoBombero);
        bool EditarCursoBombero(CursoBomberoDTO p_CursoBombero);
        bool BorrarCursoBombero(CursoBomberoDTO p_CursoBombero);
        CursoBomberoDTO CargarCursoBombero(CursoBomberoDTO p_CursoBombero);
        List<CursoBomberoDTO> ListarCursoBomberos();
    }
}
