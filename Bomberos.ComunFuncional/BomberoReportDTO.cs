using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.Comun
{
    public class BomberoReportDTO
    {
        public string p_Nombres { get; set; }
        public string p_Apellidos { get; set; }
        public string p_Rut { get; set; }
        public string p_TIB { get; set; }
        public string p_FechaInscripcion { get; set; }
        public string p_FechaNacimiento { get; set; }
        public string p_GrupoSanguineo { get; set; }
        public string p_DireccionParticular { get; set; }
        public string p_DireccionLaboral { get; set; }
        public string p_TelefonoParticular { get; set; }
        public string p_TelefonoLaboral { get; set; }
        public string p_Celular { get; set; }
        public string p_Email { get; set; }
        public string p_Profesion { get; set; }
        public string p_Compañia { get; set; }
        public string p_EstadoCivil { get; set; }
        public string p_Estado { get; set; }
        public string p_Cargo { get; set; }
        public string p_NumeroRegistro { get; set; }
        public string p_Foto { get; set; }
        public string p_NivelAcademico { get; set; }
        public string p_TiempoServicio { get; set; }
        public List<ReincorporacionReport> ListaReincorporaciones { get; set; }

        public BomberoReportDTO()
        {
            ListaReincorporaciones = new List<ReincorporacionReport>();
        }

        public class ReincorporacionReport
        {
            public string p_Fecha { get; set; }
        }
    }
}
