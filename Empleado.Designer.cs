
namespace OnlyPans
{
    partial class Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            this.Btnvender = new System.Windows.Forms.Button();
            this.LblTituloVenta = new System.Windows.Forms.Label();
            this.Lblnombre = new System.Windows.Forms.Label();
            this.Lblcedula = new System.Windows.Forms.Label();
            this.Txtboxnombre = new System.Windows.Forms.TextBox();
            this.Txtboxcedula = new System.Windows.Forms.TextBox();
            this.LblDatoscliente = new System.Windows.Forms.Label();
            this.LblDatosventa = new System.Windows.Forms.Label();
            this.LblcantpanA = new System.Windows.Forms.Label();
            this.LblCantpanNA = new System.Windows.Forms.Label();
            this.LblcantpanE = new System.Windows.Forms.Label();
            this.Lblhoraventa = new System.Windows.Forms.Label();
            this.Txtboxhora = new System.Windows.Forms.TextBox();
            this.Valortotalventa = new System.Windows.Forms.TextBox();
            this.LblpanA = new System.Windows.Forms.Label();
            this.LblpanE = new System.Windows.Forms.Label();
            this.LblpanNA = new System.Windows.Forms.Label();
            this.Lblventasrealizadas = new System.Windows.Forms.Label();
            this.RctxtboxVentas = new System.Windows.Forms.RichTextBox();
            this.BtnCerrarsesion = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.Txtboxguardado = new System.Windows.Forms.TextBox();
            this.TxtNumPanA = new System.Windows.Forms.TextBox();
            this.TxtNumPanNA = new System.Windows.Forms.TextBox();
            this.TxtNumPanE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btnvender
            // 
            this.Btnvender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnvender.Location = new System.Drawing.Point(130, 421);
            this.Btnvender.Name = "Btnvender";
            this.Btnvender.Size = new System.Drawing.Size(104, 26);
            this.Btnvender.TabIndex = 0;
            this.Btnvender.Text = "VENDER";
            this.Btnvender.UseVisualStyleBackColor = true;
            this.Btnvender.Click += new System.EventHandler(this.Btnvender_Click);
            // 
            // LblTituloVenta
            // 
            this.LblTituloVenta.AutoSize = true;
            this.LblTituloVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloVenta.Location = new System.Drawing.Point(12, 9);
            this.LblTituloVenta.Name = "LblTituloVenta";
            this.LblTituloVenta.Size = new System.Drawing.Size(336, 33);
            this.LblTituloVenta.TabIndex = 4;
            this.LblTituloVenta.Text = "REGISTRO DE VENTA";
            this.LblTituloVenta.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lblnombre
            // 
            this.Lblnombre.AutoSize = true;
            this.Lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblnombre.Location = new System.Drawing.Point(45, 131);
            this.Lblnombre.Name = "Lblnombre";
            this.Lblnombre.Size = new System.Drawing.Size(69, 20);
            this.Lblnombre.TabIndex = 5;
            this.Lblnombre.Text = "Nombre:";
            // 
            // Lblcedula
            // 
            this.Lblcedula.AutoSize = true;
            this.Lblcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcedula.Location = new System.Drawing.Point(45, 167);
            this.Lblcedula.Name = "Lblcedula";
            this.Lblcedula.Size = new System.Drawing.Size(63, 20);
            this.Lblcedula.TabIndex = 6;
            this.Lblcedula.Text = "Cedula:";
            this.Lblcedula.Click += new System.EventHandler(this.Lblcedula_Click);
            // 
            // Txtboxnombre
            // 
            this.Txtboxnombre.Location = new System.Drawing.Point(137, 131);
            this.Txtboxnombre.Name = "Txtboxnombre";
            this.Txtboxnombre.Size = new System.Drawing.Size(196, 20);
            this.Txtboxnombre.TabIndex = 7;
            // 
            // Txtboxcedula
            // 
            this.Txtboxcedula.Location = new System.Drawing.Point(137, 169);
            this.Txtboxcedula.Name = "Txtboxcedula";
            this.Txtboxcedula.Size = new System.Drawing.Size(97, 20);
            this.Txtboxcedula.TabIndex = 8;
            // 
            // LblDatoscliente
            // 
            this.LblDatoscliente.AutoSize = true;
            this.LblDatoscliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatoscliente.Location = new System.Drawing.Point(12, 77);
            this.LblDatoscliente.Name = "LblDatoscliente";
            this.LblDatoscliente.Size = new System.Drawing.Size(178, 25);
            this.LblDatoscliente.TabIndex = 9;
            this.LblDatoscliente.Text = "Datos del cliente:";
            // 
            // LblDatosventa
            // 
            this.LblDatosventa.AutoSize = true;
            this.LblDatosventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatosventa.Location = new System.Drawing.Point(12, 220);
            this.LblDatosventa.Name = "LblDatosventa";
            this.LblDatosventa.Size = new System.Drawing.Size(186, 25);
            this.LblDatosventa.TabIndex = 10;
            this.LblDatosventa.Text = "Datos de la venta:";
            // 
            // LblcantpanA
            // 
            this.LblcantpanA.AutoSize = true;
            this.LblcantpanA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblcantpanA.Location = new System.Drawing.Point(186, 264);
            this.LblcantpanA.Name = "LblcantpanA";
            this.LblcantpanA.Size = new System.Drawing.Size(70, 18);
            this.LblcantpanA.TabIndex = 11;
            this.LblcantpanA.Text = "Cantidad:";
            this.LblcantpanA.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LblCantpanNA
            // 
            this.LblCantpanNA.AutoSize = true;
            this.LblCantpanNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantpanNA.Location = new System.Drawing.Point(186, 298);
            this.LblCantpanNA.Name = "LblCantpanNA";
            this.LblCantpanNA.Size = new System.Drawing.Size(70, 18);
            this.LblCantpanNA.TabIndex = 13;
            this.LblCantpanNA.Text = "Cantidad:";
            // 
            // LblcantpanE
            // 
            this.LblcantpanE.AutoSize = true;
            this.LblcantpanE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblcantpanE.Location = new System.Drawing.Point(186, 332);
            this.LblcantpanE.Name = "LblcantpanE";
            this.LblcantpanE.Size = new System.Drawing.Size(70, 18);
            this.LblcantpanE.TabIndex = 14;
            this.LblcantpanE.Text = "Cantidad:";
            this.LblcantpanE.Click += new System.EventHandler(this.label3_Click);
            // 
            // Lblhoraventa
            // 
            this.Lblhoraventa.AutoSize = true;
            this.Lblhoraventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblhoraventa.Location = new System.Drawing.Point(45, 370);
            this.Lblhoraventa.Name = "Lblhoraventa";
            this.Lblhoraventa.Size = new System.Drawing.Size(113, 20);
            this.Lblhoraventa.TabIndex = 22;
            this.Lblhoraventa.Text = "Hora de venta:";
            this.Lblhoraventa.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Txtboxhora
            // 
            this.Txtboxhora.Location = new System.Drawing.Point(164, 372);
            this.Txtboxhora.Name = "Txtboxhora";
            this.Txtboxhora.Size = new System.Drawing.Size(102, 20);
            this.Txtboxhora.TabIndex = 23;
            // 
            // Valortotalventa
            // 
            this.Valortotalventa.Location = new System.Drawing.Point(204, 225);
            this.Valortotalventa.Name = "Valortotalventa";
            this.Valortotalventa.Size = new System.Drawing.Size(100, 20);
            this.Valortotalventa.TabIndex = 27;
            this.Valortotalventa.Visible = false;
            this.Valortotalventa.TextChanged += new System.EventHandler(this.Valortotalventa_TextChanged);
            // 
            // LblpanA
            // 
            this.LblpanA.AutoSize = true;
            this.LblpanA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblpanA.Location = new System.Drawing.Point(46, 263);
            this.LblpanA.Name = "LblpanA";
            this.LblpanA.Size = new System.Drawing.Size(98, 20);
            this.LblpanA.TabIndex = 28;
            this.LblpanA.Text = "Pan Aliñado.";
            this.LblpanA.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // LblpanE
            // 
            this.LblpanE.AutoSize = true;
            this.LblpanE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblpanE.Location = new System.Drawing.Point(46, 331);
            this.LblpanE.Name = "LblpanE";
            this.LblpanE.Size = new System.Drawing.Size(105, 20);
            this.LblpanE.TabIndex = 29;
            this.LblpanE.Text = "Pan Especial.";
            this.LblpanE.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblpanNA
            // 
            this.LblpanNA.AutoSize = true;
            this.LblpanNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblpanNA.Location = new System.Drawing.Point(45, 297);
            this.LblpanNA.Name = "LblpanNA";
            this.LblpanNA.Size = new System.Drawing.Size(122, 20);
            this.LblpanNA.TabIndex = 30;
            this.LblpanNA.Text = "Pan No Aliñado.";
            // 
            // Lblventasrealizadas
            // 
            this.Lblventasrealizadas.AutoSize = true;
            this.Lblventasrealizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblventasrealizadas.Location = new System.Drawing.Point(444, 77);
            this.Lblventasrealizadas.Name = "Lblventasrealizadas";
            this.Lblventasrealizadas.Size = new System.Drawing.Size(190, 25);
            this.Lblventasrealizadas.TabIndex = 31;
            this.Lblventasrealizadas.Text = "Ventas realizadas:";
            // 
            // RctxtboxVentas
            // 
            this.RctxtboxVentas.Location = new System.Drawing.Point(449, 105);
            this.RctxtboxVentas.MinimumSize = new System.Drawing.Size(333, 342);
            this.RctxtboxVentas.Name = "RctxtboxVentas";
            this.RctxtboxVentas.Size = new System.Drawing.Size(333, 342);
            this.RctxtboxVentas.TabIndex = 32;
            this.RctxtboxVentas.Text = "";
            this.RctxtboxVentas.TextChanged += new System.EventHandler(this.RctxtboxVentas_TextChanged);
            // 
            // BtnCerrarsesion
            // 
            this.BtnCerrarsesion.Location = new System.Drawing.Point(493, 453);
            this.BtnCerrarsesion.Name = "BtnCerrarsesion";
            this.BtnCerrarsesion.Size = new System.Drawing.Size(111, 23);
            this.BtnCerrarsesion.TabIndex = 33;
            this.BtnCerrarsesion.Text = "CERRAR SESIÓN";
            this.BtnCerrarsesion.UseVisualStyleBackColor = true;
            this.BtnCerrarsesion.Click += new System.EventHandler(this.BtnCerrarsesion_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(663, 453);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 34;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Txtboxguardado
            // 
            this.Txtboxguardado.Location = new System.Drawing.Point(663, 83);
            this.Txtboxguardado.Name = "Txtboxguardado";
            this.Txtboxguardado.Size = new System.Drawing.Size(100, 20);
            this.Txtboxguardado.TabIndex = 35;
            this.Txtboxguardado.Visible = false;
            // 
            // TxtNumPanA
            // 
            this.TxtNumPanA.Location = new System.Drawing.Point(262, 263);
            this.TxtNumPanA.Name = "TxtNumPanA";
            this.TxtNumPanA.Size = new System.Drawing.Size(43, 20);
            this.TxtNumPanA.TabIndex = 36;
            // 
            // TxtNumPanNA
            // 
            this.TxtNumPanNA.Location = new System.Drawing.Point(262, 296);
            this.TxtNumPanNA.Name = "TxtNumPanNA";
            this.TxtNumPanNA.Size = new System.Drawing.Size(43, 20);
            this.TxtNumPanNA.TabIndex = 37;
            // 
            // TxtNumPanE
            // 
            this.TxtNumPanE.Location = new System.Drawing.Point(262, 332);
            this.TxtNumPanE.Name = "TxtNumPanE";
            this.TxtNumPanE.Size = new System.Drawing.Size(43, 20);
            this.TxtNumPanE.TabIndex = 38;
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(826, 505);
            this.Controls.Add(this.TxtNumPanE);
            this.Controls.Add(this.TxtNumPanNA);
            this.Controls.Add(this.TxtNumPanA);
            this.Controls.Add(this.Txtboxguardado);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnCerrarsesion);
            this.Controls.Add(this.RctxtboxVentas);
            this.Controls.Add(this.Lblventasrealizadas);
            this.Controls.Add(this.LblpanNA);
            this.Controls.Add(this.LblpanE);
            this.Controls.Add(this.LblpanA);
            this.Controls.Add(this.Valortotalventa);
            this.Controls.Add(this.Txtboxhora);
            this.Controls.Add(this.Lblhoraventa);
            this.Controls.Add(this.LblcantpanE);
            this.Controls.Add(this.LblCantpanNA);
            this.Controls.Add(this.LblcantpanA);
            this.Controls.Add(this.LblDatosventa);
            this.Controls.Add(this.LblDatoscliente);
            this.Controls.Add(this.Txtboxcedula);
            this.Controls.Add(this.Txtboxnombre);
            this.Controls.Add(this.Lblcedula);
            this.Controls.Add(this.Lblnombre);
            this.Controls.Add(this.LblTituloVenta);
            this.Controls.Add(this.Btnvender);
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnvender;
        private System.Windows.Forms.Label LblTituloVenta;
        private System.Windows.Forms.Label Lblnombre;
        private System.Windows.Forms.Label Lblcedula;
        private System.Windows.Forms.TextBox Txtboxnombre;
        private System.Windows.Forms.TextBox Txtboxcedula;
        private System.Windows.Forms.Label LblDatoscliente;
        private System.Windows.Forms.Label LblDatosventa;
        private System.Windows.Forms.Label LblcantpanA;
        private System.Windows.Forms.Label LblCantpanNA;
        private System.Windows.Forms.Label LblcantpanE;
        private System.Windows.Forms.Label Lblhoraventa;
        private System.Windows.Forms.TextBox Txtboxhora;
        private System.Windows.Forms.TextBox Valortotalventa;
        private System.Windows.Forms.Label LblpanA;
        private System.Windows.Forms.Label LblpanE;
        private System.Windows.Forms.Label LblpanNA;
        private System.Windows.Forms.Label Lblventasrealizadas;
        private System.Windows.Forms.Button BtnCerrarsesion;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox Txtboxguardado;
        private System.Windows.Forms.TextBox TxtNumPanA;
        private System.Windows.Forms.TextBox TxtNumPanNA;
        private System.Windows.Forms.TextBox TxtNumPanE;
        public System.Windows.Forms.RichTextBox RctxtboxVentas;
    }
}