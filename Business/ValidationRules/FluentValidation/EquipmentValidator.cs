using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class EquipmentValidator : AbstractValidator<Equipment>
    {
        public EquipmentValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Piece).NotEmpty();
            RuleFor(c => c.ClinicId).NotEmpty();
            RuleFor(c => c.Piece).GreaterThanOrEqualTo(1);
            RuleFor(c => c.UnitPrice).GreaterThanOrEqualTo(0.01);
            RuleFor(c => c.UsageRate).GreaterThanOrEqualTo(0.0);
            RuleFor(c => c.UsageRate).LessThanOrEqualTo(100.0);
            
        }

    }
}
