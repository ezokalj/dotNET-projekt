using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biljkovoditelj.model.Entities
{
    public class WateringLog
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        [Range(1, 10000)]
        public int AmountMl { get; set; }

        [StringLength(200)]
        public string Notes { get; set; } = string.Empty;

        [ForeignKey("Plant")]
        public int PlantId { get; set; }

        // Navigation Properties
        public virtual Plant Plant { get; set; }
    }
}
