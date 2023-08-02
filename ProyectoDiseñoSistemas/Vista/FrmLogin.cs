using ProyectoDiseñoSistemas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDiseñoSistemas.Vista
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        int m, mx, my;

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

       

        private void BarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void BarraTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(user.Text !="")
            {
                if(pass.Text != "")
                {
                    UsuarioModel users = new UsuarioModel();
                    var validaccess = users.Accesouser(user.Text,pass.Text);
                    if(validaccess == true)
                    {
                        FrmMenu menu = new FrmMenu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        msgbox("Usuario o Contraseña incorrecto");
                        pass.Clear();
                        user.Focus();
                    }
                
                }
                else
                {
                    msgbox("Porfavor ingrese el Contraseña");
                }
            }
            else
            {
                msgbox("Porfavor ingrese el usuario");
            }
        }

        private void msgbox(string msg)
        {
            lblerror.Text = msg;
            lblerror.Visible = true;
        }







    }
}
