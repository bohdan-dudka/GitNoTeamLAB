// Клас "Система керування транспортом"
using System;
using System.Collections.Generic;
using GitNoTeam.Interfaces;
using GitNoTeam.Models;

namespace GitNoTeam.Services
{
    public class TransportSystem : ITransportManagementSystem
{
    // Словник для збереження зареєстрованих транспортних засобів
    private Dictionary<string, IVehicle> _vehicles = new Dictionary<string, IVehicle>();

        // Новая функция для регистрации нового транспортного средства
        public string RegisterNewVehicle(string model, int yearOfManufacture, int maxSpeed, string currentLocation)
        {
            IVehicle newVehicle = new Car(model, yearOfManufacture, maxSpeed, currentLocation);  // Создаём новый автомобиль
            string vehicleId = Guid.NewGuid().ToString();  // Генерируем уникальный ID
            _vehicles[vehicleId] = newVehicle;  // Добавляем автомобиль в систему
            Console.WriteLine($"New vehicle registered: {newVehicle.GetModel()} with ID: {vehicleId}");
            return vehicleId;
        }

        // Реєструє новий транспортний засіб
        public string RegisterVehicle(IVehicle vehicle)
    {
        string vehicleId = Guid.NewGuid().ToString();
        _vehicles[vehicleId] = vehicle;
        Console.WriteLine($"Vehicle registered: {vehicle.GetModel()} with ID: {vehicleId}");
        return vehicleId;
    }

        public void PrintRegisteredVehicles()
        {
            Console.WriteLine("Registered Vehicles:");
            foreach (var vehicleId in _vehicles.Keys)
            {
                Console.WriteLine($"Vehicle ID: {vehicleId}, Model: {_vehicles[vehicleId].GetModel()}");
            }
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