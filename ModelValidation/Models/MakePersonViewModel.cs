using System;
using FluentValidation.Attributes;
using ModelValidation.Infrastructure;

namespace ModelValidation.Models
{
    [Validator(typeof(MakePersonViewModelValidator))]
    public class MakePersonViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public string Email { get; set; }
        public bool TermsAccepted { get; set; }

        public Limit Limit { get; set; } = new Limit();
    }

    public class Limit
    {
        public int LimitId { get; set; } = 5;
    }
}