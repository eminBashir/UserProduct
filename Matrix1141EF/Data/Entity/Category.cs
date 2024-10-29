using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Collections.Generic;

namespace Matrix1141EF.Data.Entity
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set;} 
       
    }
}
