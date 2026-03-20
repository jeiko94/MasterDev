using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasterDev
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            // Crear una instancia del contador (inicia en 0)
            var contador = new Contador();

            List<Empleado> empleados = new List<Empleado>();

            var emp1 = new EmpleadoFijo("Ana", 2000);
            var emp2 = new EmpleadoPorHoras("Luis", 40, 25);

            // Añadir empleados a la lista para conservar y mostrar su estado
            empleados.Add(emp1);
            empleados.Add(emp2);

            Circulo circulo = new Circulo(5);
            Rectangulo rectangulo = new Rectangulo(4, 6);

            ISonido perro = new Perro();
            ISonido gato = new Gato();
            ISonido vaca = new Vaca();

            // Ejecutar operaciones y mostrar resultados
            Console.WriteLine("Incrementar(): " + contador.Incrementar()); // -> 1
            Console.WriteLine("Incrementar(): " + contador.Incrementar()); // -> 2
            Console.WriteLine("Decrementar(): " + contador.Decrementar()); // -> 1

            Console.WriteLine();

            // Evitar pasar null a parámetros no anulables
            Console.WriteLine(await perro.HacerSonido(string.Empty));
            Console.WriteLine(await gato.HacerSonido(string.Empty));
            Console.WriteLine(await vaca.HacerSonido(string.Empty));

            Console.WriteLine();

            // Mostrar cada empleado en la lista
            foreach (var emp in empleados)
            {
                Console.WriteLine($"Empleado: {emp.Nombre}");
                Console.WriteLine($"Salario: {emp.CalcularSalario()}");
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("Área del círculo: " + circulo.CalcularArea());
            Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());

            Console.WriteLine();
            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}