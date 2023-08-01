using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiseñoSistemas.Modelo
{
    internal class HorariosModel
    {
        public int ID_HORARIO { get; set; }
        public string DESCRIPCION_HORARIO { get; set; }
        public string TIPO_TURNO { get; set; }
        public DateTime HORA_ENTRADA { get; set; }
        public DateTime HORA_SALIDA { get; set; }
        public double HORAS_SEMANALES { get; set; }
        public bool ESTATUS { get; set; }
        public DateTime FECHAINICIO { get; set; }


        public static DataTable GetHorarios { get; set; }
    }
}
