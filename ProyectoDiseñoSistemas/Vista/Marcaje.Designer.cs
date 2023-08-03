namespace ProyectoDiseñoSistemas.Vista
{
    partial class Marcaje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marcaje));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnResiz = new System.Windows.Forms.PictureBox();
            this.BtnMin = new System.Windows.Forms.PictureBox();
            this.BtnMax = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.horalb = new System.Windows.Forms.Label();
            this.Fechalb = new System.Windows.Forms.Label();
            this.NomEmpl = new System.Windows.Forms.Label();
            this.PhotoEmpl = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.BtnHorarios = new System.Windows.Forms.Button();
            this.BtnAsistencia = new System.Windows.Forms.Button();
            this.BtnFacturas = new System.Windows.Forms.Button();
            this.BtnPlanilla = new System.Windows.Forms.Button();
            this.BtnEmpleados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnmarca = new System.Windows.Forms.Button();
            this.lblmens = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnResiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            this.PanelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoEmpl)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(33)))), ((int)(((byte)(225)))));
            this.BarraTitulo.Controls.Add(this.label2);
            this.BarraTitulo.Controls.Add(this.BtnResiz);
            this.BarraTitulo.Controls.Add(this.BtnMin);
            this.BarraTitulo.Controls.Add(this.BtnMax);
            this.BarraTitulo.Controls.Add(this.BtnExit);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(220, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(642, 35);
            this.BarraTitulo.TabIndex = 6;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            this.BarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseMove);
            this.BarraTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Principal";
            // 
            // BtnResiz
            // 
            this.BtnResiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnResiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResiz.Image = ((System.Drawing.Image)(resources.GetObject("BtnResiz.Image")));
            this.BtnResiz.Location = new System.Drawing.Point(556, 0);
            this.BtnResiz.Name = "BtnResiz";
            this.BtnResiz.Size = new System.Drawing.Size(39, 35);
            this.BtnResiz.TabIndex = 3;
            this.BtnResiz.TabStop = false;
            this.BtnResiz.Visible = false;
            this.BtnResiz.Click += new System.EventHandler(this.BtnResiz_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMin.Image = ((System.Drawing.Image)(resources.GetObject("BtnMin.Image")));
            this.BtnMin.Location = new System.Drawing.Point(512, 11);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(39, 29);
            this.BtnMin.TabIndex = 2;
            this.BtnMin.TabStop = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMax.Image = ((System.Drawing.Image)(resources.GetObject("BtnMax.Image")));
            this.BtnMax.Location = new System.Drawing.Point(556, 0);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(39, 35);
            this.BtnMax.TabIndex = 1;
            this.BtnMax.TabStop = false;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(602, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(56, 46);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PanelCentral
            // 
            this.PanelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.PanelCentral.Controls.Add(this.lblmens);
            this.PanelCentral.Controls.Add(this.btnmarca);
            this.PanelCentral.Controls.Add(this.txtid);
            this.PanelCentral.Controls.Add(this.horalb);
            this.PanelCentral.Controls.Add(this.Fechalb);
            this.PanelCentral.Controls.Add(this.NomEmpl);
            this.PanelCentral.Controls.Add(this.PhotoEmpl);
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Location = new System.Drawing.Point(220, 0);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(642, 599);
            this.PanelCentral.TabIndex = 8;
            // 
            // horalb
            // 
            this.horalb.AutoSize = true;
            this.horalb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horalb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.horalb.Location = new System.Drawing.Point(265, 128);
            this.horalb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.horalb.Name = "horalb";
            this.horalb.Size = new System.Drawing.Size(118, 20);
            this.horalb.TabIndex = 35;
            this.horalb.Text = "02:15:44 p.m.";
            this.horalb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fechalb
            // 
            this.Fechalb.AutoSize = true;
            this.Fechalb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechalb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fechalb.Location = new System.Drawing.Point(252, 97);
            this.Fechalb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Fechalb.Name = "Fechalb";
            this.Fechalb.Size = new System.Drawing.Size(144, 25);
            this.Fechalb.TabIndex = 33;
            this.Fechalb.Text = "31/Julio/2023";
            this.Fechalb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NomEmpl
            // 
            this.NomEmpl.AutoSize = true;
            this.NomEmpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomEmpl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NomEmpl.Location = new System.Drawing.Point(111, 388);
            this.NomEmpl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NomEmpl.Name = "NomEmpl";
            this.NomEmpl.Size = new System.Drawing.Size(419, 39);
            this.NomEmpl.TabIndex = 32;
            this.NomEmpl.Text = "Juan Orlando Hernandez";
            this.NomEmpl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NomEmpl.Click += new System.EventHandler(this.label3_Click);
            // 
            // PhotoEmpl
            // 
            this.PhotoEmpl.Image = global::ProyectoDiseñoSistemas.Properties.Resources._585e4beacb11b227491c3399;
            this.PhotoEmpl.Location = new System.Drawing.Point(233, 184);
            this.PhotoEmpl.Margin = new System.Windows.Forms.Padding(2);
            this.PhotoEmpl.Name = "PhotoEmpl";
            this.PhotoEmpl.Size = new System.Drawing.Size(163, 171);
            this.PhotoEmpl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoEmpl.TabIndex = 31;
            this.PhotoEmpl.TabStop = false;
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(23)))));
            this.MenuVertical.Controls.Add(this.button2);
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.BtnUsuario);
            this.MenuVertical.Controls.Add(this.BtnHorarios);
            this.MenuVertical.Controls.Add(this.BtnAsistencia);
            this.MenuVertical.Controls.Add(this.BtnFacturas);
            this.MenuVertical.Controls.Add(this.BtnPlanilla);
            this.MenuVertical.Controls.Add(this.BtnEmpleados);
            this.MenuVertical.Controls.Add(this.label1);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 599);
            this.MenuVertical.TabIndex = 7;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(23)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(33)))), ((int)(((byte)(225)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::ProyectoDiseñoSistemas.Properties.Resources.reloj;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(7, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 43);
            this.button2.TabIndex = 25;
            this.button2.Text = "Marcaje";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(23)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(33)))), ((int)(((byte)(225)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ProyectoDiseñoSistemas.Properties.Resources.imagen_2023_07_25_230630367__2_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(8, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 43);
            this.button1.TabIndex = 24;
            this.button1.Text = "Historial de Pagos";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(23)))));
            this.BtnUsuario.FlatAppearance.BorderSize = 0;
            this.BtnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(33)))), ((int)(((byte)(225)))));
            this.BtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuario.ForeColor = System.Drawing.Color.White;
            this.BtnUsuario.Image = global::ProyectoDiseñoSistemas.Properties.Resources.imagen_2023_07_24_183742294;
            this.BtnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuario.Location = new System.Drawing.Point(7, 56);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(210, 43);
            this.BtnUsuario.TabIndex = 23;
            this.BtnUsuario.Text = "Usuarios";
            this.BtnUsuario.UseVisualStyleBackColor = false;
            // 
            // BtnHorarios
            // 
            this.BtnHorarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(23)))));
            this.BtnHorarios.FlatAppearance.BorderSize = 0;
            this.BtnHorarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(33)))), ((int)(((byte)(225)))));
            this.BtnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHorarios.ForeColor = System.Drawing.Color.White;
            this.BtnHorarios.Image = global::ProyectoDiseñoSistemas.Properties.Resources.png_clipart_daylight_saving_time_in_the_united_states_computer_icons_time_logo_time__2_;
            this.BtnHorarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHorarios.Location = new System.Drawing.Point(7, 245);
            this.BtnHorarios.Name = "BtnHorarios";
            this.BtnHorarios.Size = new System.Drawing.Size(210, 43);
            this.BtnHorarios.TabIndex = 22;
            this.BtnHorarios.Text = "Horarios";
            this.BtnHorarios.UseVisualStyleBackColor = false;
            // 
            // BtnAsistencia
            // 
            this.BtnAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(23)))));
            this.BtnAsistencia.FlatAppearance.BorderSize = 0;
            this.BtnAsistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(33)))), ((int)(((byte)(225)))));
            this.BtnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsistencia.ForeColor = System.Drawing.Color.White;
            this.BtnAsistencia.Image = global::ProyectoDiseñoSistemas.Properties.Resources.imagen_2023_07_22_142507344__1_;
            this.BtnAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAsistencia.Location = new System.Drawing.Point(7, 198);
            this.BtnAsistencia.Name = "BtnAsistencia";
            this.BtnAsistencia.Size = new System.Drawing.Size(210, 43);
            this.BtnAsistencia.TabIndex = 21;
            this.BtnAsistencia.Text = "Asistencia";
            this.BtnAsistencia.UseVisualStyleBackColor = false;
            // 
            // BtnFacturas
            // 
            this.BtnFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(23)))));
            this.BtnFacturas.FlatAppearance.BorderSize = 0;
            this.BtnFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(33)))), ((int)(((byte)(225)))));
            this.BtnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturas.ForeColor = System.Drawing.Color.White;
            this.BtnFacturas.Image = global::ProyectoDiseñoSistemas.Properties.Resources.imagen_2023_07_22_135146864;
            this.BtnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacturas.Location = new System.Drawing.Point(7, 149);
            this.BtnFacturas.Name = "BtnFacturas";
            this.BtnFacturas.Size = new System.Drawing.Size(210, 43);
            this.BtnFacturas.TabIndex = 20;
            this.BtnFacturas.Text = "Boucher";
            this.BtnFacturas.UseVisualStyleBackColor = false;
            // 
            // BtnPlanilla
            // 
            this.BtnPlanilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(23)))));
            this.BtnPlanilla.FlatAppearance.BorderSize = 0;
            this.BtnPlanilla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(33)))), ((int)(((byte)(225)))));
            this.BtnPlanilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlanilla.ForeColor = System.Drawing.Color.White;
            this.BtnPlanilla.Image = global::ProyectoDiseñoSistemas.Properties.Resources.accept_payment_flat_icon_vector_12896470__1_;
            this.BtnPlanilla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPlanilla.Location = new System.Drawing.Point(8, 295);
            this.BtnPlanilla.Name = "BtnPlanilla";
            this.BtnPlanilla.Size = new System.Drawing.Size(212, 43);
            this.BtnPlanilla.TabIndex = 19;
            this.BtnPlanilla.Text = "Planilla";
            this.BtnPlanilla.UseVisualStyleBackColor = false;
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(23)))));
            this.BtnEmpleados.FlatAppearance.BorderSize = 0;
            this.BtnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(33)))), ((int)(((byte)(225)))));
            this.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleados.ForeColor = System.Drawing.Color.White;
            this.BtnEmpleados.Image = global::ProyectoDiseñoSistemas.Properties.Resources.imagen_2023_07_27_145021816;
            this.BtnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmpleados.Location = new System.Drawing.Point(7, 105);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(214, 43);
            this.BtnEmpleados.TabIndex = 18;
            this.BtnEmpleados.Text = "Empleados";
            this.BtnEmpleados.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Apartados:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(33)))), ((int)(((byte)(225)))));
            this.panel1.Location = new System.Drawing.Point(3, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 43);
            this.panel1.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(172, 481);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(146, 20);
            this.txtid.TabIndex = 36;
            // 
            // btnmarca
            // 
            this.btnmarca.Location = new System.Drawing.Point(334, 481);
            this.btnmarca.Name = "btnmarca";
            this.btnmarca.Size = new System.Drawing.Size(93, 20);
            this.btnmarca.TabIndex = 37;
            this.btnmarca.Text = "Marcar";
            this.btnmarca.UseVisualStyleBackColor = true;
            // 
            // lblmens
            // 
            this.lblmens.AutoSize = true;
            this.lblmens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmens.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmens.Location = new System.Drawing.Point(286, 446);
            this.lblmens.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmens.Name = "lblmens";
            this.lblmens.Size = new System.Drawing.Size(49, 13);
            this.lblmens.TabIndex = 38;
            this.lblmens.Text = "registro";
            this.lblmens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Marcaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 599);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Marcaje";
            this.Text = "Marcaje";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnResiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            this.PanelCentral.ResumeLayout(false);
            this.PanelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoEmpl)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox BtnResiz;
        private System.Windows.Forms.PictureBox BtnMin;
        private System.Windows.Forms.PictureBox BtnMax;
        private System.Windows.Forms.PictureBox BtnExit;
        private System.Windows.Forms.Panel PanelCentral;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnUsuario;
        private System.Windows.Forms.Button BtnHorarios;
        private System.Windows.Forms.Button BtnAsistencia;
        private System.Windows.Forms.Button BtnFacturas;
        private System.Windows.Forms.Button BtnPlanilla;
        private System.Windows.Forms.Button BtnEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PhotoEmpl;
        private System.Windows.Forms.Label NomEmpl;
        private System.Windows.Forms.Label horalb;
        private System.Windows.Forms.Label Fechalb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnmarca;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblmens;
    }
}