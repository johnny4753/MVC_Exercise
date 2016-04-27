using System;
using System.Collections.Generic;
using FluentValidation.Attributes;
using ModelValidation.Infrastructure;

namespace ModelValidation.Models
{
    [Validator(typeof(MakePersonViewModelValidator))]
    public class MakePersonViewModel
    {
        public MakePersonViewModel()
        {
            Students.Add(new Student { Id = 10, Name = "Maths 1" });
            Students.Add(new Student { Id = 5, Name = "Maths 2" });
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; } = new DateTime(2020, 1, 1);
        public string Email { get; set; }
        public bool TermsAccepted { get; set; }
        public Tester Tester { get; set; } = new Tester();

        public List<Student> Students { get; set; } = new List<Student>();
        public Limit Limit { get; set; } = new Limit();
    }

    public class Limit
    {
        public int LimitId { get; set; } = 5;
    }

    [Validator(typeof(StudentValidator))]
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
    }

    [Validator(typeof(TesterValidator))]
    public class Tester
    {
        public int TestId { get; set; } = 50;
        public string TestName { get; set; }
        public int TestGrade { get; set; }
    }
}