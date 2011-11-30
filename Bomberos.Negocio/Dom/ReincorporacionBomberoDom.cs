using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Datos;

namespace Bomberos.Negocio.Dom
{
    public class ReincorporacionBomberoDom : IReincorporacionBomberoDom
    {
        public bool Insert(ReincorporacionBomberoDTO p_ReincorporacionBombero)
        {
            IReincorporacionBomberoDAO _ReincorporacionBombero = new ReincorporacionBomberoDAO();
            return _ReincorporacionBombero.Insert(p_ReincorporacionBombero);
        }

        public bool Update(ReincorporacionBomberoDTO p_ReincorporacionBombero)
        {
            IReincorporacionBomberoDAO _ReincorporacionBombero = new ReincorporacionBomberoDAO();
            return _ReincorporacionBombero.Update(p_ReincorporacionBombero);
        }

        public List<ReincorporacionBomberoDTO> Load(ReincorporacionBomberoDTO p_ReincorporacionBombero)
        {
            IReincorporacionBomberoDAO _ReincorporacionBombero = new ReincorporacionBomberoDAO();
            return _ReincorporacionBombero.Load(p_ReincorporacionBombero);
        }
    }
}
