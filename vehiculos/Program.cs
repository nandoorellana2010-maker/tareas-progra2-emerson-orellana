class Program
{
    static void Main(string[] args)
    {
        Carro carro1 = new Carro
        {
            Marca = "Toyota",
            Modelo = "Corolla",
            Anio = 2020,
            NumeroPuertas = 4,
            TipoCombustible = "Gasolina"
        };

        Carro carro2 = new Carro
        {
            Marca = "Ford",
            Modelo = "F-150",
            Anio = 2021,
            NumeroPuertas = 4,
            TipoCombustible = "Electrico"
        };

        Moto moto1 = new Moto
        {
            Marca = "Yamaha",
            Modelo = "FZ25",
            Anio = 2019,
            Cilindrada = 250,
            TieneMaletero = true
        };
            
        Moto moto2 = new Moto
        {
            Marca = "Honda",
            Modelo = "CB190R",
            Anio = 2023,
            Cilindrada = 190,
            TieneMaletero = false
        };

        carro1.MostrarInformacion();
        carro2.MostrarInformacion();
        moto1.MostrarInformacion();
        moto2.MostrarInformacion();

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();

    }
}