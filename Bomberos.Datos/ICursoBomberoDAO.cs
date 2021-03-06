﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberos.Comun;

namespace Bomberos.Datos
{
    public interface ICursoBomberoDAO
    {
        bool Insert(CursoBomberoDTO p_CursoBombero);
        List<CursoBomberoDTO> Load(CursoBomberoDTO p_CursoBombero);
        bool Delete(CursoBomberoDTO p_CursoBombero);
        bool Update(CursoBomberoDTO p_CursoBombero);
        List<CursoBomberoDTO> LoadAll();
    }
}
