// Інтерфейс "Обслуговування транспортного засобу"
public interface IVehicleMaintenance
{
    // Планує технічне обслуговування для транспортного засобу
    void ScheduleMaintenance(string vehicleId, string date);

    // Повертає історію обслуговування транспортного засобу
    List<string> GetMaintenanceHistory(string vehicleId);
}
