using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoTAP
{

    public partial class Form1 : Form
    {
        int cont = 0;
        Personaje p1;
        Personaje p2;
        Personaje Espectador;
        public Form1()
        {
            
            InitializeComponent();
            Contador.Start();
            Console.WriteLine("Linea en public form1");

            crearpj();
                }
        public void crearpj() {
            Espectador = new Personaje(0);
            p1 = new Personaje(1);
            p2 = new Personaje(2);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Linea en public form1load ");
        }


        public void ClickAtaque(Personaje p1, Personaje p2) {
            Espectador.Ataque(p1, p2, 5);
            Espectador.mostrar(p1, p2);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Player.Load(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\Personajes\\image 2.gif");
            //Contador.Start();
            ClickAtaque(p1,p2);        
          
        }

        private void Player_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
            {
            //Console.WriteLine(Player.Location.ToString());
           cont++;
           Console.WriteLine(cont);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player.Load(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\Personajes\\image.gif");
            pictureBox1.Load(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\Personajes\\image2.gif");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }

}
