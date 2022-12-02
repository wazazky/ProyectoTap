using System;

using System.Media;
using System.Reflection;
using System.Windows.Forms;

public class Personaje
{
    public int id;//identificador de personaje, usar el id 1 para el pricipal el 0 para el specatdor y los demas para los eneemigos 
    public int Fuerza;//modificador para el daño 
    public int Resistencia;//Modificador para la vida
    public  int Inteligencia;//el modificador de aumenta la curacion y el escudo 
    public int Suerte;//pasan cosas 
    public float vida;//la vida se calcula en (resistencia*5) * (fuerza*5)
    public float escudo;//el escudo se consigue despues y su multipliador es la inteligencia 

   public float Vida { get => vida; set => vida = value; }
   public float Escudo { get => escudo; set => escudo = value; }

    public Personaje(int id, int Fuerza, int Resistencia, int Inteligencia, int Suerte)
    {
        this.id = id;
        this.Fuerza = Fuerza;
       
        this.Resistencia = Resistencia;
        this.Inteligencia = Inteligencia;
       
        this.Suerte = Suerte;
        this.vida = 25 + (Inteligencia * 5);//el maximo valor base es 50
        this.escudo = 0;//el maximo valor base es 20
    }
    
   


    public static void Ataque(Personaje Atacante, Personaje Defensor, string index)
    {
        int damage = 0;
        if (index == "0") damage=1 ;
        if (index == "1") damage=4 ;
        if (index == "2") damage=9 ;
        int daño = (Atacante.Fuerza) * (damage);
        Console.WriteLine(daño.ToString() +" daño "+ index+" index"+damage.ToString().ToString()+"damage");
        if (Defensor.escudo > 0)
        {
            Defensor.escudo = Defensor.escudo - daño;
            if (Defensor.escudo < 0)
            {
                Defensor.vida = Defensor.vida + Defensor.escudo;
            }
        }
        else {
            Defensor.Vida = Defensor.Vida - daño;
        }
    }
    public static void Curar(Personaje personaje, String index) {
        int cura = 0;
        if (index == "0") cura = 1;
        if (index == "1") cura = 4;
        if (index == "2") cura = 9;
        personaje.vida = personaje.vida + cura * (personaje.Inteligencia); 
        
        if(personaje.vida >25+ (personaje.Inteligencia*2)) personaje.vida = 25+(personaje.Inteligencia*2);
    }
   
    public static void Defender(Personaje personaje,String index )
    {
        int escudo = 0;
        if (index == "0") escudo = 1;
        if (index == "1") escudo = 4;
        if (index == "2") escudo = 9;
        
        personaje.escudo = personaje.escudo + (escudo*(personaje.Resistencia));
        if (personaje.escudo > 30) personaje.escudo= 30 ;

    }
        
    public static void mostrar(Personaje p1,Personaje p2) {

        Console.WriteLine("id de personaje " + p1.id+ "Vida de personaje "+p1.Vida+ " " + p1.Fuerza + " " + p1.Resistencia);
       
        Console.WriteLine("id de personaje " + p2.id+ "Vida de personaje "+p2.Vida+ " " + p2.Fuerza + " " + p2.Resistencia+"\n");
        
    
    }
}
