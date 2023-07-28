using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiseñoSistemas.Modelo
{
    internal class ConceptosModel
    {
        public int ID_CONCEPTO { get; set; }
        public string DESCRIPCION_CONCEPTO { get; set; }
        public bool ESTATUS { get; set; }
        public static DataTable GetConcepto { get; set; }
    }
}
