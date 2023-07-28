using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiseñoSistemas.Modelo
{
    internal class PermisosModel
    {
        public int ID_EMPLEADO { get; set; }
        public string TIPO_PERMISO { get; set; }
        public DateTime DIA { get; set; }
        public DateTime HORAS { get; set; }
        public bool JUSTIFICADO { get; set; }
        public int ID_PERMISOS { get; set; }

        public static DataTable GetPermisos { get; set; }
    }
}
