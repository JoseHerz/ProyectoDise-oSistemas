using ProyectoDiseñoSistemas.Controlador;
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
    public partial class Marcaje : Form
    {
        AsistenciaModel AsistenciaModel;

        AsistenciaControl AS = new AsistenciaControl();
        public Marcaje()
        {
            InitializeComponent();
            lblmens.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horalb.Text = DateTime.Now.ToString("hh: mm: ss: HH");
            Fechalb.Text = DateTime.Now.ToString("dd/ MMM / yyyy");
        }

        void GuardarMarca()
        {
            AsistenciaModel = new AsistenciaModel();
            AsistenciaModel.ID_EMPLEADO = int.Parse(txtid.Text);
            AsistenciaModel.MARCAJE_FECHA = DateTime.Parse(Fechalb.Text);
            AsistenciaModel.MARCAJE_HORA = DateTime.Parse(horalb.Text);
            AsistenciaModel.ESTATUS = true;
            

            if (AS.Crear_Asistencia(AsistenciaModel) == true)
            {
                lblmens.Show();
                NomEmpl.Text = 
                lblmens.Text = "MARCA REGISTRADA";
                txtid.Text = string.Empty;
                this.Close();
            }
            else
            {
                lblmens.Text = "MARCA NO REGISTRADA";
            }


        }





        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnResiz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnResiz.Visible = false;
            BtnMax.Visible = true;
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMax.Visible = false;
            BtnResiz.Visible = true;
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





    }
}
