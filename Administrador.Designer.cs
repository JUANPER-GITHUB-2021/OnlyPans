
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnCerrarsesion = new System.Windows.Forms.Button();
            this.Rctxtboxmensaje = new System.Windows.Forms.RichTextBox();
            this.Lblmensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(473, 409);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnCerrarsesion
            // 
            this.BtnCerrarsesion.Location = new System.Drawing.Point(392, 403);
            this.BtnCerrarsesion.Name = "BtnCerrarsesion";
            this.BtnCerrarsesion.Size = new System.Drawing.Size(75, 35);
            this.BtnCerrarsesion.TabIndex = 4;
            this.BtnCerrarsesion.Text = "CERRAR SESIÓN";
            this.BtnCerrarsesion.UseVisualStyleBackColor = true;
            this.BtnCerrarsesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rctxtboxmensaje
            // 
            this.Rctxtboxmensaje.Location = new System.Drawing.Point(84, 95);
            this.Rctxtboxmensaje.MaximumSize = new System.Drawing.Size(374, 267);
            this.Rctxtboxmensaje.Name = "Rctxtboxmensaje";
            this.Rctxtboxmensaje.Size = new System.Drawing.Size(374, 267);
            this.Rctxtboxmensaje.TabIndex = 6;
            this.Rctxtboxmensaje.Text = resources.GetString("Rctxtboxmensaje.Text");
            this.Rctxtboxmensaje.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Lblmensaje
            // 
            this.Lblmensaje.AutoSize = true;
            this.Lblmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblmensaje.Location = new System.Drawing.Point(79, 44);
            this.Lblmensaje.Name = "Lblmensaje";
            this.Lblmensaje.Size = new System.Drawing.Size(388, 25);
            this.Lblmensaje.TabIndex = 7;
            this.Lblmensaje.Text = "MENSAJE PARA ADMINISTRADOR:";
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.Lblmensaje);
            this.Controls.Add(this.Rctxtboxmensaje);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnCerrarsesion);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnCerrarsesion;
        private System.Windows.Forms.RichTextBox Rctxtboxmensaje;
        private System.Windows.Forms.Label Lblmensaje;
    }
}