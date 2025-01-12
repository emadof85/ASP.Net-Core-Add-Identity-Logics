using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Student : BaseEntity
{


      public string FirstName { get; set; } = null!;

      public string LastName { get; set; } = null!;
    public string PhoneNumber { get; set; } = null;
      public int Age { get; set; }
    public string StudentNumber { get; set; }
    public string Password { get; set; }
    public bool IsActive { get; set; }

      public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

}
