using Biljkovoditelj.model.Entities;
using System.Collections.Generic;

namespace Biljkovoditelj.Web.Models
{
    public class HomeViewModel
    {
        public int TotalPlants { get; set; }
        public int TotalRooms { get; set; }
        public int TotalUsers { get; set; }
        public int PendingTasks { get; set; }
        public List<Reminder> RecentReminders { get; set; } = new();
        public List<WateringLog> RecentWateringLogs { get; set; } = new();
    }
}