﻿
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Btnhistorial = new System.Windows.Forms.Button();
            this.Lblhistorialventas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(153, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(381, 371);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Btnhistorial
            // 
            this.Btnhistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnhistorial.Location = new System.Drawing.Point(23, 22);
            this.Btnhistorial.Name = "Btnhistorial";
            this.Btnhistorial.Size = new System.Drawing.Size(93, 53);
            this.Btnhistorial.TabIndex = 2;
            this.Btnhistorial.Text = "GENERAR HISTORIAL";
            this.Btnhistorial.UseVisualStyleBackColor = true;
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
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.Lblhistorialventas);
            this.Controls.Add(this.Btnhistorial);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Btnhistorial;
        private System.Windows.Forms.Label Lblhistorialventas;
    }
}