using System;
using System.Threading.Tasks;

namespace MasterDev
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Crear una instancia del contador (inicia en 0)
            var contador = new Contador();

            List<Empleado> empleados = new List<Empleado>();

            new EmpleadoFijo("Ana", 2000);
            new EmpleadoPorHoras("Luis", 40, 25);

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



            Console.WriteLine(await perro.HacerSonido(null)); 
            Console.WriteLine(await gato.HacerSonido(null));  
            Console.WriteLine(await vaca.HacerSonido(null));  

            Console.WriteLine();
            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey();



            foreach (Empleado emp in empleados)
            {
                Console.WriteLine($"Empleado: {emp.Nombre}");
                Console.WriteLine($"Salario: {emp.CalcularSalario()}");
                Console.WriteLine("----------------------");
            }



            Console.WriteLine("Área del círculo: " + circulo.calcularArea());
            Console.WriteLine("Área del rectángulo: " + rectangulo.calcularArea());

        }
    }
}