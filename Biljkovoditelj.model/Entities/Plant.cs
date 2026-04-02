using System;
using System.Collections.Generic;
using System.Text;

namespace Biljkovoditelj.model.Entities
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }

        public int Age { get; set; }
        public int WateringIntervalDays { get; set; }
        public DateTime LastWatered { get; set; }

        public HealthStatus HealthStatus { get; set; }

        public int RoomId { get; set; }

        public List<CareTask> CareTasks { get; set; } = new();

    }
}
