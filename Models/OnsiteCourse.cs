using System;
using System.Collections.Generic;

namespace Sql_Labb3.Models;

public partial class OnsiteCourse
{
    public int CourseId { get; set; }

    public string Location { get; set; } = null!;

    public string Days { get; set; } = null!;

    public DateTime Time { get; set; }

    public virtual Course Course { get; set; } = null!;
}
