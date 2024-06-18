using System.Security.Cryptography.X509Certificates;

namespace EsInterfaccia
{
    public class Program
    {
        static void Main(string[] args)
        { 
            var car = new Car(0);

            car.Drive();

            refuelCar(car);

            
        }

        static void refuelCar(Car c)
        {
            bool isCheck = false;
            var refuel = c.Refuel(c.Gasoline);

            while (!isCheck)
            {
                Console.WriteLine("Quanto carburante vuoi rifornire?");
                var input = Console.ReadLine()?.Trim() ?? "";

                Console.Clear();

                var isInt = Int32.TryParse(input, out int n);

                if ((!string.IsNullOrEmpty(input)) && (isInt))
                {
                    refuel = c.Refuel(n);
                    isCheck = true;
                }
            }

            if (refuel)
                c.Drive();
        }
    }
}
