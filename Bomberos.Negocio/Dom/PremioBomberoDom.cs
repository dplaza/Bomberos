using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Datos;

namespace Bomberos.Negocio.Dom
{
    public class PremioBomberoDom: IPremioBomberoDom
    {
        public bool Insert(PremioBomberoDTO p_PremioBombero)
        {
            IPremioBomberoDAO _PremioBombero = new PremioBomberoDAO();
            return _PremioBombero.Insert(p_PremioBombero);
        }

        public bool Delete(PremioBomberoDTO p_PremioBombero)
        {
            IPremioBomberoDAO _PremioBombero = new PremioBomberoDAO();
            return _PremioBombero.Delete(p_PremioBombero);
        }

        public bool Update(PremioBomberoDTO p_PremioBombero)
        {
            IPremioBomberoDAO _PremioBombero = new PremioBomberoDAO();
            return _PremioBombero.Update(p_PremioBombero);
        }

        public PremioBomberoDTO Load(PremioBomberoDTO p_PremioBombero)
        {
            IPremioBomberoDAO _PremioBombero = new PremioBomberoDAO();
            return _PremioBombero.Load(p_PremioBombero);
        }

        public List<PremioBomberoDTO> LoadAll()
        {
            IPremioBomberoDAO _PremioBombero = new PremioBomberoDAO();
            return _PremioBombero.LoadAll();
        }
    }
}

