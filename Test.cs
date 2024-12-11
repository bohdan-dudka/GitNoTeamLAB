using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class TransportSystemTests
{
    private ITransportManagementSystem _system;

    [SetUp]
    public void Setup()
    {
        // Инициализация системы перед каждым тестом
        _system = new TransportSystem();
    }

    [Test]
    public void RegisterVehicle_ShouldReturnValidId()
    {
        // Arrange
        IVehicle car = new Car("Tesla Model S", 2022, 250, "San Francisco");

        // Act
        string vehicleId = _system.RegisterVehicle(car);

        // Assert
        Assert.That(vehicleId, Is.Not.Null);
        Assert.That(vehicleId.Length, Is.GreaterThan(0));
    }

    [Test]
    public void TrackLocation_ShouldReturnCorrectLocation()
    {
        // Arrange
        IVehicle car = new Car("Nissan Leaf", 2021, 150, "New York");
        string vehicleId = _system.RegisterVehicle(car);

        // Act
        string location = _system.TrackLocation(vehicleId);

        // Assert
        Assert.That(location, Is.EqualTo("New York"));
    }

    [Test]
    public void TrackLocation_InvalidVehicleId_ShouldReturnErrorMessage()
    {
        // Act
        string location = _system.TrackLocation("InvalidId");

        // Assert
        Assert.That(location, Is.EqualTo("Vehicle not found"));
    }

    [Test]
    public void CalculateRoute_ShouldReturnRouteMessage()
    {
        // Arrange
        IVehicle car = new Car("Ford Mustang", 2019, 240, "Los Angeles");
        string vehicleId = _system.RegisterVehicle(car);

        // Act
        string routeMessage = _system.CalculateRoute(vehicleId, "San Diego");

        // Assert
        Assert.That(routeMessage, Is.EqualTo($"Route calculated for Ford Mustang to San Diego"));
    }

    [Test]
    public void CalculateRoute_InvalidVehicleId_ShouldReturnErrorMessage()
    {
        // Act
        string routeMessage = _system.CalculateRoute("InvalidId", "Miami");

        // Assert
        Assert.That(routeMessage, Is.EqualTo("Vehicle not found"));
    }

    [Test]
    public void GetRegisteredVehicleIds_ShouldReturnAllIds()
    {
        // Arrange
        IVehicle car1 = new Car("BMW X5", 2020, 220, "Berlin");
        IVehicle car2 = new Car("Audi Q7", 2021, 230, "Munich");
        _system.RegisterVehicle(car1);
        _system.RegisterVehicle(car2);

        // Act
        List<string> vehicleIds = _system.GetRegisteredVehicleIds();

        // Assert
        Assert.That(vehicleIds.Count, Is.EqualTo(2));
    }
}
