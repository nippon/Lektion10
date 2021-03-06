﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lektion10.Model.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
