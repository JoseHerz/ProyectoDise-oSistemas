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
        public string TIPO_TURNO { get; set; }
        public bool ESTATUS { get; set; }
        public string JORNADA_LABORAL { get; set; }
        public double HORAS_SEMANALES { get; set; }

        public static DataTable GetHorarios { get; set; }
    }
}
