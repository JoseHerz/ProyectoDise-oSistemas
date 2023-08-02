using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoDiseñoSistemas.Controlador;
using ProyectoDiseñoSistemas.Modelo;

namespace ProyectoDiseñoSistemas.Vista
{
   
    public partial class FrmRegistroEmpleado : Form
    {
        EmpleadosModel empleadosModel;
        EmpleadoControl empleadoControl = new EmpleadoControl();
        public FrmEmpleados Padre;
        bool ValEditar = false;
        bool ValEliminar = false;

        public FrmRegistroEmpleado()
        {

            InitializeComponent();
        }

        public FrmRegistroEmpleado(string primNom, string segNom, string primApellido, string segApellido, int dni, int cargo, int turno, int usuario, int tipoempleado, int tiposalario, string direc, int telefono, DateTime fechana, string genero, DateTime Fechaingre, DateTime fechasal, decimal salbase, int cuenta, bool estado, string departamento)
        {
            InitializeComponent();
            TxtPrimerNombre.Text = primNom;
            TxtSegundoNombre.Text = segNom;
            TxtPrimerApellido.Text = primApellido;
            TxtSegundoApellido.Text = segApellido;
            TxtDNI.Text = dni.ToString();
            TxtDireccion.Text = direc;
            TxtTelefono.Text = telefono.ToString();
            dtpnacimiento.Value = fechana;
            cmbgenero.SelectedValue = genero;
            Dtpingreso.Value = Fechaingre;
            dtpsalida.Value = fechasal;
            chkestatus.Checked = estado;
            cmbcargo.SelectedValue = cargo;
            Cmbturno.SelectedValue = turno;
            cmbusuario.SelectedValue = usuario;
            cmbtipoempleado.SelectedValue = tipoempleado;
            cmbsalario.SelectedValue = tiposalario;
            TxtSalarioBase.Text = salbase.ToString();
            txtcuenta.Text = cuenta.ToString();
            cmbdepartamento.SelectedValue = departamento;
        }



        void Guardad()
        {
            empleadosModel = new EmpleadosModel();
            empleadosModel.PRIMER_NOMBRE = TxtPrimerNombre.Text;
            empleadosModel.SEGUNDO_NOMBRE = TxtSegundoNombre.Text;
            empleadosModel.PRIMER_APELLIDO = TxtPrimerApellido.Text;
            empleadosModel.SEGUNDO_APELLIDO = TxtSegundoApellido.Text;
            empleadosModel.DNI = int.Parse(TxtDNI.Text);
            empleadosModel.DIRECCION = TxtDireccion.Text;
            empleadosModel.TELEFONO = int.Parse(TxtTelefono.Text);
            empleadosModel.FECHA_NACIMIENTO = dtpnacimiento.Value;
            empleadosModel.GENERO = cmbgenero.SelectedItem.ToString();
            empleadosModel.FECHA_INGRESO = Dtpingreso.Value;
            empleadosModel.FECHA_SALIDA = dtpsalida.Value;
            empleadosModel.ESTATUS = chkestatus.Checked;
            //empleadosModel.ID_HORARIO = CmbHorario.SelectedItem.ToString();


        }

        //funcionamiento general
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

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void FrmRegistroEmpleado_Load(object sender, EventArgs e)
        {
            Cmbturno.DataSource = empleadoControl.AlimentarCmbTurno();
            Cmbturno.DisplayMember = "TIPO_TURNO";
            Cmbturno.ValueMember = "ID_HORARIO";
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
