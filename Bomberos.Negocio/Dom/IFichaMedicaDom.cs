using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Dom
{
    public interface IFichaMedicaDom
    {
        bool Insert(FichaMedicaDTO p_FichaMedica);
        FichaMedicaDTO Load(FichaMedicaDTO p_FichaMedica);
        bool Update(FichaMedicaDTO p_FichaMedica);
    }
}
