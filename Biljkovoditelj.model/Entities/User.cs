using System;
using System.Collections.Generic;
using System.Text;

namespace Biljkovoditelj.model.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string email { get; set; }

        public List<Plant> Plants { get; set; } = new List<Plant>();
    }
}
