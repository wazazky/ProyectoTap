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
    public partial class VentanaDeJuego : Form
    {
        public VentanaDeJuego()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
    }
}
