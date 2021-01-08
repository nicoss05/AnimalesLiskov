using ConsoleApp1.Implementation;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animales = new List<Animal>();
            animales.Add(new MamiferoAnimal(1, "Leon"));

            foreach (var animal in animales)
            {
                Console.WriteLine(string.Format("Animal {0} Peso: {1} Peso Minimo: {2}",
                animal.ToString(),
                animal.CalculatePeso(450).ToString(),
                animal.PesoMinimo().ToString()));
            }

            Console.WriteLine();
            List<IAnimal> Soloanimales = new List<IAnimal>();

            Soloanimales.Add(new MamiferoAnimal(1, "Leon"));
        }
    }
}