using Biljkovoditelj.model.Entities;

namespace Biljkovoditelj.Web.Data
{
    public static class MockRepository
    {
        public static List<Room> GetRooms()
        {
            var livingRoom = new Room
            {
                Id = 1,
                Name = "Living Room",
                LightLevel = 8,
                Humidity = 50,
                Temperature = 22,
                Plants = new List<Plant>
                {
                    new Plant { Id = 1, Name = "Monstera", Species = "Monstera Deliciosa" },
                    new Plant { Id = 2, Name = "Ficus", Species = "Ficus Elastica" }
                }
            };

            var bedroom = new Room
            {
                Id = 2,
                Name = "Bedroom",
                LightLevel = 5,
                Humidity = 45,
                Temperature = 20,
                Plants = new List<Plant>
                {
                    new Plant { Id = 3, Name = "Snake Plant", Species = "Sansevieria" }
                }
            };

            return new List<Room> { livingRoom, bedroom };
        }

        public static List<Plant> GetPlants()
        {
            return GetRooms()
                .SelectMany(r => r.Plants)
                .ToList();
        }

        public static Plant GetPlantById(int id)
        {
            return GetPlants()
                .FirstOrDefault(p => p.Id == id);
        }

        public static List<User> GetUsers()
        {
            return new List<User>
            {
                new User
                {
                    Id = 1,
                    Name = "John Doe",
                    email = "john@example.com",
                    Plants = new List<Plant>
                    {
                        new Plant { Id = 1, Name = "Monstera", Species = "Monstera Deliciosa" },
                        new Plant { Id = 2, Name = "Ficus", Species = "Ficus Elastica" }
                    }
                },
                new User
                {
                    Id = 2,
                    Name = "Jane Smith",
                    email = "jane@example.com",
                    Plants = new List<Plant>
                    {
                        new Plant { Id = 3, Name = "Snake Plant", Species = "Sansevieria" }
                    }
                }
            };
        }

        public static User GetUserById(int id)
        {
            return GetUsers()
                .FirstOrDefault(u => u.Id == id);
        }

        public static List<CareTask> GetCareTasks()
        {
            return new List<CareTask>
            {
                new CareTask
                {
                    Id = 1,
                    Title = "Water Monstera",
                    Description = "Water the Monstera in the living room",
                    DueDate = DateTime.Now.AddDays(2),
                    isIsCompleted = false,
                    PlantId = 1
                },
                new CareTask
                {
                    Id = 2,
                    Title = "Fertilize Ficus",
                    Description = "Apply fertilizer to the Ficus",
                    DueDate = DateTime.Now.AddDays(7),
                    isIsCompleted = false,
                    PlantId = 2
                },
                new CareTask
                {
                    Id = 3,
                    Title = "Prune Snake Plant",
                    Description = "Remove dead leaves from Snake Plant",
                    DueDate = DateTime.Now.AddDays(5),
                    isIsCompleted = true,
                    PlantId = 3
                }
            };
        }

        public static CareTask GetCareTaskById(int id)
        {
            return GetCareTasks()
                .FirstOrDefault(ct => ct.Id == id);
        }

        public static List<Reminder> GetReminders()
        {
            return new List<Reminder>
            {
                new Reminder
                {
                    Id = 1,
                    Message = "Time to water the Monstera",
                    ReminderDate = DateTime.Now.AddHours(2),
                    PlantId = 1
                },
                new Reminder
                {
                    Id = 2,
                    Message = "Check humidity levels for Ficus",
                    ReminderDate = DateTime.Now.AddHours(24),
                    PlantId = 2
                },
                new Reminder
                {
                    Id = 3,
                    Message = "Move Snake Plant to sunnier spot",
                    ReminderDate = DateTime.Now.AddDays(1),
                    PlantId = 3
                }
            };
        }

        public static Reminder GetReminderById(int id)
        {
            return GetReminders()
                .FirstOrDefault(r => r.Id == id);
        }

        public static List<WateringLog> GetWateringLogs()
        {
            return new List<WateringLog>
            {
                new WateringLog
                {
                    Id = 1,
                    Date = DateTime.Now.AddDays(-1),
                    AmountMl = 500,
                    Notes = "Plant looked thirsty",
                    plantId = 1
                },
                new WateringLog
                {
                    Id = 2,
                    Date = DateTime.Now.AddDays(-3),
                    AmountMl = 300,
                    Notes = "Regular watering schedule",
                    plantId = 2
                },
                new WateringLog
                {
                    Id = 3,
                    Date = DateTime.Now.AddDays(-2),
                    AmountMl = 200,
                    Notes = "Light watering",
                    plantId = 3
                }
            };
        }

        public static WateringLog GetWateringLogById(int id)
        {
            return GetWateringLogs()
                .FirstOrDefault(wl => wl.Id == id);
        }
    }
}