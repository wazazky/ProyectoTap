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
        string dir;
        public SoundPlayer playSimpleSound(string direccion)
        {
           
            SoundPlayer Musica = new SoundPlayer(System.Windows.Forms.Application.StartupPath + direccion);
            //Musica.Play();
            return Musica;
        }
       public void Sonido(string direccion) {
            dir = direccion;
            Thread thread = new Thread(new ThreadStart(WorkThreadFunction));
            thread.Start();

        }
        public void  efecto(string direccion)
        {

            SoundPlayer sonido = new SoundPlayer(System.Windows.Forms.Application.StartupPath + direccion);
            sonido.Play();
            
        }

        




public void WorkThreadFunction()
    {
        try
        {
            SoundPlayer sonido = new SoundPlayer(System.Windows.Forms.Application.StartupPath + dir);
                sonido.Play();
        }
        catch (Exception ex)
        {
            // log errors
        }
    }

}
}
