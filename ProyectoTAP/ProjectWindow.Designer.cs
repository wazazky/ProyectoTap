using System;
using System.Drawing;

namespace ProyectoTAP
{
    partial class ProjectWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectWindow));
            this.SalirPicture = new System.Windows.Forms.PictureBox();
            this.AtrasPicture = new System.Windows.Forms.PictureBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnCreditos = new System.Windows.Forms.Button();
            this.Version = new System.Windows.Forms.Label();
            this.menu = new ProyectoTAP.Menu();
            this.juego = new ProyectoTAP.Juego();
            this.creditos = new ProyectoTAP.Creditos();
            ((System.ComponentModel.ISupportInitialize)(this.SalirPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AtrasPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // SalirPicture
            // 
            this.SalirPicture.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.SalirPicture, "SalirPicture");
            this.SalirPicture.Name = "SalirPicture";
            this.SalirPicture.TabStop = false;
            this.SalirPicture.Click += new System.EventHandler(this.SalirPicture_Click);
            // 
            // AtrasPicture
            // 
            resources.ApplyResources(this.AtrasPicture, "AtrasPicture");
            this.AtrasPicture.Name = "AtrasPicture";
            this.AtrasPicture.TabStop = false;
            this.AtrasPicture.Click += new System.EventHandler(this.AtrasPicture_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnJugar, "btnJugar");
            this.btnJugar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnCreditos
            // 
            resources.ApplyResources(this.btnCreditos, "btnCreditos");
            this.btnCreditos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.UseVisualStyleBackColor = true;
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // Version
            // 
            resources.ApplyResources(this.Version, "Version");
            this.Version.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Version.Name = "Version";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.menu, "menu");
            this.menu.ForeColor = System.Drawing.Color.Transparent;
            this.menu.Name = "menu";
            // 
            // juego
            // 
            resources.ApplyResources(this.juego, "juego");
            this.juego.Name = "juego";
            // 
            // creditos
            // 
            resources.ApplyResources(this.creditos, "creditos");
            this.creditos.Name = "creditos";
            // 
            // ProjectWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ControlBox = false;
            this.Controls.Add(this.Version);
            this.Controls.Add(this.btnCreditos);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.AtrasPicture);
            this.Controls.Add(this.SalirPicture);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.juego);
            this.Controls.Add(this.creditos);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "ProjectWindow";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.SalirPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AtrasPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Menu menu;
        private Juego juego;
        private Creditos creditos;
        private System.Windows.Forms.PictureBox SalirPicture;
        private System.Windows.Forms.PictureBox AtrasPicture;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnCreditos;
        private System.Windows.Forms.Label Version;
    }
}

