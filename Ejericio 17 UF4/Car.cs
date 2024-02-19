using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio_17_UF4
{
    public class Car
    {
        private int gasolina;
        public Car(int gasolina)
        {
            this.gasolina = gasolina;
        }
        public void Drive()
        {
            if (gasolina > 0)
            {
                Console.WriteLine("Conducir");
            }
        }
        public bool Refuel(int gasolina)
        {
            this.gasolina += gasolina;
            return true;
        }
    }
}
