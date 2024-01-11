using System;
using System.Collections.Generic;

namespace Sql_Labb3.Models;

public partial class Student
{
    public int StudentsId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime? EnrollmentDate { get; set; }

    public string? Adress { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Class { get; set; }
}
