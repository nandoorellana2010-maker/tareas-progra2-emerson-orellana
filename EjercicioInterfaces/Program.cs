var telefono = new Telefono("Honor", "90 Lite", false);
var laptop = new Laptop("Dell", "Alienware 16 Area 51", 100, false);

Console.WriteLine("\nMostrando Estado Inicial de los Dispositivos: ");
telefono.MostrarEstado();
laptop.MostrarEstado();

Console.WriteLine("\nEncendiendo los Dispositivos:");
telefono.Encender();
telefono.MostrarEstado();
laptop.Encender();
laptop.MostrarEstado();

Console.WriteLine("\nApagando los Dispositivos: ");
telefono.Apagar();
telefono.MostrarEstado();
laptop.Apagar();
laptop.MostrarEstado();

Console.WriteLine("\nPresione cualquier tecla para salir del sistema: ");
Console.ReadKey();
