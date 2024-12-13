using GitNoTeam.Models; // Імпорт ваших інтерфейсів
using GitNoTeam.Interfaces; // Імпорт реалізацій
using GitNoTeam.Services; // Імпорт ваших інтерфейсів
// Основний клас для демонстрації
public class Program
{
    public static void Main(string[] args)
    {
        // Створення екземпляра системи керування транспортом
        ITransportManagementSystem system = new TransportSystem();

        // Створення двох автомобілів
        IVehicle car1 = new Car("Toyota Corolla", 2020, 180, "Kyiv");
        IVehicle car2 = new Car("Ford Focus", 2018, 200, "Lviv");
        IVehicle car3 = new Car("Focus", 2028, 100, "Lviv");

        // Реєстрація автомобілів у системі
        string car1Id = system.RegisterVehicle(car1);
        string car2Id = system.RegisterVehicle(car2);

        // Приклад використання: трекінг місцезнаходження
        foreach (var vehicleId in system.GetRegisteredVehicleIds())
        {
            Console.WriteLine($"Vehicle ID: {vehicleId}, Location: {system.TrackLocation(vehicleId)}");
        }

        // Розрахунок маршруту для першого автомобіля
        Console.WriteLine(system.CalculateRoute(car1Id, "Odessa"));
    }
}
