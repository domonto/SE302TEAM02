using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collector
{
    class CustomCollection
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string aliase { get; set; }
        public List<Attribute> attributes { get; set; }
    }
}
