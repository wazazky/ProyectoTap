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

    public partial class VentanaMenu : Form
    {
        SoundPlayer musicaMenu;
        int cont = 0;
        Personaje p1;
        Personaje p2;
        Personaje Espectador;//se encarga de lo relacionado con los personajes
        Wcore Handler = new Wcore();// es el manejador 
        string end = "\\Recursos Proyecto TAP\\Sonido\\TES_V_Skyrim_Soundtrack.wav";
        public VentanaMenu()
        {
            
            InitializeComponent();
            Contador.Start();
            Console.WriteLine("Linea en public form1");
           
           musicaMenu = Handler.playSimpleSound(end);
           // playSimpleSound(end);
            crearpj();
                }

       
        public void crearpj() {
            Espectador = new Personaje();
            p1 = new Personaje(1);
            p2 = new Personaje(2);
        }
       


        public void ClickAtaque(Personaje p1, Personaje p2) {
            Espectador.Ataque(p1, p2, 5);
            Espectador.mostrar(p1, p2);

        }
        private void button1_Click(object sender, EventArgs e)
        {
           // Player.Load(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\Personajes\\image 2.gif");
            //Contador.Start();
            ClickAtaque(p1,p2);        
          
        }

    

        private void timer1_Tick(object sender, EventArgs e)
            {
            //Console.WriteLine(Player.Location.ToString());
           cont++;
          // Console.WriteLine(cont);
            //if (cont == 50) {
            //   Handler.playSimpleSound(end);
            //}
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Player.Load(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\Personajes\\image.gif");
            //pictureBox1.Load(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\Personajes\\image2.gif");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var Juego = new VentanaDeJuego();
            Juego.Show();
            musicaMenu.Stop();
          /// VentanaMenu.Hide();
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
