using System;

namespace Biljkovoditelj.model.Entities
{
    public class CareTask
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        public DateTime DueDate { get; set; }
        public bool isIsCompleted { get; set; }

        public int PlantId { get; set; }
    }
}
