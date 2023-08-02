namespace ProyectoDiseñoSistemas.Vista
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnResiz = new System.Windows.Forms.PictureBox();
            this.BtnMin = new System.Windows.Forms.PictureBox();
            this.BtnMax = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnResiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(158, 361);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(133, 40);
            this.btnEntrar.TabIndex = 28;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(114, 292);
            this.pass.Margin = new System.Windows.Forms.Padding(2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(224, 29);
            this.pass.TabIndex = 25;
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(114, 235);
            this.user.Margin = new System.Windows.Forms.Padding(2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(224, 29);
            this.user.TabIndex = 23;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(266, 328);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 21);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Mostrar";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(116, 272);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(116, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Usuario:";
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(33)))), ((int)(((byte)(225)))));
            this.BarraTitulo.Controls.Add(this.label4);
            this.BarraTitulo.Controls.Add(this.BtnResiz);
            this.BarraTitulo.Controls.Add(this.BtnMin);
            this.BarraTitulo.Controls.Add(this.BtnMax);
            this.BarraTitulo.Controls.Add(this.BtnExit);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(458, 35);
            this.BarraTitulo.TabIndex = 29;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            this.BarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseMove);
            this.BarraTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(8, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Login";
            // 
            // BtnResiz
            // 
            this.BtnResiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnResiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResiz.Image = ((System.Drawing.Image)(resources.GetObject("BtnResiz.Image")));
            this.BtnResiz.Location = new System.Drawing.Point(372, 0);
            this.BtnResiz.Name = "BtnResiz";
            this.BtnResiz.Size = new System.Drawing.Size(39, 35);
            this.BtnResiz.TabIndex = 3;
            this.BtnResiz.TabStop = false;
            this.BtnResiz.Visible = false;
            // 
            // BtnMin
            // 
            this.BtnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMin.Image = ((System.Drawing.Image)(resources.GetObject("BtnMin.Image")));
            this.BtnMin.Location = new System.Drawing.Point(327, 11);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(39, 29);
            this.BtnMin.TabIndex = 2;
            this.BtnMin.TabStop = false;
            // 
            // BtnMax
            // 
            this.BtnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMax.Image = ((System.Drawing.Image)(resources.GetObject("BtnMax.Image")));
            this.BtnMax.Location = new System.Drawing.Point(372, 0);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(39, 35);
            this.BtnMax.TabIndex = 1;
            this.BtnMax.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(417, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(56, 46);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoDiseñoSistemas.Properties.Resources._585e4beacb11b227491c3399;
            this.pictureBox1.Location = new System.Drawing.Point(142, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(107, 328);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(147, 25);
            this.lblerror.TabIndex = 31;
            this.lblerror.Text = "Error Mensaje";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(458, 436);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnResiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox BtnResiz;
        private System.Windows.Forms.PictureBox BtnMin;
        private System.Windows.Forms.PictureBox BtnMax;
        private System.Windows.Forms.PictureBox BtnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblerror;
    }
}