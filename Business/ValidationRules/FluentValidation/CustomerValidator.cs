using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.NationaltyIdentity).Length(11);
            RuleFor(p => p.DateOfBirth).NotEmpty();
            
        }

       
    }
}
