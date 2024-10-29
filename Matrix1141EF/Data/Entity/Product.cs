using System.Collections.Generic;

namespace Matrix1141EF.Data.Entity
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public ICollection<UserProduct> Users { get; set; }
        public Category Category { get; set; }

    }
}
