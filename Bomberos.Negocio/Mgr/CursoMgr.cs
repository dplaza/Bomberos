using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Negocio.Dom;

namespace Bomberos.Negocio.Mgr
{
    public class CursoMgr : ICursoMgr
    {
        public bool RegistroCurso(CursoDTO p_Curso)
        {
            ICursoDom _Curso = new CursoDom();
            return _Curso.Insert(p_Curso);
        }

        public List<CursoDTO> ListarCursos()
        {
            ICursoDom _Curso = new CursoDom();
            return _Curso.LoadAll();
        }
    }
}
