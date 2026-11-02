using System;
using System.Collections.Generic;
using System.Text;

namespace AlquilerVehiculos
{
    //Herencia: Esta clase hereda de Vehiculo
    public class Auto : Vehiculo
    {
        public double costo_Seguro {  get; set; }

        //Constructor que reescribe el constructor de Vehiculo
        public Auto(String patente, String marca, double tarifa_Base, double costo_Seguro):base(patente,marca,tarifa_Base)
        {
            this.costo_Seguro = costo_Seguro;
        }

        //Polimorfismo: Sobrescribe el metodo de TarifaFinal para adaptalo al de Auto
        public override double TarifaFinal()
        {
            //Encapsulamiento: use el metodo Tarifa_Base para acceder a tarifa_Base
            return costo_Seguro + Tarifa_Base;
        }
        //Sobrescribe la funcion TipoVehiculo para Auto
        public override string TipoVehiculo()
        {
            return "Auto";
        }
    }
}
