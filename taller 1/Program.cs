using System;

namespace Reto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mostrar fecha en dos formatos diferentes
            Console.WriteLine("Mostar fechas en diferentes formatos");
            Console.WriteLine("Hoy es: " + DateTime.Now.ToString("d")); // Ej: 10/05/2025
            Console.WriteLine("Hoy es: " + DateTime.Now.ToString("d 'de' MMMM 'del' yyyy")); // Ej: 10 de mayo del 2025

            // Esperar que el usuario presione una tecla para continuar
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Pedir la base del triángulo
            Console.WriteLine("Digite la base del triángulo:");
            float baseTriangulo = float.Parse(Console.ReadLine());

            // Pedir la altura del triángulo
            Console.WriteLine("Digite la altura del triángulo:");
            float alturaTriangulo = float.Parse(Console.ReadLine());

            // Calcular el área del triángulo
            float area = (baseTriangulo * alturaTriangulo) / 2;

            // Mostrar el resultado en diferentes formatos

            Console.WriteLine("\n--- Resultados en diferentes formatos ---");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Formato numérico con dos decimales: " + area.ToString("N2"));
            Console.WriteLine("Formato de moneda: " + area.ToString("C2"));
            Console.WriteLine("Formato fijo: " + area.ToString("F2"));
            Console.WriteLine("Formato general: " + area.ToString("G"));

            // Esperar que el usuario presione una tecla para salir
            Console.WriteLine("\nPresiona cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
