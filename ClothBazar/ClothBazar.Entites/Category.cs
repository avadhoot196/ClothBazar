﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Entites
{
    public class Category : BaseEntity
    {
        public List<Product> products { get; set; }
    }
}
