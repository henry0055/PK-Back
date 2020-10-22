using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PK.Models
{
    public class Ability
    {
        public ability ability { get; set; }
        public  bool is_hidden { get; set; }
        public int slot { get; set; }
    }
    
   public class ability
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
