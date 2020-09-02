using EToolService.Model.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EToolService.Mobile.Validators
{
    public class ServiceRequestValidator : AbstractValidator<ToolServiceInsertRequest>
    {
        public ServiceRequestValidator()
        {
            RuleFor(x => x.ToolName).NotNull().NotEmpty()
                .WithMessage("Naziv alata ne moze biti prazno polje");
            RuleFor(x => x.ServiceType).NotNull().NotEmpty()
                .WithMessage("Morate odabrati tip servisa");
            RuleFor(x => x.Quantity).GreaterThan(0)
                .WithMessage("Količina mora biti veća od nule");
        }
    }
}
