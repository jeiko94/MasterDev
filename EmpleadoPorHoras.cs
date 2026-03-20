public class EmpleadoPorHoras : Empleado
{
    private int horas;
    private double valorHora;

    public EmpleadoPorHoras(string nombre, int horas, double valorHora)
        : base(nombre)
    {
        this.horas = horas;
        this.valorHora = valorHora;
    }

    // Override del método
    public override double CalcularSalario()
    {
        return horas * valorHora;
    }
}