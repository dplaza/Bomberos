﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Negocio.Mgr
{
    public interface ICursoMgr
    {
        bool RegistroCurso(CursoDTO p_Curso);
        bool EditarCurso(CursoDTO p_Curso);
        CursoDTO CargarCurso(CursoDTO p_Curso);
        List<CursoDTO> ListarCursos();
        bool BorrarCurso(CursoDTO p_Curso);
    }
}
