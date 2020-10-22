using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PK.Models
{
    public class Pokemon
    { 
        public int id { get; set; }
        public string name { get; set; }
        public int  order { get; set; }
        public int base_experience { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public string location_area_encounters { get; set; }
        public Species species { get; set; }
        public Sprites sprites { get; set; }
        public List<Ability> abilities { get; set; }
        public List<Move> moves { get; set; }
        public List<Form> forms { get; set; }
        public List <Stat> stats { get; set; }
        public List<Type> types { get; set; }
    }
}
