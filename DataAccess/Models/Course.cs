using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Course:BaseEntity
{

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
}
