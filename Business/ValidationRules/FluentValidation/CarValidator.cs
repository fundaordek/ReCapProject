using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(5);
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.ModelYear).GreaterThan(2021);
        }
    }
}
