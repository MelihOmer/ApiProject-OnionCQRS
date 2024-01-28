﻿using ApiProject.Domain.Common;

namespace ApiProject.Domain.Entities
{
    public class Category : EntityBase
    {
        public Category()
        {
            
        }
        public Category(int parentId,string name,int priority)
        {
            ParentId = parentId;
            Name = name;
            ParentId = parentId;
        }
        public  int ParentId { get; set; }
        public  string Name { get; set; }
        public  int Priority { get; set; }
        public ICollection<Detail> Details { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
    
}

