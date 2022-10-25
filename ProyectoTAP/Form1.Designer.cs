using System.Drawing;

namespace ProyectoTAP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PantallaDeJuego = new System.Windows.Forms.GroupBox();
            this.Pantalla_de_Juego = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Contador = new System.Windows.Forms.Timer(this.components);
            this.PantallaDeJuego.SuspendLayout();
            this.Pantalla_de_Juego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // PantallaDeJuego
            // 
            resources.ApplyResources(this.PantallaDeJuego, "PantallaDeJuego");
            this.PantallaDeJuego.BackColor = System.Drawing.Color.Transparent;
            this.PantallaDeJuego.Controls.Add(this.Pantalla_de_Juego);
            this.PantallaDeJuego.Controls.Add(this.button2);
            this.PantallaDeJuego.Controls.Add(this.button3);
            this.PantallaDeJuego.Controls.Add(this.button1);
            this.PantallaDeJuego.Name = "PantallaDeJuego";
            this.PantallaDeJuego.TabStop = false;
            // 
            // Pantalla_de_Juego
            // 
            resources.ApplyResources(this.Pantalla_de_Juego, "Pantalla_de_Juego");
            this.Pantalla_de_Juego.Controls.Add(this.pictureBox1);
            this.Pantalla_de_Juego.Controls.Add(this.Player);
            this.Pantalla_de_Juego.Name = "Pantalla_de_Juego";
            this.Pantalla_de_Juego.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Player
            // 
            resources.ApplyResources(this.Player, "Player");
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Name = "Player";
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Contador
            // 
            this.Contador.Enabled = true;
            this.Contador.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.PantallaDeJuego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PantallaDeJuego.ResumeLayout(false);
            this.Pantalla_de_Juego.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PantallaDeJuego;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.GroupBox Pantalla_de_Juego;
        private System.Windows.Forms.Timer Contador;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

