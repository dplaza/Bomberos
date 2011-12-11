using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.Comun
{
    public class FichaMedicaReportDTO
    {
        public BomberoReportDTO p_Bombero { get; set; }
        public string p_Hepatitis { get; set; }
        public string p_Tifus { get; set; }
        public string p_OtrasEnfermedades { get; set; }
        public string p_Operaciones { get; set; }
        public string p_Alergia { get; set; }
        public string p_HipertensionArterial { get; set; }
        public string p_Diabetes { get; set; }
        public string p_Epilepsia { get; set; }
        public string p_Asma { get; set; }
        public string p_AntecedentesCronicos { get; set; }
        public string p_MedicamentosToma { get; set; }
        public string p_MedicamentosNoToma { get; set; }
        public string p_NombrePariente1 { get; set; }
        public string p_NombrePariente2 { get; set; }
        public string p_ParentescoPariente1 { get; set; }
        public string p_ParentescoPariente2 { get; set; }
        public string p_TelefonoPariente1 { get; set; }
        public string p_TelefonoPariente2 { get; set; }
        public string p_CelularPariente1 { get; set; }
        public string p_CelularPariente2 { get; set; }
    }
}
