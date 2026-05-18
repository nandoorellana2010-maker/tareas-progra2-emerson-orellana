public class Carro: Vehiculo
{
     public int NumeroPuertas {get; set;}
    public string? TipoCombustible {get; set;}
    public override void MostrarInformacion()
    {
     Console.WriteLine("==Informacion del Carro ==");  
     base.MostrarInformacion();
     Console.WriteLine($"Numero de puertas: {NumeroPuertas}");
     Console.WriteLine($"Tipo de Combustible: {TipoCombustible}");
     Console.WriteLine();
    }

}