using ProyectoDiseñoSistemas.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDiseñoSistemas
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            FrmAsistencia frmAsistencia = new FrmAsistencia();
            frmAsistencia.Show();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados frmEmpleados = new FrmEmpleados();
            frmEmpleados.Show();
        }

        private void BtnPlanilla_Click(object sender, EventArgs e)
        {
            FrmPlanilla frmPlanilla = new FrmPlanilla();
            frmPlanilla.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHistorialPagos frmHistorialPagos = new FrmHistorialPagos();
            frmHistorialPagos.Show();
        }

        private void BtnHorarios_Click(object sender, EventArgs e)
        {
            FrmHorarios frmHorarios = new FrmHorarios();
            frmHorarios.Show();
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            FrmVerUsuario frmVerUsuario = new FrmVerUsuario();
            frmVerUsuario.Show();
        }

        private void BtnFacturas_Click(object sender, EventArgs e)
        {
            FrmVistaBoucher frmVistaBoucher = new FrmVistaBoucher();
            frmVistaBoucher.Show();
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
