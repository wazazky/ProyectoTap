using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTAP
{
    internal class Wcore
    {

        public SoundPlayer playSimpleSound(string direccion)
        {
           
            SoundPlayer Musica = new SoundPlayer(System.Windows.Forms.Application.StartupPath + direccion);
            Musica.Play();
            return Musica;
        }

    }
}
