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
        // Wcore Wcore=new Wcore();//objeto para el sonido
        Personaje Espectador = new Personaje();
        Personaje P1 = new Personaje(1,10,5,3,1,1,1);
        Personaje P2 = new Personaje(2,4,3,3,2,2,2);
        Random rnd = new Random();
        string cura = "\\Recursos Proyecto TAP\\sonido\\c.wav";
        string escudo = "\\Recursos Proyecto TAP\\sonido\\s.wav";
        string golpe = "\\Recursos Proyecto TAP\\sonido\\a.wav";
        string victoria= "\\Recursos Proyecto TAP\\sonido\\end.wav";
        bool Turno = true;//true es para el Player1 , false es para el player 2


        public Juego()
        {
            InitializeComponent();
           Personaje.mostrar(P1, P2);
            cambiarTurno();
            btnReset.Hide();
            labelVictoria.Visible = false;
            labelVictoria.BackColor = Color.FromArgb(120, Color.Black);
            labelctlr();
            iniLabelEstado();




            //Player1Image.Image = ListaDeAtaques.Images[0];
            //P1CA.Enabled = false; referencia pa saber que hacer 
        }

        void iniLabelEstado() {

            labelvidaP1.BackColor = Color.FromArgb(200, Color.Black);
            labelvidaP2.BackColor = Color.FromArgb(200, Color.Black);
            labelescudoP1.BackColor = Color.FromArgb(200, Color.Black);
            labelescudoP2.BackColor = Color.FromArgb(200, Color.Black);
            labelvidaP1.ForeColor = Color.FromArgb(120, Color.Green);
            labelvidaP2.ForeColor = Color.FromArgb(120, Color.Green);
            labelescudoP1.ForeColor = Color.FromArgb(120, Color.Blue);
            labelescudoP2.ForeColor = Color.FromArgb(120, Color.Blue);


        }
        void labelctlr() 
        {
            labelvidaP1.Text = "vida " + P1.Vida.ToString();
            labelvidaP2.Text = "vida " + P2.Vida.ToString();
            labelescudoP1.Text = "Escudo " + P1.Escudo.ToString();
            labelescudoP2.Text = "Escudo " + P2.Escudo.ToString();

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
            revolver();
        }

        void disableCartas() 
        {
            P2CA.Enabled = false;
            P2CD.Enabled = false;
            P2CC.Enabled = false;
            P1CA.Enabled = false;
            P1CD.Enabled = false;
            P1CC.Enabled = false;


        }

        void revolver() {

            if (Turno)
            {

                FlechaTurno.Location = new Point(866, 300);
                P1CA.ImageIndex = rnd.Next(3);
                P1CD.ImageIndex = rnd.Next(3);
                P1CC.ImageIndex = rnd.Next(3);


            }
            if (!Turno)
            {
                FlechaTurno.Location = new Point(261, 300);

                P2CA.ImageIndex = rnd.Next(3);
                P2CD.ImageIndex = rnd.Next(3);
                P2CC.ImageIndex = rnd.Next(3);

            }


        }
        private void P1CA_Click(object sender, EventArgs e)
        {
           Personaje.Ataque(P1, P2, P1CA.ImageIndex.ToString());Personaje.mostrar(P1, P2);
            Wcore.Sonido(golpe);
            Player2Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\e\\h.gif");
            Player1Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\p\\a.gif");
            cambiarTurno();
            Status();
            labelctlr();
        }

        private void P1CD_Click(object sender, EventArgs e)
        {
            Player2Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\e\\i.gif");
            Player1Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\p\\s.gif");
           Personaje.Defender(P1, P1CD.ImageIndex.ToString());Personaje.mostrar(P1, P2);
            Wcore.Sonido(escudo);
            cambiarTurno();
            labelctlr();
        }

        private void P1CC_Click(object sender, EventArgs e)
        {
            Player2Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\e\\i.gif");
            Player1Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\p\\c.gif");
           Personaje.Curar(P1, P1CC.ImageIndex.ToString());Personaje.mostrar(P1, P2);
            Wcore.Sonido(cura);
            cambiarTurno();
            labelctlr();
        }

        private void P2CC_Click(object sender, EventArgs e)
        {
            Player2Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\e\\c.gif");
            Player1Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\p\\i.gif");
           Personaje.Curar(P2, P2CC.ImageIndex.ToString());Personaje.mostrar(P1, P2);
            Wcore.Sonido(cura);
            cambiarTurno();
            labelctlr();
        }

        private void P2CD_Click(object sender, EventArgs e)
        {
            Player2Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\e\\s.gif");
            Player1Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\p\\i.gif");
           Personaje.Defender(P2, P2CD.ImageIndex.ToString());Personaje.mostrar(P1, P2);
            Wcore.Sonido(escudo);
            cambiarTurno();
            labelctlr();
        }

        private void P2CA_Click(object sender, EventArgs e)
        {
            Player2Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\e\\a.gif");
            Player1Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\p\\h.gif");
           Personaje.Ataque(P2, P1, P2CA.ImageIndex.ToString());Personaje.mostrar(P1, P2);
            Wcore.Sonido(golpe);
            cambiarTurno();
            Status();
            labelctlr();
        }
        private void Status(){
            if (P1.Vida <= 0) {
                FlechaTurno.Hide();
                Wcore.Sonido(victoria);
                disableCartas();
                btnReset.Show();
                labelVictoria.Visible = true;
                labelVictoria.Text = "Ganador Jugador 2";
            }
            if (P2.Vida <= 0)
            {
                FlechaTurno.Hide();
                Wcore.Sonido(victoria);
                disableCartas();
                btnReset.Show();
                labelVictoria.Visible = true;
                labelVictoria.Text = "Ganador Jugador 1";

            }


          
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            P1 = new Personaje(1, 10, 5, 3, 1, 1, 1);
            P2 = new Personaje(2, 4, 3, 3, 2, 2, 2);
            btnReset.Hide();
            FlechaTurno.Show();
            cambiarTurno();
            labelVictoria.Visible = false;
            Player1Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\p\\i.gif");
            Player2Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\e\\i.gif");

        }
    }
}
//300, 300 locacion de la flexha de turno P1
//866, 300 locacion de la flexha de turno P2