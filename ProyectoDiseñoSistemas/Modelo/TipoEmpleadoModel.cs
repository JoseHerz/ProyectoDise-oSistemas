using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiseñoSistemas.Modelo
{
    internal class TipoEmpleadoModel
    {
        public int ID_TIPO_EMPLEADO { get; set; }
        public string DESCRIPCION_TIPOEMPLEADO { get; set; }
        public bool HORAS_EXTRAS { get; set; }
        public static DataTable GetTipoEmpleado { get; set; }
    }
}
