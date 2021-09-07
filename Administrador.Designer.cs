
namespace OnlyPans
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.RctxtHistorial = new System.Windows.Forms.RichTextBox();
            this.Btnhistorial = new System.Windows.Forms.Button();
            this.Lblhistorialventas = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnCerrarsesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RctxtHistorial
            // 
            this.RctxtHistorial.Location = new System.Drawing.Point(143, 56);
            this.RctxtHistorial.Name = "RctxtHistorial";
            this.RctxtHistorial.Size = new System.Drawing.Size(381, 371);
            this.RctxtHistorial.TabIndex = 0;
            this.RctxtHistorial.Text = "";
            // 
            // Btnhistorial
            // 
            this.Btnhistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnhistorial.Location = new System.Drawing.Point(25, 22);
            this.Btnhistorial.Name = "Btnhistorial";
            this.Btnhistorial.Size = new System.Drawing.Size(93, 53);
            this.Btnhistorial.TabIndex = 2;
            this.Btnhistorial.Text = "GENERAR HISTORIAL";
            this.Btnhistorial.UseVisualStyleBackColor = true;
            this.Btnhistorial.Click += new System.EventHandler(this.Btnhistorial_Click);
            // 
            // Lblhistorialventas
            // 
            this.Lblhistorialventas.AutoSize = true;
            this.Lblhistorialventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblhistorialventas.Location = new System.Drawing.Point(147, 22);
            this.Lblhistorialventas.Name = "Lblhistorialventas";
            this.Lblhistorialventas.Size = new System.Drawing.Size(348, 31);
            this.Lblhistorialventas.TabIndex = 3;
            this.Lblhistorialventas.Text = "HISTORIAL DE VENTAS:";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(23, 404);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnCerrarsesion
            // 
            this.BtnCerrarsesion.Location = new System.Drawing.Point(23, 363);
            this.BtnCerrarsesion.Name = "BtnCerrarsesion";
            this.BtnCerrarsesion.Size = new System.Drawing.Size(75, 35);
            this.BtnCerrarsesion.TabIndex = 4;
            this.BtnCerrarsesion.Text = "CERRAR SESIÓN";
            this.BtnCerrarsesion.UseVisualStyleBackColor = true;
            this.BtnCerrarsesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnCerrarsesion);
            this.Controls.Add(this.Lblhistorialventas);
            this.Controls.Add(this.Btnhistorial);
            this.Controls.Add(this.RctxtHistorial);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btnhistorial;
        private System.Windows.Forms.Label Lblhistorialventas;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnCerrarsesion;
        private System.Windows.Forms.RichTextBox RctxtHistorial;
    }
}