public class Desarrollador: Empleado
{
    public string? LenguajePrincipal { get; set; }

    public override double CalcularSalarioAnual()
    {
        return SalarioBase *12;  
    }
    public override void MostrarInformacion()
    {
        Console.WriteLine("=== Información del Desarrollador ===");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Salario Base: {SalarioBase:C}");
            Console.WriteLine($"Lenguaje Principal: {LenguajePrincipal}");
            Console.WriteLine($"Salario Anual: {CalcularSalarioAnual():C}");
            Console.WriteLine();
    }
}