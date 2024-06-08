using LoanworksBackend.Modules.CreditCard.Core.CreditCardApplication;
namespace LoanworksBackend.Modules.CreditCard.Validators.Application;

using FluentValidation;

public class InsertCreditCardApplicationValidator : AbstractValidator<CreditCardApplication>
{
    public InsertCreditCardApplicationValidator()
    {
        RuleFor(x => x.Name).NotEmpty().EmailAddress();
        RuleFor(x => x.FeeType).NotEmpty();
    }
}

