using System;
using System.Collections.Generic;
using System.Text;

namespace Biljkovoditelj.model.Entities
{
    public class WateringLog
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int AmountMl { get; set; }
        public string Notes { get; set; } = string.Empty;

        public int plantId { get; set; }
    }
}
