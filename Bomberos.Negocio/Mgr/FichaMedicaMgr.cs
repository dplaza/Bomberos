using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Negocio.Dom;

namespace Bomberos.Negocio.Mgr
{
    public class FichaMedicaMgr : IFichaMedicaMgr
    {
        public bool RegistroFichaMedica(FichaMedicaDTO p_FichaMedica)
        {
            IFichaMedicaDom _FichaMedica = new FichaMedicaDom();
            return _FichaMedica.Insert(p_FichaMedica);
        }

        public bool EditarFichaMedica(FichaMedicaDTO p_FichaMedica)
        {
            IFichaMedicaDom _FichaMedica = new FichaMedicaDom();
            return _FichaMedica.Update(p_FichaMedica);
        }

        public FichaMedicaDTO CargarFichaMedica(FichaMedicaDTO p_FichaMedica)
        {
            IFichaMedicaDom _FichaMedica = new FichaMedicaDom();
            return _FichaMedica.Load(p_FichaMedica);
        }
    }
}
