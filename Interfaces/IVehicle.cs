// Інтерфейс "Транспортний засіб"
public interface IVehicle
{
    // Повертає модель транспортного засобу
    string GetModel();

    // Повертає рік випуску транспортного засобу
    int GetYearOfManufacture();

    // Повертає максимальну швидкість транспортного засобу
    int GetMaxSpeed();

    // Повертає поточне місцезнаходження транспортного засобу
    string GetCurrentLocation();
}