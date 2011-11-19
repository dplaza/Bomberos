using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Mgr
{
    public interface IBomberoMgr
    {
        bool RegistroBombero(BomberoDTO p_Bombero);
        bool EditarBombero(BomberoDTO p_Bombero);
        BomberoDTO CargarBombero(BomberoDTO p_Bombero);
        List<BomberoDTO> ListarBomberos();
        string digitoVerificador(int rut);
    }
}
