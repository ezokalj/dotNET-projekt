using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biljkovoditelj.model.Entities
{
    public class Plant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Species { get; set; }

        [Range(0, 200)]
        public int Age { get; set; }

        [Range(1, 365)]
        public int WateringIntervalDays { get; set; }

        public DateTime LastWatered { get; set; }

        public HealthStatus HealthStatus { get; set; }

        [ForeignKey("Room")]
        public int RoomId { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }

        // Navigation Properties
        public virtual Room Room { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<CareTask> CareTasks { get; set; } = new List<CareTask>();
        public virtual ICollection<Reminder> Reminders { get; set; } = new List<Reminder>();
        public virtual ICollection<WateringLog> WateringLogs { get; set; } = new List<WateringLog>();
    }
}
