using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars_Api_Integration.Entities
{
    public class StarWarsCharactersResponse
    {
        public string count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<NameResult> results { get; set; }
    }
}
