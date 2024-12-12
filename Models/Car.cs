using GitNoTeam.Interfaces;

namespace GitNoTeam.Models
{
    // Клас "Автомобіль" (приклад реалізації IVehicle)
    public class Car : IVehicle
{
    private string _model; // Модель автомобіля
    private int _yearOfManufacture; // Рік випуску автомобіля
    private int _maxSpeed; // Максимальна швидкість автомобіля
    private string _currentLocation; // Поточне місцезнаходження

    public Car(string model, int yearOfManufacture, int maxSpeed, string currentLocation)
    {
        _model = model;
        _yearOfManufacture = yearOfManufacture;
        _maxSpeed = maxSpeed;
        _currentLocation = currentLocation;
    }

    public string GetModel()
    {
        return _model;
    }

    public int GetYearOfManufacture()
    {
        return _yearOfManufacture;
    }

    public int GetMaxSpeed()
    {
        return _maxSpeed;
    }

    public string GetCurrentLocation()
    {
        return _currentLocation;
    }
}}