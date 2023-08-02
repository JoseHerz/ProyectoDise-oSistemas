using ProyectoDiseñoSistemas.Controlador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiseñoSistemas.Modelo
{
    internal class UsuarioModel
    {
        public int ID_USUARIO { get; set; } 

        public string USUARIO_USER { get; set; }

        public string USUARIO_PASSWORD { get; set; }

        public int ID_ROL_USUARIO { get; set; }
        public bool ESTATUS { get; set; }

        public static DataTable GetUsuarios{ get; set; }

        UsuarioControl usuariocontrol = new UsuarioControl();
        public bool Accesouser(string user, string pass)
        {
            return usuariocontrol.Acceso(user, pass);
        }



    }
}
