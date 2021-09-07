
namespace OnlyPans
{
    partial class iniciarsesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iniciarsesion));
            this.Lbltitulo = new System.Windows.Forms.Label();
            this.Lblusuario = new System.Windows.Forms.Label();
            this.Btniniciar = new System.Windows.Forms.Button();
            this.Txtboxusuario = new System.Windows.Forms.TextBox();
            this.Txtboxcontraseña = new System.Windows.Forms.TextBox();
            this.Lblcontraseña = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbltitulo
            // 
            this.Lbltitulo.AutoSize = true;
            this.Lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltitulo.Location = new System.Drawing.Point(137, 53);
            this.Lbltitulo.Name = "Lbltitulo";
            this.Lbltitulo.Size = new System.Drawing.Size(365, 33);
            this.Lbltitulo.TabIndex = 0;
            this.Lbltitulo.Text = "PANADERÍA ONLYPANS";
            this.Lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbltitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lblusuario
            // 
            this.Lblusuario.AutoSize = true;
            this.Lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblusuario.Location = new System.Drawing.Point(172, 145);
            this.Lblusuario.Name = "Lblusuario";
            this.Lblusuario.Size = new System.Drawing.Size(68, 20);
            this.Lblusuario.TabIndex = 1;
            this.Lblusuario.Text = "Usuario:";
            this.Lblusuario.Click += new System.EventHandler(this.label2_Click);
            // 
            // Btniniciar
            // 
            this.Btniniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btniniciar.Location = new System.Drawing.Point(245, 338);
            this.Btniniciar.Name = "Btniniciar";
            this.Btniniciar.Size = new System.Drawing.Size(121, 26);
            this.Btniniciar.TabIndex = 2;
            this.Btniniciar.Text = "INICIAR SESIÓN";
            this.Btniniciar.UseVisualStyleBackColor = true;
            this.Btniniciar.Click += new System.EventHandler(this.Btniniciar_Click);
            // 
            // Txtboxusuario
            // 
            this.Txtboxusuario.Location = new System.Drawing.Point(245, 145);
            this.Txtboxusuario.Name = "Txtboxusuario";
            this.Txtboxusuario.Size = new System.Drawing.Size(183, 20);
            this.Txtboxusuario.TabIndex = 3;
            this.Txtboxusuario.TextChanged += new System.EventHandler(this.Txtboxusuario_TextChanged);
            // 
            // Txtboxcontraseña
            // 
            this.Txtboxcontraseña.Location = new System.Drawing.Point(274, 219);
            this.Txtboxcontraseña.Name = "Txtboxcontraseña";
            this.Txtboxcontraseña.Size = new System.Drawing.Size(154, 20);
            this.Txtboxcontraseña.TabIndex = 4;
            this.Txtboxcontraseña.UseSystemPasswordChar = true;
            this.Txtboxcontraseña.TextChanged += new System.EventHandler(this.Txtboxcontraseña_TextChanged);
            // 
            // Lblcontraseña
            // 
            this.Lblcontraseña.AutoSize = true;
            this.Lblcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcontraseña.Location = new System.Drawing.Point(172, 217);
            this.Lblcontraseña.Name = "Lblcontraseña";
            this.Lblcontraseña.Size = new System.Drawing.Size(96, 20);
            this.Lblcontraseña.TabIndex = 5;
            this.Lblcontraseña.Text = "Contraseña:";
            this.Lblcontraseña.Click += new System.EventHandler(this.Lblcontraseña_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(537, 406);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // iniciarsesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.Lblcontraseña);
            this.Controls.Add(this.Txtboxcontraseña);
            this.Controls.Add(this.Txtboxusuario);
            this.Controls.Add(this.Btniniciar);
            this.Controls.Add(this.Lblusuario);
            this.Controls.Add(this.Lbltitulo);
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.Name = "iniciarsesion";
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.iniciarsesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbltitulo;
        private System.Windows.Forms.Label Lblusuario;
        private System.Windows.Forms.Button Btniniciar;
        private System.Windows.Forms.TextBox Txtboxusuario;
        private System.Windows.Forms.TextBox Txtboxcontraseña;
        private System.Windows.Forms.Label Lblcontraseña;
        private System.Windows.Forms.Button BtnSalir;
    }
}

