using System;

namespace Ejercicio1DeNahuelNavarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Distancia recorrida";
            double tiempo, velocidad, distancia, distanciaKM;

            Console.Write("Ingrese el valor de velocidad: ");
            velocidad = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de tiempo: ");
            tiempo = double.Parse(Console.ReadLine());

            distancia = velocidad * tiempo;
            distanciaKM = 0.001 * distancia;

            Console.WriteLine($"La distancia recorrida en metros por segundos es de {distancia} m/s");
            Console.WriteLine($"La distancia recorrida en kilometros es de {distanciaKM} Kms");
            
            Console.ReadLine();
        }
    }
}
