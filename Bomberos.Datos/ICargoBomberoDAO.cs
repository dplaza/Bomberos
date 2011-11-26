using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public interface ICargoBomberoDAO
    {
        bool Insert(CargoBomberoDTO p_CargoBombero);
        List<CargoBomberoDTO> Load(CargoBomberoDTO p_CargoBombero);
        bool Delete(CargoBomberoDTO p_CargoBombero);
        bool Update(CargoBomberoDTO p_CargoBombero);
        List<CargoBomberoDTO> LoadAll();
    }
}
