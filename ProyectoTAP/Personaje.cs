using System;

using System.Media;

public class Personaje
{
    int id;//identificador de personaje, usar el id 1 para el pricipal el 0 para el specatdor y los demas para los eneemigos 
    int Fuerza;//modificador para el daño y el calculo d vida total 
    int Persepcion;//modificador de punteria 
    int Resistencia;//Modificador para la vida
    int Carisma;// reduce el costo de los objetos 
    int Inteligencia;//el modificador de aumenta la curacion y el escudo 
    int Agilidad;//modificador para bajar la punteria al enemigo
    int Suerte;//padan cosas 
    float vida;//la vida se calcula en (resistencia*5) * (fuerza*5)
    float escudo;//el escudo se consigue despues y su multipliador es la inteligencia 

    public global::System.Int32 Id { get => id; set => id = value; }
    public global::System.Int32 Fuerza1 { get => Fuerza; set => Fuerza = value; }
    public global::System.Int32 Persepcion1 { get => Persepcion; set => Persepcion = value; }
    public global::System.Int32 Resistencia1 { get => Resistencia; set => Resistencia = value; }
    public global::System.Int32 Carisma1 { get => Carisma; set => Carisma = value; }
    public global::System.Int32 Inteligencia1 { get => Inteligencia; set => Inteligencia = value; }
    public global::System.Int32 Suerte1 { get => Suerte; set => Suerte = value; }
    public float Vida { get => vida; set => vida = value; }
    public float Escudo { get => escudo; set => escudo = value; }
    public int Agilidad1 { get => Agilidad2; set => Agilidad2 = value; }
    public int Agilidad2 { get => Agilidad; set => Agilidad = value; }

    public Personaje(int id, int Fuerza, int Persepcion, int Resistencia, int Carisma, int Inteligencia,int Agilidad, int Suerte)
    {
        this.id = id;
        this.Fuerza = Fuerza;
        this.Persepcion = Persepcion;
        this.Resistencia = Resistencia;
        this.Carisma = Carisma;
        this.Inteligencia = Inteligencia;
        this.Agilidad2 = Agilidad;
        this.Suerte = Suerte;
        this.vida = (Resistencia * 5) + (Fuerza * 5);
        this.escudo = 0;
    }
    public Personaje(int id)
    {
        Random rnd = new Random();

        this.id = id;
        this.Fuerza = rnd.Next(10);
        this.Persepcion = rnd.Next(10);
        this.Resistencia = rnd.Next(10);
        this.Carisma = rnd.Next(10);
        this.Inteligencia = rnd.Next(10);
        this.Suerte = rnd.Next(10);
        this.Agilidad2 = rnd.Next(10);
        this.vida = (Resistencia * 5) + (Fuerza * 5);
        this.escudo = 0;
    }
    public Personaje()//este consturctor es para el Espectador
    { 

    }


    public void Ataque(Personaje Atacante, Personaje Defensor, int damage)
    {
        float daño = (Atacante.Fuerza) * (damage);
        if (Defensor.escudo > 0)
        {
            Defensor.escudo = Defensor.escudo - daño;
            if (Defensor.escudo < 0)
            {
                Defensor.vida = Defensor.vida - Defensor.escudo;
            }
        }
        else {
            Defensor.Vida = Defensor.Vida - daño;
        }

    }
    public void Curar(Personaje Defensor, int cura) {
        Defensor.vida = Defensor.vida + cura * (Defensor.Inteligencia);
    }
    public void eleccion(Personaje Atacante, Personaje Defensor) {

        Random rnd = new Random();
        int eleccion = rnd.Next(2);
        if (eleccion == 1)
        {
            Curar(Defensor , rnd.Next(5));

        }
        else {
            Ataque(Defensor,Atacante, rnd.Next(5));
        }       
        }
    public void mostrar(Personaje p1,Personaje p2) {

        Console.WriteLine("id de personaje " + p1.id+ "Vida de personaje "+p1.Vida);
        Console.WriteLine("id de personaje " + p2.id+ "Vida de personaje "+p2.Vida);

    
    }
}
