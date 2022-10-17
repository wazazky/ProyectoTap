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
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Linea en public form1");
           // pictureBox1.Image = 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Linea en public form1load ");
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Player.Load(System.Windows.Forms.Application.StartupPath + "\\Recursos Proyecto TAP\\Personajes\\image 2.gif");
            Contador.Start();
          
          
        }

        private void Player_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
