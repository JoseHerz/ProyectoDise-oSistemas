using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiseñoSistemas.Modelo
{
    internal class DeducionesModel
    {
        public int ID_EMPLEADO { get; set; }
        public int ID_DEDUCCIONES { get; set; }
        public string DESCRIPCION_DEDUCCION { get; set; }
        public bool ESTATUS { get; set; }

        public static DataTable GetDeducciones { get; set; }
    }
}
