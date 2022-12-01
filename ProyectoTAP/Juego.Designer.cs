using System.Windows.Forms;

namespace ProyectoTAP
{
    partial class Juego
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.FondoPicture = new System.Windows.Forms.PictureBox();
            this.Player1Image = new System.Windows.Forms.PictureBox();
            this.Player2Image = new System.Windows.Forms.PictureBox();
            this.P1CA = new System.Windows.Forms.Button();
            this.ListaDeAtaques = new System.Windows.Forms.ImageList(this.components);
            this.P1CD = new System.Windows.Forms.Button();
            this.ListaDeCuras = new System.Windows.Forms.ImageList(this.components);
            this.P1CC = new System.Windows.Forms.Button();
            this.ListaDeDefensas = new System.Windows.Forms.ImageList(this.components);
            this.P2CA = new System.Windows.Forms.Button();
            this.P2CD = new System.Windows.Forms.Button();
            this.P2CC = new System.Windows.Forms.Button();
            this.FlechaTurno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FondoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlechaTurno)).BeginInit();
            this.SuspendLayout();
            // 
            // FondoPicture
            // 
            this.FondoPicture.BackColor = System.Drawing.Color.Transparent;
            this.FondoPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FondoPicture.Image = ((System.Drawing.Image)(resources.GetObject("FondoPicture.Image")));
            this.FondoPicture.Location = new System.Drawing.Point(0, 0);
            this.FondoPicture.Name = "FondoPicture";
            this.FondoPicture.Size = new System.Drawing.Size(1182, 659);
            this.FondoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FondoPicture.TabIndex = 0;
            this.FondoPicture.TabStop = false;
            // 
            // Player1Image
            // 
            this.Player1Image.BackColor = System.Drawing.Color.Transparent;
            this.Player1Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Player1Image.Image = ((System.Drawing.Image)(resources.GetObject("Player1Image.Image")));
            this.Player1Image.Location = new System.Drawing.Point(217, 415);
            this.Player1Image.Name = "Player1Image";
            this.Player1Image.Size = new System.Drawing.Size(211, 163);
            this.Player1Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Player1Image.TabIndex = 1;
            this.Player1Image.TabStop = false;
            // 
            // Player2Image
            // 
            this.Player2Image.BackColor = System.Drawing.Color.Transparent;
            this.Player2Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Player2Image.Image = ((System.Drawing.Image)(resources.GetObject("Player2Image.Image")));
            this.Player2Image.Location = new System.Drawing.Point(846, 395);
            this.Player2Image.Name = "Player2Image";
            this.Player2Image.Size = new System.Drawing.Size(162, 173);
            this.Player2Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Player2Image.TabIndex = 2;
            this.Player2Image.TabStop = false;
            // 
            // P1CA
            // 
            this.P1CA.BackColor = System.Drawing.Color.Transparent;
            this.P1CA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.P1CA.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.P1CA.FlatAppearance.BorderSize = 0;
            this.P1CA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.P1CA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.P1CA.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.P1CA.ImageIndex = 0;
            this.P1CA.ImageList = this.ListaDeAtaques;
            this.P1CA.Location = new System.Drawing.Point(1, 0);
            this.P1CA.Margin = new System.Windows.Forms.Padding(0);
            this.P1CA.Name = "P1CA";
            this.P1CA.Size = new System.Drawing.Size(150, 150);
            this.P1CA.TabIndex = 3;
            this.P1CA.UseVisualStyleBackColor = false;
            this.P1CA.Click += new System.EventHandler(this.P1CA_Click);
            // 
            // ListaDeAtaques
            // 
            this.ListaDeAtaques.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListaDeAtaques.ImageStream")));
            this.ListaDeAtaques.TransparentColor = System.Drawing.Color.Transparent;
            this.ListaDeAtaques.Images.SetKeyName(0, "carta0.png");
            this.ListaDeAtaques.Images.SetKeyName(1, "carta1.png");
            this.ListaDeAtaques.Images.SetKeyName(2, "carta2.png");
            // 
            // P1CD
            // 
            this.P1CD.BackColor = System.Drawing.Color.Black;
            this.P1CD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.P1CD.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.P1CD.FlatAppearance.BorderSize = 0;
            this.P1CD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.P1CD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.P1CD.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.P1CD.ImageIndex = 1;
            this.P1CD.ImageList = this.ListaDeDefensas;
            this.P1CD.Location = new System.Drawing.Point(151, 0);
            this.P1CD.Margin = new System.Windows.Forms.Padding(0);
            this.P1CD.Name = "P1CD";
            this.P1CD.Size = new System.Drawing.Size(150, 150);
            this.P1CD.TabIndex = 4;
            this.P1CD.UseVisualStyleBackColor = false;
            this.P1CD.Click += new System.EventHandler(this.P1CD_Click);
            // 
            // ListaDeCuras
            // 
            this.ListaDeCuras.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListaDeCuras.ImageStream")));
            this.ListaDeCuras.TransparentColor = System.Drawing.Color.Transparent;
            this.ListaDeCuras.Images.SetKeyName(0, "carta6.png");
            this.ListaDeCuras.Images.SetKeyName(1, "carta7.png");
            this.ListaDeCuras.Images.SetKeyName(2, "carta8.png");
            // 
            // P1CC
            // 
            this.P1CC.BackColor = System.Drawing.Color.Black;
            this.P1CC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.P1CC.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.P1CC.FlatAppearance.BorderSize = 0;
            this.P1CC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.P1CC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.P1CC.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.P1CC.ImageIndex = 1;
            this.P1CC.ImageList = this.ListaDeCuras;
            this.P1CC.Location = new System.Drawing.Point(301, 0);
            this.P1CC.Margin = new System.Windows.Forms.Padding(0);
            this.P1CC.Name = "P1CC";
            this.P1CC.Size = new System.Drawing.Size(150, 150);
            this.P1CC.TabIndex = 5;
            this.P1CC.UseVisualStyleBackColor = false;
            this.P1CC.Click += new System.EventHandler(this.P1CC_Click);
            // 
            // ListaDeDefensas
            // 
            this.ListaDeDefensas.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListaDeDefensas.ImageStream")));
            this.ListaDeDefensas.TransparentColor = System.Drawing.Color.Transparent;
            this.ListaDeDefensas.Images.SetKeyName(0, "carta3.png");
            this.ListaDeDefensas.Images.SetKeyName(1, "carta4.png");
            this.ListaDeDefensas.Images.SetKeyName(2, "carta5.png");
            // 
            // P2CA
            // 
            this.P2CA.BackColor = System.Drawing.Color.Black;
            this.P2CA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.P2CA.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.P2CA.FlatAppearance.BorderSize = 0;
            this.P2CA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.P2CA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.P2CA.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.P2CA.ImageIndex = 1;
            this.P2CA.ImageList = this.ListaDeAtaques;
            this.P2CA.Location = new System.Drawing.Point(1032, 0);
            this.P2CA.Margin = new System.Windows.Forms.Padding(0);
            this.P2CA.Name = "P2CA";
            this.P2CA.Size = new System.Drawing.Size(150, 150);
            this.P2CA.TabIndex = 8;
            this.P2CA.UseVisualStyleBackColor = false;
            this.P2CA.Click += new System.EventHandler(this.P2CA_Click);
            // 
            // P2CD
            // 
            this.P2CD.BackColor = System.Drawing.Color.Black;
            this.P2CD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.P2CD.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.P2CD.FlatAppearance.BorderSize = 0;
            this.P2CD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.P2CD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.P2CD.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.P2CD.ImageIndex = 0;
            this.P2CD.ImageList = this.ListaDeDefensas;
            this.P2CD.Location = new System.Drawing.Point(882, 0);
            this.P2CD.Margin = new System.Windows.Forms.Padding(0);
            this.P2CD.Name = "P2CD";
            this.P2CD.Size = new System.Drawing.Size(150, 150);
            this.P2CD.TabIndex = 7;
            this.P2CD.UseVisualStyleBackColor = false;
            this.P2CD.Click += new System.EventHandler(this.P2CD_Click);
            // 
            // P2CC
            // 
            this.P2CC.BackColor = System.Drawing.Color.Black;
            this.P2CC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.P2CC.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.P2CC.FlatAppearance.BorderSize = 0;
            this.P2CC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.P2CC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.P2CC.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.P2CC.ImageIndex = 1;
            this.P2CC.ImageList = this.ListaDeCuras;
            this.P2CC.Location = new System.Drawing.Point(732, 0);
            this.P2CC.Margin = new System.Windows.Forms.Padding(0);
            this.P2CC.Name = "P2CC";
            this.P2CC.Size = new System.Drawing.Size(150, 150);
            this.P2CC.TabIndex = 6;
            this.P2CC.UseVisualStyleBackColor = false;
            this.P2CC.Click += new System.EventHandler(this.P2CC_Click);
            // 
            // FlechaTurno
            // 
            this.FlechaTurno.BackColor = System.Drawing.Color.Transparent;
            this.FlechaTurno.Image = ((System.Drawing.Image)(resources.GetObject("FlechaTurno.Image")));
            this.FlechaTurno.Location = new System.Drawing.Point(261, 297);
            this.FlechaTurno.Name = "FlechaTurno";
            this.FlechaTurno.Size = new System.Drawing.Size(120, 112);
            this.FlechaTurno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlechaTurno.TabIndex = 9;
            this.FlechaTurno.TabStop = false;
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.FlechaTurno);
            this.Controls.Add(this.P2CA);
            this.Controls.Add(this.P2CD);
            this.Controls.Add(this.P2CC);
            this.Controls.Add(this.P1CC);
            this.Controls.Add(this.P1CD);
            this.Controls.Add(this.P1CA);
            this.Controls.Add(this.Player2Image);
            this.Controls.Add(this.Player1Image);
            this.Controls.Add(this.FondoPicture);
            this.DoubleBuffered = true;
            this.Name = "Juego";
            this.Size = new System.Drawing.Size(1182, 659);
            ((System.ComponentModel.ISupportInitialize)(this.FondoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlechaTurno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FondoPicture;
        private System.Windows.Forms.PictureBox Player1Image;
        private System.Windows.Forms.PictureBox Player2Image;
        private System.Windows.Forms.Button P1CA;
        private System.Windows.Forms.Button P1CD;
        private System.Windows.Forms.Button P1CC;
        private System.Windows.Forms.Button P2CA;
        private System.Windows.Forms.Button P2CD;
        private System.Windows.Forms.Button P2CC;
        public System.Windows.Forms.ImageList ListaDeCuras;
        private System.Windows.Forms.ImageList ListaDeAtaques;
        private System.Windows.Forms.ImageList ListaDeDefensas;
        private PictureBox FlechaTurno;
    }
}
