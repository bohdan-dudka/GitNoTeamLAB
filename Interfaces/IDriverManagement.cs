// Інтерфейс "Управління водіями"
public interface IDriverManagement
{
    // Призначає водія на транспортний засіб
    void AssignDriver(string vehicleId, string driverId);

    // Повертає інформацію про водія, закріпленого за транспортним засобом
    string GetDriverInfo(string vehicleId);

    // Знімає водія з транспортного засобу
    void RemoveDriver(string vehicleId);
}
