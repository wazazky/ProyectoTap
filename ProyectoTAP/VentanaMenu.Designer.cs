using System;
using System.Drawing;

namespace ProyectoTAP
{
    partial class VentanaMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaMenu));
            this.Contador = new System.Windows.Forms.Timer(this.components);
            this.ImagenMenu = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // Contador
            // 
            this.Contador.Enabled = true;
            this.Contador.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ImagenMenu
            // 
            resources.ApplyResources(this.ImagenMenu, "ImagenMenu");
            this.ImagenMenu.Name = "ImagenMenu";
            this.ImagenMenu.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.BtnSalir, "BtnSalir");
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // VentanaMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ControlBox = false;
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ImagenMenu);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "VentanaMenu";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.ImagenMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Contador;
        private System.Windows.Forms.PictureBox ImagenMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnSalir;
    }
}

