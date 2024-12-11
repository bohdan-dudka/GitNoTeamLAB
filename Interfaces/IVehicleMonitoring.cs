// Інтерфейс "Моніторинг стану транспортного засобу"
public interface IVehicleMonitoring
{
    // Перевіряє рівень палива транспортного засобу
    double CheckFuelLevel(string vehicleId);

    // Перевіряє стан батареї транспортного засобу (для електромобілів)
    string CheckBatteryStatus(string vehicleId);

    // Повертає діагностичну інформацію про транспортний засіб
    string GetDiagnostics(string vehicleId);
}
