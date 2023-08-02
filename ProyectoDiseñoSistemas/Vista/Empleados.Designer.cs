namespace ProyectoDiseñoSistemas.Vista
{
    partial class FrmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleados));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnResiz = new System.Windows.Forms.PictureBox();
            this.BtnMin = new System.Windows.Forms.PictureBox();
            this.BtnMax = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.BtnHorarios = new System.Windows.Forms.Button();
            this.BtnAsistencia = new System.Windows.Forms.Button();
            this.BtnFacturas = new System.Windows.Forms.Button();
            this.BtnPlanilla = new System.Windows.Forms.Button();
            this.BtnEmpleados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnResiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.PanelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1040, 35);
            this.BarraTitulo.TabIndex = 4;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown_1);
            this.BarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseMove_1);
            this.BarraTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseUp_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Empleados";
            // 
            // BtnResiz
            // 
            this.BtnResiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnResiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResiz.Image = ((System.Drawing.Image)(resources.GetObject("BtnResiz.Image")));
            this.BtnResiz.Location = new System.Drawing.Point(954, 0);
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
            this.BtnMin.Location = new System.Drawing.Point(910, 11);
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
            this.BtnMax.Location = new System.Drawing.Point(954, 0);
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
            this.BtnExit.Location = new System.Drawing.Point(1000, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(56, 46);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(23)))));
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
            this.MenuVertical.Location = new System.Drawing.Point(0, 35);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 605);
            this.MenuVertical.TabIndex = 13;
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
            this.panel1.Location = new System.Drawing.Point(-2, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 43);
            this.panel1.TabIndex = 11;
            // 
            // PanelCentral
            // 
            this.PanelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.PanelCentral.Controls.Add(this.button5);
            this.PanelCentral.Controls.Add(this.button4);
            this.PanelCentral.Controls.Add(this.button3);
            this.PanelCentral.Controls.Add(this.BtnNuevo);
            this.PanelCentral.Controls.Add(this.textBox3);
            this.PanelCentral.Controls.Add(this.label4);
            this.PanelCentral.Controls.Add(this.dataGridView1);
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Location = new System.Drawing.Point(220, 35);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(820, 605);
            this.PanelCentral.TabIndex = 14;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(712, 53);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 24);
            this.button5.TabIndex = 34;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(375, 572);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 40);
            this.button4.TabIndex = 33;
            this.button4.Text = "Actualizar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(216, 572);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 40);
            this.button3.TabIndex = 32;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Location = new System.Drawing.Point(58, 572);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(133, 40);
            this.BtnNuevo.TabIndex = 31;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(195, 52);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(511, 26);
            this.textBox3.TabIndex = 30;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(26, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Buscar Empleado:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(790, 455);
            this.dataGridView1.TabIndex = 16;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmEmpleados";
            this.Text = "Empleados";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnResiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.PanelCentral.ResumeLayout(false);
            this.PanelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox BtnResiz;
        private System.Windows.Forms.PictureBox BtnMin;
        private System.Windows.Forms.PictureBox BtnMax;
        private System.Windows.Forms.PictureBox BtnExit;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnUsuario;
        private System.Windows.Forms.Button BtnHorarios;
        private System.Windows.Forms.Button BtnAsistencia;
        private System.Windows.Forms.Button BtnFacturas;
        private System.Windows.Forms.Button BtnPlanilla;
        private System.Windows.Forms.Button BtnEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelCentral;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}