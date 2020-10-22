using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PK.Models
{
    public class Stat
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public stat stat { get; set; }
    }

    public class stat
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
