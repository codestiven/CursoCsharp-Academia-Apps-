﻿namespace CursoCsharp
{
    partial class Form1
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
            this.lblHolamundo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHolamundo
            // 
            this.lblHolamundo.BackColor = System.Drawing.Color.Khaki;
            this.lblHolamundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHolamundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lblHolamundo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHolamundo.Location = new System.Drawing.Point(0, 0);
            this.lblHolamundo.Name = "lblHolamundo";
            this.lblHolamundo.Size = new System.Drawing.Size(800, 450);
            this.lblHolamundo.TabIndex = 0;
            this.lblHolamundo.Text = "Hola Mundo";
            this.lblHolamundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHolamundo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHolamundo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHolamundo;
    }
}

