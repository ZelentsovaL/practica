using System;
using System.Collections.Generic;

namespace practice;

public partial class Warehouseoperation
{
    public int Operationid { get; set; }

    public DateOnly Date { get; set; }

    public int Productid { get; set; }

    public int Quantity { get; set; }

    public int Operationtype { get; set; }

    public virtual Operationtype OperationtypeNavigation { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
