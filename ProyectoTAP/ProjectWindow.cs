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
using NAudio.Wave;
using System.Timers;

namespace ProyectoTAP
{

    public partial class ProjectWindow : Form
    {
        string MMenu = "\\Recursos Proyecto TAP\\sonido\\Musica Menu.wav";
        string MJuego = "\\Recursos Proyecto TAP\\sonido\\The_Untold.wav";
        
        
        WaveStream MusicaMenu;
        WaveStream MusicaJuego;
        WaveChannel32 first;
        WaveChannel32 second;
        MixingWaveProvider32 mixer1;
        MixingWaveProvider32 mixer2;
        DirectSoundOut SalidaM;
        DirectSoundOut SalidaJ;
        public ProjectWindow()
        {
           
          
            iniMMenu();
            InitializeComponent();
            
            menu.Show();
            AtrasPicture.Hide();
            btnJugar.BackColor = Color.FromArgb(120, Color.Black);
           
        }

        private void SalirPicture_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void iniMMenu() {
            MusicaMenu = new WaveFileReader(System.Windows.Forms.Application.StartupPath + MMenu);
            first = new WaveChannel32(MusicaMenu, 1.0f, 0.0f);
            mixer1 = new MixingWaveProvider32();
            mixer1.AddInputStream(first);
            SalidaM = new DirectSoundOut(DirectSoundOut.DSDEVID_DefaultPlayback);
            SalidaM.Init(mixer1);
            SalidaM.Play();

        }
        void iniMJuego() {
            MusicaJuego = new WaveFileReader(System.Windows.Forms.Application.StartupPath + MJuego);
            second = new WaveChannel32(MusicaJuego, 1.0f, 0.0f);
            mixer2 = new MixingWaveProvider32();
            mixer2.AddInputStream(second);
            SalidaJ = new DirectSoundOut(DirectSoundOut.DSDEVID_DefaultPlayback);
            SalidaJ.Init(mixer2);
            SalidaJ.Play();


        }

        private void AtrasPicture_Click(object sender, EventArgs e)
        {

            if (juego.Visible) {
                SalidaM.Stop();
                SalidaJ.Stop();
                iniMMenu();
            }
            //condicion para no reproducir musica cuando se llama desde el control de creditos   
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
            SalidaM.Stop();
            iniMJuego();
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
