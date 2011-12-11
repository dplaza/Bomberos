using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.Comun
{
    public class FichaMedicaDTO
    {
        public BomberoDTO Bombero{ get; set; }
        public bool Hepatitis { get; set; }
        public bool Tifus { get; set; }
        public string OtrasEnfermedades { get; set; }
        public string Operaciones { get; set; }
        public string Alergia { get; set; }
        public bool HipertensionArterial { get; set; }
        public bool Diabetes { get; set; }
        public bool Epilepsia { get; set; }
        public bool Asma { get; set; }
        public string AntecedentesCronicos { get; set; }
        public string MedicamentosToma { get; set; }
        public string MedicamentosNoToma { get; set; }
        public string NombrePariente1 { get; set; }
        public string NombrePariente2 { get; set; }
        public string ParentescoPariente1 { get; set; }
        public string ParentescoPariente2 { get; set; }
        public string TelefonoPariente1 { get; set; }
        public string TelefonoPariente2 { get; set; }
        public string CelularPariente1 { get; set; }
        public string CelularPariente2 { get; set; }
    }
}
