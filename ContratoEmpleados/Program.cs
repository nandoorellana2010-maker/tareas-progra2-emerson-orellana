class Program
{
    static void Main(string[]args)
    {
        Gerente gerente = new Gerente
        {
          Nombre = "Nicolle Guevara",
          ID = 002,
          SalarioBase = 28600,
          BonoAnual = 87000 
        };

        Desarrollador desarrollador = new Desarrollador
        {
            Nombre = "Emerson Orellana",
            ID = 007,
            SalarioBase = 26500,
            LenguajePrincipal = "C#"
        };

        Contador contador = new Contador
        {
            Nombre = "Jhon Doe",
            ID = 100,
            SalarioBase = 25000,
            HorasExtras = 22,
            PagoPorHoraExtra = 166  
        };

        gerente.MostrarInformacion();
        desarrollador.MostrarInformacion();
        contador.MostrarInformacion();

        Console.WriteLine("Presiona cualquier tecla para poder salir del sistema...");
        Console.ReadKey();

    }
}
