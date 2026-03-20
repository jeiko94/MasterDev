namespace MasterDev
{
    public class Empleado
    {
        public string Nombre { get; set; }

        public Empleado(string nombre)
        {
            Nombre = nombre;
        }

        public virtual double CalcularSalario()
        {
            return 0;
        }
    }
}

