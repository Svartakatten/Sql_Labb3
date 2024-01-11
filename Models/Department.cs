using System;
using System.Collections.Generic;

namespace Sql_Labb3.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string Name { get; set; } = null!;

    public decimal Budget { get; set; }

    public DateTime StartDate { get; set; }

    public int? Administrator { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
