using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProyectoTAP
{
   
    internal class Wcore
    {
        
        public static SoundPlayer playSimpleSound(string direccion)
        {
           
            SoundPlayer Musica = new SoundPlayer(System.Windows.Forms.Application.StartupPath + direccion);
            //Musica.Play();
           
            return Musica;
        }
   public static void Sonido(string direccion)
        {
           
            SoundPlayer Musica = new SoundPlayer(System.Windows.Forms.Application.StartupPath + direccion);
            Musica.Play();
           


        }
 

        





}
}
