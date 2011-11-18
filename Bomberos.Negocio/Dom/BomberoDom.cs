using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Datos;

namespace Bomberos.Negocio.Dom
{
    public class BomberoDom : IBomberoDom
    {
        public bool Insert(BomberoDTO p_Bombero)
        {
            IBomberoDAO _Bombero = new BomberoDAO();
            return _Bombero.Insert(p_Bombero);
        }

        public BomberoDTO Load(BomberoDTO p_Bombero)
        {
            IBomberoDAO _Bombero = new BomberoDAO();
            return _Bombero.Load(p_Bombero);
        }

        public bool Delete(BomberoDTO p_Bombero)
        {
            IBomberoDAO _Bombero = new BomberoDAO();
            return _Bombero.Delete(p_Bombero);
        }

        public bool Update(BomberoDTO p_Bombero)
        {
            IBomberoDAO _Bombero = new BomberoDAO();
            return _Bombero.Update(p_Bombero);
        }

        public List<BomberoDTO> ListAll()
        {
            IBomberoDAO _Bombero = new BomberoDAO();
            return _Bombero.LoadAll();
        }
    }
}
