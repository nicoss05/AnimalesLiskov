using System;

namespace Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal empLeon = new MamiferoAnimal(1, "Leon");
            Console.WriteLine(string.Format("Animal {0} {1}",
               empLeon.ToString(),
               empLeon.CalculatePeso(450).ToString()));
        }
    }
}
