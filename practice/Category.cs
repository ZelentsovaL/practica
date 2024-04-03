using System;
using System.Collections.Generic;

namespace practice;

public partial class Category
{
    public long Idcategory { get; set; }

    public string Namecategory { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
