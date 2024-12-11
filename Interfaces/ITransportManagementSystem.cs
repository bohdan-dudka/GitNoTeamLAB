// Інтерфейс "Система керування транспортом"
public interface ITransportManagementSystem
{
    // Реєструє новий транспортний засіб у системі
    string RegisterVehicle(IVehicle vehicle);

    // Відстежує місцезнаходження транспортного засобу за ID
    string TrackLocation(string vehicleId);

    // Розраховує маршрут до пункту призначення для заданого транспортного засобу
    string CalculateRoute(string vehicleId, string destination);

    // Повертає список усіх зареєстрованих транспортних засобів
    List<IVehicle> GetRegisteredVehicles();

    // Повертає список ідентифікаторів зареєстрованих транспортних засобів
    List<string> GetRegisteredVehicleIds();
}
