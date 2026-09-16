using System;

namespace AbstractFactoryDemo
{
    // 1. Abstract Products
    public interface IVehicle
    {
        void ShowDetails();
    }

    public interface IEngine
    {
        void Start();
    }

    // 2. Concrete Products - Gasoline
    public class GasolineCar : IVehicle
    {
        public void ShowDetails() => Console.WriteLine("Vehicle: Gasoline Car");
    }

    public class GasolineTruck : IVehicle
    {
        public void ShowDetails() => Console.WriteLine("Vehicle: Gasoline Truck");
    }

    public class GasolineEngine : IEngine
    {
        public void Start() => Console.WriteLine("Engine: Gasoline Engine Started (Vroom!)");
    }

    // 3. Concrete Products - Electric
    public class ElectricCar : IVehicle
    {
        public void ShowDetails() => Console.WriteLine("Vehicle: Electric Car");
    }

    public class ElectricTruck : IVehicle
    {
        public void ShowDetails() => Console.WriteLine("Vehicle: Electric Truck");
    }

    public class ElectricEngine : IEngine
    {
        public void Start() => Console.WriteLine("Engine: Electric Engine Started (Silent...)");
    }

    // 4. Abstract Factory Interface
    public interface IVehicleFactory
    {
        IVehicle CreateCar();
        IVehicle CreateTruck();
        IEngine CreateEngine();
    }

    // 5. Concrete Factories
    public class GasolineVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateCar() => new GasolineCar();
        public IVehicle CreateTruck() => new GasolineTruck();
        public IEngine CreateEngine() => new GasolineEngine();
    }

    public class ElectricVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateCar() => new ElectricCar();
        public IVehicle CreateTruck() => new ElectricTruck();
        public IEngine CreateEngine() => new ElectricEngine();
    }

    // 6. Main Program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Gasoline Vehicle Factory ---");
            IVehicleFactory gasolineFactory = new GasolineVehicleFactory();
            IVehicle gasCar = gasolineFactory.CreateCar();
            IEngine gasEngine = gasolineFactory.CreateEngine();

            gasCar.ShowDetails();
            gasEngine.Start();

            Console.WriteLine("\n--- Electric Vehicle Factory ---");
            IVehicleFactory electricFactory = new ElectricVehicleFactory();
            IVehicle electricCar = electricFactory.CreateCar();
            IEngine electricEngine = electricFactory.CreateEngine();

            electricCar.ShowDetails();
            electricEngine.Start();
        }
    }
}
