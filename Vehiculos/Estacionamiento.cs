using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Estacionamiento
    {
        private int capacidadDeEstacionamiento;
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> listadoVehiculos;
        private string nombre;

        public List<Vehiculo> ListadoDeVehiculos
        {
            get { return listadoVehiculos; }
        } 
        public string Nombre { get { return nombre; } }

        private Estacionamiento(string nombre, int capacidad)
        {
            this.capacidadDeEstacionamiento = capacidad;
            this.nombre = nombre;
            this.listadoVehiculos = new List<Vehiculo>();
        }

        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            if(estacionamiento is null)
            {
                return new Estacionamiento(nombre, capacidad);
            }
            else
            {
                estacionamiento.capacidadDeEstacionamiento = capacidad;
                return estacionamiento;
            }
        }
        public string InformarSalida(Vehiculo vehiculo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Estacionamiento: {Nombre}");
            sb.AppendLine(vehiculo.ToString());
            sb.AppendLine(vehiculo.HorarioEgreso.ToString());
            sb.AppendLine(vehiculo.CostoEstadia.ToString());
            return sb.ToString();
        }


    }
}
