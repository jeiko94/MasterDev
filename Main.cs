using System;

namespace MasterDev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia del contador (inicia en 0)
            var contador = new Contador();

            List<Empleado> empleados = new List<Empleado>();

            new EmpleadoFijo("Ana", 2000);
            new EmpleadoPorHoras("Luis", 40, 25);


            // Ejecutar operaciones y mostrar resultados
            Console.WriteLine("Incrementar(): " + contador.Incrementar()); // -> 1
            Console.WriteLine("Incrementar(): " + contador.Incrementar()); // -> 2
            Console.WriteLine("Decrementar(): " + contador.Decrementar()); // -> 1

            Console.WriteLine();
            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey();



            foreach (Empleado emp in empleados)
            {
                Console.WriteLine($"Empleado: {emp.Nombre}");
                Console.WriteLine($"Salario: {emp.CalcularSalario()}");
                Console.WriteLine("----------------------");
            }
        }
    }
}