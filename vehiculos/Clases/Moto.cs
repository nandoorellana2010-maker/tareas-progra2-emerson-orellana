public class Moto : Vehiculo
{
    public int Cilindrada {get; set;}
    public bool TieneMaletero {get; set;}

    public override void MostrarInformacion()
    {
        Console.WriteLine("==Informacion de la Moto ==");  
        base.MostrarInformacion();
        Console.WriteLine($"Cilindrada: {Cilindrada} cc");
        Console.WriteLine($"Tiene Maletero?: {(TieneMaletero ? "Si" : "No")}");
        Console.WriteLine();
    }
}