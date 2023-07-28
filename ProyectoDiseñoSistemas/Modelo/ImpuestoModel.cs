using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiseñoSistemas.Modelo
{
    internal class ImpuestoModel
    {
        public int ID_IMPUESTO { get; set; }
        public string DESCRIPCION_IMPUESTO { get; set; }
        public int ID_EMPLEADO { get; set; }
        public double PORCENTAJE_IMPUESTO { get; set; }

        public static DataTable GetImpuestos { get; set; }
    }
}
