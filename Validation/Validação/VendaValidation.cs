using FluentValidation;
using System;
using Validation.Entities;

namespace Validation.Validação
{
    public class VendaValidation : AbstractValidator<Venda>
    {
        public VendaValidation()
        {
            RuleFor(v => v.Data)
                .LessThanOrEqualTo(DateTime.Today).WithMessage("A data da venda não pode estar no futuro.")
                .NotNull().WithMessage("A data da venda não pode ser nula.");

            RuleFor(v => v.Total).GreaterThan(0).WithMessage("O total da venda deve ser maior que zero.");

            RuleFor(v => v.Items).NotNull().WithMessage("A propriedade Itens da venda não pode ser nula.")
                .Must(i => i != null ? i.Count > 0 : false)
                .WithMessage("A venda deve possuir pelo menos 1 item.");
                //.SetValidator(new ItemVendaValidation(v=> v.));
        }
    }
}
