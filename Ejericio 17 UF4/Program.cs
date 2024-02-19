using System;

namespace Ejericio_17_UF4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduce la cantidad de gasolina que quieres repostar");
            int gasolina = Convert.ToInt32(Console.ReadLine());
            Car coche = new Car(0);
            coche.Refuel(gasolina);
            coche.Drive();
        }
    }
}