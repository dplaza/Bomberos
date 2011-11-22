using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Dom
{
    public interface ICursoDom
    {
        bool Insert(CursoDTO p_Curso);
        CursoDTO Load(CursoDTO p_Curso);
        bool Delete(CursoDTO p_Curso);
        bool Update(CursoDTO p_Curso);
        List<CursoDTO> LoadAll();
    }
}
