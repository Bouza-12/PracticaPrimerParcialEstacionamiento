using System.Text;

namespace Vehiculos
{
    public enum EVehiculos {  Automovil, Moto}

    public abstract  class Vehiculo
    {
        private DateTime horarioEgreso;
        private DateTime horarioIngreso;
        private string patente;

        public string Patente { get { return patente;} set { if (ValidarPatente(value)){
                    patente = value;}; } }

        public DateTime HorarioIngreso { get { return horarioIngreso;} set { horarioIngreso = value; } }
        public DateTime HorarioEgreso 
        { 
            get 
            { 
                return horarioEgreso;
            }
            set 
            { 
                if(HorarioIngreso < value)
                {
                    horarioEgreso = value;
                }
            } 
        }
        public abstract double CostoEstadia { get; }
        public abstract string Descripcion { get; }

        protected virtual double CargoDeEstacionamiento()
        {
            return HorarioEgreso.Hour - HorarioIngreso.Hour;
        }
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Patente: {Patente}");
            sb.AppendLine($"Hora de Ingreso: {HorarioIngreso}");
            return string.Empty;
        }
        private bool ValidarPatente(string patente)
        {
            return patente.Length == 6 || patente.Length == 7;
        }
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.Patente == v2.Patente;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}