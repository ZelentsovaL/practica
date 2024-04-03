using System;
using System.Collections.Generic;

namespace practice;

public partial class Department
{
    public int Departmentid { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
