using FluentValidation;
using Validation.Entities;

namespace Validation.Validação
{
    public class ItemVendaValidation : AbstractValidator<ItemVenda>
    {
        public ItemVendaValidation()
        {
            RuleFor(i => i.Descricao).Length(3, 50).WithMessage("A descrição do item deve ter entre {MinLength}  e {MaxLength} caracteres.");

            RuleFor(i => i.Preco).GreaterThan(0).WithMessage("O preço do item deve ser maior que {ComparisonValue}.");

            RuleFor(i => i.Quantidade).GreaterThan(0).WithMessage("A quantidade do item deve ser maior que {ComparisonValue}.");
        }
    }
}
