using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PK.Models
{
    public class GameIndex
    {
        public int game_index { get; set; }
        public version version { get; set; }
    }

    public class version
    {
        public string name {get;set;}
        public string url { get; set; }
    }
}
