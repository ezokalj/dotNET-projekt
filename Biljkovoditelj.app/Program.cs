using Biljkovoditelj.model.Entities;

var livingRoom = new Room
{
    Id = 1,
    Name = "Living Room",
    LightLevel = 8,
    Humidity = 50,
    Temperature = 22
};

var bedroom = new Room
{
    Id = 2,
    Name = "Bedroom",
    LightLevel = 5,
    Humidity = 45,
    Temperature = 20
};

var kitchen = new Room
{
    Id = 3,
    Name = "Kitchen",
    LightLevel = 9,
    Humidity = 60,
    Temperature = 23
};

// Living room
var monstera = new Plant
{
    Id = 1,
    Name = "Monstera",
    Species = "Monstera Deliciosa",
    WateringIntervalDays = 5,
    LastWatered = DateTime.Now.AddDays(-6),
    HealthStatus = HealthStatus.NeedsWater,
    RoomId = 1
};

var ficus = new Plant
{
    Id = 2,
    Name = "Ficus",
    Species = "Ficus Elastica",
    WateringIntervalDays = 7,
    LastWatered = DateTime.Now.AddDays(-2),
    HealthStatus = HealthStatus.Healthy,
    RoomId = 1
};

var lavender = new Plant
{
    Id = 3,
    Name = "Lavender",
    Species = "Lavandula",
    WateringIntervalDays = 10,
    LastWatered = DateTime.Now.AddDays(-12),
    HealthStatus = HealthStatus.NeedsWater,
    RoomId = 1
};

// Bedroom
var sansevieria = new Plant
{
    Id = 4,
    Name = "Snake Plant",
    Species = "Sansevieria",
    WateringIntervalDays = 14,
    LastWatered = DateTime.Now.AddDays(-15),
    HealthStatus = HealthStatus.NeedsWater,
    RoomId = 2
};

var pothos = new Plant
{
    Id = 5,
    Name = "Pothos",
    Species = "Epipremnum Aureum",
    WateringIntervalDays = 4,
    LastWatered = DateTime.Now.AddDays(-1),
    HealthStatus = HealthStatus.Healthy,
    RoomId = 2
};

var aloe = new Plant
{
    Id = 6,
    Name = "Aloe Vera",
    Species = "Aloe Barbadensis",
    WateringIntervalDays = 12,
    LastWatered = DateTime.Now.AddDays(-9),
    HealthStatus = HealthStatus.Healthy,
    RoomId = 2
};

// Kitchen
var basil = new Plant
{
    Id = 7,
    Name = "Basil",
    Species = "Ocimum Basilicum",
    WateringIntervalDays = 2,
    LastWatered = DateTime.Now.AddDays(-3),
    HealthStatus = HealthStatus.NeedsWater,
    RoomId = 3
};

var orchid = new Plant
{
    Id = 8,
    Name = "Orchid",
    Species = "Phalaenopsis",
    WateringIntervalDays = 8,
    LastWatered = DateTime.Now.AddDays(-10),
    HealthStatus = HealthStatus.Sick,
    RoomId = 3
};

var cactus = new Plant
{
    Id = 9,
    Name = "Cactus",
    Species = "Echinopsis",
    WateringIntervalDays = 20,
    LastWatered = DateTime.Now.AddDays(-5),
    HealthStatus = HealthStatus.Healthy,
    RoomId = 3
};

livingRoom.Plants.AddRange(new[] { monstera, ficus, lavender });
bedroom.Plants.AddRange(new[] { sansevieria, pothos, aloe });
kitchen.Plants.AddRange(new[] { basil, orchid, cactus });

var rooms = new List<Room>
{
    livingRoom,
    bedroom,
    kitchen
};

// Users
var ana = new User
{
    Id = 1,
    Name = "Ana",
    email = "ana@mail.com",
    Plants = new List<Plant> { monstera, ficus, basil }
};

var marko = new User
{
    Id = 2,
    Name = "Marko",
    email = "marko@mail.com",
    Plants = new List<Plant> { lavender, orchid, cactus }
};

var users = new List<User> { ana, marko };

// LINQ biljka koje trebaju zalijevanje
var plantsThatNeedWater =
    rooms
        .SelectMany(r => r.Plants)
        .Where(p => DateTime.Now >
            p.LastWatered.AddDays(p.WateringIntervalDays));

Console.WriteLine("Plants that need watering:");

foreach (var plant in plantsThatNeedWater)
{
    Console.WriteLine(plant.Name);
}

//LINQ biljka u jako osvjetlj enim sobama
var brightRoomPlants =
    rooms
        .Where(r => r.LightLevel >= 8)
        .SelectMany(r => r.Plants);

Console.WriteLine("\nPlants in bright rooms:");

foreach (var plant in brightRoomPlants)
{
    Console.WriteLine(plant.Name);
}

//Broj biljaka u sobi
var plantCountPerRoom =
    rooms.Select(r => new
    {
        RoomName = r.Name,
        PlantCount = r.Plants.Count
    });

Console.WriteLine("\nPlant count per room:");

foreach (var item in plantCountPerRoom)
{
    Console.WriteLine($"{item.RoomName}: {item.PlantCount}");
}