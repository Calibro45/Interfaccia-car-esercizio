using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsInterfaccia
{
    internal class Car : IVehicle
    {
        public int Gasoline { get; set; }

        public Car(int g)
        {
            Gasoline = g;
        }

        public void Drive()
        {
            if (Gasoline > 0)
                Console.WriteLine("The car is Driving.");
            else
                Console.WriteLine("The car need a refuel!");
        }

        public bool Refuel(int n)
        {
            Gasoline += n;

            if (Gasoline > 0)
                return true;
            else 
                return false;
        }

    }
}
