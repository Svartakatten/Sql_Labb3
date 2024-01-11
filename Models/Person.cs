using System;
using System.Collections.Generic;

namespace Sql_Labb3.Models;

public partial class Person
{
    public int PersonId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime? HireDate { get; set; }

    public string? Phone { get; set; }

    public string Discriminator { get; set; } = null!;

    public virtual OfficeAssignment? OfficeAssignment { get; set; }

    public virtual ICollection<StudentGrade> StudentGrades { get; set; } = new List<StudentGrade>();

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
