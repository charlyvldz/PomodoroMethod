namespace Prueba_Reloj_Cuenta_Atras
{
    partial class frmPomodoro
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPomodoro));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndescansolargo = new System.Windows.Forms.Button();
            this.btndescansocorto = new System.Windows.Forms.Button();
            this.btndetener = new System.Windows.Forms.Button();
            this.btniniciar = new System.Windows.Forms.Button();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.lbltiempo = new System.Windows.Forms.Label();
            this.lbldescansol = new System.Windows.Forms.Label();
            this.lbldescansoc = new System.Windows.Forms.Label();
            this.lblpomodoros = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconodenotificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btndescansolargo);
            this.groupBox1.Controls.Add(this.btndescansocorto);
            this.groupBox1.Controls.Add(this.btndetener);
            this.groupBox1.Controls.Add(this.btniniciar);
            this.groupBox1.Location = new System.Drawing.Point(106, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actividad";
            // 
            // btndescansolargo
            // 
            this.btndescansolargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescansolargo.Location = new System.Drawing.Point(218, 19);
            this.btndescansolargo.Name = "btndescansolargo";
            this.btndescansolargo.Size = new System.Drawing.Size(91, 50);
            this.btndescansolargo.TabIndex = 5;
            this.btndescansolargo.Text = "Descanso Largo";
            this.btndescansolargo.UseVisualStyleBackColor = true;
            this.btndescansolargo.Click += new System.EventHandler(this.btndescansolargo_Click);
            // 
            // btndescansocorto
            // 
            this.btndescansocorto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescansocorto.Location = new System.Drawing.Point(121, 19);
            this.btndescansocorto.Name = "btndescansocorto";
            this.btndescansocorto.Size = new System.Drawing.Size(91, 50);
            this.btndescansocorto.TabIndex = 5;
            this.btndescansocorto.Text = "Descanso Corto";
            this.btndescansocorto.UseVisualStyleBackColor = true;
            this.btndescansocorto.Click += new System.EventHandler(this.btndescansocorto_Click);
            // 
            // btndetener
            // 
            this.btndetener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndetener.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetener.ForeColor = System.Drawing.Color.White;
            this.btndetener.Location = new System.Drawing.Point(315, 19);
            this.btndetener.Name = "btndetener";
            this.btndetener.Size = new System.Drawing.Size(92, 50);
            this.btndetener.TabIndex = 4;
            this.btndetener.Text = "Detener";
            this.btndetener.UseVisualStyleBackColor = false;
            this.btndetener.Click += new System.EventHandler(this.btndetener_Click);
            // 
            // btniniciar
            // 
            this.btniniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciar.Location = new System.Drawing.Point(22, 19);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(93, 50);
            this.btniniciar.TabIndex = 4;
            this.btniniciar.Text = "Iniciar Pomodoro";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // tiempo
            // 
            this.tiempo.Interval = 1000;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.BackColor = System.Drawing.Color.Transparent;
            this.lbltiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltiempo.ForeColor = System.Drawing.Color.Red;
            this.lbltiempo.Location = new System.Drawing.Point(137, -7);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(363, 135);
            this.lbltiempo.TabIndex = 3;
            this.lbltiempo.Text = "00:00";
            this.lbltiempo.Visible = false;
            // 
            // lbldescansol
            // 
            this.lbldescansol.AutoSize = true;
            this.lbldescansol.BackColor = System.Drawing.Color.Transparent;
            this.lbldescansol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescansol.Location = new System.Drawing.Point(36, 87);
            this.lbldescansol.Name = "lbldescansol";
            this.lbldescansol.Size = new System.Drawing.Size(18, 20);
            this.lbldescansol.TabIndex = 5;
            this.lbldescansol.Text = "0";
            this.lbldescansol.Visible = false;
            // 
            // lbldescansoc
            // 
            this.lbldescansoc.AutoSize = true;
            this.lbldescansoc.BackColor = System.Drawing.Color.Transparent;
            this.lbldescansoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescansoc.Location = new System.Drawing.Point(36, 67);
            this.lbldescansoc.Name = "lbldescansoc";
            this.lbldescansoc.Size = new System.Drawing.Size(18, 20);
            this.lbldescansoc.TabIndex = 6;
            this.lbldescansoc.Text = "0";
            this.lbldescansoc.Visible = false;
            // 
            // lblpomodoros
            // 
            this.lblpomodoros.AutoSize = true;
            this.lblpomodoros.BackColor = System.Drawing.Color.Transparent;
            this.lblpomodoros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpomodoros.Location = new System.Drawing.Point(36, 47);
            this.lblpomodoros.Name = "lblpomodoros";
            this.lblpomodoros.Size = new System.Drawing.Size(18, 20);
            this.lblpomodoros.TabIndex = 4;
            this.lblpomodoros.Text = "0";
            this.lblpomodoros.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-21, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 110);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.lbltiempo);
            this.panel2.Controls.Add(this.lbldescansol);
            this.panel2.Controls.Add(this.lblpomodoros);
            this.panel2.Controls.Add(this.lbldescansoc);
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 219);
            this.panel2.TabIndex = 8;
            // 
            // iconodenotificacion
            // 
            this.iconodenotificacion.Icon = ((System.Drawing.Icon)(resources.GetObject("iconodenotificacion.Icon")));
            this.iconodenotificacion.Text = "Método Pomodoro";
            this.iconodenotificacion.Visible = true;
            this.iconodenotificacion.DoubleClick += new System.EventHandler(this.iconodenotificacion_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 113);
            this.panel1.TabIndex = 7;
            // 
            // frmPomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 321);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(618, 360);
            this.MinimumSize = new System.Drawing.Size(618, 360);
            this.Name = "frmPomodoro";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Método de Pomodoro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndetener;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.Button btndescansolargo;
        private System.Windows.Forms.Button btndescansocorto;
        private System.Windows.Forms.Label lbldescansol;
        private System.Windows.Forms.Label lbldescansoc;
        private System.Windows.Forms.Label lblpomodoros;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NotifyIcon iconodenotificacion;
        private System.Windows.Forms.Panel panel1;
    }
}

