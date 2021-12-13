using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AsteroidsKrof
{
    class JSONObj
    {
        public class Asteroid
        {
            public string Name { get; set; }
            public string Date { get; set; }
            public string Speed { get; set; }
            public string Diameter { get; set; }
            public string Distance { get; set; }
        }
    }
}
