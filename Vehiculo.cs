using System;
using System.Collections.Generic;
using System.Text;

namespace AlquilerVehiculos
{
    public class Vehiculo
    {
        //Encapsulamiento: atributos privados que solo se pueden acceder con metodos
        private String patente;
        private String marca;
        private Double tarifa_Base;

        public Vehiculo (string patente, string marca, double tarifa_Base)
        {
            this.patente = patente;
            this.marca = marca;
            this.tarifa_Base = tarifa_Base;
        }

        //propiedades get y set
        public String Patente
        {
            get {  return patente; }
            set {  patente = value; }
        }
        public String Marca
        {
            get { return marca; }
            set {  marca = value; }
        }
        public double Tarifa_Base
        {
            get { return tarifa_Base; }
            set { tarifa_Base = value; }
        }

        //Polimorfismo: Metodo virtual para que las clases que hereden de Vehiculo sobreescriban este metodo
        public virtual double TarifaFinal()
        {
            return tarifa_Base;
        }
        //Metodo virtual para identificar el tipo de vehiculo
        public virtual string TipoVehiculo()
        {
            return "";
        }
    }
}
