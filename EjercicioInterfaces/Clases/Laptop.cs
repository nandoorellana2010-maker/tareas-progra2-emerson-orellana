public class Laptop : IDispositivoElectronico
{
    public string? Marca { get; set; }
    public string? Modelo { get; set; }
    public bool EstaEncendido { get; set; }
    public int NivelBateria {get; set;}

    public Laptop(string marca, string modelo, int nivelBateria, bool estaEncendido = true)
    {
        Marca = marca;
        Modelo = modelo;
        EstaEncendido = estaEncendido;
        NivelBateria = nivelBateria;
    }

    public void Encender()
    {
        EstaEncendido = true;
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo} se ha encendido!");
    }
    
    public void Apagar()
    {
        EstaEncendido = false;
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo} se ha apagado!");
    }
    public void MostrarEstado()
    {
        var estado = EstaEncendido ? "Encendido" : "Apagado";
        Console.WriteLine($"Marca: {Marca}\nModelo: {Modelo}\nEstado: {estado}\n");

    }
}