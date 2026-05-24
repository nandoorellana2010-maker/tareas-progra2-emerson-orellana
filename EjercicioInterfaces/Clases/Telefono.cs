public class Telefono : IDispositivoElectronico
{
    public string? Marca {get; set;}
    public string? Modelo {get; set;}
    public bool EstaEncendido {get; set;}

    public Telefono(string marca, string modelo, bool estaEncendido = false)
    {
        Marca = marca;
        Modelo = modelo;
        EstaEncendido = estaEncendido;
    }

    public void Encender()
    {
        EstaEncendido = true;
        Console.WriteLine($"Marca: {Marca}, Modelo {Modelo} se ha encendido!");
    }
    
    public void Apagar()
    {
        EstaEncendido = false;
        Console.WriteLine($"Marca: {Marca}, Modelo {Modelo} se ha apagado!");
    }
    public void MostrarEstado()
    {
        var estado = EstaEncendido ? "Encendido" : "Apagado";
        Console.WriteLine($"Marca: {Marca}\nModelo: {Modelo}\nEstado: {estado}\n");

    }
}