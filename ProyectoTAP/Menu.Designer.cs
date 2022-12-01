namespace ProyectoTAP
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.ImagenMenu = new System.Windows.Forms.PictureBox();
            this.ImagenTitulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagenMenu
            // 
            this.ImagenMenu.BackColor = System.Drawing.Color.Transparent;
            this.ImagenMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImagenMenu.BackgroundImage")));
            this.ImagenMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImagenMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagenMenu.Image = ((System.Drawing.Image)(resources.GetObject("ImagenMenu.Image")));
            this.ImagenMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ImagenMenu.Location = new System.Drawing.Point(0, 0);
            this.ImagenMenu.Name = "ImagenMenu";
            this.ImagenMenu.Size = new System.Drawing.Size(1182, 659);
            this.ImagenMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenMenu.TabIndex = 1;
            this.ImagenMenu.TabStop = false;
            // 
            // ImagenTitulo
            // 
            this.ImagenTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ImagenTitulo.Image = ((System.Drawing.Image)(resources.GetObject("ImagenTitulo.Image")));
            this.ImagenTitulo.Location = new System.Drawing.Point(655, 98);
            this.ImagenTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.ImagenTitulo.Name = "ImagenTitulo";
            this.ImagenTitulo.Size = new System.Drawing.Size(419, 136);
            this.ImagenTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImagenTitulo.TabIndex = 2;
            this.ImagenTitulo.TabStop = false;
            this.ImagenTitulo.Click += new System.EventHandler(this.ImagenTitulo_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.ImagenTitulo);
            this.Controls.Add(this.ImagenMenu);
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(1182, 659);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenTitulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagenMenu;
        private System.Windows.Forms.PictureBox ImagenTitulo;
    }
}
