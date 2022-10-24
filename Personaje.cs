using System;
	

 
public class Personaje
{
    int id;
    int Fuerza;
    int Persepcion;
    int Resistencia;
    int Carisma;
    int Inteligencia;
    int Suerte;

    public global::System.Int32 Id { get => id; set => id = value; }
    public global::System.Int32 Fuerza1 { get => Fuerza; set => Fuerza = value; }
    public global::System.Int32 Persepcion1 { get => Persepcion; set => Persepcion = value; }
    public global::System.Int32 Resistencia1 { get => Resistencia; set => Resistencia = value; }
    public global::System.Int32 Carisma1 { get => Carisma; set => Carisma = value; }
    public global::System.Int32 Inteligencia1 { get => Inteligencia; set => Inteligencia = value; }
    public global::System.Int32 Suerte1 { get => Suerte; set => Suerte = value; }

    public Personaje(int id,int Fuerza,int Persepcion,int Resistencia,int Carisma,int Inteligencia,int Suerte)
	{ 
        this.id = id;   
        this.Fuerza = Fuerza;
        this.Persepcion = Persepcion;
        this.Resistencia = Resistencia;
        this.Carisma = Carisma;
        this.Inteligencia = Inteligencia;
        this.Suerte = Suerte;

	}
    public Personaje(int id) {
        Random rnd = new Random();
         
        this.id = id;

        this.Fuerza = rnd.Next(10);
        this.Persepcion = rnd.Next(10);
        this.Resistencia = rnd.Next(10);
        this.Carisma = rnd.Next(10);
        this.Inteligencia = rnd.Next(10);
        this.Suerte = rnd.Next(10);

    }


}
