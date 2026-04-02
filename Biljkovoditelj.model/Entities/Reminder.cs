using System;
using System.Collections.Generic;
using System.Text;

namespace Biljkovoditelj.model.Entities
{
    public class Reminder
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime ReminderDate { get; set; }

        public int PlantId { get; set; }
    }
}
