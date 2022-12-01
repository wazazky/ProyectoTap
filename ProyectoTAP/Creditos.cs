using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTAP
{
    public partial class Creditos : UserControl
    {
        public Creditos()
        {
            InitializeComponent();
  

            IntegrantesTxt.Text = "20211813 RAUL GIOVANNI MOLINA MEDNEZ\r\r\n22212072 LIZARRAGA RODRIGUEZ JESUS ALBERTO\r\r\n 20210567 Garcia Torres Omar";
            DatosTec.Text = "TECNOLÓGICO NACIONAL DE MÉXICO\r\nINSTITUTO TECNOLÓGICO DE TIJUANA\r\n\r\nDEPARTAMENTO DE SISTEMAS Y COMPUTACIÓN\r\nING.EN SISTEMAS COMPUTACIONALES\r\nSEMESTRE 2022 - 2";
            IntegrantesTxt.BackColor= Color.FromArgb(120, Color.Black);
            DatosTec.BackColor= Color.FromArgb(120, Color.Black);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
