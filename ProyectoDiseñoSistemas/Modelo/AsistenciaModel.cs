using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiseñoSistemas.Modelo
{
    internal class AsistenciaModel
    {
        public int ID_EMPLEADO { get; set; }
        public string DIA { get; set; }
        public DateTime HORA_ENTRADA { get; set; }
        public DateTime HORA_SALIDA { get; set; }
        public bool ESTATUS { get; set; }

        public static DataTable GetAsistencia { get; set; }
    }
}
