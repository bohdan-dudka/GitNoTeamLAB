// Клас "Система керування транспортом"
using System;
using System.Collections.Generic;
using GitNoTeam.Interfaces;

namespace GitNoTeam.Services
{
    public class TransportSystem : ITransportManagementSystem
{
    // Словник для збереження зареєстрованих транспортних засобів
    private Dictionary<string, IVehicle> _vehicles = new Dictionary<string, IVehicle>();

    // Реєструє новий транспортний засіб
    public string RegisterVehicle(IVehicle vehicle)
    {
        string vehicleId = Guid.NewGuid().ToString();
        _vehicles[vehicleId] = vehicle;
        Console.WriteLine($"Vehicle registered: {vehicle.GetModel()} with ID: {vehicleId}");
        return vehicleId;
    }

    // Відстежує місцезнаходження транспортного засобу
    public string TrackLocation(string vehicleId)
    {
        if (_vehicles.TryGetValue(vehicleId, out IVehicle vehicle))
        {
            return vehicle.GetCurrentLocation();
        }
        return "Vehicle not found";
    }

    // Розраховує маршрут для транспортного засобу
    public string CalculateRoute(string vehicleId, string destination)
    {
        if (_vehicles.TryGetValue(vehicleId, out IVehicle vehicle))
        {
            return $"Route calculated for {vehicle.GetModel()} to {destination}";
        }
        return "Vehicle not found";
    }

    // Повертає список усіх зареєстрованих транспортних засобів
    public List<IVehicle> GetRegisteredVehicles()
    {
        return new List<IVehicle>(_vehicles.Values);
    }

    // Повертає список ідентифікаторів зареєстрованих транспортних засобів
    public List<string> GetRegisteredVehicleIds()
    {
        return new List<string>(_vehicles.Keys);
    }
    }
}