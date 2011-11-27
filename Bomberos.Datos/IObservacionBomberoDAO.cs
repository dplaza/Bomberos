using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public interface IObservacionBomberoDAO
    {
        bool Insert(ObservacionBomberoDTO p_ObservacionBombero);
        List<ObservacionBomberoDTO> Load(ObservacionBomberoDTO p_ObservacionBombero);
    }
}
