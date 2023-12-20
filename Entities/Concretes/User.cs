﻿using Core.Entities;
using System.Text.Json.Serialization;

namespace Entities.Concretes
{
    public class User : Entity<Guid>
    {
        //public Guid DepartmentId { get; set; }
        //public Department Department { get; set; }
        //public virtual ICollection<Course> Courses { get; set; }
        public ICollection<UserCourse> UserCourses { get; set; }   /*= new List<UserCourse>();*/

        public string? NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? BirthDate { get; set; }

        //[JsonIgnore]

        public string? Country { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? AddressDetails { get; set; }
        public string? AboutMe { get; set; }
        public string? Phone { get; set; }




    }
}
