﻿using System;
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
    public partial class FrmVistaBoucher : Form
    {
        public FrmVistaBoucher()
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
