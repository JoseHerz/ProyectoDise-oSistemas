﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiseñoSistemas.Modelo
{
    internal class HorasExtraModel
    {
        public int ID_HORAS_EXTRAS { get; set; }

        public int ID_EMPLEADO { get; set; }
        public DateTime DIA { get; set; }
        public DateTime HORA_INICIAL { get; set; }
        public DateTime HORA_FINAL { get; set; }
        public bool ESTATUS { get; set; }

        public static DataTable GetHorasExtras { get; set; }
    }
}
