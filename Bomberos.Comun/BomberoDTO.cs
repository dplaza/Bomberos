using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.Comun
{
    public class BomberoDTO
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Rut { get; set; }
        public string TIB { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string GrupoSanguineo { get; set; }
        public string DireccionParticular { get; set; }
        public string DireccionLaboral { get; set; }
        public string TelefonoParticular { get; set; }
        public string TelefonoLaboral { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Profesion { get; set; }
        public CompañiaDTO Compañia { get; set; }
        public string EstadoCivil { get; set; }
        public bool isAdmin { get; set; }
        public string Password { get; set; }
        public string Estado { get; set; }
        public CargoDTO Cargo { get; set; }
        public int NumeroRegistro { get; set; }

    }
}
