using System;
using System.Collections.Generic;

namespace practice;

public partial class Manufacturer
{
    public int Idmanufacturer { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
