using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoTAP
{

    public partial class ProjectWindow : Form
    {
        string MMenu = "\\Recursos Proyecto TAP\\sonido\\Musica Menu.wav";
        string MJuego = "\\Recursos Proyecto TAP\\sonido\\The_Untold.wav";
        
        SoundPlayer musicaMenu;
        SoundPlayer MusicaJuego;
        //Wcore controlador=new Wcore();
        public ProjectWindow()
        {
            musicaMenu= Wcore.playSimpleSound(MMenu);
            MusicaJuego = Wcore.playSimpleSound(MJuego);
            musicaMenu.Play(); 
            InitializeComponent();
            //Contador.Start();
            menu.Show();
            AtrasPicture.Hide();
            btnJugar.BackColor = Color.FromArgb(120, Color.Black);
        }

        private void SalirPicture_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void AtrasPicture_Click(object sender, EventArgs e)
        {
            
            if (juego.Visible) musicaMenu.Play();//condicion para no reproducir musica cuando se llama desde el control de creditos   
            creditos.Hide();
            juego.Hide();
            menu.Show();
            AtrasPicture.Hide();
            btnJugar.Show();
            btnCreditos.Show();
            SalirPicture.Show();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            musicaMenu.Stop();
            MusicaJuego.Play();
            SalirPicture.Hide();
           
            creditos.Hide();
            juego.Show();
            menu.Hide();
            AtrasPicture.Show();
            btnJugar.Hide();
            btnCreditos.Hide();

        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            btnJugar.Hide();
            btnCreditos.Hide();
            menu.Hide();
            creditos.Show();
            juego.Hide();
            AtrasPicture.Show();

        }

         
       
    }

}
