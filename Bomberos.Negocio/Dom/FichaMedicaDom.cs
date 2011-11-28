using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Datos;

namespace Bomberos.Negocio.Dom
{
    public class FichaMedicaDom : IFichaMedicaDom
    {
        public bool Insert(FichaMedicaDTO p_FichaMedica)
        {
            IFichaMedicaDAO _FichaMedica= new FichaMedicaDAO();
            return _FichaMedica.Insert(p_FichaMedica);
        }

        public FichaMedicaDTO Load(FichaMedicaDTO p_FichaMedica)
        {
            IFichaMedicaDAO _FichaMedica = new FichaMedicaDAO();
            return _FichaMedica.Load(p_FichaMedica);
        }

        public bool Update(FichaMedicaDTO p_FichaMedica)
        {
            IFichaMedicaDAO _FichaMedica = new FichaMedicaDAO();
            return _FichaMedica.Update(p_FichaMedica);
        }

    }
}
