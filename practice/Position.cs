using System;
using System.Collections.Generic;

namespace practice;

public partial class Position
{
    public int Positionid { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Responsibilities { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
