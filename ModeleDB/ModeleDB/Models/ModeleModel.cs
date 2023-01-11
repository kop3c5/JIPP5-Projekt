using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModeleDB.Models
{
    public class ModeleModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Scale { get; set; }

        public string Brand { get; set; }

        public string Details { get; set; }
    }
}
