using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public interface IPremioBomberoDAO
    {
        bool Insert(PremioBomberoDTO p_PremioBombero);
        List<PremioBomberoDTO> Load(PremioBomberoDTO p_PremioBombero);
        bool Delete(PremioBomberoDTO p_PremioBombero);
        bool Update(PremioBomberoDTO p_PremioBombero);
        List<PremioBomberoDTO> LoadAll();
    }
}
