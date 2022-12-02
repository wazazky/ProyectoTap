using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoTAP
{
    public partial class Juego : UserControl
    {
        // Wcore Wcore=new Wcore();//objeto para el sonido

        Personaje P1;
        Personaje P2;
        Random rnd = new Random();
        string cura = "\\Recursos Proyecto TAP\\sonido\\c.wav";
        string escudo = "\\Recursos Proyecto TAP\\sonido\\s.wav";
        string golpe = "\\Recursos Proyecto TAP\\sonido\\a.wav";
        string victoria= "\\Recursos Proyecto TAP\\sonido\\end.wav";
        string rol= "\\Recursos Proyecto TAP\\sonido\\t.wav";
        bool Turno = true;//true es para el Player1 , false es para el player 2
        bool readyP1=false, readyP2=false;

        public Juego()
        {
            InitializeComponent();
            Tooltipini();
            btnReset.Hide();  
            FlechaTurno.Hide();
            disableLabel();
            disableCartas();
          

        }
        void disableLabel() {
           labelVictoria.Visible= false;
            labelvidaP1.Visible= false;
            labelvidaP2.Visible = false;
            labelescudoP1.Visible = false;
            labelescudoP2.Visible = false;
            labelAtributosP1.Visible = false;
            labelAtributosP2.Visible = false;

        }
        void iniLabelEstado() {
            labelVictoria.Visible = false;
            labelvidaP1.Visible = true;
            labelvidaP2.Visible = true;
            labelescudoP1.Visible = true;
            labelescudoP2.Visible = true;
            labelAtributosP1.Visible = true;
            labelAtributosP2.Visible = true;
            labelVictoria.BackColor = Color.FromArgb(120, Color.Black);
            labelvidaP1.BackColor = Color.FromArgb(200, Color.Black);
            labelvidaP2.BackColor = Color.FromArgb(200, Color.Black);
            labelescudoP1.BackColor = Color.FromArgb(200, Color.Black);
            labelescudoP2.BackColor = Color.FromArgb(200, Color.Black);
            labelvidaP1.ForeColor = Color.FromArgb(120, Color.Green);
            labelvidaP2.ForeColor = Color.FromArgb(120, Color.Green);
            labelescudoP1.ForeColor = Color.FromArgb(120, Color.Blue);
            labelescudoP2.ForeColor = Color.FromArgb(120, Color.Blue);
            labelAtributosP1.BackColor = Color.FromArgb(120, Color.Black);
            labelAtributosP2.BackColor = Color.FromArgb(120, Color.Black);
            labelctlr();
            FlechaTurno.Show();
            cambiarTurno();

        }
        void labelctlr() 
        {
            labelvidaP1.Text = "vida " + P1.Vida.ToString()+"/"+(25+(P1.Inteligencia*5));
            labelvidaP2.Text = "vida " + P2.Vida.ToString()+ "/"+(25+(P2.Inteligencia*5));
            labelescudoP1.Text = "Escudo " + P1.Escudo.ToString()+"/30";
            labelescudoP2.Text = "Escudo " + P2.Escudo.ToString()+"/30";
            labelAtributosP1.Text="Fuerza: "+P1.Fuerza.ToString()+"\nResistencia: "+P1.Resistencia.ToString()+"\nInteligencia: "+P1.Inteligencia.ToString();
            labelAtributosP2.Text = P2.Fuerza.ToString() + " :Fuerza\n" + P2.Resistencia.ToString() + " :Resistencia\n" + P2.Inteligencia.ToString()+" :Inteligencia";

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
        void resetRol() {

            btnRolCP2.Show();
            btnRolCP2.Enabled = true;
            btnRolCP1.Show();
            btnRolCP1.Enabled = true;
            btnRolEP1.Show();
            btnRolEP1.Enabled = true;
            btnRolEP2.Show();
            btnRolEP2.Enabled = true;
            btnRolFP2.Show();
            btnRolFP2.Enabled = true;
            btnRolFP1.Show();
            btnRolFP1.Enabled = true;
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
            P1 = new Personaje(1, 10, 5, 3, 1);
            P2 = new Personaje(2, 4, 3, 3, 2);
            btnReset.Hide();
            FlechaTurno.Show();
            cambiarTurno();
            labelVictoria.Visible = false;
            Player1Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\p\\i.gif");
            Player2Image.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\e\\i.gif");
            FlechaTurno.Hide();
            disableLabel();
            disableCartas();
            resetRol();
            readyP1 = false;
            readyP2 = false;

        }

        private void btnRolFP1_Click(object sender, EventArgs e)
        {
            P1 = new Personaje(1, 3, rnd.Next(3) + 1, rnd.Next(3) + 1, 0);
            readyP1= true;  
            if (readyP1 & readyP2) iniLabelEstado();
            btnRolCP1.Hide();
            btnRolEP1.Hide();
            btnRolFP1.Enabled= false;
            Wcore.Sonido(rol);
        }

        private void btnRolCP1_Click(object sender, EventArgs e)
        {
            P1 = new Personaje(1, rnd.Next(3) + 1, rnd.Next(3) + 1, 3, 0);
            readyP1 = true;
            if (readyP1 & readyP2) iniLabelEstado();
            btnRolFP1.Hide();
            btnRolEP1.Hide();
            btnRolCP1.Enabled = false;
            Wcore.Sonido(rol);
        }

        private void btnRolEP1_Click(object sender, EventArgs e)
        {
            P1 = new Personaje(1, rnd.Next(3) + 1,3, rnd.Next(3) + 1, 0);
            readyP1 = true;
            if (readyP1 & readyP2) iniLabelEstado();
            btnRolFP1.Hide();
            btnRolCP1.Hide();
            btnRolEP1.Enabled = false;
            Wcore.Sonido(rol);
        }

        private void btnRolEP2_Click(object sender, EventArgs e)
        {
            P2 = new Personaje(1, rnd.Next(3)+1, 3, rnd.Next(3)+1, 0);
            readyP2 = true;
            if (readyP1 & readyP2) iniLabelEstado();
            btnRolFP2.Hide();
            btnRolCP2.Hide();
            btnRolEP2.Enabled = false;
            Wcore.Sonido(rol);
        }

        private void btnRolCP2_Click(object sender, EventArgs e)
        {
            P2 = new Personaje(1, rnd.Next(3)+1, rnd.Next(3)+1, 3, 0);
            readyP2 = true;
            if (readyP1 & readyP2) iniLabelEstado();
            btnRolFP2.Hide();
            btnRolEP2.Hide();
            btnRolCP2.Enabled = false;
            Wcore.Sonido(rol);

        }

        void Tooltipini() { 
        InfoC.SetToolTip(btnRolCP1, "La cura recibida\nsera X 3\nAdemas tendras mas vida inicial");
        InfoC.SetToolTip(btnRolCP2, "La cura recibida\nsera X 3\nAdemas tendras mas vida inicial");
        InfoF.SetToolTip(btnRolFP1, "El daño realizado\nsera X 3");
        InfoF.SetToolTip(btnRolFP2, "El daño realizado\nsera X 3");
        InfoE.SetToolTip(btnRolEP1, "El escudo añadido\nsera X 3");
        InfoE.SetToolTip(btnRolEP2, "El escudo añadido\nsera X 3");
        }

        private void btnRolFP2_Click(object sender, EventArgs e)
        {
            P2 = new Personaje(1, 3, rnd.Next(3)+1, rnd.Next(3)+1, 0);
            readyP2 = true;
            if (readyP1 & readyP2) iniLabelEstado();
            btnRolEP2.Hide();
            btnRolCP2.Hide();
            btnRolFP2.Enabled = false;

        }
    }
}
//300, 300 locacion de la flexha de turno P1
//866, 300 locacion de la flexha de turno P2
