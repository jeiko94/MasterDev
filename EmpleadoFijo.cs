public class EmpleadoFijo : Empleado
{
    private double salarioFijo;

    public EmpleadoFijo(string nombre, double salarioFijo)
        : base(nombre)
    {
        this.salarioFijo = salarioFijo;
    }

    public override double CalcularSalario()
    {
        return salarioFijo;
    }
}