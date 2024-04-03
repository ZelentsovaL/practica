using System;
using System.Collections.Generic;

namespace practice;

public partial class Employee
{
    public int Employeeid { get; set; }

    public string Lastname { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Middlename { get; set; }

    public int Positionid { get; set; }

    public int Departmentid { get; set; }

    public string Contactinfo { get; set; } = null!;

    public virtual ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();

    public virtual Department Department { get; set; } = null!;

    public virtual Position Position { get; set; } = null!;
}
