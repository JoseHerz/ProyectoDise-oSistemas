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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            obtenerempleados();
        }


        public void obtenerempleados()
        {
            new EmpleadoControl().ListarEmpleados();
            dataGridView1.DataSource = EmpleadosModel.GetEmpleado;
        }

        void filtrar()
        {
            EmpleadosModel.GetEmpleado.DefaultView.RowFilter = $"ID_EMPLEADO+PRIMER_NOMBRE+PRIMER_APELLIDO+DNI+DIRECCION+ESTATUS+GENERO like '%{textBox3.Text}%'";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            filtrar();
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmRegistroEmpleado frmRegistroEmpleado = new FrmRegistroEmpleado();
            frmRegistroEmpleado.ShowDialog();
        }

        int m, mx, my;

        private void BarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        

        private void BarraTitulo_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void BarraTitulo_MouseUp_1(object sender, MouseEventArgs e)
        {
            m = 0;
        }

    }
}
