using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class VoyageValidator:AbstractValidator<Voyage>
    {
        public VoyageValidator()
        {
            RuleFor(x => x.ShipId).NotEmpty().WithMessage("Ship cannot be null");
            RuleFor(x => x.PortId).NotEmpty().WithMessage("Port cannot be null");
            RuleFor(x => x.VoyageArrivalDate).NotEmpty().WithMessage("Arrival Date cannot be null");
            RuleFor(x => x.VoyageDepartureDate).NotEmpty().WithMessage("Departure Date cannot be null");
        }
    }
}