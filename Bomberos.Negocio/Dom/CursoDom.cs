using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;
using Bomberos.Datos;

namespace Bomberos.Negocio.Dom
{
    public class CursoDom : ICursoDom
    {
        public bool Insert(CursoDTO p_Curso)
        {
            ICursoDAO _Curso = new CursoDAO();
            return _Curso.Insert(p_Curso);
        }

        public bool Delete(CursoDTO p_Curso)
        {
            ICursoDAO _Curso = new CursoDAO();
            return _Curso.Delete(p_Curso);
        }

        public bool Update(CursoDTO p_Curso)
        {
            ICursoDAO _Curso = new CursoDAO();
            return _Curso.Update(p_Curso);
        }

        public CursoDTO Load(CursoDTO p_Curso)
        {
            ICursoDAO _Curso = new CursoDAO();
            return _Curso.Load(p_Curso);
        }

        public List<CursoDTO> LoadAll()
        {
            ICursoDAO _Curso = new CursoDAO();
            return _Curso.LoadAll();
        }
    }
}
