using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Biljkovoditelj.model.Entities
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Range(0, 100)]
        public int LightLevel { get; set; }

        [Range(0, 100)]
        public double Humidity { get; set; }

        [Range(-50, 50)]
        public double Temperature { get; set; }

        // Navigation Properties
        public virtual ICollection<Plant> Plants { get; set; } = new List<Plant>();
    }
}
