using System;
using System.Collections.Generic;
using System.Text;

namespace Biljkovoditelj.model.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int LightLevel { get; set; }
        public double Humidity { get; set; }
        public double Temperature { get; set; }

        public List<Plant> Plants { get; set; } = new();
    }
}
