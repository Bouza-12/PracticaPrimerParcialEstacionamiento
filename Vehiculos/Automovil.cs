using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Automovil : Vehiculo
    {
        private string marca;
        private static double valorHora;

        public override string Descripcion { get { return marca; }}
        public static double ValorHora { set { if (value > 0) { valorHora = value; } } }
        public override double CostoEstadia
        {
            get
            {
                return this.CargoDeEstacionamiento();
            }
        }

        private Automovil() { valorHora = 120; }

        public Automovil(string patente, DateTime ingreso, string marca)
        {
            Patente = patente;
            this.HorarioIngreso = ingreso;
            this.marca = marca;
        }

        
        protected override double CargoDeEstacionamiento()
        {
            return valorHora * (HorarioEgreso.Hour - HorarioEgreso.Hour);
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("******AUTOMOVIL******");
            sb.AppendLine($"Patente: {Patente}");
            sb.AppendLine($"Hora de Ingreso: {HorarioIngreso}");
            return sb.ToString();

        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
