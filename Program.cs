namespace AlquilerVehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista heterogenea: almacena los datos de todos los vehiculos
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            vehiculos.Add(new Auto("ASA870", "Fiat", 150000, 3000));
            vehiculos.Add(new Camioneta("FMP567","Fiat", 300000, 1.1, 3000));

            Console.WriteLine("Listado de vehiculos en alquiler: ");

            //Polimorfismo: Recorre la lista vehiculos y utilizo una variable tipo para almacenar el TipoVehiculo
            foreach(Vehiculo v in vehiculos)
            {
                string tipo = v.TipoVehiculo();
                Console.WriteLine($"Tipo: {tipo}   | Patente: {v.Patente}   | Marca: {v.Marca}   | Costo: {v.TarifaFinal()}");
            }
        }
    }
}
