using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biljkovoditelj.model.Entities
{
    public class Reminder
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public string Message { get; set; }

        public DateTime ReminderDate { get; set; }

        [ForeignKey("Plant")]
        public int PlantId { get; set; }

        // Navigation Properties
        public virtual Plant Plant { get; set; }
    }
}
