using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Matrix1141EF.Data.Entity
{
    public class User : IdentityUser<int>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Product Product { get; set; }
        public ICollection<UserProduct> Products { get; set; }

    }
}
