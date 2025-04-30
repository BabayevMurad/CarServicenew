using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Entities
{
    public class Issue
    {
        public int Id { get; set; }
        public string Level { get; set; }
        public string Problem { get; set; }
        public string Description { get; set; }
    }
}
