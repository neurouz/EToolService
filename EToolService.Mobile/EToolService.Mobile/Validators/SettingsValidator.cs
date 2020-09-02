using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace EToolService.Mobile.Validators
{
    public class SettingsValidator : AbstractValidator<EToolService.Model.Requests.CustomerUpdateRequest>
    {
        [Obsolete]
        public SettingsValidator()
        {
            RuleFor(x => x.Address).NotNull().NotEmpty()
                .WithMessage("Adresa ne moze biti prazno polje");
            RuleFor(x => x.CompanyName).NotNull().NotEmpty()
                .WithMessage("Naziv kompanije ne moze biti prazno polje");
            RuleFor(x => x.Password).NotNull().NotEmpty()
                .WithMessage("Lozinka ne moze biti prazno polje");
            RuleFor(x => x.PasswordConfirm).NotNull().NotEmpty().Equal(x => x.Password)
                .WithMessage("Lozinke moraju biti iste");
            RuleFor(x => x.Username).NotNull().NotEmpty()
                .WithMessage("Korisnicko ime ne moze biti prazno polje");
            RuleFor(x => x.PhoneNumber).NotNull().NotEmpty()
                .WithMessage("Broj telefona ne moze biti prazno polje");
            RuleFor(x => x.Email).NotNull().NotEmpty()
                .EmailAddress(EmailValidationMode.Net4xRegex)
                .WithMessage("Email adresa nije validna");
        }
    }
}
