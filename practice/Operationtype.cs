using System;
using System.Collections.Generic;

namespace practice;

public partial class Operationtype
{
    public int Operationtypeid { get; set; }

    public string Nameoperation { get; set; } = null!;

    public virtual ICollection<Warehouseoperation> Warehouseoperations { get; set; } = new List<Warehouseoperation>();
}
