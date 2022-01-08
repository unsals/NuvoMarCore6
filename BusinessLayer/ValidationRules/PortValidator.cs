using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortValidator : AbstractValidator<Port>
    {
        public PortValidator()
        {
            RuleFor(x => x.PortName).NotEmpty().WithMessage("Port Name cannot be null");
            RuleFor(x => x.PortCity).NotEmpty().WithMessage("Port City cannot be null");
        }
    }
}
