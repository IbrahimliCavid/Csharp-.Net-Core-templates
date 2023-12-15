namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gasstation: ");
            Console.WriteLine("Your car's has not gasoline. Please add The gasoline.");
            int gasoline = int.Parse(Console.ReadLine());
            Car car = new Car(gasoline);
            car.Drive();
        }
    }

    public class Car:IVehcile
    {
        private int _gasoline;

        public Car(int gasoline)
        {
            _gasoline = gasoline;
        }

        public void Drive()
        {
            if (Refuel(_gasoline))
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("Car not driving");
            }
        } 

        public bool Refuel(int gasoline)
        {
            if (gasoline > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public interface IVehcile
    {
        void Drive();
        bool Refuel(int gasoline);
    }

    
}