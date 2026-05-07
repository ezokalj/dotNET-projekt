using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Biljkovoditelj.model.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        // Navigation Properties
        public virtual ICollection<Plant> Plants { get; set; } = new List<Plant>();
    }
}
