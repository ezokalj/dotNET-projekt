using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biljkovoditelj.model.Entities
{
    public class CareTask
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }

        [ForeignKey("Plant")]
        public int PlantId { get; set; }

        // Navigation Properties
        public virtual Plant Plant { get; set; }
    }
}
