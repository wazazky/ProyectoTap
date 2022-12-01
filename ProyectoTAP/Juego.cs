using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoTAP
{
    public partial class Juego : UserControl
    {   
        Wcore handler=new Wcore();//objeto para el sonido
        Personaje Espectador=new Personaje();
        Personaje P1=new Personaje(1);
        Personaje P2=new Personaje(2);
        string cura = "\\Recursos Proyecto TAP\\sonido\\c.wav";
        string escudo = "\\Recursos Proyecto TAP\\sonido\\s.wav";
        string golpe = "\\Recursos Proyecto TAP\\sonido\\a.wav";
        bool Turno = true;//true es para el Player1 , false es para el player 2


        public Juego()
        {
            InitializeComponent();
            Espectador.mostrar(P1,P2);
            cambiarTurno();
           
            //Player1Image.Image = ListaDeAtaques.Images[0];
            //P1CA.Enabled = false; referencia pa saber que hacer 
        }
        void cambiarTurno() {
            Turno = !Turno;
            if (Turno)
            {
                
                FlechaTurno.Location = new Point(866, 300);
                P1CA.Enabled = false;
                P1CD.Enabled = false;
                P1CC.Enabled = false;
                P2CA.Enabled = true;
                P2CD.Enabled = true;
                P2CC.Enabled = true;

            }
            if (!Turno)
            {
                FlechaTurno.Location = new Point(261, 300);
                P1CA.Enabled = true; 
                P1CD.Enabled = true; 
                P1CC.Enabled = true; 
                P2CA.Enabled = false;
                P2CD.Enabled = false;
                P2CC.Enabled = false;
              
            }
        }
        private void P1CA_Click(object sender, EventArgs e)
        {
            Espectador.Ataque(P1, P2, P1CA.ImageIndex.ToString()); Espectador.mostrar(P1, P2);
            handler.Sonido(golpe);
            Player2Image.Image =Image.FromFile(System.Windows.Forms.Application.StartupPath+"\\Recursos Proyecto TAP\\e\\h.gif");
            Player1Image.Image= Image.FromFile(System.Windows.Forms.Application.StartupPath+ "\\Recursos Proyecto TAP\\p\\a.gif");
            cambiarTurno();
        }

        private void P1CD_Click(object sender, EventArgs e)
        {
            Player2Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\e\\i.gif");
            Player1Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\p\\s.gif");
            Espectador.Defender(P1, P1CD.ImageIndex.ToString()); Espectador.mostrar(P1, P2);
             handler.Sonido(escudo);
            cambiarTurno();
        }

        private void P1CC_Click(object sender, EventArgs e)
        {
            Player2Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\e\\i.gif");
            Player1Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\p\\c.gif");
            Espectador.Curar(P1, P1CC.ImageIndex.ToString()); Espectador.mostrar(P1, P2);
             handler.Sonido(cura);
            cambiarTurno();
        }

        private void P2CC_Click(object sender, EventArgs e)
        {
            Player2Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\e\\c.gif");
            Player1Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\p\\i.gif");
            Espectador.Curar(P2, P2CC.ImageIndex.ToString()); Espectador.mostrar(P1, P2);
             handler.Sonido(cura);
            cambiarTurno();
        }

        private void P2CD_Click(object sender, EventArgs e)
        {
            Player2Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\e\\s.gif");
            Player1Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\p\\i.gif");
            Espectador.Defender(P2, P2CD.ImageIndex.ToString()); Espectador.mostrar(P1, P2);
             handler.Sonido(escudo);
            cambiarTurno();
        }

        private void P2CA_Click(object sender, EventArgs e)
        {
            Player2Image.Image =Image.FromFile(System.Windows.Forms.Application.StartupPath+"\\Recursos Proyecto TAP\\e\\a.gif");
            Player1Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\p\\h.gif");
            Espectador.Ataque(P2, P1, P1CA.ImageIndex.ToString()); Espectador.mostrar(P1, P2);
             handler.Sonido(golpe);
            cambiarTurno();
        }

       

        

    }
}
//300, 300 locacion de la flexha de turno P1
//866, 300 locacion de la flexha de turno P2