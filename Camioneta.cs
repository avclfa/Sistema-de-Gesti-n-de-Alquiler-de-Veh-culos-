using System;
using System.Collections.Generic;
using System.Text;

namespace AlquilerVehiculos
{
    //Herencia: Esta clase hereda de Vehiculo
    public class Camioneta : Vehiculo
    {
        public double tonelaje {  get; set; }
        public double costoxtonelada {  get; set; }

        //Constructor que reescribe el constructor de Vehiculo
        public Camioneta(string patente, string marca, double tarifa_Base, double tonelaje, double costoxtonelada) : base(patente, marca, tarifa_Base)
        {
            this.tonelaje = tonelaje;
            this.costoxtonelada = costoxtonelada;
        }

        //Polimorfismo: Sobrescribe el metodo de TarifaFinal para adaptalo al de Camioneta
        public override double TarifaFinal()
        {
            //Encapsulamiento: use el metodo Tarifa_Base para acceder a tarifa_Base
            double recargo = costoxtonelada * tonelaje;
            return Tarifa_Base + recargo;
        }

        //Sobrescribe la funcion TipoVehiculo para Camioneta
        public override string TipoVehiculo()
        {
            return "Camioneta";
        }
    }
}
