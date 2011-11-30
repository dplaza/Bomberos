using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Mgr
{
    public interface ICargoBomberoMgr
    {
        bool RegistroCargoBombero(CargoBomberoDTO p_CargoBombero);
        bool EditarCargoBombero(CargoBomberoDTO p_CargoBombero);
        bool BorrarCargoBombero(CargoBomberoDTO p_CargoBombero);
        List<CargoBomberoDTO> CargarCargoBombero(CargoBomberoDTO p_CargoBombero);
        List<CargoBomberoDTO> ListarCargoBomberos();
    }
}
