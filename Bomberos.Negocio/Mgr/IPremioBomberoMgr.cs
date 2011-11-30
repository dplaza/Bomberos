using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Mgr
{
    public interface IPremioBomberoMgr
    {
        bool RegistroPremioBombero(PremioBomberoDTO p_PremioBombero);
        bool EditarPremioBombero(PremioBomberoDTO p_PremioBombero);
        bool BorrarPremioBombero(PremioBomberoDTO p_PremioBombero);
        List<PremioBomberoDTO> CargarPremioBombero(PremioBomberoDTO p_PremioBombero);
        List<PremioBomberoDTO> ListarPremioBomberos();
    }
}
