using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PK.Models
{
    public class Move
    {
        public move move { get; set; }
        public List<version_group_detail> version_group_details { get; set; }
    }
    public class move
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class version_group_detail
    {
        public int level_learned_at { get; set; }
        public move_learn_method move_learn_method { get; set; }
        public move_learn_method version_group { get; set; }

    }

    public class move_learn_method
    {
        public string name { get; set; }
        public string url { get; set; }

    }

    public class version_group
    {
        public string name { get; set; }
        public string url { get; set; }

    }
}
