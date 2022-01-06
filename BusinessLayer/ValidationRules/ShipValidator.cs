using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ShipValidator:AbstractValidator<Ship>
    {
        public ShipValidator()
        {
            RuleFor(x => x.ShipName).NotEmpty().WithMessage("Ship Name cannot be null");
            RuleFor(x => x.ShipName).MinimumLength(3).WithMessage("Ship Name should be minimum 3 characters.");
        }
    }
}
