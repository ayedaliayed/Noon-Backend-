﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AliExpress.Models
{
    public class Category: BaseEntity,IDeletedEntity
    {
        public string Name { get; set; }
        public string Name_Ar { get; set; }
    public bool IsDeleted { get; set; }
    public ICollection<Subcategory> Subcategories { get; set; }
    
    public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    
    public  ICollection<Specification> Specifications { get; set; }
        public Category()
        {
            Specifications = new List<Specification>();

        }

    }
}
