﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PK.Models
{
    public class RootObject
    {
        public int count { get; set; }
        public object previous { get; set; }
        public List<Result> results { get; set; }
        
        
    }
}
