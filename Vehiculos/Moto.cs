using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    internal class Moto : Vehiculo
    {
        public enum ETipo { Ciclomotor, Scooter, Sport }

        private ETipo tipo;
        private static double valorHora;

        public override double CostoEstadia 
        {
            get { return this.CargoDeEstacionamiento(); }
        }

        public override string Descripcion { get { return this.tipo.ToString(); } }

        public double ValorHora
        {
            set
            {
                if(valorHora > 0)
                {
                    valorHora = value;
                }
            }
        }

        private Moto()
        {
            valorHora = 100;
        }

        public Moto(string patente, DateTime ingreso, ETipo tipo)
        {
            this.Patente = patente;
            this.HorarioIngreso = ingreso;
            this.tipo = tipo;
        }



        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * valorHora;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("******MOTO******");
            sb.AppendLine(this.Descripcion);
            sb.AppendLine(base.MostrarDatos());
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
