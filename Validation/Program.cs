using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using Validation.Entities;
using Validation.Validação;

namespace Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemVenda item1 = new ItemVenda
            {
                Descricao = "PC Game",
                Preco = 60,
                Quantidade = 4
            };

            Venda venda = new Venda
            {
                Data = DateTime.Today.AddDays(-10),
                Tipo = TipoVenda.Padrão,
                Items = new List<ItemVenda>(new[] { item1}),
                Total = 10
            };

            VendaValidation validator = new VendaValidation();

            ValidationResult resultado = validator.Validate(venda);

            if (resultado.IsValid)
            {
                Console.WriteLine("Venda validada com sucesso");
                Console.WriteLine(venda.Data);
            }
            else
            {
                Console.WriteLine("Venda Invalida");
                resultado.Errors
                    .ToList()
                    .ForEach(e => Console.WriteLine($"{e.PropertyName}: {e.ErrorMessage}"));
                Console.WriteLine(venda.Data);
            }



            Console.ReadKey();

        }
    }
}
