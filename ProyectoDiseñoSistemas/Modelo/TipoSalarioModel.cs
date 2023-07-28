using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiseñoSistemas.Modelo
{
    internal class TipoSalarioModel
    {
        public int ID_TIPO_SALARIO { get; set; }
        public string DESCRIPCION_TIPO_SALARIO { get; set; }
        public bool ESTATUS { get; set; }
        public static DataTable GetTipoSalario { get; set; }
    }
}
